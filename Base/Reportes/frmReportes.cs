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
using DevExpress.XtraReports.UI;

namespace Base.Reportes
{
    public partial class frmReportes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmReportes()
        {
            InitializeComponent();
            cargarGrid();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                // fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    if (gvGrid.DataRowCount != 0)
                    {
                        if (barToggleSwitchItem1.Checked == true)
                        {
                            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[7].FieldName).ToString();
                            LibroDiarioReport rep = new LibroDiarioReport();
                            rep.Parameters[0].Value = vId;
                            rep.Parameters[1].Value = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
                            rep.Parameters[2].Value = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                            rep.CreateDocument();
                            rep.ShowRibbonPreviewDialog();

                        }
                        else
                        if (barToggleSwitchItem2.Checked == true)
                        {
                            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                            MayorReport rep = new MayorReport();
                            rep.Parameters[0].Value = vId;
                            DateTime ff = Convert.ToDateTime(busque1.EditValue);

                            rep.Parameters[1].Value = ff.ToString("yyyy");
                            rep.CreateDocument();
                            rep.ShowRibbonPreviewDialog();

                        }
                        else
                        if (barToggleSwitchItem3.Checked == true)
                        {
                            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                            Report1 rep = new Report1();
                            rep.Parameters[0].Value = vId;
                            rep.Parameters[1].Value = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
                            rep.Parameters[2].Value = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                            rep.CreateDocument();
                            rep.ShowRibbonPreviewDialog();

                        }
                        else
                        if (barToggleSwitchItem4.Checked == true)
                        {

                        }
                        else
                        if (barToggleSwitchItem5.Checked == true)
                        {
                            string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                            LiquidacionViaje rep = new LiquidacionViaje();
                            rep.Parameters[0].Value = vId;
                            rep.CreateDocument();
                            rep.ShowRibbonPreviewDialog();
                        }
                        else
                        if (barToggleSwitchItem6.Checked == true)
                        {

                        }
                    }
                    else
                    {
                        DialogResult result = XtraMessageBox.Show(this, "No se tiene nada seleccionado.", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                // fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            //barToggleSwitchItem1.Checked = true;
            barEditItem1.Enabled = true;
            barEditItem2.Enabled = true;
            ribbonPageGroup4.Visible = false;
            ribbonPageGroup3.Visible = true;
            barToggleSwitchItem2.Checked = false;
            barToggleSwitchItem3.Checked = false;
            barToggleSwitchItem4.Checked = false;
            barToggleSwitchItem5.Checked = false;
            barToggleSwitchItem6.Checked = false;
            string fe1 = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
            string fe2 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
            cargarGrid("",fe1,fe2);
        }

        private void barToggleSwitchItem2_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            barEditItem1.Enabled = true;
            barEditItem2.Enabled = true;
            ribbonPageGroup3.Visible = false;
            ribbonPageGroup4.Visible = true;
            barEditItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            barToggleSwitchItem1.Checked = false;
            barToggleSwitchItem3.Checked = false;
            barToggleSwitchItem4.Checked = false;
            barToggleSwitchItem5.Checked = false;
            barToggleSwitchItem6.Checked = false;
            string fe1 = Convert.ToString(busque1.EditValue);
            //string fe2 = Convert.ToString(busque2.EditValue);
            cargarGrid("",fe1);
        }

        private void barToggleSwitchItem3_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            barToggleSwitchItem2.Checked = false;
            barToggleSwitchItem1.Checked = false;
            barToggleSwitchItem4.Checked = false;
            barToggleSwitchItem5.Checked = false;
            barToggleSwitchItem6.Checked = false;
            barEditItem1.Enabled = true;
            barEditItem2.Enabled = true;
            ribbonPageGroup4.Visible = false;
            ribbonPageGroup3.Visible = true;
            string fe1 = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
            string fe2 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
            cargarGrid();
        }


        private void barToggleSwitchItem4_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            barToggleSwitchItem2.Checked = false;
            barToggleSwitchItem3.Checked = false;
            barToggleSwitchItem1.Checked = false;
            barToggleSwitchItem5.Checked = false;
            barToggleSwitchItem6.Checked = false;
            cargarGrid();
        }

        private void barToggleSwitchItem5_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            barToggleSwitchItem2.Checked = false;
            barToggleSwitchItem3.Checked = false;
            barToggleSwitchItem4.Checked = false;
            barToggleSwitchItem1.Checked = false;
            barToggleSwitchItem6.Checked = false; 
            string fe1 = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
            string fe2 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
            cargarGrid("", fe1, fe2);
        }

        private void barToggleSwitchItem6_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            barToggleSwitchItem2.Checked = false;
            barToggleSwitchItem3.Checked = false;
            barToggleSwitchItem4.Checked = false;
            barToggleSwitchItem5.Checked = false;
            barToggleSwitchItem1.Checked = false;
            cargarGrid();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }
        private void cargarGrid(string ids = "",string fecha1 = "",string fecha2 ="")
        {
            try
            {
                string fe1 = fecha1;
                string fe2 = fecha2;
                string id = ids;
                
                // fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    if (barToggleSwitchItem1.Checked == true)
                    {
                        
                        gcGrid.DataSource = null;
                        gvGrid.Columns.Clear();
                        var datos = db.pac_partida_3("1", "","","");
                        gcGrid.DataSource = datos.ToList();
                        gcGrid.Refresh();
                        fc.ocultarColumnas(gcGrid, gvGrid);
                    }
                    else
                        if (barToggleSwitchItem2.Checked == true)
                    {
                        gcGrid.DataSource = null;
                        gvGrid.Columns.Clear();
                        var datos = db.pac_nomenclatura_1("1", "","","");
                        gcGrid.DataSource = datos.ToList();
                        gcGrid.Refresh();
                        fc.ocultarColumnas(gcGrid, gvGrid);
                    }
                    else
                        if (barToggleSwitchItem3.Checked == true)
                    {
                        gcGrid.DataSource = null;
                        gvGrid.Columns.Clear();
                        var datos = db.pac_banco_1("1", "", "", "");
                        gcGrid.DataSource = datos.ToList();
                        gcGrid.Refresh();
                        fc.ocultarColumnas(gcGrid, gvGrid);
                    }
                    else
                        if (barToggleSwitchItem4.Checked == true)
                    {

                    }
                    else
                        if (barToggleSwitchItem5.Checked == true)
                    {
                        gcGrid.DataSource = null;
                        gvGrid.Columns.Clear();
                        var datos = db.pac_viaje_1("1",fe1,fe2,"");
                        gcGrid.DataSource = datos.ToList();
                        gcGrid.Refresh();
                        fc.ocultarColumnas(gcGrid, gvGrid);

                    }
                    else
                        if (barToggleSwitchItem6.Checked == true)
                    {

                    }
        

                }
               // fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            string fechaactual2 = DateTime.Now.Date.ToString("yyyy");
            barEditItem1.EditValue = fechaactual;
            barEditItem2.EditValue = fechaactual;

            busque1.EditValue = fechaactual;
            busque2.EditValue = fechaactual;

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnbusq2_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }
    }
}