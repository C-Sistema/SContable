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

namespace Base
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            aceptar();
        }
        private void aceptar()
        {
            if (vpValidar.Validate())
            {

                try
                {
                    fc.openWaitForm(ssm);
                    using (DBSistemaContable db = new DBSistemaContable())
                    {
                        var datos = db.pac_usuario_3(txtUsuario.Text, txtPass.Text, "", "").ToArray();
                        if (datos[0].id_emp == 0 && datos[0].id_usu == 0)
                        {
                            lblInformacion.Text = Convert.ToString(datos[0].Nombre);
                            lblInformacion.Visible = true;
                        }
                        else
                        {
                            this.Visible = false;
                            fc.IdEmpleado = Convert.ToInt32(datos[0].id_emp);
                            frmPrincipal frm = new frmPrincipal();
                            frm.Show();
                        }
                    }
                    fc.closeWaitForm(ssm);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptar();
            }
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                aceptar();
            }
        }

        private void frmLogin_Enter(object sender, EventArgs e)
        {
            aceptar();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptar();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                aceptar();
            }
        }
    }
}