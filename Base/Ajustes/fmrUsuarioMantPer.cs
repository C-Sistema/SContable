using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Base.BD;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;


namespace Base.Usuario
{
    public partial class fmrUsuarioMantPer : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        
        public fmrUsuarioMantPer(string id=null)
        {
            InitializeComponent();
            bandera = true;
            if (id != null)
            {
                this.id = id;
                cargarGrid();

//                cargarPermisos();
                this.Text = "Clientes - Editar";
                bandera = false;
            }
        }
        void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {

                    //var datos = db.pac_permiso_1("1", "", "", "");
                    gcGrid.DataSource = null;
                    gridView1.Columns.Clear();
                    var datos2 = db.pac_permiso_2(id.ToString(), "", "", "");
                    var datosUs = db.pac_usuario_2(id.ToString(), null, null, null).ToArray();
                    lblNombre.Text = datosUs[0].Nombre +" "+ datosUs[0].Apellido;
                    lblUsuario.Text = datosUs[0].Usuario;
                    gcGrid.DataSource = datos2.ToList();
                    fc.ocultarColumnas2(gridView1);
                    gcGrid.Refresh();
                    //string xd= gridView1.GetRowCellValue(Convert.ToInt32(2), "id_bot").ToString();

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
        
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
        }
        private void gcNuevos_Click(object sender, EventArgs e)
        {
        }
        private void simpleButton1_Click(object sender, EventArgs e)
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
                            //db.pac_()
                            
                            
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
                            //fc.openWaitForm(ssm);
                            //db.pam_usuario();
                            //permisos();
                            var dt = new DataTable();
                            dt.Columns.Add("id_bot", typeof(int));
                            for (int x = 0; x < gridView1.RowCount; x++)
                            {
                                if (gridView1.GetRowCellValue(x, "Permiso").ToString() == "True")
                                {
                                    dt.Rows.Add(gridView1.GetRowCellValue(x, "id_bot"));
                                }

                            }
                            var para1 = new SqlParameter("@accion", SqlDbType.TinyInt);
                            var paraid = new SqlParameter("@id", SqlDbType.Int);
                            var paraban = new SqlParameter("@ban", SqlDbType.TinyInt);
                            var parares= new SqlParameter("@res", SqlDbType.VarChar);

                            var parametros = new SqlParameter("@lst", SqlDbType.Structured);
                            parametros.Value = dt;
                            parametros.TypeName = "dbo.permisoUsuario";

                            para1.Value = 1;
                            paraid.Value = Convert.ToInt32(id);
                            paraban.Value = 0;
                            parares.Value = Convert.ToString(res);
                            using (var datos = new DBSistemaContable())
                            {
                                datos.Database.ExecuteSqlCommand("exec pam_permiso @accion,@id,@lst,@ban,@res", para1,paraid,parametros,paraban,parares);
                                XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }


                            //db.pam_permiso(1, Convert.ToInt32(id), ban, res);
                            // db.pam_permiso(1,"4",)
                            //fc.closeWaitForm(ssm);
                            //
                            //db.pam_usuario(2, Convert.ToInt32(id), txtNombre.Text, txtPass1.Text, txtContraVieja.Text, Convert.ToInt32(id), null, fc.IdEmpleado, DateTime.Now.Date, ban, res);
                            
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcGrid_DataSourceChanged(object sender, EventArgs e)
        {
            
        }

        private void gcGrid_Click(object sender, EventArgs e)
        {

        }

        private void gcGrid_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void fmrUsuarioMantPer_Load(object sender, EventArgs e)
        {

        }
    }
}