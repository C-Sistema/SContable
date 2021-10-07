using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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

namespace Base.Viaje
{
    public partial class frmViajeMaestroDetalle : DevExpress.XtraEditors.XtraForm
    {

        Funciones fc = new Funciones();
        DataTable dt = new DataTable();
        string idviajeman = null;

        public frmViajeMaestroDetalle(DataTable dat = null, String id = null,string idviaje = null)
        {
            InitializeComponent();
            dt = dat;
            idviajeman = id;
            cargarLook(id);
        }


        private void cargarLook(string id = null)
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    var producto = db.pac_producto_1(1.ToString(), "", "", "").ToArray();
                    var tamaño = db.pac_tamano_1(1.ToString(), "", "", "").ToArray();
                    var presentacion = db.pac_presentacion_1(1.ToString(), "", "", "").ToArray();
                    lookProducto.Properties.DataSource = producto;
                    lookTam.Properties.DataSource = tamaño;
                    lookPres.Properties.DataSource = presentacion;
                    //producto[0].Producto
                    lookProducto.Properties.DisplayMember = "Producto";
                    lookProducto.Properties.ValueMember = "id_pro";
                    //tamaño[0].Tamaño
                    lookTam.Properties.DisplayMember = "Tamaño";
                    lookTam.Properties.ValueMember = "id_tam";
                    //presentacion[0].Presentacion
                    lookPres.Properties.DisplayMember = "Presentacion";
                    lookPres.Properties.ValueMember = "id_pre";

                    if (id != null)
                    {
                        int num = Convert.ToInt32(id);

                        lookProducto.EditValue = Convert.ToInt32(dt.Rows[num][2]);
                        lookTam.EditValue = Convert.ToInt32(dt.Rows[num][4]);
                        lookPres.EditValue = Convert.ToInt32(dt.Rows[num][6]);
                        txtCantidad.EditValue = Convert.ToDouble(dt.Rows[num][8]);
                        txtPresUni.EditValue = Convert.ToDouble(dt.Rows[num][9]);
                        txtPresTot.EditValue = Convert.ToDouble(dt.Rows[num][10]);
                    }
                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                frmViajeMant viajeMant = Owner as frmViajeMant;
                if (idviajeman != null)
                {
                    //dt.Rows[Convert.ToInt32(idviajeman)][0] = 
                    dt.Rows[Convert.ToInt32(idviajeman)][2] = Convert.ToInt32(lookProducto.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][3] = lookProducto.Text;
                    dt.Rows[Convert.ToInt32(idviajeman)][4] = Convert.ToInt32(lookTam.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][5] = lookTam.Text;
                    dt.Rows[Convert.ToInt32(idviajeman)][6] = Convert.ToInt32(lookPres.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][7] = lookPres.Text;
                    dt.Rows[Convert.ToInt32(idviajeman)][8] = Convert.ToDouble(txtCantidad.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][9] = Convert.ToDouble(txtPresUni.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][10] = Convert.ToDouble(txtPresTot.EditValue);
                    dt.Rows[Convert.ToInt32(idviajeman)][11] = Convert.ToDouble(txtCantidad.EditValue);

                    int to = Convert.ToInt32(idviajeman) + 1;
                    XtraMessageBox.Show(this, "Se modifico exitosamente el registro No. " + to.ToString() , fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idviajeman = null;
                }
                else
                {
                    int x = dt.Rows.Count + 1;
                    dt.Rows.Add(0,x, Convert.ToInt32(lookProducto.EditValue), lookProducto.Text, Convert.ToInt32(lookTam.EditValue), lookTam.Text, Convert.ToInt32(lookPres.EditValue), lookPres.Text, Convert.ToDouble(txtCantidad.EditValue), Convert.ToDouble(txtPresUni.EditValue), Convert.ToDouble(txtPresTot.EditValue),Convert.ToDouble(txtCantidad.EditValue), Convert.ToDouble(viajeMant.idviadmantvia));
                }
                
                viajeMant.gridControl1.DataSource = dt;
                viajeMant.ComprobarBotones();
                viajeMant.gridControl1.Refresh();
                lookProducto.EditValue = null;
                //lookProducto;
                lookPres.EditValue = null;
                lookTam.EditValue = null;
                txtPresUni.EditValue = 1;
                txtCantidad.EditValue = 1;
                this.Close();

            }
            


        }

        private void frmViajeMaestroDetalle_Load(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.EditValue) * Convert.ToDouble(txtPresUni.EditValue);
            txtPresTot.Text = Convert.ToString(res);
        }

        private void txtPresUni_EditValueChanged(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.EditValue) * Convert.ToDouble(txtPresUni.EditValue);
            txtPresTot.Text = Convert.ToString(res);
        }

        private void txtCantidad_EditValueChanged(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.EditValue) * Convert.ToDouble(txtPresUni.EditValue);
            txtPresTot.Text = Convert.ToString(res);
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.EditValue) * Convert.ToDouble(txtPresUni.EditValue);
            txtPresTot.Text = Convert.ToString(res);
        }

        private void txtPresUni_Enter(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.EditValue) * Convert.ToDouble(txtPresUni.EditValue);
            txtPresTot.Text = Convert.ToString(res);
        }

        private void txtPresTot_Enter(object sender, EventArgs e)
        {
            double res = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPresUni.Text);
            txtPresTot.Text = Convert.ToString(res);
        }
    }
}

