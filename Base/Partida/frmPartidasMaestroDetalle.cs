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
using static Base.Funciones;

namespace Base.Partida
{
    public partial class frmPartidasMaestroDetalle : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        DataTable dt = new DataTable();
        string idlista = null;
        public frmPartidasMaestroDetalle(DataTable dat = null, String id = null, string idviaje = null)
        {
            InitializeComponent();
            dt = dat;
            idlista = id;
            cargarLook(id);
        }
        private void cargarLook(string id = null)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var nomenclatura = db.pac_nomenclatura_3(1.ToString(), "", "", "").ToArray();
                    lookNomenclatura.Properties.DataSource = nomenclatura;
                    //producto[0].Producto
                    lookNomenclatura.Properties.DisplayMember = "Nombre";
                    lookNomenclatura.Properties.ValueMember = "id_nom";

                    if (id != null)
                    {
                        int num = Convert.ToInt32(id);
                        txtMonto.EditValue = Convert.ToDecimal(dt.Rows[num][6]);
                        if (Convert.ToBoolean(dt.Rows[num][7]) == true)
                        {
                            checkDebe.Checked = true;
                            checkHeber.Checked = false;
                        }
                        else
                        {
                            checkDebe.Checked = false;
                            checkHeber.Checked = true;
                        }

                        lookNomenclatura.EditValue = Convert.ToInt32(dt.Rows[num][9]);
                        //El numero representa al la columna y el entero "num" a la posision
                    }
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDebe.Checked == true)
            {
                checkHeber.Checked = false;
            }
        }

        private void checkHeber_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHeber.Checked == true)
            {
                checkDebe.Checked = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (vpValidar.Validate())
            {
                frmPartidasMant viajeMant = Owner as frmPartidasMant;
                if (idlista != null)
                {
                    
                    dt.Rows[Convert.ToInt32(idlista)][2] = Convert.ToString(lookNomenclatura.Text);
                    dt.Rows[Convert.ToInt32(idlista)][3] = Convert.ToString("Q");

                    if (checkDebe.Checked == true)
                    {
                        dt.Rows[Convert.ToInt32(idlista)][4] = Convert.ToDecimal(txtMonto.EditValue);
                        dt.Rows[Convert.ToInt32(idlista)][5] = Convert.ToDecimal(0);
                    }
                    else
                    {
                        dt.Rows[Convert.ToInt32(idlista)][5] = Convert.ToDecimal(txtMonto.EditValue);
                        dt.Rows[Convert.ToInt32(idlista)][4] = Convert.ToDecimal(0);
                    }
                    dt.Rows[Convert.ToInt32(idlista)][6] = Convert.ToDecimal(txtMonto.EditValue);
                    dt.Rows[Convert.ToInt32(idlista)][7] = Convert.ToByte(checkDebe.Checked);
                    dt.Rows[Convert.ToInt32(idlista)][8] = Convert.ToInt32(idlista);
                    dt.Rows[Convert.ToInt32(idlista)][9] = Convert.ToInt32(lookNomenclatura.EditValue);

                    int to = Convert.ToInt32(idlista) + 1;
                    XtraMessageBox.Show(this, "Se modifico exitosamente el registro No. " + to.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idlista = null;
                }
                else
                {
                    int x = dt.Rows.Count + 1;
                    decimal debe = 0, haber = 0;

                    if (checkDebe.Checked == true)
                    {
                        debe = Convert.ToDecimal(txtMonto.EditValue);
                    }
                    else
                    {
                        haber = Convert.ToDecimal(txtMonto.EditValue);
                    }
                    dt.Rows.Add(0,//0
                        x,//1
                        Convert.ToString(lookNomenclatura.Text),//2
                        Convert.ToString("Q"),//3
                        debe,//4
                        haber,//5                     
                        Convert.ToDecimal(txtMonto.EditValue),//6
                        Convert.ToByte(checkDebe.Checked),//7
                        Convert.ToInt32(0),//8
                        Convert.ToInt32(lookNomenclatura.EditValue)//9
                        );

                }

                viajeMant.gridControl1.DataSource = dt;
                viajeMant.ComprobarBotones();
                viajeMant.gridControl1.Refresh();
                lookNomenclatura.EditValue = null;
                //lookProducto;
                this.Close();




            }

        }

        private void frmPartidasMaestroDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}