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

namespace Base.Pagos
{
    public partial class frmMaestroDetalleDatoPagoProv : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        DataTable dt = new DataTable();
        string idpa = null;
        string idno = null;
        string cuxpa = null;
        bool detalle_partida;
        public frmMaestroDetalleDatoPagoProv(DataTable dt = null, string idpa = null, string idno = null, bool detalle_partida = false)
        {
            InitializeComponent();
            this.idpa = idpa;
            this.idno = idno;
            this.detalle_partida = detalle_partida;
            this.dt = dt;
            cargarLook();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                frmPagoProveMant viajeMant = Owner as frmPagoProveMant;
                if (idno != null)
                {
                    //dt.Rows[Convert.ToInt32(idviajeman)][0] = 
                    dt.Rows[Convert.ToInt32(idno)][2] = Convert.ToString(txtDescripcion.Text);
                    dt.Rows[Convert.ToInt32(idno)][3] = Convert.ToString(txtDato1.Text);
                    dt.Rows[Convert.ToInt32(idno)][4] = Convert.ToString(txtDato2.Text);
                    dt.Rows[Convert.ToInt32(idno)][5] = Convert.ToString(txtDato3.Text);
                    //dt.Rows[Convert.ToInt32(id)][6] = Convert.ToInt32(idpart);

                    int to = Convert.ToInt32(idno) + 1;
                    XtraMessageBox.Show(this, "Se modifico exitosamente el registro No. " + to.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idno = null;
                }
                else
                {
                    int x = dt.Rows.Count + 1;
                    dt.Rows.Add(0, x, Convert.ToString(txtDescripcion.Text), Convert.ToString(txtDato1.Text), Convert.ToString(txtDato2.Text), Convert.ToString(txtDato3.Text));
                }

                viajeMant.gridControl1.DataSource = dt;
                viajeMant.ComprobarBotones();
                viajeMant.gridControl1.Refresh();
                this.Close();

            }

        }
    

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMaestroDetalleDatoPagoProv_Load(object sender, EventArgs e)
        {

        }

        private void frmMaestroDetalleDatoPagoProv_Load_1(object sender, EventArgs e)
        {

        }
        private void cargarLook()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    if (idno != null && detalle_partida == false)
                    {
                        int num = Convert.ToInt32(idno);
                        txtDescripcion.Text = Convert.ToString(dt.Rows[num][2]);
                        txtDato1.EditValue = Convert.ToString(dt.Rows[num][3]);
                        txtDato2.EditValue = Convert.ToString(dt.Rows[num][4]);
                        txtDato3.EditValue = Convert.ToString(dt.Rows[num][5]);
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