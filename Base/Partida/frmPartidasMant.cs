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
using System.Globalization;

namespace Base.Partida
{
    public partial class frmPartidasMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string idVi = "0", mo2;
        public string idpartida, existenciadmantvia;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;
        string SimboloMoneda;
        DataTable dt = new DataTable();
        string respuesBan = null;
        public frmPartidasMant(string id = "0")
        {
            InitializeComponent();
            ComprobarBotones();
            idpartida = id;
            if (id != "0")
            {
                this.idVi = id;
                cargarDatos(idpartida);
            }
          
        }
        //Carga los datos para viajes registrados 
        private void cargarDatos(string idpartida = "0")
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var partida = db.pac_partida_2(idpartida, "","","").ToArray();
                    txtFolio.EditValue = Convert.ToInt16(partida[0].Folio);
                    txtPartida.EditValue = Convert.ToInt32(partida[0].No);
                    deFecha.EditValue = Convert.ToDateTime(partida[0].Fecha).ToString("dd/MM/yyyy");
                    txtDebe.EditValue = Convert.ToDecimal(partida[0].Debe);
                    txtHaber.EditValue = Convert.ToDecimal(partida[0].Haber);
                    txtDescripcion.Text = Convert.ToString(partida[0].Descripcion);


                    //var detalle = db.pac_detaxpart_1(idpartida, "1", "", "");
                    //gridControl1.DataSource = detalle.ToList();
                    fc.ocultarColumnas(gridControl1, gridView1);
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
        public void ComprobarBotones()
        {
            if (gridView1.RowCount == 0)
            {
                btnEditarSelecionado.Enabled = false;
                btnEliminarDetalle.Enabled = false;
            }
            else
            {
                btnEditarSelecionado.Enabled = true;
                btnEliminarDetalle.Enabled = true;
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

                        fc.openWaitForm(ssm);
                        var dt2 = new DataTable();
                        dt2.Columns.Add("id_dexpa", typeof(int));
                        dt2.Columns.Add("monto_dexpa", typeof(decimal));
                        dt2.Columns.Add("debe_haber_dexpa", typeof(decimal));
                        dt2.Columns.Add("id_nom", typeof(decimal));
                        for (int x = 0; x < gridView1.RowCount; x++)
                        {
                            dt2.Rows.Add(
                                Convert.ToInt32(gridView1.GetRowCellValue(x, "id_dexpa")),
                                Convert.ToInt32(gridView1.GetRowCellValue(x, "id_monto")),
                                Convert.ToDecimal(gridView1.GetRowCellValue(x, "id_debe_haber_dexpa")),
                                Convert.ToDecimal(gridView1.GetRowCellValue(x, "id_nom"))
                                );
                        }
                        var accion = new SqlParameter("@accion", SqlDbType.TinyInt);
                        var id = new SqlParameter("@id_par", SqlDbType.Int);
                        var folio = new SqlParameter("@folio_par", SqlDbType.SmallInt);
                        var nopar = new SqlParameter("@no_par", SqlDbType.Int);
                        var fechapar = new SqlParameter("@fecha_par", SqlDbType.Date);
                        var descripcion = new SqlParameter("@descripcion_par", SqlDbType.VarChar);
                        var totaldebe = new SqlParameter("@totaldebe_par", SqlDbType.Decimal);
                        var totalhaber = new SqlParameter("@totalhaber_par ", SqlDbType.Decimal);
                        var idEmpx = new SqlParameter("@idx_emp", SqlDbType.Int);
                        var fechaBit = new SqlParameter("@fecha_bit", SqlDbType.Date);
                        var bandera = new SqlParameter("@ban", SqlDbType.TinyInt);
                        var respuesta = new SqlParameter("@res", SqlDbType.VarChar);

                        var lislpartida = new SqlParameter("@listadetaxpart", SqlDbType.Structured);
                        lislpartida.Value = dt2;
                        lislpartida.TypeName = "dbo.UDTdexpa";
                        id.Value = Convert.ToInt32(idVi);
                        folio.Value = Convert.ToInt16(txtFolio.EditValue);
                        nopar.Value = Convert.ToInt32(txtPartida.EditValue);
                        fechapar.Value = Convert.ToDateTime(deFecha.EditValue);
                        descripcion.Value = Convert.ToString(txtDescripcion.Text);
                        totaldebe.Value = Convert.ToDecimal(txtDebe.EditValue);
                        totalhaber.Value = Convert.ToDecimal(txtHaber.EditValue);
                        idEmpx.Value = Convert.ToInt32(fc.IdEmpleado);
                        fechaBit.Value = Convert.ToDateTime(DateTime.Now.Date.ToString("dd/MM/yyyy"));
                        bandera.Value = 0;
                        respuesta.Value = Convert.ToString(res);
                        //fc.openWaitForm(ssm);
                        if (idVi == "0")
                        {
                           
                            using (var datos = new DBSistemaContable())
                            {
                                accion.Value = 1;
                                // execute pam_viaje 1,null,fecha_via,no_via,factura_via,fechav_via,totalnf_via,totalfi_via,totalr_via,                                                  tcambio_via,id_mon,id_pro,lisltalote,idx_emp,fecha_bit,@ban output,@res output;
                                //datos.Database.ExecuteSqlCommand("execute pam_viaje @accion,@id,@fecha_via,@no_via,@codigo_via,@factura_via,@fechav_via,@piloto_via,@placas_via,@totalnf_via,@totalfi_via,@totalr_via,@tcambio_via,@id_mon,@id_pro,@lisltalote,@idx_emp,@fecha_bit,@ban,@res", accion, id, fecha, noV, codigo, factura, fechaVen, piloto, placas, totalnF, totalF, totalR, tCambio, idmon, idProv, lisltalote, idEmpx, fechaBit, bandera, respuesta);
                                datos.Database.ExecuteSqlCommand("execute pam_partida @accion,@id_par,@folio_par,@no_par,@fecha_par,@descripcion_par,@totaldebe_par,@totalhaber_par,@listadetaxpart,@idx_emp,@fecha_bit,@ban,@res", accion, id, folio, nopar, fechapar, descripcion, totaldebe, totalhaber, lislpartida, idEmpx, fechaBit, bandera, respuesta);
                                XtraMessageBox.Show(this, "La operación se ha realizado correctamente", fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else if (idVi != "0")
                        {
                            using (var datos = new DBSistemaContable())
                            {
                                accion.Value = 2;
                                datos.Database.ExecuteSqlCommand("execute pam_partida @accion,@id_par,@folio_par,@no_par,@fecha_par,@descripcion_par,@totaldebe_par,@totalhaber_par,@listadetaxpart,@idx_emp,@fecha_bit,@ban,@res", accion, id, folio, nopar, fechapar, descripcion, totaldebe, totalhaber, lislpartida, idEmpx, fechaBit, bandera, respuesta);

                                this.Close();
                            }
                            if (ban.Value.ToString() == "1")
                            {

                                this.Close();
                            }
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

        private void btnEditarSelecionado_Click(object sender, EventArgs e)
        {
            string vId = Convert.ToString(gridView1.FocusedRowHandle);
            frmPartidasMaestroDetalle maestrodetalle = new frmPartidasMaestroDetalle(dt, vId);
            AddOwnedForm(maestrodetalle);
            ComprobarBotones();
            maestrodetalle.ShowDialog();
            cambiarNo();
            gridControl1.Refresh();
        }
        private void cambiarNo()
        {
            DataView dtV = dt.DefaultView;
            dtV.Sort = "id_debe_haber_dexpa DESC";
            dt = dtV.ToTable();
            for (int x = 0; x < dt.Rows.Count; x++)
            {
                dt.Rows[x][1] = x + 1;
            }
            gridControl1.DataSource = dt;
            gridControl1.Refresh();
            //sumaTotalLabel();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmPartidasMaestroDetalle maestrodetalle = new frmPartidasMaestroDetalle(dt);
            AddOwnedForm(maestrodetalle);
            maestrodetalle.ShowDialog();
            cambiarNo();
        }

        private void frmPartidasMant_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("id_dexpa ", typeof(int));//0
            dt.Columns.Add("No", typeof(int));//1
            dt.Columns.Add("Descripción", typeof(string));//2
            dt.Columns.Add("Mon", typeof(string));//3
            dt.Columns.Add("Debe", typeof(decimal));//4
            dt.Columns.Add("Haber", typeof(decimal));//5
            dt.Columns.Add("id_monto", typeof(decimal));//6
            dt.Columns.Add("id_debe_haber_dexpa", typeof(byte));//7
            dt.Columns.Add("id_par", typeof(int));//8
            dt.Columns.Add("id_nom", typeof(int));//9

            for (int x = 0; x < gridView1.RowCount; x++)
            {
                dt.Rows.Add(
                Convert.ToInt32(gridView1.GetRowCellValue(x, "id_dexpa")),
                x + 1,
                Convert.ToString(gridView1.GetRowCellValue(x, "Descripción")),
                Convert.ToString(gridView1.GetRowCellValue(x, "Mon")),
                Convert.ToString(gridView1.GetRowCellValue(x, "Debe")),
                Convert.ToInt32(gridView1.GetRowCellValue(x, "Haber")),
                Convert.ToInt32(gridView1.GetRowCellValue(x, "id_monto")),
                Convert.ToByte(gridView1.GetRowCellValue(x, "id_debe_haber_dexpa")),
                Convert.ToInt32(gridView1.GetRowCellValue(x, "id_par")),
                Convert.ToString(gridView1.GetRowCellValue(x, "id_nom"))
                );
            }
            gridControl1.DataSource = dt;
            fc.ocultarColumnas(gridControl1, gridView1);
            gridControl1.Refresh();
            ComprobarBotones();
        }
    }
}