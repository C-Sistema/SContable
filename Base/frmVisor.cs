using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Base
{
    public partial class frmVisor : DevExpress.XtraEditors.XtraForm
    {
        public string filePath; //Para pasar el link de la imagen
        Image fileold;
        bool bandera = true;
        Funciones fc = new Funciones();
       
        public frmVisor()
        {
            InitializeComponent();
            bandera = true;
        }

        public frmVisor(Image imgBD)
        {
            InitializeComponent();
            bandera = false;
            pcFoto.Image = imgBD;
            fileold= imgBD;
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofArchivo.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofArchivo.FileName;
                    pcFoto.Image = new Bitmap(filePath);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*
        private void SimpleButton1_Click(object sender, EventArgs e)
        {
            if (bandera)
            {
                pcFoto.Image = Base.Properties.Resources.imagen_icon;
                filePath = "";
            }
            else
            {
                pcFoto.Image = fileold;
            }  
        }
        */
        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            
            this.Close();
        }
    }
}