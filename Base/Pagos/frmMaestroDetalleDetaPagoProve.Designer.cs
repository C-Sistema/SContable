
namespace Base.Pagos
{
    partial class frmMaestroDetalleDetaPagoProve
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lookCuexpa = new DevExpress.XtraEditors.LookUpEdit();
            this.txtMontoTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCuexpa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.txtTotal);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.txtDescripcion);
            this.tablePanel1.Controls.Add(this.lookCuexpa);
            this.tablePanel1.Controls.Add(this.txtMontoTotal);
            this.tablePanel1.Controls.Add(this.txtTipoCambio);
            this.tablePanel1.Controls.Add(this.txtMonto);
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 37F)});
            this.tablePanel1.Size = new System.Drawing.Size(513, 363);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.tablePanel1.SetColumn(this.txtTotal, 2);
            this.txtTotal.Location = new System.Drawing.Point(260, 172);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "f2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTotal, 3);
            this.txtTotal.Size = new System.Drawing.Size(234, 20);
            this.txtTotal.TabIndex = 48;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(19, 175);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 3);
            this.labelControl1.Size = new System.Drawing.Size(28, 13);
            this.labelControl1.TabIndex = 47;
            this.labelControl1.Text = "Total:";
            // 
            // txtDescripcion
            // 
            this.tablePanel1.SetColumn(this.txtDescripcion, 2);
            this.txtDescripcion.Location = new System.Drawing.Point(260, 267);
            this.txtDescripcion.MaxLength = 40;
            this.txtDescripcion.Name = "txtDescripcion";
            this.tablePanel1.SetRow(this.txtDescripcion, 5);
            this.txtDescripcion.Size = new System.Drawing.Size(234, 37);
            this.txtDescripcion.TabIndex = 46;
            this.txtDescripcion.Text = "";
            // 
            // lookCuexpa
            // 
            this.tablePanel1.SetColumn(this.lookCuexpa, 2);
            this.lookCuexpa.Location = new System.Drawing.Point(260, 16);
            this.lookCuexpa.Name = "lookCuexpa";
            this.lookCuexpa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCuexpa.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_cuxpa", "id_cuxpa", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Factura", "No. Factura"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Viaje", "Viaje"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Saldo", "Saldo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Categoria", "Categoria")});
            this.tablePanel1.SetRow(this.lookCuexpa, 0);
            this.lookCuexpa.Size = new System.Drawing.Size(234, 20);
            this.lookCuexpa.TabIndex = 45;
            this.lookCuexpa.EditValueChanged += new System.EventHandler(this.lookCuexpa_EditValueChanged);
            // 
            // txtMontoTotal
            // 
            this.tablePanel1.SetColumn(this.txtMontoTotal, 2);
            this.txtMontoTotal.Enabled = false;
            this.txtMontoTotal.Location = new System.Drawing.Point(260, 224);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Properties.Mask.EditMask = "f2";
            this.txtMontoTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtMontoTotal, 4);
            this.txtMontoTotal.Size = new System.Drawing.Size(234, 20);
            this.txtMontoTotal.TabIndex = 43;
            // 
            // txtTipoCambio
            // 
            this.tablePanel1.SetColumn(this.txtTipoCambio, 2);
            this.txtTipoCambio.EditValue = "1";
            this.txtTipoCambio.Location = new System.Drawing.Point(260, 120);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Properties.Mask.EditMask = "f5";
            this.txtTipoCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTipoCambio, 2);
            this.txtTipoCambio.Size = new System.Drawing.Size(234, 20);
            this.txtTipoCambio.TabIndex = 42;
            this.txtTipoCambio.EditValueChanged += new System.EventHandler(this.txtTipoCambio_EditValueChanged);
            this.txtTipoCambio.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtTipoCambio_EditValueChanging);
            // 
            // txtMonto
            // 
            this.tablePanel1.SetColumn(this.txtMonto, 2);
            this.txtMonto.Location = new System.Drawing.Point(260, 68);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "f2";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtMonto, 1);
            this.txtMonto.Size = new System.Drawing.Size(234, 20);
            this.txtMonto.TabIndex = 41;
            this.txtMonto.PropertiesChanged += new System.EventHandler(this.txtMonto_PropertiesChanged);
            this.txtMonto.EditValueChanged += new System.EventHandler(this.txtMonto_EditValueChanged);
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 2);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(259, 321);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 6);
            this.simpleButton2.Size = new System.Drawing.Size(236, 33);
            this.simpleButton2.TabIndex = 40;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(18, 321);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 6);
            this.simpleButton1.Size = new System.Drawing.Size(236, 33);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 1);
            this.labelControl8.Location = new System.Drawing.Point(19, 71);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 1);
            this.labelControl8.Size = new System.Drawing.Size(34, 13);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Monto:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 1);
            this.labelControl6.Location = new System.Drawing.Point(19, 19);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 0);
            this.labelControl6.Size = new System.Drawing.Size(94, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Cuentas por pagar:";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(19, 279);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 5);
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Descripcion:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(19, 227);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(30, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Saldo:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(19, 123);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tipo de cambio:";
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // frmMaestroDetalleDetaPagoProve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 363);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmMaestroDetalleDetaPagoProve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmMaestroDetalleDetaPagoProve_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCuexpa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMontoTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraEditors.LookUpEdit lookCuexpa;
        private DevExpress.XtraEditors.TextEdit txtMontoTotal;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}