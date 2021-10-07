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


namespace Base.Proveedores
{

    public partial class frmProveedoresMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;

        public frmProveedoresMant(string id = null)
        {
            InitializeComponent();
            bandera = true;
            if (id != null)
            {
                this.id = id;
                cargarDatos();
                bandera = false;
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
                    var datos = db.pac_proveedor_2(id, "", "", "").ToArray();

                    txtNombre.EditValue = datos[0].Proveedor;
                    txtDireccion.EditValue = datos[0].Direccion;
                    txtCodigo.EditValue = datos[0].CP;
                    txtTel1.EditValue = datos[0].Telefono_1;
                    txtTel2.EditValue = datos[0].Telefono_2;
                    txtReferencias.Text= datos[0].Extra;
                    txtRfiscal.EditValue = datos[0].Reg__Fiscal;
                    //txtEmail.EditValue = datos[0].Correo;
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
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
                                if (id == null)
                                {
                                    fc.openWaitForm(ssm);
                                    //agregamos pam para insertar
                                    db.pam_proveedor(1, null, txtNombre.Text, txtDireccion.Text, txtCodigo.Text, Convert.ToString(txtTel1.Text), Convert.ToString(txtTel2.Text), txtRfiscal.Text, null, null, txtReferencias.Text, ban, res);
                                    fc.closeWaitForm(ssm);
                                    XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (ban.Value.ToString() == "1")
                                    {

                                        this.Close();
                                    }
                                }
                                else
                                {
                                    //modificar
                                    fc.openWaitForm(ssm);
                                    /* 
                                     Agregamos pam para modificar*/
                                    db.pam_proveedor(2, Convert.ToInt32(id), txtNombre.Text, txtDireccion.Text, txtCodigo.Text, Convert.ToString(txtTel1.Text), Convert.ToString(txtTel2.Text), txtRfiscal.Text, null, null, txtReferencias.Text, ban, res);
                                     
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
    }
}