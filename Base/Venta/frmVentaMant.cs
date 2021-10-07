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
using System.Data.SqlClient;
using Base.Venta;

namespace Base.Venta
{
    public partial class frmVentaMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string idVi = "0", mo2;
        public string idviadmantvia, existenciadmantvia;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        string SimboloMoneda;
        DataTable dt = new DataTable();
        string respuesBan = null;
        int idlotemant = 0;
        public frmVentaMant(string id = "0", string respuestaban = null)
        {
            InitializeComponent();
            if (id == "0")
            {
                this.idVi = id;
                bandera = false;

                lookEmpleado.EditValue = fc.IdEmpleado;
                ComprobarBotones();
                deFechaCredito.Enabled = false;
                CargarDatos();
            }
        }

        private void CargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var moneda = db.pac_moneda_1("1","","","").ToArray();
                    var empleado = db.pac_empleado_1("1", "", "", "").ToArray();
                    var cliente = db.pac_cliente_1("1", "", "", "").ToArray();

                    lookMoneda.Properties.DataSource = moneda;
                    lookMoneda.Properties.DisplayMember = "Iso";
                    lookMoneda.Properties.ValueMember = "id_mon";

                    lookEmpleado.Properties.DataSource = empleado;
                    lookEmpleado.Properties.DisplayMember = "Nombre";
                    lookEmpleado.Properties.ValueMember = "id_emp";
                    
