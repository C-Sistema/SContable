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

namespace Base.Ajustes
{
    public partial class frmReportePagoxProv : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string vId = null;
        public frmReportePagoxProv(string id = null)
        {
            InitializeComponent();
            this.vId = id;
            cargarDatos();
        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    //var datos = db.pac_reporte_pago(vId, "", "", "");
                    //gridControl1.DataSource = datos.ToList();
                    //fc.ocultarColumnas(gridControl1, gridView1);
                    //gridControl1.Refresh();


                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReportePagoxProv_Load(object sender, EventArgs e)
        {

        }
    }
}