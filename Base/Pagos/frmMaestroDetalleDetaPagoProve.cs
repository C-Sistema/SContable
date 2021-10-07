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

namespace Base.Pagos
{
    public partial class frmMaestroDetalleDetaPagoProve : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string idpa = null;
        string idno = null;
        string cuxpa = null;
        bool detalle_partida;
        DataTable dt = new DataTable();
        
        public frmMaestroDetalleDetaPagoProve(DataTable dt = null, string idpa = null, string cuxpa= null,string idno= null,bool detalle_partida = false)
        {
            InitializeComponent();
            this.idpa = idpa;
            this.idno = idno;
            this.cuxpa = cuxpa;
            this.detalle_partida = detalle_partida;
            this.dt = dt;
            cargarLook();
        }
        private void cargarLook()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var cuenta = db.pac_cuenxpaga_4(0.ToString(),1.ToString(), "", "").ToArray();
                    lookCuexpa.Properties.DataSource = cuenta.ToArray();
                    
                    lookCuexpa.Properties.DisplayMember = "Factura";
                    lookCuexpa.Properties.ValueMember = "id_cuxpa";
                    if (idno != null && detalle_partida == true)
                    {
                        int num = Convert.ToInt32(idno);
                        lookCuexpa.EditValue = Convert.ToInt32(cuxpa);
                        int index = lookCuexpa.ItemIndex;
                        txtTipoCambio.EditValue = Convert.ToDecimal(dt.Rows[num][5]);
                        txtMonto.EditValue = Convert.ToDecimal(dt.Rows[num][4]);
                        txtDescripcion.Text = Convert.ToString(dt.Rows[num][2]);
                        txtTotal.EditValue = Convert.ToDecimal(dt.Rows[num][7]);
                        for (int y = 0; y < cuenta.Count(); y++)
                        {
                            if (Convert.ToInt32(cuenta[y].id_cuxpa) == Convert.ToInt32(cuxpa))
                            {
                                txtMontoTotal.EditValue = Convert.ToDecimal(cuenta[y].Saldo);
                            }
                        }
                    }
                 

                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmPagoProveMant viajeMant = Owner as frmPagoProveMant;
            if (vpValidar.Validate())
            {

                if (Convert.ToDouble(txtTotal.EditValue) <= Convert.ToDouble(txtMontoTotal.EditValue))
                {
                    bool exis = false;
                    string pos = null;
                    for (int x = 0; x < viajeMant.deta.Rows.Count; x++)
                    {
                        if (Convert.ToDouble(lookCuexpa.EditValue) == Convert.ToDouble(viajeMant.deta.Rows[x][9]))
                        {
                            exis = true;
                            pos = Convert.ToString(x);
                        }
                    }
                    if (exis == false)
                    {
                        int x = viajeMant.deta.Rows.Count + 1;
                        viajeMant.deta.Rows.Add(
                            Convert.ToInt32(0),
                            Convert.ToInt32(x),
                            Convert.ToString(txtDescripcion.Text),
                            Convert.ToString("Q"),
                            Convert.ToDecimal(txtMonto.EditValue),
                            Convert.ToDecimal(txtTipoCambio.EditValue),
                            Convert.ToString("Q"),
                            Convert.ToDecimal(txtTotal.EditValue),
                            Convert.ToInt32(idpa),
                            Convert.ToInt32(lookCuexpa.EditValue));

                        this.Close();
                    }
                    else
                    if (exis == true)
                    {
                        //mandar mensaje si desea reemplaza el existente o agregar otra cuenta
                        DialogResult result = XtraMessageBox.Show(this, "¿La cuenta por pagar ya existe desea reemplazar los datos existentes?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            //viajeMant.deta.Rows[Convert.ToInt32(pos)][0]
                            //viajeMant.deta.Rows[Convert.ToInt32(pos)][1]
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][2] = Convert.ToString(txtDescripcion.Text);
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][3] = Convert.ToString("Q");
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][4] = Convert.ToDecimal(txtMonto.EditValue);
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][5] = Convert.ToDecimal(txtTipoCambio.EditValue);
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][6] = Convert.ToString("Q");
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][7] = Convert.ToDecimal(txtTotal.EditValue);
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][8] = Convert.ToInt32(idpa);
                            viajeMant.deta.Rows[Convert.ToInt32(pos)][9] = Convert.ToInt32(lookCuexpa.EditValue);

                            int to = Convert.ToInt32(idno) + 1;
                            XtraMessageBox.Show(this, "Se modifico exitosamente el registro No. " + to.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            idno = null;
                            this.Close();
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show(this, "El total no puede ser mayo que el saldo", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            


                
                viajeMant.gridControl1.DataSource = dt;
                viajeMant.ComprobarBotones();
                viajeMant.gridControl1.Refresh();
                //lookProducto;

            


        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaestroDetalleDetaPagoProve_Load(object sender, EventArgs e)
        {

        }

        private void lookCuexpa_EditValueChanged(object sender, EventArgs e)
        {
            
            var datoslook = lookCuexpa.Properties.DataSource as Array;
            int index = lookCuexpa.ItemIndex;

            txtMonto.EditValue = Convert.ToDecimal(lookCuexpa.Properties.GetDataSourceValue("Saldo", index));
            //txtTipoCambio.EditValue = Convert.ToDecimal(lookCuexpa.Properties.GetDataSourceValue("Saldo", index));
            txtMontoTotal.EditValue = Convert.ToDecimal(lookCuexpa.Properties.GetDataSourceValue("Saldo", index));
            //txtDescripcion.Text = lookCuexpa.Properties.GetDataSourceValue("Descripción", index).ToString();
            txtDescripcion.Text = Convert.ToString(lookCuexpa.Properties.GetDataSourceValue("Descripción", index));
            //string te = lookCuexpa.Properties.GetDataSourceValue("Viaje",index).ToString();



        }

        public void llenardatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var cuenta = db.pac_cuenxpaga_4(0.ToString(), 1.ToString(), "", "").ToArray();
        
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMonto_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.EditValue = Convert.ToDouble(txtMonto.EditValue) * Convert.ToDouble(txtTipoCambio.EditValue);
        }

        private void txtMonto_PropertiesChanged(object sender, EventArgs e)
        {
            txtTotal.EditValue = Convert.ToDouble(txtMonto.EditValue) * Convert.ToDouble(txtTipoCambio.EditValue);
        }

        private void txtTipoCambio_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.EditValue = Convert.ToDouble(txtMonto.EditValue) * Convert.ToDouble(txtTipoCambio.EditValue);
        }

        private void txtTipoCambio_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotal.EditValue = Convert.ToDouble(txtMonto.EditValue) * Convert.ToDouble(txtTipoCambio.EditValue);
        }

        private void frmMaestroDetalleDetaPagoProve_Load_1(object sender, EventArgs e)
        {

        }
    }
}