                    lookCliente.Properties.DataSource = cliente;
                    lookCliente.Properties.DisplayMember = "Nombre";
                    lookCliente.Properties.ValueMember = "id_cli";
                    
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
            string mon = lookMoneda.Text;
            frmVentaMaestroDetalle frm = new frmVentaMaestroDetalle(dt);
            AddOwnedForm(frm);
            frm.ShowDialog();
            cambiarNo();
            total();
            ComprobarBotones();
            fc.ocultarColumnas(gridControl1,gridView1);
            gridControl1.Refresh();
            
        }
   
        private void total()
        {
            decimal tot = 0;
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                 tot +=  Convert.ToDecimal(dt.Rows[x][12]); 
            }
            txtTotal.EditValue = tot;
        }

            private void cambiarNo()
        {
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                dt.Rows[x][1] = x + 1;
            }
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string mon = lookMoneda.Text;
            int numer = Convert.ToInt32(gridView1.FocusedRowHandle);
            idlotemant = Convert.ToInt32(gridView1.GetRowCellValue(numer, "id_lot"));
            int idNo = Convert.ToInt32(gridView1.GetRowCellValue(numer, "No"))-1;
            frmVentaMaestroDetalle frm = new frmVentaMaestroDetalle(dt, idlotemant,idNo,mon);
            AddOwnedForm(frm);
            frm.ShowDialog();
            ComprobarBotones();
            cambiarNo();
            total();
            fc.ocultarColumnas(gridControl1,gridView1);
            gridControl1.Refresh();

        }

        private void frmVentaMant_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("id_lot", typeof(int));//0
            dt.Columns.Add("No", typeof(int));//1
            dt.Columns.Add("id_via", typeof(int));//2
            dt.Columns.Add("id_pro", typeof(int));//3
            dt.Columns.Add("Producto", typeof(string));//4
            dt.Columns.Add("id_tam", typeof(int));//5
            dt.Columns.Add("Tamaño", typeof(string));//6
            dt.Columns.Add("id_pre", typeof(int));//7
            dt.Columns.Add("Presentacion", typeof(string));//8
            dt.Columns.Add("Existencias", typeof(double));//9
            dt.Columns.Add("Pedido", typeof(double));//10
            dt.Columns.Add("Unitario", typeof(double));//11
            dt.Columns.Add("Total", typeof(double));//12
            deFechaCredito.EditValue = DateTime.Now.Date.ToString("dd/MM/yyyy");

            for (int x = 0; x < gridView1.RowCount; x++)
            {
                dt.Rows.Add(
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_lot")),
                    x + 1,
                    Convert.ToString(gridView1.GetRowCellValue(x, "id_via")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pro")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Producto")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_tam")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Tamaño")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pre")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Presentacion")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Existencias")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Pedido")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Unitario")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Total"))
                    );
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
           

        }
        public void ComprobarBotones()
        {
            if (gridView1.RowCount == 0)
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int real = gridView1.FocusedRowHandle;
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
                            dt.Rows[real].Delete();
                            cambiarNo();
                            ComprobarBotones();
                            total();
                            fc.ocultarColumnas(gridControl1,gridView1);
                            gridControl1.Refresh();
                            //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CheckCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckCredito.Checked == true)
            {
                deFechaCredito.Enabled = true;
            }
            else if (CheckCredito.Checked == false)
            {
                deFechaCredito.Enabled = false;
            }
        }

        private void lookMoneda_EditValueChanged(object sender, EventArgs e)
        {
            if (lookMoneda.EditValue != null)
            {
                frmVentaMaestroDetalle maestroventa = new frmVentaMaestroDetalle();
                if (lookMoneda.Text == "GTQ")
                {   lblMoneda.Text = "Q";
                    lblTotal.Text = "Q";
                }
                else if (lookMoneda.Text == "USD")
                {
                    lblMoneda.Text = "$";
                    lblTotal.Text = "$";
                }
                else if (lookMoneda.Text == "CRC")
                {
                    lblMoneda.Text = "₡";
                    lblTotal.Text  = "₡";
                }
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {

                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            
                            var dt2 = new DataTable();
                            dt2.Columns.Add("cantidad_dexve", typeof(int));
                            dt2.Columns.Add("preciou_dexve", typeof(decimal));
                            dt2.Columns.Add("preciot_dexve", typeof(decimal));
                            dt2.Columns.Add("id_lot", typeof(int));
                            for (int x = 0; x < gridView1.RowCount; x++)
                            {
                                dt2.Rows.Add(
                                    Convert.ToInt32(gridView1.GetRowCellValue(x, "Pedido")),
                                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Unitario")),
                                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Total")),
                                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_lot")));
                            }
                            var accion = new SqlParameter("@accion", SqlDbType.TinyInt);
                            var id = new SqlParameter("@id_ven", SqlDbType.Int);
                            var factura = new SqlParameter("@facura_ven", SqlDbType.VarChar);
                            var total = new SqlParameter("@total_ven", SqlDbType.Decimal);
                            var credito = new SqlParameter("@credito_ven", SqlDbType.Bit);
                            var fechaVen = new SqlParameter("@fechaxvenc_cuxco", SqlDbType.Date);
                            var id_clie = new SqlParameter("@id_cli", SqlDbType.Int);
                            var id_emp = new SqlParameter("@id_emp", SqlDbType.Int);
                            var id_mon = new SqlParameter("@id_mon", SqlDbType.Int);
                            var lisltalote = new SqlParameter("@lisltadetalle", SqlDbType.Structured);
                            var idEmpx = new SqlParameter("@idx_emp", SqlDbType.Int);
                            var fechaBit = new SqlParameter("@fecha_bit", SqlDbType.Date);
                            var bandera = new SqlParameter("@ban", SqlDbType.TinyInt);
                            var respuesta = new SqlParameter("@res", SqlDbType.VarChar);
                            lisltalote.Value = dt2;
                            lisltalote.TypeName = "dbo.UDTdexve";

                            id.Value = Convert.ToInt32(idVi);
                            factura.Value = Convert.ToString(txtFactura.EditValue);
                            total.Value = Convert.ToDecimal(txtTotal.EditValue);
                            credito.Value = Convert.ToByte(CheckCredito.Checked);
                            fechaVen.Value = Convert.ToDateTime(deFechaCredito.EditValue);
                            id_clie.Value = Convert.ToInt32(lookCliente.EditValue);
                            id_emp.Value = Convert.ToInt32(lookEmpleado.EditValue);
                            id_mon.Value = Convert.ToInt32(lookMoneda.EditValue);
                            idEmpx.Value = Convert.ToInt32(fc.IdEmpleado);
                            fechaBit.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy"));

                            bandera.Value = 0;
                            respuesta.Value = Convert.ToString(res);

                            if (idVi == "0")
                            {
                                using (var datos = new DBSistemaContable())
                                {
                                    accion.Value = 1;
                                    // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                    datos.Database.ExecuteSqlCommand("execute pam_venta @accion,@id_ven,@facura_ven,@total_ven,@credito_ven,@fechaxvenc_cuxco,@id_cli,@id_emp,@id_mon,@lisltadetalle,@idx_emp,@fecha_bit,@ban,@res",
                                                            accion, id, factura, total, credito, fechaVen, id_clie, id_emp, id_mon, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
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
                fc.closeWaitForm(ssm);
            }

        }
    }
}