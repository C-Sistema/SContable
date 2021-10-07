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
    public partial class prueba : DevExpress.XtraEditors.XtraForm
    {
        public prueba()
        {
            InitializeComponent();
            ofArchivo.ShowDialog();
            imageEdit1.Image = new Bitmap(ofArchivo.FileName);

            pictureEdit1.Image = new Bitmap(ofArchivo.FileName);

            if (ofArchivo.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}