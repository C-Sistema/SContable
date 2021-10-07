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
using System.Data.Entity.Core.Objects;
using Base.BD;

namespace Base.CuentasXpagar
{
    public partial class frmCuentasXpagarMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string respuesBan = null;
        string idVi = "0", respuestaRes, origenFrm;
        bool bandera;
        public frmCuentasXpagarMant(string id = "0", string respuestaban = null,string origenFrm = null)
        {
            InitializeComponent();
            cargarLook();
            lblCodViaje.Visible = true;
            lookCodigoViaje.Visible = true;
            bandera = true;
            respuestaRes = respuestaban;
            this.origenFrm = origenFrm;
            if (id != "0")
            {
                this.idVi = id;
                bandera = false;
            
            }
            if(origenFrm == "cuentasxpagar")
            {
                cheVia.Visible = false;
            }
            cargarLook(idVi);

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            string fechaactual = DateTime.Now.Date.ToString("yyyy/MM/dd");
                            if (cheVia.Checked == true && idVi == "0" || origenFrm == "viaje")
                            {
                                fc.openWaitForm(ssm);
                                db.pam_cuenxpaga(Convert.ToByte(1), null, Convert.ToString(txtCodigoViaje.EditValue),Convert.ToString(txtDescripcion.Text), Convert.ToDecimal(txtMonto.EditValue), Convert.ToDateTime(fechaactual), cheFiscal.Checked, Convert.ToInt32(lookCodigoViaje.EditValue), Convert.ToInt32(lookMoneda.EditValue), Convert.ToInt32(lookProveedor.EditValue), Convert.ToInt32(lookCategoria.EditValue), fc.IdEmpleado, DateTime.Now, ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (ban.Value.ToString() == "1")
                                {
                                    this.Close();
                                }

                            }
                            else if (cheVia.Checked == false && idVi == "0")
                            {
                                fc.openWaitForm(ssm);
                                db.pam_cuenxpaga(Convert.ToByte(1), null, Convert.ToString(txtCodigoViaje.EditValue), Convert.ToString(txtDescripcion.Text), Convert.ToDecimal(txtMonto.EditValue), Convert.ToDateTime(fechaactual), cheFiscal.Checked, Convert.ToInt32(1), Convert.ToInt32(lookMoneda.EditValue), Convert.ToInt32(lookProveedor.EditValue), Convert.ToInt32(lookCategoria.EditValue), fc.IdEmpleado, DateTime.Now, ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (ban.Value.ToString() == "1")
                                {
                                    this.Close();
                                }
                            }
                            else if (respuestaRes == "1")//tiene pagos
                            {
                                //modificar
                                fc.openWaitForm(ssm);
                                db.pam_cuenxpaga(Convert.ToByte(3), Convert.ToInt32(idVi), Convert.ToString(txtCodigoViaje.EditValue), Convert.ToString(txtDescripcion.Text), Convert.ToDecimal(txtMonto.EditValue), Convert.ToDateTime(fechaactual), cheFiscal.Checked, Convert.ToInt32(1), Convert.ToInt32(lookMoneda.EditValue), Convert.ToInt32(lookProveedor.EditValue), Convert.ToInt32(lookCategoria.EditValue), fc.IdEmpleado, DateTime.Now, ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (ban.Value.ToString() == "1")
                                {

                                    this.Close();
                                }
                            }
                            else if (respuestaRes == "0")//no tiene pagos 
                            {
                                fc.openWaitForm(ssm);
                                db.pam_cuenxpaga(Convert.ToByte(2), Convert.ToInt32(idVi), Convert.ToString(txtCodigoViaje.EditValue), Convert.ToString(txtDescripcion.Text), Convert.ToDecimal(txtMonto.EditValue), Convert.ToDateTime(fechaactual), cheFiscal.Checked, Convert.ToInt32(1), Convert.ToInt32(lookMoneda.EditValue), Convert.ToInt32(lookProveedor.EditValue), Convert.ToInt32(lookCategoria.EditValue), fc.IdEmpleado, DateTime.Now, ban, res);
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

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCuentasXpagarMant_Load(object sender, EventArgs e)
        {

        }

        private void cargarLook(string id = null)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    string fecha = DateTime.Now.ToString("yyyy/MM/dd");
                    string fechai = Convert.ToString("2000/01/01");
                    var moneda = db.pac_moneda_1(1.ToString(), "", "", "").ToArray();
                    var proveedor = db.pac_proveedor_1(1.ToString(), "", "", "").ToArray();
                    var categoria = db.pac_catexcxp_1(1.ToString(), "", "", "").ToArray();
                    var viaje = db.pac_viaje_1(1.ToString(),fechai, fecha,"").ToArray();

                    lookCodigoViaje.Properties.DataSource = viaje;
                    lookMoneda.Properties.DataSource = moneda;
                    lookProveedor.Properties.DataSource = proveedor;
                    lookCategoria.Properties.DataSource = categoria;

                    lookCodigoViaje.Properties.DisplayMember = "Codigo";
                    lookCodigoViaje.Properties.DisplayMember = "Factura";
                    lookCodigoViaje.Properties.ValueMember = "id_via";
                    //proveedor
                    lookProveedor.Properties.DisplayMember = "Proveedor";
                    lookProveedor.Properties.ValueMember = "id_pro";
                    //tamaño[0].Tamaño
                    lookMoneda.Properties.DisplayMember = "Iso";
                    lookMoneda.Properties.ValueMember = "id_mon";
                    //presentacion[0].Presentacion
                    lookCategoria.Properties.DisplayMember = "Categoria";
                    lookCategoria.Properties.ValueMember = "id_caxcxp";

                    if (id != null && id!="0" && origenFrm == "cuentasxpagar")
                    {
                        int num = Convert.ToInt32(id);
                        var cuenta = db.pac_cuenxpaga_3(idVi, "", "", "").ToArray();
                        lblCodViaje.Visible = true;
                        lookCodigoViaje.Visible = true;
                        cheFiscal.Checked = Convert.ToBoolean(cuenta[0].Fiscal);
                        lookCodigoViaje.EditValue = cuenta[0].id_via;
                        txtCodigoViaje.EditValue = cuenta[0].Factura;
                        txtMonto.EditValue = cuenta[0].Monto;
                        deFechaPago.EditValue = cuenta[0].Fecha;
                        lookMoneda.EditValue = cuenta[0].id_mon;
                        lookProveedor.EditValue = cuenta[0].id_pro;
                        lookCategoria.EditValue = cuenta[0].id_caxcxp;
                        txtDescripcion.Text = Convert.ToString(cuenta[0].Descripción);
                    }
                    if (origenFrm == "viaje" && id != null)
                    {
                        cheVia.Visible = true;
                        cheVia.Enabled = false;
                        cheVia.Checked = true;
                        lookCodigoViaje.EditValue = id;
                        lookCodigoViaje.Enabled = false;
                        lookCodigoViaje.Visible = true;
                        
                        this.Text = "Cuentas por pagar viaje: " + lookCodigoViaje.Text;

                    }

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cheVia_CheckedChanged(object sender, EventArgs e)
        {
            if (cheVia.Checked == true)
            {
                lookCodigoViaje.Visible = true;
                lblCodViaje.Visible = true;
            }
            else
            {
                lookCodigoViaje.Visible = false;
                lblCodViaje.Visible = false;
            }
        }
    }
}