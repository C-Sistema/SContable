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
using Base.Partida;
using Base.BD;
using System.Data.Entity.Core.Objects;

namespace Base.Partida
{
    public partial class frmPartidas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Funciones fc = new Funciones();
        public frmPartidas()
        {
            InitializeComponent();
        }
        public void Cargarform(Form frm)
        {
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }
   

        private void frmPartidas_Load(object sender, EventArgs e)
        {
            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
            Fecha1.EditValue = fechaactual;
            Fecha2.EditValue = fechaactual;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }
        void cargarGrid()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    string fe1 = Convert.ToDateTime(Fecha1.EditValue).ToString("yyyy-MM-dd");
                    string fe2 = Convert.ToDateTime(Fecha2.EditValue).ToString("yyyy-MM-dd");
                    var datos = db.pac_partida_1(fe1, fe2,"1", "");
                    
                    gcGrid.DataSource = datos.ToList();
                    gcGrid.Refresh();
                    fc.ocultarColumnas(gcGrid,gvGrid);

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            cargarGrid();
        }

        private void btnNuevo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPartidasMant frm = new frmPartidasMant();
            frm.Text = "Nueva partida";
            Cargarform(frm);
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gvGrid.DataRowCount == 0)
            {
                DialogResult result = XtraMessageBox.Show(this, "No se tiene seleccionado ningúna partida seleccionada.\n ¿Desea crear una nueva ?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmPartidasMant frm = new frmPartidasMant();
                    frm.Text = "Nueva partida";
                    Cargarform(frm);
                    //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string vId = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[0].FieldName).ToString();
                string folio = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[1].FieldName).ToString();
                string numero = gvGrid.GetRowCellValue(gvGrid.FocusedRowHandle, gvGrid.Columns[2].FieldName).ToString();
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            string fechaactual = DateTime.Now.Date.ToString("dd/MM/yyyy");
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            byte[] bytes = Encoding.ASCII.GetBytes("");
                            
                            frmPartidasMant frm = new frmPartidasMant(vId);
                            frm.Text = "Editar: "+ "Folio "+folio+" Partida no: "+numero;
                            Cargarform(frm);
                           
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
                            DialogResult result = XtraMessageBox.Show(this, "¿Desea eliminar el registro seleccionado?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                db.pam_partida(Convert.ToByte(3), Convert.ToInt32(vId), null, null, null, null, null, null, Convert.ToInt32(fc.IdEmpleado), Convert.ToDateTime(fechaactual), ban, res);
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
    }
}