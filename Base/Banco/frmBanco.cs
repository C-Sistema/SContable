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
using Base.Banco;

namespace Base.Banco
{
    public partial class frmBanco : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmBanco()
        {
            InitializeComponent();
            cargarGrid();
            gcGrid.Refresh();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }
 
        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBancoMant frm = new frmBancoMant();
            frm.Text = "Nuevo Banco";
            cargarForm(frm);
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
                    var datos = db.pac_banco_1("1", "", "", "");
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
        private void cargarForm(Form frmForm)
        {
            frmForm.MdiParent = this.MdiParent;
            frmForm.Show();
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
                            db.pam_banco(Convert.ToByte(3), Convert.ToInt32(vId),null,null,null,null, null, null, null, null, null, null, ban, res);
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
                cargarGrid();
            }
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.Refresh();
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            Inicio.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            Final.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount != 0)
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();

                frmBancoHistorial frm = new frmBancoHistorial(vId,Convert.ToString(Inicio.EditValue),Convert.ToString(Final.EditValue));
                frm.Text = "Historia bancario";
                frm.ShowDialog();

            }
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount != 0)
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                frmBancoHistorial frm = new frmBancoHistorial(vId, Convert.ToString(Inicio.EditValue), Convert.ToString(Final.EditValue),"Rep");
                frm.Text = "Reporte bancario";
                frm.ShowDialog();

            }

        }
    }
}