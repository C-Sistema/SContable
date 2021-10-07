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
    public partial class frmViajeCuentas : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        public frmViajeCuentas(string vid = null)
        {
            InitializeComponent();
            id = vid;
            cargarDatos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
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
                    DataTable valores = new DataTable();
                    if (id!= null)
                    {
                        var datos = db.pac_cuenxpaga_2(id, "1", "", "").ToArray();
                        gridControl1.DataSource = datos;
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

        private void frmViajeCuentas_Load(object sender, EventArgs e)
        {

        }
    }
}