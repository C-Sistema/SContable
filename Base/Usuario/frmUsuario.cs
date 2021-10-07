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
using Base.Ajustes;

namespace Base.Usuario
{
    public partial class frmUsuario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmUsuario()
        {
            InitializeComponent();
            cargarGrid();
      
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
            cargarGrid();
        }
        public void Cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmUsuarioMantenimiento frm = new frmUsuarioMantenimiento();
            //frm.Text = "Nuevo Usuario";
            //Cargarform(frm);
        }
        void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var datos = db.pac_usuario_1("1", "", "", "");
                    
                    gcGrid.DataSource = datos.ToList();
                    
                    fc.ocultarColumnas(gcGrid, gvGrid);
                    gcGrid.Refresh();

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
            frmUsuarioMantenimiento frm = new frmUsuarioMantenimiento(vId, "usuario");
            frm.Text = "Editar usuario";
            frm.MdiParent = this.MdiParent;
            frm.Show();

            cargarGrid();
        }
        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount != 0)
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
                                if (Convert.ToInt32(vId) != fc.IdEmpleado)
                                {
                                    db.pam_usuario(3, Convert.ToInt32(vId), null, null, null, null, null, fc.IdEmpleado, DateTime.Now.Date, ban, res);
                                    XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    XtraMessageBox.Show(this, "No puedes eliminar tu propia cuenta de usuario", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cargarGrid();

        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnPermisos_ItemClick(object sender, ItemClickEventArgs e)
        {
            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
            fmrUsuarioMantPer frm = new fmrUsuarioMantPer(vId);
            frm.Text = "Permisos usuario";
            frm.MdiParent = this.MdiParent;
            frm.Show();
            cargarGrid();


        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
    }
}