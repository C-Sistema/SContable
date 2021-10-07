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
namespace Base.Venta
{
    public partial class frmVenta : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmVenta()
        {
            InitializeComponent();
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
            frmVentaMant frm = new frmVentaMant();
            frm.Text = "Nueva venta";
            Cargarform(frm);
        }
        public void Cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        void cargarGrid(string now =  null)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    string fe1 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                    string fe2 = Convert.ToDateTime(barEditItem3.EditValue).ToString("yyyy-MM-dd");
                    var datos = db.pac_venta_1("1", fe1, fe2, "");
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
                                DateTime fecha = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy"));
                                db.pam_venta(Convert.ToByte(11), Convert.ToInt32(vId), null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), fecha, ban, res);

                                if (Convert.ToInt32(ban.Value) == 1)
                                {
                                    DialogResult resultado = XtraMessageBox.Show(this, "Eliminar este registro alterara otras tablas debido a que ya tiene otros procedimientos.\n¿Desea continuar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                    if (resultado == DialogResult.Yes)
                                    {
                                        db.pam_venta(Convert.ToByte(4), Convert.ToInt32(vId), null, null, null, null, null, null, null, fc.IdEmpleado, fecha, ban, res);
                                    }

                                }
                                else
                                if (Convert.ToInt32(ban.Value) == 0)
                                {
                                    db.pam_venta(Convert.ToByte(5), Convert.ToInt32(vId), null, null, null, null, null, null, null, fc.IdEmpleado, fecha, ban, res);
                                }

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
            }
            cargarGrid();

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            barEditItem2.EditValue = fechaactual;
            barEditItem3.EditValue = fechaactual;
        }
    }
}