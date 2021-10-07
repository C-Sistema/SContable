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


namespace Base.Viaje
{
    public partial class frmViajeAjuste : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        bool bit = false;
        string idvia;
        public frmViajeAjuste(string idvia)
        {
            InitializeComponent();
            this.idvia = idvia;
            CargarDatos(idvia);
        }

        private void CargarDatos(string id)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var lote = db.pac_lote_1(id, "1", "", "").ToArray();
                    
                    lookDescripcion.Properties.DataSource = lote;
                    lookDescripcion.Properties.DisplayMember = "Producto";
                    lookDescripcion.Properties.ValueMember = "id_lot";
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            using (DBSistemaContable db = new DBSistemaContable())
            {
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        ObjectParameter ban = new ObjectParameter("ban", 0);
                        ObjectParameter res = new ObjectParameter("res", "");
                        using (var datos = new DBSistemaContable())
                        {
                            if (listItem.SelectedItem.ToString() == "Incrementar")
                            {
                                bit = true;
                            }
                            fc.openWaitForm(ssm);
                            datos.pam_ajusxlote(Convert.ToByte(1),null,DateTime.Now,Convert.ToInt32(txtCantidad.EditValue),bit,txtDes.Text,Convert.ToInt32(lookDescripcion.EditValue),Convert.ToInt32(idvia),ban,res);
                            fc.closeWaitForm(ssm);
                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        if (ban.Value.ToString() == "1")
                        {
                            this.Close();
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
}