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

namespace Base.Usuario
{
    public partial class frmUsuarioMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        string idUsuarioEmple;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        string casoform = null;
        string idempleado = null;
        public frmUsuarioMantenimiento(string id = null, string caso = null)
        {
            InitializeComponent();
            bandera = true;
            casoform = caso;
            idempleado = id;
            if (id != null && caso == "ModificarUsuario")
            {
                this.id = id;
                cargarDatos();
                this.Text = "Usuario - Editar";
                bandera = false;
                lblContra3.Visible = true;
                txtContraVieja.Visible = true;
                lblcontra1.Text = "Nueva contraseña";
            }
            else
            if (id != null && caso == "usuario")
            {
                this.id = id;
                cargarDatos();
                this.Text = "Usuario - Editar";
                bandera = false;
                lblContra3.Visible = false;
                txtContraVieja.Visible = false;
                lblcontra1.Text = "Nueva contraseña";
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
                    var datos = db.pac_usuario_2(id, "", "", "").ToArray();

                    txtNombre.EditValue = datos[0].Usuario;

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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    using (DBSistemaContable db = new DBSistemaContable())
                    {
                        using (var dbTransaccion = db.Database.BeginTransaction())
                        {
                            try
                            {
                                ObjectParameter ban = new ObjectParameter("ban", 0);
                                ObjectParameter res = new ObjectParameter("res", "");
                                string fechactual = DateTime.Now.ToString("yyyy/MM/dd");
                                if (idempleado != null && casoform == "nuevo")
                                {
                                    fc.openWaitForm(ssm);
                                    //agregamos pam para insertar
                                    db.pam_usuario(1, null, txtNombre.Text, txtPass1.Text, null, Convert.ToInt32(idempleado), null, fc.IdEmpleado, DateTime.Now.Date, ban, res);
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
                                    //db.pam_usuario();
                                    fc.closeWaitForm(ssm);
                                    DialogResult resulta = XtraMessageBox.Show(this, "Se borrará la contraseña anterior", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (resulta == DialogResult.Yes)
                                    {
                                        if (fc.IdEmpleado == Convert.ToInt32(id))
                                        {
                                            db.pam_usuario(2, Convert.ToInt32(id), txtNombre.Text, txtPass1.Text, txtContraVieja.Text, null, null, null, null, ban, res);
                                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            db.pam_usuario(4, Convert.ToInt32(id), txtNombre.Text, txtPass1.Text, txtContraVieja.Text, null, null, fc.IdEmpleado, Convert.ToDateTime(fechactual), ban, res);
                                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                        if (ban.Value.ToString() == "1")
                                        {

                                            this.Close();
                                        }

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
                    XtraMessageBox.Show(this, "Las contraseñas no coinciden", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}