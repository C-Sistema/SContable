using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Base.BD;
using System.Data.Entity.Core.Objects;
using Base.Usuario;


namespace Base.Empleado
{
    public partial class frmEmpleado1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        string idusuarioempleado = null, vIdemp;
        public frmEmpleado1()
        {
            InitializeComponent();
            cargarGrid();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEmpleadoMant frm = new frmEmpleadoMant();
            frm.Text = "Nuevo empleado";
            Cargarform(frm);
        }
        public void Cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
            frmEmpleadoMant frm = new frmEmpleadoMant(vId);
            frm.Text = "Editar empleado";
            Cargarform(frm);

            cargarGrid();
        }
        void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    gcGrid.DataSource = null;
                    gvGrid.Columns.Clear();
                    var datos = db.pac_empleado_1("1", "1", "", "");
                    gcGrid.DataSource = datos.ToList();
                    gcGrid.Refresh();
                    fc.ocultarColumnas(gcGrid, gvGrid);

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
            using (DBSistemaContable db = new DBSistemaContable())
            {
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        DialogResult result = XtraMessageBox.Show(this, "¿Desea borrar el siguiente registro?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        byte[] bytes = Encoding.ASCII.GetBytes("");
                        if (result == DialogResult.Yes)
                        {
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            string fechaActual = DateTime.Now.Date.ToString();
                            db.pam_empleado(3, Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, fc.IdEmpleado, Convert.ToDateTime(fechaActual), ban, res);
                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            cargarGrid();
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            gcGrid.ShowRibbonPrintPreview();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            string Idemp  = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
            CargarIdUsEmp(Idemp);
            if (idusuarioempleado == null)
            {
                DialogResult resulta = XtraMessageBox.Show(this, "El empleado no tiene cuenta de usuario, ¿Desea crear una cuenta de usuario?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resulta == DialogResult.Yes)
                {
                    frmUsuarioMantenimiento frm = new frmUsuarioMantenimiento(Idemp, "nuevo");
                    frm.Text = "Crear usuario";
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    cargarGrid();
                    idusuarioempleado = null;
                }
                else {
                    cargarGrid();
                }
          
            }
            else if (idusuarioempleado != null)
            {
                DialogResult resulta = XtraMessageBox.Show(this, "El empleado ya tiene usuario desea modificarlo", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resulta == DialogResult.Yes)
                {
                    frmUsuarioMantenimiento frm = new frmUsuarioMantenimiento(idusuarioempleado, "ModificarUsuario");
                    frm.Text = "Modificar usuario";
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                    cargarGrid();
                    idusuarioempleado = null;
                }
                else
                {
                    cargarGrid();
                }

            }
                        
        }
        private void CargarIdUsEmp(string id)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    DataTable valores = new DataTable();
                    var datos = db.pac_usuario_1(Convert.ToString(1), "", "", "").ToArray();
                    for (int x = 0; x < datos.Count(); x++)
                    {
                        if (datos[x].id_emp == Convert.ToInt32(id))
                        {
                            idusuarioempleado = datos[x].id_usu.ToString();
                        }
                    }
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}