
namespace Base.Ajustes
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.txtDpis = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaIni = new DevExpress.XtraEditors.DateEdit();
            this.txtTotalnf = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalfi = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalR = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.cheCerrado = new DevExpress.XtraEditors.CheckEdit();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.datFechaVen = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalnf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalfi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCerrado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaVen.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaVen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // txtDpis
            // 
            this.tablePanel1.SetColumn(this.txtDpis, 2);
            this.txtDpis.Location = new System.Drawing.Point(74, 90);
            this.txtDpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDpis.Name = "txtDpis";
            this.tablePanel1.SetRow(this.txtDpis, 2);
            this.txtDpis.Size = new System.Drawing.Size(73, 13);
            this.txtDpis.TabIndex = 6;
            this.txtDpis.Text = "Total, no fiscal ";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(74, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(52, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Factura #:";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 5);
            this.labelControl5.Location = new System.Drawing.Point(321, 43);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Fecha inicio:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 2);
            this.labelControl6.Location = new System.Drawing.Point(74, 134);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 3);
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Resultado";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 5);
            this.labelControl7.Location = new System.Drawing.Point(321, 90);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 2);
            this.labelControl7.Size = new System.Drawing.Size(55, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Total fiscal:";
            // 
            // txtFactura
            // 
            this.tablePanel1.SetColumn(this.txtFactura, 3);
            this.txtFactura.Location = new System.Drawing.Point(166, 40);
            this.txtFactura.Name = "txtFactura";
            this.tablePanel1.SetRow(this.txtFactura, 1);
            this.txtFactura.Size = new System.Drawing.Size(142, 20);
            this.txtFactura.TabIndex = 22;
            // 
            // dtFechaIni
            // 
            this.tablePanel1.SetColumn(this.dtFechaIni, 6);
            this.dtFechaIni.EditValue = null;
            this.dtFechaIni.Location = new System.Drawing.Point(416, 40);
            this.dtFechaIni.Name = "dtFechaIni";
            this.dtFechaIni.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.dtFechaIni, 1);
            this.dtFechaIni.Size = new System.Drawing.Size(141, 20);
            this.dtFechaIni.TabIndex = 23;
            // 
            // txtTotalnf
            // 
            this.tablePanel1.SetColumn(this.txtTotalnf, 3);
            this.txtTotalnf.Location = new System.Drawing.Point(166, 87);
            this.txtTotalnf.Name = "txtTotalnf";
            this.tablePanel1.SetRow(this.txtTotalnf, 2);
            this.txtTotalnf.Size = new System.Drawing.Size(142, 20);
            this.txtTotalnf.TabIndex = 24;
            // 
            // txtTotalfi
            // 
            this.tablePanel1.SetColumn(this.txtTotalfi, 6);
            this.txtTotalfi.Location = new System.Drawing.Point(416, 87);
            this.txtTotalfi.Name = "txtTotalfi";
            this.tablePanel1.SetRow(this.txtTotalfi, 2);
            this.txtTotalfi.Size = new System.Drawing.Size(141, 20);
            this.txtTotalfi.TabIndex = 25;
            // 
            // txtTotalR
            // 
            this.tablePanel1.SetColumn(this.txtTotalR, 3);
            this.txtTotalR.Location = new System.Drawing.Point(166, 130);
            this.txtTotalR.Name = "txtTotalR";
            this.tablePanel1.SetRow(this.txtTotalR, 3);
            this.txtTotalR.Size = new System.Drawing.Size(142, 20);
            this.txtTotalR.TabIndex = 26;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 5);
            this.labelControl1.Location = new System.Drawing.Point(322, 175);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 4);
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Tipo de Cambio";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 5);
            this.labelControl2.Location = new System.Drawing.Point(322, 134);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Moneda:";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 2);
            this.labelControl4.Location = new System.Drawing.Point(75, 217);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 5);
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Proveedor:";
            // 
            // lookUpEdit1
            // 
            this.tablePanel1.SetColumn(this.lookUpEdit1, 6);
            this.lookUpEdit1.Location = new System.Drawing.Point(416, 130);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "Seleccionar moneda";
            this.tablePanel1.SetRow(this.lookUpEdit1, 3);
            this.lookUpEdit1.Size = new System.Drawing.Size(141, 20);
            this.lookUpEdit1.TabIndex = 34;
            // 
            // cheCerrado
            // 
            this.tablePanel1.SetColumn(this.cheCerrado, 3);
            this.cheCerrado.Location = new System.Drawing.Point(166, 172);
            this.cheCerrado.Name = "cheCerrado";
            this.cheCerrado.Properties.Caption = "Terminado";
            this.tablePanel1.SetRow(this.cheCerrado, 4);
            this.cheCerrado.Size = new System.Drawing.Size(142, 20);
            this.cheCerrado.TabIndex = 35;
            // 
            // txtTipoCambio
            // 
            this.tablePanel1.SetColumn(this.txtTipoCambio, 6);
            this.txtTipoCambio.Location = new System.Drawing.Point(416, 172);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.tablePanel1.SetRow(this.txtTipoCambio, 4);
            this.txtTipoCambio.Size = new System.Drawing.Size(141, 20);
            this.txtTipoCambio.TabIndex = 36;
            // 
            // lookUpEdit2
            // 
            this.tablePanel1.SetColumn(this.lookUpEdit2, 3);
            this.lookUpEdit2.Location = new System.Drawing.Point(166, 213);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.NullText = "Seleccionar proveedor";
            this.tablePanel1.SetRow(this.lookUpEdit2, 5);
            this.lookUpEdit2.Size = new System.Drawing.Size(142, 20);
            this.lookUpEdit2.TabIndex = 37;
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 3);
            this.simpleButton1.Location = new System.Drawing.Point(165, 255);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 6);
            this.simpleButton1.Size = new System.Drawing.Size(144, 35);
            this.simpleButton1.TabIndex = 38;
            this.simpleButton1.Text = "Aceptar";
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 6);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(415, 254);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 6);
            this.simpleButton2.Size = new System.Drawing.Size(143, 37);
            this.simpleButton2.TabIndex = 39;
            this.simpleButton2.Text = "Cancelar";
            // 
            // datFechaVen
            // 
            this.tablePanel1.SetColumn(this.datFechaVen, 6);
            this.datFechaVen.EditValue = null;
            this.datFechaVen.Location = new System.Drawing.Point(416, 213);
            this.datFechaVen.Name = "datFechaVen";
            this.datFechaVen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datFechaVen.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.datFechaVen, 5);
            this.datFechaVen.Size = new System.Drawing.Size(141, 20);
            this.datFechaVen.TabIndex = 40;
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 5);
            this.labelControl8.Location = new System.Drawing.Point(322, 217);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 5);
            this.labelControl8.Size = new System.Drawing.Size(48, 13);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "Fecha fin:";
            // 
            // labelControl9
            // 
            this.tablePanel1.SetColumn(this.labelControl9, 2);
            this.labelControl9.Location = new System.Drawing.Point(75, 175);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel1.SetRow(this.labelControl9, 4);
            this.labelControl9.Size = new System.Drawing.Size(57, 13);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "Mercaderia:";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 42.2F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60.24F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 97.57F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.99F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 61.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 97.06F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.86F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80.08F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.48F)});
            this.tablePanel1.Controls.Add(this.labelControl9);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.datFechaVen);
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.lookUpEdit2);
            this.tablePanel1.Controls.Add(this.txtTipoCambio);
            this.tablePanel1.Controls.Add(this.cheCerrado);
            this.tablePanel1.Controls.Add(this.lookUpEdit1);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.txtTotalR);
            this.tablePanel1.Controls.Add(this.txtTotalfi);
            this.tablePanel1.Controls.Add(this.txtTotalnf);
            this.tablePanel1.Controls.Add(this.dtFechaIni);
            this.tablePanel1.Controls.Add(this.txtFactura);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.txtDpis);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 46F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(699, 301);
            this.tablePanel1.TabIndex = 0;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 336);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XtraForm1";
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaIni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalnf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalfi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheCerrado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaVen.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datFechaVen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.LabelControl txtDpis;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit datFechaVen;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.CheckEdit cheCerrado;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTotalR;
        private DevExpress.XtraEditors.TextEdit txtTotalfi;
        private DevExpress.XtraEditors.TextEdit txtTotalnf;
        private DevExpress.XtraEditors.DateEdit dtFechaIni;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}