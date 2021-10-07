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


namespace Base.Ajustes
{
    public partial class frmBitacora : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        string fechaCortaInicio, fechaCortaFinal;
        public frmBitacora()
        {
            InitializeComponent();
            cargarGrid();
       
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowPrintPreview();
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((Inicio.EditValue != null) && (Final.EditValue != null))
            {
                
                try
                {
                    fc.openWaitForm(ssm);
                    using (DBSistemaContable db = new DBSistemaContable())
                    {
                        //string dia = beInicio.EditValue(yyyy/MM/dd);
                        gcGrid.DataSource = null;
                        gvGrid.Columns.Clear();
                        DateTime fecha = Convert.ToDateTime(Inicio.EditValue);
                        fechaCortaInicio = fecha.ToString("yyyy/MM/dd");
                        fecha = Convert.ToDateTime(Final.EditValue);
                        fechaCortaFinal = fecha.ToString("yyyy/MM/dd");

                        var datos = db.pac_bitacora_1(fechaCortaInicio, fechaCortaFinal, "", ""); ;
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
            else
            {
                XtraMessageBox.Show(this, "Debe de establecer una fecha de inicio y una fecha de final para completar la busqueda", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
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
                    var datos = db.pac_bitacora_1(DateTime.Now.ToString("yyyy/MM/dd"), DateTime.Now.ToString("yyyy/MM/dd"),null,null);
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

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            Final.EditValue = fechaactual;
            Inicio.EditValue = fechaactual;


        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }
    }
}