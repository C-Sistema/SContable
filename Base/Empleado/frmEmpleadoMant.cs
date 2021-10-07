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



namespace Base.Empleado
{
    public partial class frmEmpleadoMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        public frmEmpleadoMant(string id = null)
        {
            InitializeComponent();
            bandera = true;
            this.id = id;
            cargarDatos();
            bandera = false;



        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    DataTable valores = new DataTable();
                    var datos = db.pac_empleado_2(id, "", "", "").ToArray();
                    var rol = db.pac_rol_1(1.ToString(), "","","").ToArray();
                    lookRol.Properties.DataSource = rol;
                    lookRol.Properties.DisplayMember = "Rol";
                    lookRol.Properties.ValueMember = "id_rol";
                    if (id != null)
                    {
                        txtNombre.EditValue = datos[0].Nombre;
                        txtApellido.EditValue = datos[0].Apellido;
                        txtDpi.EditValue = datos[0].Cui;
                        txtDireccion.EditValue = datos[0].Direccion;
                        txtTel1.EditValue = datos[0].Telefono_1;
                        txtTel2.EditValue = datos[0].Telefono_2;
                        txtEmail.EditValue = datos[0].Correo;
                        deInicioContrato.EditValue = datos[0].F_incio.ToString("dd/MM/yyyy");
                        deFinContrato.EditValue = datos[0].F_fin;
                        lookRol.EditValue = datos[0].id_rol;
                    }
                    
                    
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if(vpValidar.Validate())
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
                                string fechaactual = DateTime.Now.Date.ToString("yyyy/MM/dd");
                                if (id == null)
                                {
                                    fc.openWaitForm(ssm);
                                    //agregamos pam para insertar
                                    db.pam_empleado(1, null, txtNombre.Text, txtApellido.Text, txtDpi.Text, Convert.ToDateTime(deInicioContrato.EditValue), Convert.ToDateTime(deFinContrato.EditValue), txtDireccion.Text, txtTel1.Text, txtTel2.Text, txtEmail.Text, Convert.ToInt32(lookRol.EditValue), fc.IdEmpleado, Convert.ToDateTime(fechaactual), ban, res);
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
                                    db.pam_empleado(2, Convert.ToInt32(id), txtNombre.Text, txtApellido.Text, txtDpi.Text, Convert.ToDateTime(deInicioContrato.EditValue), Convert.ToDateTime(deFinContrato.EditValue), txtDireccion.Text, txtTel1.Text, txtTel2.Text, txtEmail.Text, Convert.ToInt32(lookRol.EditValue), fc.IdEmpleado, Convert.ToDateTime(fechaactual), ban, res);
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

 
    }
}