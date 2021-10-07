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

namespace Base.Usuario
{
    public partial class frmRoles : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmRoles()
        {
            InitializeComponent();
            cargarGrid();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRolMant frm = new frmRolMant();
            frm.Text = "Nuevo rol";

        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
        public void cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var datos = db.pac_rol_1("1", "1", "", "");
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
    }
}