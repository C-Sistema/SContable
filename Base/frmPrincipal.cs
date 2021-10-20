using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Base.Clientes;
using Base.Empleado;
using Base.Proveedores;
using Base.Ajustes;
using Base.Usuario;
using Base.Producto;
using Base.Moneda;
using Base.Viaje;
using Base.Venta;
using Base.CuentasXpagar;
using Base.Banco;
using Base.Partida;
using Base.Pagos;
using Base.Reportes;
using Base.Liquidacion;
using DevExpress.XtraReports.UI;

namespace Base
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cargarForm(Form frmForm)
        {
            frmForm.MdiParent = this;
            frmForm.Show();
         
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {      
        }
        private void BarButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
        }
        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.Text = "Clientes";
            cargarForm(frm);    
        }
        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmBitacora frm = new frmBitacora();
            frm.Text = "Bitacora";
            cargarForm(frm);
        }

        private void barButtonItem41_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.Text = "Usuario";
            cargarForm(frm);
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
    
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmEmpleado1 frm = new frmEmpleado1();
            frm.Text = "Empleado";
            cargarForm(frm);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.Text = "Proveedor";
            cargarForm(frm);
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBitacora frm = new frmBitacora();
            frm.Text = "Bitacora";
            cargarForm(frm);
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBoton frm = new frmBoton();
            frm.Text = "Botón";
            cargarForm(frm);
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModulo frm = new frmModulo();
            frm.Text = "Modulo";
            cargarForm(frm);
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProducto frm = new frmProducto();
            frm.Text = " Productos";
            cargarForm(frm);
        }

        private void barButtonItem42_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMoneda frm = new frmMoneda();
            frm.Text = " Monedas";
            cargarForm(frm);
        }

        private void barButtonItem43_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmViaje frm = new frmViaje();
            frm.Text = " Viajes";
            cargarForm(frm);
        }

        private void barButtonItem44_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVenta frm = new frmVenta();
            frm.Text = " Ventas";
            cargarForm(frm);
        }

        private void barButtonItem45_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmCuentasXpagar frm = new frmCuentasXpagar();
            frm.Text = " Cuentas por pagar";
            cargarForm(frm);
        }

        private void barButtonItem46_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.Text = "Bancos";
            cargarForm(frm);
        }

        private void barButtonItem47_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPartidas frm = new frmPartidas();
            frm.Text = "Partidas";
            cargarForm(frm);
        }

        private void barButtonItem48_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem49_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPagoProve frm = new frmPagoProve();
            frm.Text = "Pago a proveedores";
            cargarForm(frm);
        }

        private void barButtonItem50_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReporteDiario frm = new ReporteDiario();
            frm.Text = "Reporte de libro diario";
            cargarForm(frm);
        }

        private void barButtonItem52_ItemClick(object sender, ItemClickEventArgs e)
        {
            LibroDiarioReport rep = new LibroDiarioReport();
            rep.Parameters[1].Value = "01/01/0001";
            rep.Parameters[2].Value = "01/01/2023";
            rep.RequestParameters = false;
            
            rep.CreateDocument();
            rep.ShowRibbonPreviewDialog();
            //rep.RequestParameters = false;

            //rep.ShowRibbonPreview();
            //rep.ShowPreview();
        }

        private void barButtonItem51_ItemClick(object sender, ItemClickEventArgs e)
        {

            LibroMayorReport rep = new LibroMayorReport();
            

            //LibroMayorReport rep = new LibroMayorReport();

            //rep.Parameters[0].Value = "1";
            //rep.Parameters[1].Value = "2021";

            //rep.Parameters[2].Value = "";
            //rep.Parameters[3].Value = "";
            //rep.CreateDocument();


        }

        private void barButtonItem53_ItemClick(object sender, ItemClickEventArgs e)
        {
            VerReportes frm = new VerReportes();
            frm.Show();
        }

        private void barButtonItem54_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmReportes frm = new frmReportes();
            cargarForm(frm);
        }

        private void barButtonItem55_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMenuReportes frm = new frmMenuReportes();
            cargarForm(frm);
        }

        private void barButtonItem56_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLiquidacion frm = new frmLiquidacion();
            cargarForm(frm);
        }

        private void barButtonItem57_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAjuste frm = new frmAjuste();
            cargarForm(frm);
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}
