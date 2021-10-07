
namespace Base.Banco
{
    partial class frmBancoMant
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtNoCunta = new DevExpress.XtraEditors.TextEdit();
            this.txtTitular = new DevExpress.XtraEditors.TextEdit();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.lookMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTipoCambio = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtTipoBanco = new System.Windows.Forms.RichTextBox();
            this.CheckFiscal = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCunta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitular.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckFiscal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 5);
            this.labelControl1.Location = new System.Drawing.Point(356, 106);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Monto:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 2);
            this.labelControl2.Location = new System.Drawing.Point(103, 151);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Moneda:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(103, 61);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nombre:";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 5);
            this.labelControl5.Location = new System.Drawing.Point(356, 61);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "No. Cuenta:";
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 3);
            this.simpleButton1.Location = new System.Drawing.Point(187, 227);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 5);
            this.simpleButton1.Size = new System.Drawing.Size(156, 41);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 6);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(440, 227);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 5);
            this.simpleButton2.Size = new System.Drawing.Size(156, 41);
            this.simpleButton2.TabIndex = 13;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 2);
            this.labelControl4.Location = new System.Drawing.Point(103, 196);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 4);
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 22;
            this.labelControl4.Text = "Tipo:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 5);
            this.labelControl6.Location = new System.Drawing.Point(356, 151);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 3);
            this.labelControl6.Size = new System.Drawing.Size(75, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "Tipo de cambio:";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 2);
            this.labelControl7.Location = new System.Drawing.Point(103, 106);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 2);
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "Titular:";
            // 
            // txtNombre
            // 
            this.tablePanel1.SetColumn(this.txtNombre, 3);
            this.txtNombre.Location = new System.Drawing.Point(187, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.MaxLength = 40;
            this.tablePanel1.SetRow(this.txtNombre, 1);
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 26;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Datos incorrectos";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            conditionValidationRule4.Value1 = "";
            this.vpValidar.SetValidationRule(this.txtNombre, conditionValidationRule4);
            // 
            // txtNoCunta
            // 
            this.tablePanel1.SetColumn(this.txtNoCunta, 6);
            this.txtNoCunta.Location = new System.Drawing.Point(440, 57);
            this.txtNoCunta.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoCunta.Name = "txtNoCunta";
            this.txtNoCunta.Properties.MaxLength = 20;
            this.tablePanel1.SetRow(this.txtNoCunta, 1);
            this.txtNoCunta.Size = new System.Drawing.Size(156, 20);
            this.txtNoCunta.TabIndex = 27;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Datos incorrectos";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            conditionValidationRule3.Value1 = "<Null>";
            this.vpValidar.SetValidationRule(this.txtNoCunta, conditionValidationRule3);
            // 
            // txtTitular
            // 
            this.tablePanel1.SetColumn(this.txtTitular, 3);
            this.txtTitular.Location = new System.Drawing.Point(187, 102);
            this.txtTitular.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Properties.MaxLength = 40;
            this.tablePanel1.SetRow(this.txtTitular, 2);
            this.txtTitular.Size = new System.Drawing.Size(156, 20);
            this.txtTitular.TabIndex = 28;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Datos incorrectos";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            conditionValidationRule2.Value1 = "";
            this.vpValidar.SetValidationRule(this.txtTitular, conditionValidationRule2);
            // 
            // txtMonto
            // 
            this.tablePanel1.SetColumn(this.txtMonto, 6);
            this.txtMonto.Location = new System.Drawing.Point(440, 102);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "f2";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtMonto, 2);
            this.txtMonto.Size = new System.Drawing.Size(156, 20);
            this.txtMonto.TabIndex = 29;
            conditionValidationRule1.ErrorText = "";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.None;
            conditionValidationRule1.Value1 = "@";
            conditionValidationRule1.Value2 = "com";
            this.vpValidar.SetValidationRule(this.txtMonto, conditionValidationRule1);
            // 
            // lookMoneda
            // 
            this.tablePanel1.SetColumn(this.lookMoneda, 3);
            this.lookMoneda.Location = new System.Drawing.Point(188, 147);
            this.lookMoneda.Name = "lookMoneda";
            this.lookMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_mon", "id_mon", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iso", "Iso"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Simbolo", "Simbolo"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Moneda", "Moneda")});
            this.tablePanel1.SetRow(this.lookMoneda, 3);
            this.lookMoneda.Size = new System.Drawing.Size(154, 20);
            this.lookMoneda.TabIndex = 30;
            this.lookMoneda.EditValueChanged += new System.EventHandler(this.lookMoneda_EditValueChanged_1);
            this.lookMoneda.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.lookMoneda_EditValueChanging_1);
            // 
            // txtTipoCambio
            // 
            this.tablePanel1.SetColumn(this.txtTipoCambio, 6);
            this.txtTipoCambio.Location = new System.Drawing.Point(441, 147);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Properties.Mask.EditMask = "f2";
            this.txtTipoCambio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTipoCambio, 3);
            this.txtTipoCambio.Size = new System.Drawing.Size(154, 20);
            this.txtTipoCambio.TabIndex = 31;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 95.01F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.99F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 95.14F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.86F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.CheckFiscal);
            this.tablePanel1.Controls.Add(this.txtTipoBanco);
            this.tablePanel1.Controls.Add(this.txtTipoCambio);
            this.tablePanel1.Controls.Add(this.lookMoneda);
            this.tablePanel1.Controls.Add(this.txtMonto);
            this.tablePanel1.Controls.Add(this.txtTitular);
            this.tablePanel1.Controls.Add(this.txtNoCunta);
            this.tablePanel1.Controls.Add(this.txtNombre);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel1.Size = new System.Drawing.Size(691, 313);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtTipoBanco
            // 
            this.tablePanel1.SetColumn(this.txtTipoBanco, 3);
            this.txtTipoBanco.Location = new System.Drawing.Point(188, 183);
            this.txtTipoBanco.MaxLength = 20;
            this.txtTipoBanco.Name = "txtTipoBanco";
            this.tablePanel1.SetRow(this.txtTipoBanco, 4);
            this.txtTipoBanco.Size = new System.Drawing.Size(154, 39);
            this.txtTipoBanco.TabIndex = 32;
            this.txtTipoBanco.Text = "";
            // 
            // CheckFiscal
            // 
            this.tablePanel1.SetColumn(this.CheckFiscal, 6);
            this.CheckFiscal.Location = new System.Drawing.Point(441, 192);
            this.CheckFiscal.Name = "CheckFiscal";
            this.CheckFiscal.Properties.Caption = "Fiscal";
            this.tablePanel1.SetRow(this.CheckFiscal, 4);
            this.CheckFiscal.Size = new System.Drawing.Size(154, 20);
            this.CheckFiscal.TabIndex = 33;
            // 
            // frmBancoMant
            // 
            this.AcceptButton = this.simpleButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(691, 313);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBancoMant";
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCunta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitular.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTipoCambio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckFiscal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.CheckEdit CheckFiscal;
        private System.Windows.Forms.RichTextBox txtTipoBanco;
        private DevExpress.XtraEditors.TextEdit txtTipoCambio;
        private DevExpress.XtraEditors.LookUpEdit lookMoneda;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.TextEdit txtTitular;
        private DevExpress.XtraEditors.TextEdit txtNoCunta;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}