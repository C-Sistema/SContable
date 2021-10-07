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
using System.Data.Entity.Core.Objects;
using Base.BD;

namespace Base.Liquidacion
{
    public partial class frmLiquidacion : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmLiquidacion()
        {
            InitializeComponent();
            Inicio.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            Final.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            cargarGrid();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún viaje.", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                frmLiquidacionMant frm = new frmLiquidacionMant(vId);
                frm.Text = "Liquidacion";
                frm.ShowDialog();
            }
        }
        private void cargarForm(Form frmForm)
        {
            frmForm.MdiParent = this.MdiParent;
            frmForm.Show();
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
                    string fe1 = Convert.ToDateTime(Inicio.EditValue).ToString("yyyy/MM/dd");
                    string fe2 = Convert.ToDateTime(Final.EditValue).ToString("yyyy/MM/dd");

                    var datos = db.pac_viaje_1("1", fe1, fe2, "");
                    gcGrid.DataSource = datos.ToList();
                    fc.ocultarColumnas(gcGrid, gvGrid);
                    //fc.ocultarColumnas(gvGrid);
                    gcGrid.Refresh();
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void frmLiquidacion_Load(object sender, EventArgs e)
        {
            Inicio.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            Final.EditValue = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}