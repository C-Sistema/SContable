using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base.BD;
using System.Data.Entity.Core.Objects;


namespace Base.Banco
{
    public partial class frmBancoMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        bool bandera;
        public frmBancoMant(string id = null)
        {
            InitializeComponent();
            cargarmoneda();
            bandera = true;
            if (id != null)
            {
                this.id = id;
                cargarDatos();
                bandera = false;
            }
        }
        private void cargarmoneda()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var datos = db.pac_moneda_1("1", "", "", "").ToArray();
                    lookMoneda.Properties.DataSource = datos;
                    lookMoneda.Properties.DisplayMember = "Iso";
                    lookMoneda.Properties.ValueMember = "id_mon";
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    DataTable valores = new DataTable();
                    var datos = db.pac_banco_2(id, "", "", "").ToArray();

                    txtNombre.EditValue = datos[0].Banco;
                    txtNoCunta.EditValue = datos[0].Cuenta;
                    txtMonto.EditValue = datos[0].Monto;
                    lookMoneda.EditValue = datos[0].id_mon;
                    txtNombre.EditValue = datos[0].Banco;
                    CheckFiscal.EditValue = datos[0].Fiscal;
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            if (id == null)
                            {
                                fc.openWaitForm(ssm);
                                //agregamos pam para insertar
                                
                                db.pam_banco(Convert.ToByte(1), null, txtNombre.Text,txtNoCunta.Text,txtTitular.Text,Convert.ToDecimal(txtMonto.EditValue),CheckFiscal.Checked, txtTipoBanco.Text, Convert.ToDecimal(txtTipoCambio.EditValue),Convert.ToInt16(lookMoneda.EditValue),fc.IdEmpleado,Convert.ToDateTime(fecha), ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (ban.Value.ToString() != "0")
                                {

                                    this.Close();
                                }
                            }
                            else
                            {
                                //modificar
                                fc.openWaitForm(ssm);
                                /* 
                                 Agregamos pam para modificar
                                 */
                                db.pam_banco(Convert.ToByte(2), Convert.ToInt32(id), txtNombre.Text, txtNoCunta.Text,txtTitular.Text, Convert.ToDecimal(txtMonto.EditValue), CheckFiscal.Checked,txtTipoBanco.Text,Convert.ToDecimal(txtTipoCambio.EditValue), Convert.ToInt16(lookMoneda.EditValue), fc.IdEmpleado, Convert.ToDateTime(fecha), ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (ban.Value.ToString() == "1")
                                {

                                    this.Close();
                                }
                            }
                            dbTransaccion.Commit();
                        }
                        catch (Exception ex)
                        {
                            dbTransaccion.Rollback();
                            XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
        }

        private void lookMoneda_EditValueChanged_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lookMoneda.EditValue) == 1)
            {
                txtTipoCambio.EditValue = 1;
            }
        }

        private void lookMoneda_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (Convert.ToInt32(lookMoneda.EditValue) == 1)
            {
                txtTipoCambio.EditValue = 1;
            }
        }


    }
}