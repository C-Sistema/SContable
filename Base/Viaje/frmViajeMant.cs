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
using Base.BD;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Globalization;

namespace Base.Viaje
{
    public partial class frmViajeMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string idVi = "0",mo2;
        public string idviadmantvia,existenciadmantvia;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        string SimboloMoneda;
        DataTable dt = new DataTable();
        string respuesBan = null;
        public frmViajeMant(string id = "0",string respuestaban = null)
        {
            InitializeComponent();
            respuesBan = respuestaban;
            ComprobarBotones();
            idviadmantvia = id;
            bandera = true;
            if (id != "0")
            {
                this.idVi = id;
                cargarDatos();
                bandera = false;
            }
            else
            {
                cargarLook();
            }
        }
        
        public void ComprobarBotones()
        {
            if (gridView1.RowCount == 0)
            {
                txtEditarDetalle.Enabled = false;
                txtEliminarDetalle.Enabled = false;
            }
            else
            {
                txtEditarDetalle.Enabled = true;
                txtEliminarDetalle.Enabled = true;
            }
        }
        //carga los datos para ususrios nuevos
        private void cargarLook()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var Proveedor = db.pac_proveedor_1(1.ToString(), "", "", "").ToArray();
                    var Moneda = db.pac_moneda_1(1.ToString(), "", "", "").ToArray();

                    lookProveedor.Properties.DataSource = Proveedor;
                    lookMoneda.Properties.DataSource = Moneda;
                    //Proveedor[0].
                    lookProveedor.Properties.DisplayMember = "Proveedor";
                    lookProveedor.Properties.ValueMember = "id_pro";
                    //Moneda[0].
                   // lookMoneda.Properties.DisplayMember = "Iso" ;
                    lookMoneda.Properties.DisplayMember = "Iso";
                    lookMoneda.Properties.ValueMember = "id_mon";
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Carga los datos para viajes registrados 
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var viaje = db.pac_viaje_2(idVi,"","","").ToArray();
                    var Proveedor = db.pac_proveedor_1(1.ToString(), "", "", "").ToArray();
                    var Moneda = db.pac_moneda_1(1.ToString(), "", "", "").ToArray();

                    lookProveedor.Properties.DataSource = Proveedor;
                    lookMoneda.Properties.DataSource = Moneda;
                    lookProveedor.Properties.DisplayMember = "Proveedor";
                    lookProveedor.Properties.ValueMember = "id_pro";
                    lookProveedor.EditValue = viaje[0].id_pro;
                    lookMoneda.Properties.DisplayMember = "Iso";
                    lookMoneda.Properties.ValueMember = "id_mon";
                    lookMoneda.EditValue = viaje[0].id_mon;
                    SimboloMoneda = Moneda[Convert.ToInt32(viaje[0].id_mon)-1].Simbolo;
                    lblMonedaF.Text = SimboloMoneda;
                    lblMonedaNF.Text = SimboloMoneda;
                    lblMonedaResultado.Text = SimboloMoneda;
                    lblSimbolo.Text = SimboloMoneda;
                    lblSimbolo.Text = lookMoneda.Text;
                    txtFactura.Text = viaje[0].Factura.ToString();
                    deVencimiento.EditValue = Convert.ToDateTime(viaje[0].Vence).ToString("dd/MM/yyyy");
                    deCompra.EditValue = Convert.ToDateTime(viaje[0].Fecha).ToString("dd/MM/yyyy");
                    txtTipoCambio.EditValue = viaje[0].Cambio;
                    txtCodViaje.EditValue = viaje[0].Codigo;
                   
                    quitarsimb(viaje[0].Total_nf.ToString());
                    txtTotalnf.EditValue = Convert.ToDouble(mo2);
                    quitarsimb(viaje[0].Total_fi.ToString());
                    txtTotalfi.EditValue = Convert.ToDouble(mo2);
                    quitarsimb(viaje[0].Total.ToString());
                    txtTotalR.EditValue = Convert.ToDouble(mo2);
                    txtPiloto.EditValue = viaje[0].Piloto.ToString();
                    txtPlacas.EditValue = viaje[0].Placas.ToString();
                    txtIdViaje.EditValue = viaje[0].No.ToString();
                    
