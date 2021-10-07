
namespace Base.CuentasXpagar
{
    partial class frmCuentasXpagarMant
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
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.lblFactura = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblCodViaje = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtFactura = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lookCategoria = new DevExpress.XtraEditors.LookUpEdit();
            this.lookProveedor = new DevExpress.XtraEditors.LookUpEdit();
            this.lookMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.deFechaPago = new DevExpress.XtraEditors.DateEdit();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.txtCodigoViaje = new DevExpress.XtraEditors.TextEdit();
            this.lookCodigoViaje = new DevExpress.XtraEditors.LookUpEdit();
            this.cheFiscal = new DevExpress.XtraEditors.CheckEdit();
            this.cheVia = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura)).BeginInit();
            this.txtFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPago.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoViaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCodigoViaje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // lblFactura
            // 
            this.txtFactura.SetColumn(this.lblFactura, 1);
            this.lblFactura.Location = new System.Drawing.Point(117, 126);
            this.lblFactura.Name = "lblFactura";
            this.txtFactura.SetRow(this.lblFactura, 2);
            this.lblFactura.Size = new System.Drawing.Size(41, 13);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "Factura:";
            // 
            // labelControl2
            // 
            this.txtFactura.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(117, 232);
            this.labelControl2.Name = "labelControl2";
            this.txtFactura.SetRow(this.labelControl2, 4);
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Monto:";
            // 
            // labelControl3
            // 
            this.txtFactura.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(117, 285);
            this.labelControl3.Name = "labelControl3";
            this.txtFactura.SetRow(this.labelControl3, 5);
            this.labelControl3.Size = new System.Drawing.Size(75, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fecha de pago:";
            // 
            // lblCodViaje
            // 
            this.txtFactura.SetColumn(this.lblCodViaje, 1);
            this.lblCodViaje.Location = new System.Drawing.Point(117, 73);
            this.lblCodViaje.Name = "lblCodViaje";
            this.txtFactura.SetRow(this.lblCodViaje, 1);
            this.lblCodViaje.Size = new System.Drawing.Size(63, 13);
            this.lblCodViaje.TabIndex = 11;
            this.lblCodViaje.Text = "Codigo viaje:";
            // 
            // labelControl7
            // 
            this.txtFactura.SetColumn(this.labelControl7, 1);
            this.labelControl7.Location = new System.Drawing.Point(117, 338);
            this.labelControl7.Name = "labelControl7";
            this.txtFactura.SetRow(this.labelControl7, 6);
            this.labelControl7.Size = new System.Drawing.Size(42, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Moneda:";
            // 
            // labelControl8
            // 
            this.txtFactura.SetColumn(this.labelControl8, 1);
            this.labelControl8.Location = new System.Drawing.Point(117, 391);
            this.labelControl8.Name = "labelControl8";
            this.txtFactura.SetRow(this.labelControl8, 7);
            this.labelControl8.Size = new System.Drawing.Size(54, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Proveedor:";
            // 
            // labelControl4
            // 
            this.txtFactura.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(117, 444);
            this.labelControl4.Name = "labelControl4";
            this.txtFactura.SetRow(this.labelControl4, 8);
            this.labelControl4.Size = new System.Drawing.Size(51, 13);
            this.labelControl4.TabIndex = 46;
            this.labelControl4.Text = "Categoría:";
            // 
            // txtFactura
            // 
            this.txtFactura.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.txtFactura.Controls.Add(this.simpleButton2);
            this.txtFactura.Controls.Add(this.simpleButton1);
            this.txtFactura.Controls.Add(this.lookCategoria);
            this.txtFactura.Controls.Add(this.lookProveedor);
            this.txtFactura.Controls.Add(this.lookMoneda);
            this.txtFactura.Controls.Add(this.deFechaPago);
            this.txtFactura.Controls.Add(this.txtMonto);
            this.txtFactura.Controls.Add(this.txtDescripcion);
            this.txtFactura.Controls.Add(this.txtCodigoViaje);
            this.txtFactura.Controls.Add(this.lookCodigoViaje);
            this.txtFactura.Controls.Add(this.cheFiscal);
            this.txtFactura.Controls.Add(this.cheVia);
            this.txtFactura.Controls.Add(this.labelControl1);
            this.txtFactura.Controls.Add(this.labelControl4);
            this.txtFactura.Controls.Add(this.labelControl8);
            this.txtFactura.Controls.Add(this.labelControl7);
            this.txtFactura.Controls.Add(this.lblCodViaje);
            this.txtFactura.Controls.Add(this.labelControl3);
            this.txtFactura.Controls.Add(this.labelControl2);
            this.txtFactura.Controls.Add(this.lblFactura);
            this.txtFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFactura.Location = new System.Drawing.Point(0, 0);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 46F)});
            this.txtFactura.Size = new System.Drawing.Size(572, 519);
            this.txtFactura.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.txtFactura.SetColumn(this.simpleButton2, 2);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(288, 481);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.txtFactura.SetRow(this.simpleButton2, 9);
            this.simpleButton2.Size = new System.Drawing.Size(168, 34);
            this.simpleButton2.TabIndex = 78;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton1
            // 
            this.txtFactura.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(116, 481);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.txtFactura.SetRow(this.simpleButton1, 9);
            this.simpleButton1.Size = new System.Drawing.Size(168, 34);
            this.simpleButton1.TabIndex = 77;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // lookCategoria
            // 
            this.txtFactura.SetColumn(this.lookCategoria, 2);
            this.lookCategoria.Location = new System.Drawing.Point(289, 440);
            this.lookCategoria.Name = "lookCategoria";
            this.lookCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCategoria.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_caxcxp", "id_caxcxp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Categoria", "Categoria")});
            this.txtFactura.SetRow(this.lookCategoria, 8);
            this.lookCategoria.Size = new System.Drawing.Size(166, 20);
            this.lookCategoria.TabIndex = 76;
            // 
            // lookProveedor
            // 
            this.txtFactura.SetColumn(this.lookProveedor, 2);
            this.lookProveedor.Location = new System.Drawing.Point(289, 387);
            this.lookProveedor.Name = "lookProveedor";
            this.lookProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookProveedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Proveedor", "Proveedor"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_pro", "id_pro", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.txtFactura.SetRow(this.lookProveedor, 7);
            this.lookProveedor.Size = new System.Drawing.Size(166, 20);
            this.lookProveedor.TabIndex = 75;
            // 
            // lookMoneda
            // 
            this.txtFactura.SetColumn(this.lookMoneda, 2);
            this.lookMoneda.Location = new System.Drawing.Point(289, 334);
            this.lookMoneda.Name = "lookMoneda";
            this.lookMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_mon", "id_mon", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iso", "Iso"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Simbolo", "Simbolo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moneda", "Moneda")});
            this.txtFactura.SetRow(this.lookMoneda, 6);
            this.lookMoneda.Size = new System.Drawing.Size(166, 20);
            this.lookMoneda.TabIndex = 74;
            // 
            // deFechaPago
            // 
            this.txtFactura.SetColumn(this.deFechaPago, 2);
            this.deFechaPago.EditValue = null;
            this.deFechaPago.Location = new System.Drawing.Point(289, 281);
            this.deFechaPago.Name = "deFechaPago";
            this.deFechaPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaPago.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtFactura.SetRow(this.deFechaPago, 5);
            this.deFechaPago.Size = new System.Drawing.Size(166, 20);
            this.deFechaPago.TabIndex = 73;
            // 
            // txtMonto
            // 
            this.txtFactura.SetColumn(this.txtMonto, 2);
            this.txtMonto.Location = new System.Drawing.Point(289, 228);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "f2";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFactura.SetRow(this.txtMonto, 4);
            this.txtMonto.Size = new System.Drawing.Size(166, 20);
            this.txtMonto.TabIndex = 72;
            // 
            // txtDescripcion
            // 
            this.txtFactura.SetColumn(this.txtDescripcion, 2);
            this.txtDescripcion.Location = new System.Drawing.Point(289, 162);
            this.txtDescripcion.MaxLength = 40;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtFactura.SetRow(this.txtDescripcion, 3);
            this.txtDescripcion.Size = new System.Drawing.Size(166, 47);
            this.txtDescripcion.TabIndex = 71;
            this.txtDescripcion.Text = "";
            // 
            // txtCodigoViaje
            // 
            this.txtFactura.SetColumn(this.txtCodigoViaje, 2);
            this.txtCodigoViaje.Location = new System.Drawing.Point(289, 122);
            this.txtCodigoViaje.Name = "txtCodigoViaje";
            this.txtCodigoViaje.Properties.MaxLength = 20;
            this.txtFactura.SetRow(this.txtCodigoViaje, 2);
            this.txtCodigoViaje.Size = new System.Drawing.Size(166, 20);
            this.txtCodigoViaje.TabIndex = 70;
            // 
            // lookCodigoViaje
            // 
            this.txtFactura.SetColumn(this.lookCodigoViaje, 2);
            this.lookCodigoViaje.Location = new System.Drawing.Point(289, 69);
            this.lookCodigoViaje.Name = "lookCodigoViaje";
            this.lookCodigoViaje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCodigoViaje.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_via", "id_via", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Factura", "Factura"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Codigo")});
            this.txtFactura.SetRow(this.lookCodigoViaje, 1);
            this.lookCodigoViaje.Size = new System.Drawing.Size(166, 20);
            this.lookCodigoViaje.TabIndex = 69;
            // 
            // cheFiscal
            // 
            this.txtFactura.SetColumn(this.cheFiscal, 2);
            this.cheFiscal.Location = new System.Drawing.Point(289, 16);
            this.cheFiscal.Name = "cheFiscal";
            this.cheFiscal.Properties.Caption = "Cuenta fiscal";
            this.txtFactura.SetRow(this.cheFiscal, 0);
            this.cheFiscal.Size = new System.Drawing.Size(166, 20);
            this.cheFiscal.TabIndex = 68;
            // 
            // cheVia
            // 
            this.txtFactura.SetColumn(this.cheVia, 1);
            this.cheVia.Location = new System.Drawing.Point(117, 16);
            this.cheVia.Name = "cheVia";
            this.cheVia.Properties.Caption = "Agregar a viaje";
            this.txtFactura.SetRow(this.cheVia, 0);
            this.cheVia.Size = new System.Drawing.Size(166, 20);
            this.cheVia.TabIndex = 67;
            // 
            // labelControl1
            // 
            this.txtFactura.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(117, 179);
            this.labelControl1.Name = "labelControl1";
            this.txtFactura.SetRow(this.labelControl1, 3);
            this.labelControl1.Size = new System.Drawing.Size(58, 13);
            this.labelControl1.TabIndex = 65;
            this.labelControl1.Text = "Descripcion:";
            // 
            // frmCuentasXpagarMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 519);
            this.Controls.Add(this.txtFactura);
            this.Name = "frmCuentasXpagarMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmCuentasXpagarMant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura)).EndInit();
            this.txtFactura.ResumeLayout(false);
            this.txtFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPago.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoViaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCodigoViaje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheVia.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraEditors.LabelControl lblFactura;
        private DevExpress.Utils.Layout.TablePanel txtFactura;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblCodViaje;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit lookCategoria;
        private DevExpress.XtraEditors.LookUpEdit lookProveedor;
        private DevExpress.XtraEditors.LookUpEdit lookMoneda;
        private DevExpress.XtraEditors.DateEdit deFechaPago;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtCodigoViaje;
        private DevExpress.XtraEditors.LookUpEdit lookCodigoViaje;
        private DevExpress.XtraEditors.CheckEdit cheFiscal;
        private DevExpress.XtraEditors.CheckEdit cheVia;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}