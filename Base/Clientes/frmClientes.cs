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
using Base.Clientes;
using System.Data.Entity.Core.Objects;
using Base.BD;
namespace Base.Clientes
{
    public partial class frmClientes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        private void cargarForm(Form frmForm)
        {
            frmForm.MdiParent = this.MdiParent;
            frmForm.Show();
        }
        public frmClientes()
        {
            
            InitializeComponent();
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
                    var datos = db.pac_cliente_1("1", "", "", "");
                    gcGrid.DataSource = datos.ToList();
                    fc.ocultarColumnas(gcGrid, gvGrid);
                    //fc.ocultarColumnas(gvGrid);
                    gcGrid.Refresh();
                    decimal que = 0, dol=0, col = 0;
                    for (int x = 0; x < gvGrid.RowCount; x++)
                    {
                        que = que + Convert.ToDecimal(gvGrid.GetRowCellValue(x, gvGrid.Columns[7].FieldName));
                        dol= dol + Convert.ToDecimal(gvGrid.GetRowCellValue(x, gvGrid.Columns[8].FieldName));
                        col = col + Convert.ToDecimal(gvGrid.GetRowCellValue(x, gvGrid.Columns[9].FieldName));

                    }
                    barStaticItem5.Caption = "Número de clientes: "+ Convert.ToString(gvGrid.RowCount);
                    barStaticItem1.Caption = "Total Q. " + Convert.ToString(que);
                    barStaticItem2.Caption = "Total $: " + Convert.ToString(col);
                    barStaticItem3.Caption = "Total ₡. " + Convert.ToString(dol);
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmClienteMant frm = new frmClienteMant();
            frm.Text = "Nuevo cliente";
            cargarForm(frm);
            cargarGrid();
        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                XtraMessageBox.Show(this, "No se tiene seleccionado ningún registro.", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
                                db.pam_cliente(Convert.ToByte(3), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, ban, res);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cargarGrid();
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
            
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún cliente.\n ¿Desea crear un cliente?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmClienteMant frm = new frmClienteMant();
                    frm.Text = "Nuevo cliente";
                    cargarForm(frm);
                }
            }
            else
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                frmClienteMant frm = new frmClienteMant(vId);
                frm.Text = "Edita Cliente";
                cargarForm(frm);
                
            }
            cargarGrid();
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
        }
    }
}