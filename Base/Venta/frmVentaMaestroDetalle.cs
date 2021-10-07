using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmVentaMaestroDetalle : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        DataTable dt = new DataTable();
        int idlotemant,idNomant= 0;
        int idlote,idvia,idpro,idtam,idpre = 0;
        string mon = null;
        private void txtPrecioUnita_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotal.EditValue = Convert.ToDecimal(txtPrecioUnita.EditValue) * Convert.ToDecimal(txtPedido.EditValue);
        }

        private void txtPrecioUnita_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotal.EditValue = Convert.ToDecimal(txtPrecioUnita.EditValue) * Convert.ToDecimal(txtPedido.EditValue);
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPedido_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotal.EditValue = Convert.ToDecimal(txtPrecioUnita.EditValue) * Convert.ToDecimal(txtPedido.EditValue);
        }

        private void frmVentaMaestroDetalle_Load(object sender, EventArgs e)
        {

        }

        private void txtPedido_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotal.EditValue = Convert.ToDecimal(txtPrecioUnita.EditValue) * Convert.ToDecimal(txtPedido.EditValue);
        }


        public frmVentaMaestroDetalle(DataTable dat = null, int idmantlote = 0, int idNo = 0,string mon = null)
        {
            InitializeComponent();
            dt = dat;
            idNomant = idNo;
            idlote = 0;
            this.idlotemant = idmantlote;
            this.mon = mon;
            moneda(mon);
            cargargrid();
        }
        private void cargargrid(string dattable = null)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var lote = db.pac_lote_3("1", "", "", "").ToList();

                    gridControl1.DataSource = lote;
                    if (idlotemant != 0 && dattable == null)
                    {
                        for (int b = 0; b < gridView1.RowCount; b++)
                        {
                            if (idlotemant == Convert.ToInt32(gridView1.GetRowCellValue(b, "id_lot")))
                            {
                                idlote = Convert.ToInt32(gridView1.GetRowCellValue(b, "id_lot"));
                                idvia = Convert.ToInt32(gridView1.GetRowCellValue(b, "id_via"));
                                idtam = Convert.ToInt32(gridView1.GetRowCellValue(b, "id_tam"));
                                idpre = Convert.ToInt32(gridView1.GetRowCellValue(b, "id_pre"));
                                idpro = Convert.ToInt32(gridView1.GetRowCellValue(b, "id_pro"));
                                txtProducto.EditValue = Convert.ToString(gridView1.GetRowCellValue(b, "Producto"));
                                txtTamaño.EditValue = Convert.ToString(gridView1.GetRowCellValue(b, "Tamaño"));
                                txtPresentacion.EditValue = Convert.ToString(gridView1.GetRowCellValue(b, "Presentación"));
                                txtExistencias.EditValue = Convert.ToDecimal(gridView1.GetRowCellValue(b, "Existencia"));
                                txtPedido.EditValue = Convert.ToInt32(dt.Rows[idNomant][10]);
                                txtPrecioUnita.EditValue = Convert.ToDecimal(dt.Rows[idNomant][11]);
                            }
                       
                        }
                    }
                    //fc.ocultarColumnas(gridView1);
                    gridControl1.Refresh();
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void moneda(string mon)
        {


            frmVentaMant frmv = new frmVentaMant();
            if (mon == "GTQ")
            {
                lblTotal.Text = "Q";
                lblPrecioUni.Text = "Q";
            }
            else if (mon == "USD")
            {
                lblTotal.Text = "$";
                lblPrecioUni.Text = "$";
            }
            else if (mon == "CRC")
            {
                lblTotal.Text = "₡";
                lblPrecioUni.Text = "₡";
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                int existe = 0;
                int pos = 0;
                if (Convert.ToDouble(txtPedido.EditValue) <= Convert.ToDouble(txtExistencias.EditValue))
                {
                    if (idNomant == 0 && idlotemant == 0 && idlote == 0)
                    {
                        for (int a = 0; a < dt.Rows.Count; a++)
                        {
                            for (int b = 0; b < gridView1.RowCount; b++)
                            {
                                if (Convert.ToInt32(dt.Rows[a][0]) == Convert.ToInt32(gridView1.GetRowCellValue(b, "id_lot")))
                                {
                                    existe = 1;
                                    pos = a;
                                }
                            }
                        }
                        if (existe == 1)
                        {
                            if (Convert.ToDouble(dt.Rows[pos][10]) <= Convert.ToDouble(txtExistencias.EditValue))
                            {
                                dt.Rows[pos][10] = Convert.ToDouble(txtPedido.EditValue);
                                dt.Rows[pos][11] = Convert.ToDouble(txtPrecioUnita.EditValue);
                                dt.Rows[pos][12] = Convert.ToDouble(txtTotal.EditValue);
                                idNomant = 0;
                                idlotemant = 0;
                                this.Close();
                            }
                            else
                            {
                                XtraMessageBox.Show(this, "El pedido  pasa las existencias", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        if (existe == 0)
                        {
                            int x = dt.Rows.Count + 1;
                            dt.Rows.Add(
                            idlote,//0
                            x,//1
                            idvia,//2
                            idpro,//3
                            Convert.ToString(txtProducto.EditValue),//4
                            idtam,//5
                            Convert.ToString(txtTamaño.EditValue),//6
                            idpre,//7
                            Convert.ToString(txtPresentacion.EditValue),//8
                            Convert.ToDouble(txtExistencias.EditValue),//9
                            Convert.ToDouble(txtPedido.EditValue),//10
                            Convert.ToDouble(txtPrecioUnita.EditValue),//11
                            Convert.ToDouble(txtTotal.EditValue)//12
                            );
                            idNomant = 0;
                            idlotemant = 0;
                            this.Close();
                        }
                    }
                    else
                    {
                        if (idlote != 0)
                        {
                            for (int a = 0; a < dt.Rows.Count; a++)
                            {
                                if (Convert.ToInt32(dt.Rows[a][0]) == idlote)
                                {
                                    existe = 1;
                                    a = dt.Rows.Count;
                                }
                            }
                            if (existe == 1)
                            {
                                if (Convert.ToDecimal(txtPedido.EditValue) > Convert.ToDecimal(gridView1.GetRowCellValue(pos, "Existencia")))
                                {
                                    XtraMessageBox.Show(this, "El pedido pasa las existencias", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    int numer = Convert.ToInt32(gridView1.FocusedRowHandle);
                                    if (numer == 0)
                                    {
                                        int numeere = 0;
                                        for (int c = 0; c < dt.Rows.Count; c++)
                                        {
                                            if (idlote == Convert.ToInt32(dt.Rows[c]["id_lot"]))
                                            {
                                                numeere = Convert.ToInt32(dt.Rows[c]["No"]) - 1;
                                                dt.Rows[c][10] = Convert.ToDouble(txtPedido.EditValue);
                                                dt.Rows[c][11] = Convert.ToDouble(txtPrecioUnita.EditValue);
                                                dt.Rows[c][12] = Convert.ToDouble(txtTotal.EditValue);
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                            }
                            else if (existe == 0)
                            {
                                int x = dt.Rows.Count + 1;
                                dt.Rows.Add(
                                idlote,
                                x,
                                idvia,
                                idpro,
                                Convert.ToString(txtProducto.EditValue),
                                idtam,
                                Convert.ToString(txtTamaño.EditValue),
                                idpre,
                                Convert.ToString(txtPresentacion.EditValue),
                                Convert.ToDouble(txtExistencias.EditValue),
                                Convert.ToDouble(txtPedido.EditValue),
                                Convert.ToDouble(txtPrecioUnita.EditValue),
                                Convert.ToDouble(txtTotal.EditValue)
                                );
                                idNomant = 0;
                                idlotemant = 0;
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "El pedido  pasa las existencias", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                frmVentaMant ventaMant = Owner as frmVentaMant;
                ventaMant.gridControl1.DataSource = dt;
                //fc.ocultarColumnas(gridView1);
                ventaMant.gridControl1.Refresh();
            }
        }
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int numer = Convert.ToInt32(gridView1.FocusedRowHandle);
            idlote = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_lot"));
            idvia = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_via"));
            idtam = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_tam"));
            idpre = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_pre"));
            idpro = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_pro"));
            txtProducto.EditValue = Convert.ToString(gridView1.GetRowCellValue(numer, "Producto"));
            txtTamaño.EditValue = Convert.ToString(gridView1.GetRowCellValue(numer, "Tamaño"));
            txtPresentacion.EditValue = Convert.ToString(gridView1.GetRowCellValue(numer, "Presentación"));
            txtExistencias.EditValue = Convert.ToDecimal(gridView1.GetRowCellValue(numer, "Existencia"));
            txtPedido.EditValue = Convert.ToDecimal(gridView1.GetRowCellValue(numer, "Pedido"));
        }
    }
}