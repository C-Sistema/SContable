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
using Base.Viaje;
using Base.Liquidacion;
using Base.CuentasXpagar;

namespace Base.Viaje
{
    public partial class frmViaje : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmViaje()
        {
            InitializeComponent();
            cargarGrid();

        }
        public void Cargarform(Form frm)
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
                    string fe1 = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
                    string fe2 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                    var datos = db.pac_viaje_3("1", fe1, fe2, "");
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

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }


        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmViajeMant frm = new frmViajeMant();
            frm.Text = "Nuevo Viaje";
            Cargarform(frm);
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún viaje.\n ¿Desea crear uno nuevo ?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmViajeMant frm = new frmViajeMant();
                    frm.Text = "Nuevo Viaje";
                    Cargarform(frm);
                    //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                //
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();

                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            db.pam_viaje(Convert.ToByte(11), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                            if (Convert.ToInt32(ban.Value) == 1)
                            {
                                DialogResult result = XtraMessageBox.Show(this, "Realizar esta modificación alterara otras tablas debido a que ya tiene otros procedimientos.\n¿Desea continuar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                byte[] bytes = Encoding.ASCII.GetBytes("");
                                if (result == DialogResult.Yes)
                                {
                                    frmViajeMant frm = new frmViajeMant(vId, Convert.ToString(ban.Value));
                                    frm.Text = "Editar Viaje";
                                    Cargarform(frm);
                                }
                            }
                            else
                            {
                                frmViajeMant frm = new frmViajeMant(vId, Convert.ToString(ban.Value));
                                frm.Text = "Editar Viaje";
                                Cargarform(frm);
                            }
                            //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
                            db.pam_viaje(Convert.ToByte(11), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                            if (Convert.ToInt32(ban.Value) == 1)
                            {
                                DialogResult result = XtraMessageBox.Show(this, "Eliminar este registro alterara otras tablas debido a que ya tiene otros procedimientos.\n¿Desea continuar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                byte[] bytes = Encoding.ASCII.GetBytes("");
                                if (result == DialogResult.Yes)
                                {
                                    db.pam_viaje(Convert.ToByte(5), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                                }
                            }
                            else
                            {
                                db.pam_viaje(Convert.ToByte(4), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
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

        private void ribbonControl_Click(object sender, EventArgs e)
        {

        }

        private void frmViaje_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            barEditItem1.EditValue = fechaactual;
            barEditItem2.EditValue = fechaactual;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (gvGrid.DataRowCount != 0)
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                if (vId != "0")
                {
                    using (DBSistemaContable db = new DBSistemaContable())
                    {
                        using (var dbTransaccion = db.Database.BeginTransaction())
                        {
                            try
                            {
                                ObjectParameter ban = new ObjectParameter("ban", 0);
                                ObjectParameter res = new ObjectParameter("res", "");
                                string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
                                fc.openWaitForm(ssm);
                                db.pam_viaje(Convert.ToByte(6), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                                fc.closeWaitForm(ssm);
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

            }
            else
            {
                XtraMessageBox.Show("Seleccione un viaje para terminarlo o activarlo", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount != 0)
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                if (vId != "0")
                {
                    frmCuentasXpagarMant frm = new frmCuentasXpagarMant(vId, null, "viaje");
                    frm.Text = "Cuentas por pagar viaje";
                    Cargarform(frm);
                }
            }
            else
            {
                XtraMessageBox.Show("Seleccione un viaje para poder agregarle cuentas por pagar", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount != 0)
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();

                frmViajeCuentas frm = new frmViajeCuentas(vId);
                frm.Text = "Cuentas por pagar viaje";
                frm.ShowDialog();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
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
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún viaje.", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                frmViajeAjuste frm = new frmViajeAjuste(vId);
                frm.Text = "Ajuste viaje";
                frm.ShowDialog();
            }
        }
    }
}