using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base.Usuario
{
    public partial class frmPermiso : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPermiso()
        {
            InitializeComponent();
         
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gcGrid.ShowRibbonPrintPreview();
        }


    }
}