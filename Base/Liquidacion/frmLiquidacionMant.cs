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

namespace Base.Liquidacion
{
    public partial class frmLiquidacionMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        public frmLiquidacionMant(string id = null)
        {          
            InitializeComponent();
            this.id = id;
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    using (var dbTransaccion = db.Database.BeginTransaction())
                    {
                        try
                        {
                            string fecha = DateTime.Now.ToString("dd/MM/yyyy");
                            ObjectParameter ban = new ObjectParameter("ban", 0);
                            ObjectParameter res = new ObjectParameter("res", "");
                            if (id != null)
                            {
                                fc.openWaitForm(ssm);
                                db.pam_liquidacion(Convert.ToByte(2), Convert.ToInt32(id), Convert.ToDateTime(deFecha.EditValue), txtDescripcion.Text, fc.IdEmpleado, Convert.ToDateTime(fecha), ban, res);
                                fc.closeWaitForm(ssm);
                                XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLiquidacionMant_Load(object sender, EventArgs e)
        {

        }
    }
}