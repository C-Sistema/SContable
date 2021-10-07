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

namespace Base.Banco
{
    public partial class frmBancoHistorial : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id,fecha1,fecha2 = null;
        string his_repo;

        public frmBancoHistorial(string vid = null,string fecha1 ="",string fecha2 ="",string his_repo = null)
        {
            InitializeComponent();
            id = vid;
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.his_repo = his_repo;
            cargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmBancoHistorial_Load(object sender, EventArgs e)
        {

        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    if (id != null && his_repo == null)
                    {
                        gridControl1.DataSource = null;
                        gridView1.Columns.Clear();
                        string f1, f2;
                        f1 = Convert.ToString(Convert.ToDateTime(fecha1).ToString("yyyy/MM/dd"));
                        f2 = Convert.ToString(Convert.ToDateTime(fecha2).ToString("yyyy/MM/dd"));
                        var datos = db.pac_histxbanc_1(id, f1, f2, "");
                        gridControl1.DataSource = datos.ToList();
                        fc.ocultarColumnas(gridControl1,gridView1);
                        gridControl1.Refresh();
                    }
                    else if(his_repo != null)
                        {
                        gridControl1.DataSource = null;
                        gridView1.Columns.Clear();
                        string f1, f2;
                        f1 = Convert.ToString(Convert.ToDateTime(fecha1).ToString("yyyy/MM/dd"));
                        f2 = Convert.ToString(Convert.ToDateTime(fecha2).ToString("yyyy/MM/dd"));
                        var datos = db.pac_histxbanc_2(id, f1, f2, "");
                        gridControl1.DataSource = datos.ToList();
                        fc.ocultarColumnas(gridControl1,gridView1);
                        gridControl1.Refresh();
                    }

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