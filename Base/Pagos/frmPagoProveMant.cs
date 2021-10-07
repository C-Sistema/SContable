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
using System.Data.SqlTypes;
using Base.Partida;
namespace Base.Pagos
{
    public partial class frmPagoProveMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        
        DataTable dtBanco = new DataTable();
        
        string idVi = "0", mo2;
        public string idviadmantvia, existenciadmantvia;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        public string idpartida;
        bool Detalle_o_Dato = true;//si el Detalle_o_Dato es true es DETALLE, si es false es DATO
        string SimboloMoneda;
        public DataTable deta = new DataTable();
        public DataTable dato = new DataTable();
        string respuesBan = null;
        public frmPagoProveMant(string idpartida = "0",string id = null, string respuestaban = null)
        {
            InitializeComponent();
            respuesBan = respuestaban;
            ComprobarBotones();
            this.idpartida = idpartida;
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
                cargarDatos();
            }
        }
        public void ComprobarBotones()
        {
            
            if (gridView1.RowCount > 0)
            {
                btnEditarSelec.Enabled = true;
                btnEliminarSelec.Enabled = true;

            }
            else {
                btnEditarSelec.Enabled = false;
                btnEliminarSelec.Enabled = false;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
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

                        var detalle = new DataTable();
                        var datoxpagar = new DataTable();


                        datoxpagar.Columns.Add("descripcion_daxpa", typeof(string));
                        datoxpagar.Columns.Add("dato1_daxpa", typeof(string));
                        datoxpagar.Columns.Add("dato2_daxpa", typeof(string));
                        datoxpagar.Columns.Add("dato3_daxpa", typeof(string));

                        detalle.Columns.Add("monto_dexpa", typeof(decimal));
                        detalle.Columns.Add("tcambio_dexpa", typeof(decimal));
                        detalle.Columns.Add("montot_dexpa", typeof(decimal));
                        detalle.Columns.Add("descripcion_dexpa", typeof(string));
                        detalle.Columns.Add("id_dexpa", typeof(int));
                        for (int x = 0; x < dato.Rows.Count; x++)
                        {
                            datoxpagar.Rows.Add(
                                Convert.ToString(dato.Rows[x][2]),
                                Convert.ToString(dato.Rows[x][3]),
                                Convert.ToString(dato.Rows[x][4]),
                                Convert.ToString(dato.Rows[x][5]));
                        }
                        for (int x = 0; x < deta.Rows.Count; x++)
                        {
                            detalle.Rows.Add(
                                Convert.ToDecimal(deta.Rows[x][4]),
                                Convert.ToDecimal(deta.Rows[x][5]),
                                Convert.ToDecimal(deta.Rows[x][7]),
                                Convert.ToString(deta.Rows[x][2]),
                                Convert.ToString(deta.Rows[x][9]));
                        }


                        var accion = new SqlParameter("@accion", SqlDbType.TinyInt);
                        var id = new SqlParameter("@id_paxpr", SqlDbType.Int);
                        var monto = new SqlParameter("@monto_paxpr", SqlDbType.Decimal);
                        var tcambio = new SqlParameter("@tcambio_paxpr", SqlDbType.Decimal);
                        var montoq = new SqlParameter("@montoq_paxpr", SqlDbType.Decimal);
                        var idfor = new SqlParameter("@id_for", SqlDbType.Int);
                        var idban = new SqlParameter("@id_ban", SqlDbType.Int);
                        var idpar = new SqlParameter("@id_par", SqlDbType.Int);
                        var cheque = new SqlParameter("@cheque_paxpr", SqlDbType.VarChar);
                        var fechac = new SqlParameter("@fechac_paxpr", SqlDbType.VarChar);
                        
                        var proveedorc = new SqlParameter("@proveedorc_paxpr", SqlDbType.VarChar);
                        var sumac = new SqlParameter("@sumac_paxpr", SqlDbType.VarChar);
                        var fechat = new SqlParameter("@fechat_paxpr", SqlDbType.DateTime);
                        var codigot = new SqlParameter("@codigot_paxpr", SqlDbType.VarChar);
                        var boletatt = new SqlParameter("@boletat_paxpr", SqlDbType.VarChar);
                        var clientet = new SqlParameter("@clientet_paxpr", SqlDbType.VarChar);
                        var agenciat = new SqlParameter("@agenciat_paxpr", SqlDbType.VarChar);
                        var numerocht = new SqlParameter("@numerocht_paxpr", SqlDbType.VarChar);

                        var idEmpx = new SqlParameter("@idx_emp", SqlDbType.Int);
                        var fechaBit = new SqlParameter("@fecha_bit", SqlDbType.Date);
                        var bandera = new SqlParameter("@ban", SqlDbType.TinyInt);
                        var respuesta = new SqlParameter("@res", SqlDbType.VarChar);
                        
                        var lisltadeta = new SqlParameter("@listadetaxpago", SqlDbType.Structured);
                        lisltadeta.Value = detalle;
                        lisltadeta.TypeName = "dbo.UDTdetaxpago";

                        var lisltadato = new SqlParameter("@listadatoxpago", SqlDbType.Structured);
                        lisltadato.Value = datoxpagar;
                        lisltadato.TypeName = "dbo.UDTdatoxpago";



                        id.Value = Convert.ToInt32(idVi);
                        monto.Value = Convert.ToDecimal(txtMonto.EditValue);
                        tcambio.Value = Convert.ToDecimal(txtTipoCambio.EditValue);
                        montoq.Value = Convert.ToDecimal(txtTotalCambioMonto.EditValue);
                        idfor.Value = Convert.ToInt32(lookFor.EditValue);
                        idban.Value = Convert.ToInt32(lookBan.EditValue);
                        idpar.Value = Convert.ToInt32(idpartida);
                        cheque.Value = Convert.ToString(txtCheque.EditValue);
                        fechac.Value = Convert.ToString(deFecha.Text);

                        proveedorc.Value = Convert.ToString(txtCodigoCliente.EditValue);
                        sumac.Value = Convert.ToString(txtMontoLetras.Text);
                        string fecha = Convert.ToDateTime(deFecha.EditValue).ToString("yyyy/MM/dd");
                        fechat.Value = Convert.ToDateTime(fecha);
                        codigot.Value = Convert.ToString(txtNoTrans.EditValue);
                        boletatt.Value = Convert.ToString(txtBoleta.EditValue);
                        clientet.Value = Convert.ToString(txtCodigoCliente.EditValue);
                        agenciat.Value = Convert.ToString(txtAgencia.EditValue);
                        numerocht.Value = Convert.ToString(txtCH.EditValue);
                    
                        idEmpx.Value = Convert.ToInt32(fc.IdEmpleado);
                        fechaBit.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy"));
                        bandera.Value = 0;
                        respuesta.Value = Convert.ToString(res);
                        if (idVi == null)
                        {
                            using (var datos = new DBSistemaContable())
                            {
                                accion.Value = 1;
                                // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                datos.Database.ExecuteSqlCommand("execute pam_pagoxprov @accion,@id_paxpr,@monto_paxpr,@tcambio_paxpr,@montoq_paxpr,@id_for,@id_ban,@id_par,@cheque_paxpr,@fechac_paxpr,@proveedorc_paxpr,@sumac_paxpr,@fechat_paxpr,@codigot_paxpr,@boletat_paxpr,@clientet_paxpr,@agenciat_paxpr,@numerocht_paxpr,@listadetaxpago,@listadatoxpago,@idx_emp,@fecha_bit,@ban,@res", accion, id, monto, tcambio, montoq, idfor, idban, idpar, cheque, fechac, proveedorc, sumac, fechat, codigot, boletatt, clientet, agenciat, numerocht, lisltadeta, lisltadato, idEmpx, fechaBit, bandera, respuesta);
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
                                //datos.Database.ExecuteSqlCommand("execute pam_pagoxprov @accion,@id_paxpr,@monto_paxpr,@tcambio_paxpr,@montoq_paxpr,@factura_via,@id_for,@id_ban,@id_par,@cheque_paxpr,@fechac_paxpr,@proveedorc_paxpr,@sumac_paxpr,@fechat_paxpr,@codigot_paxpr,@boletat_paxpr,@clientet_paxpr,@agenciat_paxpr,@numerocht_paxpr,@listadetaxpago,@listadatoxpago,@idx_emp,@fecha_bit,@ban,@res", accion, id, monto, tcambio, montoq, idfor, idban, idpar, cheque, fechac, proveedorc, sumac, fechat, codigot, boletatt, clientet, agenciat, numerocht, lisltadeta, lisltadato, idEmpx, fechaBit, bandera, respuesta);
                                // datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
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
                        else if (respuesBan == "1")
                        {
                            fc.openWaitForm(ssm);
                            using (var datos = new DBSistemaContable())
                            {
                                accion.Value = 3;
                                // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                //datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@factura_via,@fechav_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, factura, fechaVen, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                //datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
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

        private void btnVerCuentas_Click(object sender, EventArgs e)
        {
            //ver cuentas por pagar-- DETALLE // se esta mostrando y detalle o dato debe estar TRUE
        
            if (Detalle_o_Dato != true)
            {
                gridView1.Columns.Clear();
                gridControl1.DataSource = deta;
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                Detalle_o_Dato = true;
            }
            
            ComprobarBotones();
        }
        private void btnVerdatos_Click(object sender, EventArgs e)
        {
            //ver datos --- DATOS
            ComprobarBotones();
            if (Detalle_o_Dato != false)
            {
                gridView1.Columns.Clear();
                gridControl1.DataSource = dato;
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                Detalle_o_Dato = false;
            }
            cambiarNo();
            ComprobarBotones();


        }



        private void cambiarNo()
        {
            if (Detalle_o_Dato == true)
            {
                //detalle
                for (int x = 0; x < deta.Rows.Count; x++)
                {
                    deta.Rows[x][1] = x + 1;
                }

                gridControl1.DataSource = deta;
                gridControl1.Refresh();
                //sumaTotalLabel();
            }
            else
            {
                for (int x = 0; x < dato.Rows.Count; x++)
                {
                    dato.Rows[x][1] = x + 1;
                }
                gridControl1.DataSource = dato;
                gridControl1.Refresh();
                //sumaTotalLabel();
            }
          
        }

        private void frmPagoProveMant_Load(object sender, EventArgs e)
        {
            //detalle
            deta.Columns.Add("id_dexpa", typeof(int));//0
            deta.Columns.Add("No", typeof(int));//1
            deta.Columns.Add("Descripción",typeof(string));//2
            deta.Columns.Add("M1", typeof(string));//3
            deta.Columns.Add("Total1", typeof(decimal));//4
            deta.Columns.Add("Tipo cambio", typeof(decimal));//5
            deta.Columns.Add("M2", typeof(string));//6
            deta.Columns.Add("Total2", typeof(decimal));//7
            deta.Columns.Add("id_paxpr", typeof(int));//8
            deta.Columns.Add("id_cuxpa", typeof(int));//9
            //datos 
            dato.Columns.Add("id_daxpa", typeof(int));//0
            dato.Columns.Add("No", typeof(int));//1
            dato.Columns.Add("Descripción", typeof(string));//2
            dato.Columns.Add("Dato1", typeof(string));//3
            dato.Columns.Add("Dato2", typeof(string));//4
            dato.Columns.Add("Dato3", typeof(string));//5
            dato.Columns.Add("id_paxpr", typeof(int));//6

            if (Detalle_o_Dato == true)
            {
                //cargar detalle
                for (int x = 0; x < gridView1.RowCount; x++)
                {
                    deta.Rows.Add(
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_dexpa")),
                    x + 1,
                    Convert.ToString(gridView1.GetRowCellValue(x, "Descripción")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "M1")),
                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Total1")),
                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Tipo cambio")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "M2")),
                    Convert.ToDecimal(gridView1.GetRowCellValue(x, "Total2")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_paxpr")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_cuxpa")));
                }
                gridControl1.DataSource = null;
                gridView1.Columns.Clear();
                gridControl1.DataSource = deta;
                deFecha.EditValue = DateTime.Now.ToString("D");
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                //sumaTotalLabel();
                ComprobarBotones();
            }
            else if (Detalle_o_Dato == false)
            {
                //cargar datos
                for (int x = 0; x < gridView1.RowCount; x++)
                {
                    dato.Rows.Add(
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_daxpa")),
                    x + 1,
                    Convert.ToString(gridView1.GetRowCellValue(x, "Descripción")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Dato1")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Dato2")),
                    Convert.ToString(gridView1.GetRowCellValue(x, "Dato3")),
                    Convert.ToInt32(gridView1.GetRowCellValue(x, "id_paxpr")));
                }
                gridControl1.DataSource = dato;
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                //sumaTotalLabel();
                ComprobarBotones();
            }

        }
    
        private void btnAgregarCuentas_Click(object sender, EventArgs e)
        {
            //ver cuentas por pagar-- DETALLE

            if (Detalle_o_Dato != true)
            {
                gridView1.Columns.Clear();
                gridControl1.DataSource = deta;
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                Detalle_o_Dato = true;
            }
            frmMaestroDetalleDetaPagoProve maestroDetalle = new frmMaestroDetalleDetaPagoProve(deta,idpartida);
            AddOwnedForm(maestroDetalle);
            
            maestroDetalle.ShowDialog();
            //comprobarDtActivo();
            //sumaTotalLabel();
            cambiarNo();
            ComprobarBotones();
        }

        private void btnAgregarDatos_Click(object sender, EventArgs e)
        {
            if (Detalle_o_Dato != false)
            {
                gridView1.Columns.Clear();
                gridControl1.DataSource = dato;
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
                Detalle_o_Dato = false;
            }

            frmMaestroDetalleDatoPagoProv maestroDato = new frmMaestroDetalleDatoPagoProv(dato);
            AddOwnedForm(maestroDato);
            maestroDato.ShowDialog();
            //comprobarDtActivo();
            //sumaTotalLabel();
            cambiarNo();
            ComprobarBotones();
        }

   

  
        private void txtMonto_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotalCambioMonto.EditValue = (Convert.ToDecimal(txtMonto.EditValue) * Convert.ToDecimal(txtTipoCambio.EditValue));
            txtMontoLetras.Text = fc.enletras(Convert.ToString(txtTotalCambioMonto.EditValue));
        }
        private void txtMonto_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotalCambioMonto.EditValue = (Convert.ToDecimal(txtMonto.EditValue) * Convert.ToDecimal(txtTipoCambio.EditValue));
            txtMontoLetras.Text = fc.enletras(Convert.ToString(txtTotalCambioMonto.EditValue));
        }
        private void txtTipoCambio_EditValueChanged_1(object sender, EventArgs e)
        {
            txtTotalCambioMonto.EditValue = (Convert.ToDecimal(txtMonto.EditValue) * Convert.ToDecimal(txtTipoCambio.EditValue));
            txtMontoLetras.Text = fc.enletras(Convert.ToString(txtTotalCambioMonto.EditValue));
        }
        private void txtTipoCambio_EditValueChanging_1(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            txtTotalCambioMonto.EditValue = (Convert.ToDecimal(txtMonto.EditValue) * Convert.ToDecimal(txtTipoCambio.EditValue));
            txtMontoLetras.Text = fc.enletras(Convert.ToString(txtTotalCambioMonto.EditValue));
        }

        private void btnEditarSelec_Click(object sender, EventArgs e)
        {
            if (Detalle_o_Dato == true)
            {
                int numer = Convert.ToInt32(gridView1.FocusedRowHandle);
                string cuenta = Convert.ToString(gridView1.GetRowCellValue(numer, "id_cuxpa"));
                int idNo = Convert.ToInt32(gridView1.GetRowCellValue(numer, "No")) - 1;
                frmMaestroDetalleDetaPagoProve frm = new frmMaestroDetalleDetaPagoProve(deta, idpartida, cuenta, idNo.ToString(), Detalle_o_Dato);
                AddOwnedForm(frm);
                frm.ShowDialog();
                ComprobarBotones();
                cambiarNo();
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();

            }
            else
                if (Detalle_o_Dato == false)
            {
                int numer = Convert.ToInt32(gridView1.FocusedRowHandle);
                //int idNo = Convert.ToInt32(gridView1.GetRowCellValue(numer, "No")) - 1;
                frmMaestroDetalleDatoPagoProv frm = new frmMaestroDetalleDatoPagoProv(dato, idpartida, numer.ToString(), Detalle_o_Dato);
                AddOwnedForm(frm);
                frm.ShowDialog();
                ComprobarBotones();
                cambiarNo();
                fc.ocultarColumnas(gridControl1,gridView1);
                gridControl1.Refresh();
            }

            

        }

        private void btnEliminarSelec_Click(object sender, EventArgs e)
        {
            int real = gridView1.FocusedRowHandle;
            using (DBSistemaContable db = new DBSistemaContable())
            {
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (Detalle_o_Dato == true)
                        {
                            DialogResult result = XtraMessageBox.Show(this, "¿Desea borrar la cuenta por pagar?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            byte[] bytes = Encoding.ASCII.GetBytes("");
                            if (result == DialogResult.Yes)
                            {
                                deta.Rows[real].Delete();
                                cambiarNo();
                                ComprobarBotones();
                                fc.ocultarColumnas(gridControl1,gridView1);
                                gridControl1.Refresh();
                                //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (Detalle_o_Dato == false)
                        {
                            DialogResult result = XtraMessageBox.Show(this, "¿Desea borrar los datos agregados?", fc.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            byte[] bytes = Encoding.ASCII.GetBytes("");
                            if (result == DialogResult.Yes)
                            {
                                dato.Rows[real].Delete();
                                cambiarNo();
                                ComprobarBotones();
                                fc.ocultarColumnas(gridControl1, gridView1);
                                gridControl1.Refresh();
                                //XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEditarPartida_Click(object sender, EventArgs e)
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
                        byte[] bytes = Encoding.ASCII.GetBytes("");

                        frmPartidasMant frm = new frmPartidasMant(idpartida);
                        frm.ShowDialog();

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

        private void lookFor_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void lookBan_EditValueChanged_1(object sender, EventArgs e)
        {
            var datoslook = lookBan.Properties.DataSource as Array;
            int index = lookBan.ItemIndex;
            lblSaldo.Text = lookBan.Properties.GetDataSourceValue("Monto", index).ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var formapago = db.pac_formapago_1(1.ToString(), "", "", "").ToArray();
                    var banco = db.pac_banco_1(1.ToString(), "", "", "").ToArray();
                    
                    lookFor.Properties.DataSource = formapago;
                    lookBan.Properties.DataSource = banco;
                    //Proveedor[0].
                    lookFor.Properties.DisplayMember = "Forma_pago";
                    lookFor.Properties.ValueMember = "id_for";
                    //Moneda[0].
                    // lookMoneda.Properties.DisplayMember = "Iso" ;
                    lookBan.Properties.DisplayMember = "Banco";
                    lookBan.Properties.ValueMember = "id_ban";


                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}