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

namespace Base.Ajustes
{
    public partial class ReporteDiario : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        public ReporteDiario()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void ReporteDiario_Load(object sender, EventArgs e)
        {

        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    //gridControl1.DataSource = null;
                    //gridView1.Columns.Clear();
                    //var datos = db.pac_reporte_diario("", "", "", "");
                    //gridControl1.DataSource = datos.ToList();
                    //fc.ocultarColumnas(gridControl1,gridView1);
                    //gridControl1.Refresh();


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