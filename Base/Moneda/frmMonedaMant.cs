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

namespace Base.Moneda
{
    public partial class frmMonedaMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        public frmMonedaMant(string id = null)
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
                    var datos = db.pac_cliente_1(id, "", "", "").ToArray();

                    txtNombre.EditValue = datos[0].Nombre;
                    txtApellido.EditValue = datos[0].Apellido;
                    txtNit.EditValue = datos[0].Nit;
                    txtTel1.EditValue = datos[0].Telefono_1;
                    txtTel2.EditValue = datos[0].Telefono_2;
                    txtEmail.EditValue = datos[0].Correo;


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
            if (vpValidar.Validate())
            {
                bool resemail = fc.ValidarEmail(txtEmail.Text);
                if (resemail == true)
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
                                    db.pam_cliente(1, null, txtNit.Text, txtNombre.Text, txtApellido.Text, txtTel1.Text, txtTel2.Text, txtEmail.Text, null, null, null, ban, res);
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
                                     Agregamos pam para modificar
                                     */
                                    db.pam_cliente(2, Convert.ToInt32(id), txtNit.Text, txtNombre.Text, txtApellido.Text, txtTel1.Text, txtTel2.Text, txtEmail.Text, null, null, null, ban, res);
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
                else
                {
                    XtraMessageBox.Show(this, "Revise el correo", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}