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
using Base.Ajustes;

namespace Base.Pagos
{
    public partial class frmPagoProve : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmPagoProve()
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
            using (DBSistemaContable db = new DBSistemaContable())
            {
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
                        ObjectParameter ban = new ObjectParameter("ban", 0);
                        ObjectParameter res = new ObjectParameter("res", "");
                        db.pam_partida(Convert.ToByte(11), null, null, null, Convert.ToDateTime(fechaactual), null, null, null, fc.IdEmpleado, Convert.ToDateTime(fechaactual), ban, res);
                        frmPagoProveMant frm = new frmPagoProveMant(Convert.ToString(ban.Value));
                        frm.Text = "Nuevo pago";
                        Cargarform(frm);
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

        public void Cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        private void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    gcGrid.DataSource = null;
                    gvGrid.Columns.Clear();
                    string fe1 = Convert.ToDateTime(barEditItem1.EditValue).ToString("yyyy-MM-dd");
                    string fe2 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                    var datos = db.pac_pagoxprov_1(fe1, fe2, "1", "");
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

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void frmPagoProve_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            barEditItem1.EditValue = fechaactual;
            barEditItem2.EditValue = fechaactual;
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún viaje.\n ¿Desea crear uno nuevo ?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmPagoProveMant frm = new frmPagoProveMant();
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
                                    frmPagoProveMant frm = new frmPagoProveMant(vId, Convert.ToString(ban.Value));
                                    frm.Text = "Editar Viaje";
                                    Cargarform(frm);
                                }
                            }
                            else
                            {
                                frmPagoProveMant frm = new frmPagoProveMant(vId, Convert.ToString(ban.Value));
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

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningún viaje.\n ¿Desea crear uno nuevo ?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmPagoProveMant frm = new frmPagoProveMant();
                    frm.Text = "Nuevo Viaje";
                    Cargarform(frm);
                    //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                //
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                frmReportePagoxProv frm = new frmReportePagoxProv(vId);
                frm.Text = "Reporte de pago a proveedores ";
                Cargarform(frm);
            }
        }
    }
}