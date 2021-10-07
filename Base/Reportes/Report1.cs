using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Base.Reportes
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        
        string codigo,fecha1, fecha2;


        public Report1(/*string cod = "1",string fe1 = "2021-01-01", string fe2 = "2021-06-30"*/)
        {
            InitializeComponent();
            //this.codigo = cod;
            //this.fecha1 = fe1;
            //this.fecha2 = fe2;


        }
        private void Report1_DataSourceDemanded(object sender, EventArgs e)
        {
            //this.Parameters["parameter1"].Value = codigo;
            //this.Parameters["parameter2"].Value = fecha1;
            //this.Parameters["parameter3"].Value = fecha2;

        }


    }
}