                    string viajeidlot = viaje[0].id_via.ToString();

                    var lotes321 = db.pac_lote_6(viajeidlot,"1","","");
                    gridControl1.DataSource = lotes321.ToList();
                    fc.ocultarColumnas(gridControl1,gridView1);
                    gridControl1.Refresh();
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void quitarsimb(string mo)
        {
            mo = mo.Replace("$", string.Empty);
            mo = mo.Replace("¢", string.Empty);
            mo = mo.Replace("Q", string.Empty);
            mo2 = mo;
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
        }
        private void frmViajeMant_Load(object sender, EventArgs e)
        {
                dt.Columns.Add("id_lot", typeof(int));
                dt.Columns.Add("No", typeof(int));
                dt.Columns.Add("id_pro", typeof(int));
                dt.Columns.Add("Producto", typeof(string));
                dt.Columns.Add("id_tam", typeof(int));
                dt.Columns.Add("Tamaño", typeof(string));
                dt.Columns.Add("id_pre", typeof(int));
                dt.Columns.Add("Presentacion", typeof(string));
                dt.Columns.Add("Cantidad", typeof(double));
                dt.Columns.Add("Unitario", typeof(double));
                dt.Columns.Add("Total", typeof(double));
                dt.Columns.Add("Existencia", typeof(double));
                dt.Columns.Add("id_via", typeof(double));
            for (int x = 0; x < gridView1.RowCount; x++)
                {
                    dt.Rows.Add(
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_lot")),
                    x + 1, Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pro")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Producto")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_tam")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Tamaño")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pre")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Presentacion")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Cantidad")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Unitario")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Total")),
                    Convert.ToDouble(gridView1.GetRowCellValue(x, "Existencia")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_via")));
                }
            gridControl1.DataSource = dt;
            deCompra.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            deVencimiento.EditValue = DateTime.Now.ToString("dd/MM/yyyy");
            fc.ocultarColumnas(gridControl1,gridView1);
            gridControl1.Refresh();
            sumaTotalLabel();
            ComprobarBotones();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
        }
        private void gridControl1_Click(object sender, EventArgs e)
        {
        }
        //cambia el numnero 
        private void cambiarNo()
        {
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                dt.Rows[x][1] = x + 1;
            }
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
            sumaTotalLabel();
        }
        private void sumaTotalLabel()
        {
            double totallbl = 0;
            for (int x = 0; x < gridView1.DataRowCount; x++)
            {
                totallbl = Convert.ToDouble(gridView1.GetRowCellValue(x, "Total")) + totallbl;
            }
            lblTotal.Text = Convert.ToString(totallbl);
        }
        private void simpleButton1_Click_3(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(lblTotal.Text) != Convert.ToDecimal(txtTotalR.EditValue))
            {
                XtraMessageBox.Show(this, "La suma total del listado es de: " + lblTotal.Text + "\n la sumatoria del total no fiscal y fiscal es:" + txtTotalR.EditValue + "\n Ambos totales deben de coincidir para poder realizar la operación ", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");

                            //fc.openWaitForm(ssm);

                            var dt2 = new DataTable();
                            dt2.Columns.Add("id_lot", typeof(int));
                            dt2.Columns.Add("cantidad_lot", typeof(int));
                            dt2.Columns.Add("preciou_lot", typeof(decimal));
                            dt2.Columns.Add("preciot_lot", typeof(decimal));
                            dt2.Columns.Add("id_pre", typeof(int));
                            dt2.Columns.Add("id_tam", typeof(int));
                            dt2.Columns.Add("id_pro", typeof(int));
                            for (int x = 0; x < gridView1.RowCount; x++)
                            {
                                dt2.Rows.Add(Convert.ToInt32(gridView1.GetRowCellValue(x, "id_lot")), Convert.ToInt32(gridView1.GetRowCellValue(x, "Cantidad")), Convert.ToDecimal(gridView1.GetRowCellValue(x, "Unitario")),
                                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Total")), Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pre")), Convert.ToInt32(gridView1.GetRowCellValue(x, "id_tam")), Convert.ToInt32(gridView1.GetRowCellValue(x, "id_pro")));
                                decimal cantidadUni = Convert.ToDecimal(gridView1.GetRowCellValue(x, "Unitario"));
                            }
                            var accion = new SqlParameter("@accion", SqlDbType.TinyInt);
                            var id = new SqlParameter("@id", SqlDbType.Int);
                            var fecha = new SqlParameter("@fecha_via", SqlDbType.Date);
                            var noV = new SqlParameter("@no_via", SqlDbType.Int);
                            var codigo = new SqlParameter("@codigo_via", SqlDbType.VarChar);
                            var factura = new SqlParameter("@factura_via", SqlDbType.VarChar);
                            var fechaVen = new SqlParameter("@fechav_via", SqlDbType.Date);
                            var piloto = new SqlParameter("@piloto_via", SqlDbType.VarChar);
                            var placas = new SqlParameter("@placas_via", SqlDbType.VarChar);
                            var totalnF = new SqlParameter("@totalnf_via", SqlDbType.Decimal);
                            var totalF = new SqlParameter("@totalfi_via", SqlDbType.Decimal);
                            var totalR = new SqlParameter("@totalr_via", SqlDbType.Decimal);
                            var tCambio = new SqlParameter("@tcambio_via", SqlDbType.Decimal);
                            var idmon = new SqlParameter("@id_mon", SqlDbType.Int);
                            var idProv = new SqlParameter("@id_pro", SqlDbType.Int);
                            var idEmpx = new SqlParameter("@idx_emp", SqlDbType.Int);
                            var fechaBit = new SqlParameter("@fecha_bit", SqlDbType.Date);
                            var bandera = new SqlParameter("@ban", SqlDbType.TinyInt);
                            var respuesta = new SqlParameter("@res", SqlDbType.VarChar);
                            var lisltalote = new SqlParameter("@lisltalote", SqlDbType.Structured);
                            lisltalote.Value = dt2;
                            lisltalote.TypeName = "dbo.UDTlote";
                            id.Value = Convert.ToInt32(idVi);
                            fecha.Value = Convert.ToDateTime(deCompra.EditValue);
                            noV.Value = Convert.ToInt16(txtIdViaje.EditValue);
                            codigo.Value = Convert.ToString(txtCodViaje.EditValue);
                            factura.Value = Convert.ToString(txtFactura.EditValue);
                            fechaVen.Value = Convert.ToDateTime(deVencimiento.EditValue);
                            piloto.Value = Convert.ToString(txtPiloto.EditValue);
                            placas.Value = Convert.ToString(txtPlacas.EditValue);
                            totalnF.Value = Convert.ToDecimal(txtTotalnf.EditValue);
                            totalF.Value = Convert.ToDecimal(txtTotalfi.EditValue);
                            totalR.Value = Convert.ToDecimal(txtTotalR.EditValue);
                            tCambio.Value = Convert.ToDecimal(txtTipoCambio.EditValue);
                            idmon.Value = Convert.ToInt32(lookMoneda.EditValue);
                            idProv.Value = Convert.ToInt32(lookProveedor.EditValue);
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
                                    datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                            else if (respuesBan == "0")
                            {
                                fc.openWaitForm(ssm);
                                using (var datos = new DBSistemaContable())
                                {
                                    accion.Value = 2;
                                    // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                    //datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@factura_via,@fechav_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, factura, fechaVen, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    string respues123 = Convert.ToString(respuesta.Value);

                                    //XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                fc.closeWaitForm(ssm);
                                if (ban.Value.ToString() == "1")
                                {

                                    this.Close();
                                }
                            }
                            else if(respuesBan == "1")
                            {
                                fc.openWaitForm(ssm);
                                using (var datos = new DBSistemaContable())
                                {
                                    accion.Value = 3;
                                    // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                    //datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@factura_via,@fechav_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, factura, fechaVen, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                    XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                fc.closeWaitForm(ssm);
                                if (ban.Value.ToString() == "1")
                                {

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
            }
        }
        private void simpleButton2_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lookMoneda_EditValueChanged_1(object sender, EventArgs e)
        {
            //lblSimbolo.Text = lookMoneda.Text;
            if (lookMoneda.EditValue != null)
            {
                
                if (lookMoneda.Text == "GTQ")
                {//Cambia la region de la moneda pero afecta todo el proyecto el cambio es visto a la hora de volver a cargar el form, no nos sirve
                    //lblMonedaCambio.Text = "Q";
                    lblMonedaF.Text = "Q";
                    lblMonedaNF.Text = "Q";
                    lblMonedaResultado.Text = "Q";
                    lblSimbolo.Text =  "Q";
                    lblMonedaSimbolo.Text = "Q";
                    txtTipoCambio.EditValue = 1;
                    //CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = "Q";
                }
                else if (lookMoneda.Text == "USD")
                {
                    //lblMonedaCambio.Text = "$";
                    lblMonedaF.Text = "$";
                    lblMonedaNF.Text = "$";
                    lblMonedaResultado.Text = "$";
                    lblSimbolo.Text = "$";
                    lblMonedaSimbolo.Text = "$";
                    txtTipoCambio.EditValue = 7.85;
                    //CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = "$";
                    //txtEditPrueba.Refresh();
                }
                else if (lookMoneda.Text == "CRC")
                {
                    //lblMonedaCambio.Text = "₡";
                    lblMonedaF.Text = "₡";
                    lblMonedaNF.Text = "₡";
                    lblMonedaResultado.Text = "₡";
                    lblSimbolo.Text = "₡";
                    lblMonedaSimbolo.Text = "₡";
                    txtTipoCambio.EditValue = 80.50;
                    //CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = "₡";
                    //txtEditPrueba.Refresh();
                }
            }
        }
        private void txtTotalnf_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
  
        }
        private void txtTotalfi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
  
        }

        private void txtEditPrueba_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {

           // txtEditPrueba.Text = SimboloMoneda + Convert.ToString(txtEditPrueba.EditValue);
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
         
        }

        private void txtEditarDetalle_Click(object sender, EventArgs e)
        {
        
        }

        private void txtEliminarDetalle_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton3_Click_3(object sender, EventArgs e)
        {
            frmViajeMaestroDetalle maestrodetalle = new frmViajeMaestroDetalle(dt);
            AddOwnedForm(maestrodetalle);
            maestrodetalle.lblNoFactura.Text = txtFactura.Text;
            ComprobarBotones();
            maestrodetalle.ShowDialog();
            sumaTotalLabel();
            cambiarNo();
        }

        private void txtEditarDetalle_Click_2(object sender, EventArgs e)
        {
            string vId = Convert.ToString(gridView1.FocusedRowHandle);
            frmViajeMaestroDetalle maestrodetalle = new frmViajeMaestroDetalle(dt, vId);
            AddOwnedForm(maestrodetalle);
            maestrodetalle.lblNoFactura.Text = txtFactura.Text;
            ComprobarBotones();
            maestrodetalle.ShowDialog();
            sumaTotalLabel();
            cambiarNo();
            gridControl1.Refresh();
        }

        private void txtEliminarDetalle_Click_2(object sender, EventArgs e)
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
                            ComprobarBotones();
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
            cambiarNo();

            gridControl1.Refresh();
        }

        private void txtTotalnf_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
        }

        private void txtTotalnf_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            if (idVi == "0")
            {
                txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            }
            if (lookMoneda.EditValue != null)
            {
                lblSimbolo.Text = lookMoneda.Text;
            }
        }

        private void txtTotalfi_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
        }

        private void txtTotalfi_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            if (idVi == "0")
            {
                txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            }
            if (lookMoneda.EditValue != null)
            {
                lblSimbolo.Text = lookMoneda.Text;
            }
        }



        private void txtTotalR_Enter(object sender, EventArgs e)
        {
            txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            if (idVi == "0")
            {
                txtTotalR.EditValue = Convert.ToDouble(txtTotalfi.EditValue) + Convert.ToDouble(txtTotalnf.EditValue);
            }
        }
        private void txtTotalR_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
        }
    }
}