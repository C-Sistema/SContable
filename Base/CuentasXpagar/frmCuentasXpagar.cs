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

namespace Base.CuentasXpagar
{
    public partial class frmCuentasXpagar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmCuentasXpagar()
        {
            InitializeComponent();
            cargarGrid();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }
    

        private void frmCuentasXpagar_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            barEditItem2.EditValue = fechaactual;
            barEditItem3.EditValue = fechaactual;
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
                    string fe1 = Convert.ToDateTime(barEditItem2.EditValue).ToString("yyyy-MM-dd");
                    string fe2 = Convert.ToDateTime(barEditItem3.EditValue).ToString("yyyy-MM-dd");
                    var datos = db.pac_cuenxpaga_1(fe1, fe2,"1", "");
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
        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCuentasXpagarMant frm = new frmCuentasXpagarMant();
            frm.Text = "Cuentas por pagar";
            cargarform(frm);
        }
        public void cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionada ningúna cuenta por pagar.\n ¿Desea crear una nueva cuenta por pagar ?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmCuentasXpagarMant frm = new frmCuentasXpagarMant();
                    frm.Text = "Cuentas por pagar";
                    cargarform(frm);
                }
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
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");

                            db.pam_cuenxpaga(Convert.ToByte(11), Convert.ToInt32(vId), null, null, null, null,null, null, null, null, null, null, null, ban, res);
                            if (Convert.ToInt32(ban.Value) == 1)
                            {
                                DialogResult result = XtraMessageBox.Show(this, "Realizar esta modificación alterara otras tablas debido a que ya tiene otros procedimientos.\n¿Desea continuar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                byte[] bytes = Encoding.ASCII.GetBytes("");
                                if (result == DialogResult.Yes)
                                {
                                    //retorna van 1 porque tiene prcesos que afectan el proceso 
                                    frmCuentasXpagarMant frm = new frmCuentasXpagarMant(vId, Convert.ToString(ban.Value),"cuentasxpagar");
                                    frm.Text = "Editar cuenta";
                                    cargarform(frm);
                                }
                            }
                            else
                            {
                                //retorna ban 0 cuando esta libre
                                frmCuentasXpagarMant frm = new frmCuentasXpagarMant(vId, Convert.ToString(ban.Value), "cuentasxpagar");
                                frm.Text = "Editar cuenta";
                                cargarform(frm);
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
                   
                  
                }

            }
            cargarGrid();
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
                            fc.openWaitForm(ssm);
                            db.pam_cuenxpaga(Convert.ToByte(11), Convert.ToInt32(vId), null,  null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                            if (Convert.ToInt32(ban.Value) == 1)
                            {
                                DialogResult result = XtraMessageBox.Show(this, "Eliminar este registro alterara otras tablas debido a que ya tiene otros procedimientos.\n¿Desea continuar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                byte[] bytes = Encoding.ASCII.GetBytes("");
                                if (result == DialogResult.Yes)
                                {
                                    db.pam_cuenxpaga(Convert.ToByte(5), Convert.ToInt32(vId), null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                                }
                            }
                            else
                            {
                                db.pam_cuenxpaga(Convert.ToByte(4), Convert.ToInt32(vId),null, null, null, null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
                            }
                            fc.closeWaitForm(ssm);
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

    }
}