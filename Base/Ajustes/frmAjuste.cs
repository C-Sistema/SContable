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


namespace Base.Ajustes
{
    public partial class frmAjuste : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();

        public frmAjuste()
        {
            InitializeComponent();
            cargarGrid();
           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {

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

                    var datos = db.pac_lote_3("1", "", "", "");
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
    }
}