
namespace Base.Proveedores
{
    partial class frmProveedoresMant
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.txtDpis = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtTel1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTel2 = new DevExpress.XtraEditors.TextEdit();
            this.txtRfiscal = new DevExpress.XtraEditors.TextEdit();
            this.txtReferencias = new System.Windows.Forms.RichTextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRfiscal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // txtDpis
            // 
            this.tablePanel1.SetColumn(this.txtDpis, 2);
            this.txtDpis.Location = new System.Drawing.Point(78, 88);
            this.txtDpis.Margin = new System.Windows.Forms.Padding(2);
            this.txtDpis.Name = "txtDpis";
            this.tablePanel1.SetRow(this.txtDpis, 2);
            this.txtDpis.Size = new System.Drawing.Size(37, 13);
            this.txtDpis.TabIndex = 6;
            this.txtDpis.Text = "Codigo:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 2);
            this.labelControl3.Location = new System.Drawing.Point(78, 43);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Nombre:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 5);
            this.labelControl6.Location = new System.Drawing.Point(339, 88);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 2);
            this.labelControl6.Size = new System.Drawing.Size(55, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Teléfono 1:";
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 5);
            this.labelControl7.Location = new System.Drawing.Point(339, 43);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 1);
            this.labelControl7.Size = new System.Drawing.Size(47, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Dirección:";
            // 
            // labelControl9
            // 
            this.tablePanel1.SetColumn(this.labelControl9, 2);
            this.labelControl9.Location = new System.Drawing.Point(78, 129);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.tablePanel1.SetRow(this.labelControl9, 3);
            this.labelControl9.Size = new System.Drawing.Size(55, 13);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Teléfono 2:";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 5);
            this.labelControl1.Location = new System.Drawing.Point(339, 129);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 3);
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Regitro:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 2);
            this.labelControl2.Location = new System.Drawing.Point(78, 198);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 4);
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Referencias:";
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
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.txtReferencias);
            this.tablePanel1.Controls.Add(this.txtRfiscal);
            this.tablePanel1.Controls.Add(this.txtTel2);
            this.tablePanel1.Controls.Add(this.txtTel1);
            this.tablePanel1.Controls.Add(this.txtCodigo);
            this.tablePanel1.Controls.Add(this.txtDireccion);
            this.tablePanel1.Controls.Add(this.txtNombre);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl9);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.txtDpis);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 48F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 42F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 95F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 9F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(739, 343);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.tablePanel1.SetColumn(this.txtNombre, 3);
            this.txtNombre.Location = new System.Drawing.Point(175, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.tablePanel1.SetRow(this.txtNombre, 1);
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 40;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Faltan datos";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtNombre, conditionValidationRule3);
            // 
            // txtDireccion
            // 
            this.tablePanel1.SetColumn(this.txtDireccion, 6);
            this.txtDireccion.Location = new System.Drawing.Point(438, 40);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.tablePanel1.SetRow(this.txtDireccion, 1);
            this.txtDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtDireccion.TabIndex = 41;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Faltan datos";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtDireccion, conditionValidationRule2);
            // 
            // txtCodigo
            // 
            this.tablePanel1.SetColumn(this.txtCodigo, 3);
            this.txtCodigo.Location = new System.Drawing.Point(175, 84);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Properties.Mask.EditMask = "0000-00000-0000";
            this.txtCodigo.Properties.Mask.IgnoreMaskBlank = false;
            this.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtCodigo, 2);
            this.txtCodigo.Size = new System.Drawing.Size(153, 20);
            this.txtCodigo.TabIndex = 42;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Faltan datos";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtCodigo, conditionValidationRule1);
            // 
            // txtTel1
            // 
            this.tablePanel1.SetColumn(this.txtTel1, 6);
            this.txtTel1.Location = new System.Drawing.Point(438, 84);
            this.txtTel1.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Properties.Mask.EditMask = "(000)0000-0000-0000";
            this.txtTel1.Properties.Mask.IgnoreMaskBlank = false;
            this.txtTel1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTel1, 2);
            this.txtTel1.Size = new System.Drawing.Size(152, 20);
            this.txtTel1.TabIndex = 43;
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Faltan datos";
            conditionValidationRule5.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtTel1, conditionValidationRule5);
            // 
            // txtTel2
            // 
            this.tablePanel1.SetColumn(this.txtTel2, 3);
            this.txtTel2.Location = new System.Drawing.Point(175, 126);
            this.txtTel2.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Properties.Mask.EditMask = "(000)0000-0000-0000";
            this.txtTel2.Properties.Mask.IgnoreMaskBlank = false;
            this.txtTel2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTel2, 3);
            this.txtTel2.Size = new System.Drawing.Size(153, 20);
            this.txtTel2.TabIndex = 44;
            // 
            // txtRfiscal
            // 
            this.tablePanel1.SetColumn(this.txtRfiscal, 6);
            this.txtRfiscal.Location = new System.Drawing.Point(439, 126);
            this.txtRfiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRfiscal.Name = "txtRfiscal";
            this.tablePanel1.SetRow(this.txtRfiscal, 3);
            this.txtRfiscal.Size = new System.Drawing.Size(150, 20);
            this.txtRfiscal.TabIndex = 45;
            // 
            // txtReferencias
            // 
            this.tablePanel1.SetColumn(this.txtReferencias, 3);
            this.txtReferencias.Location = new System.Drawing.Point(175, 174);
            this.txtReferencias.Margin = new System.Windows.Forms.Padding(2);
            this.txtReferencias.Name = "txtReferencias";
            this.tablePanel1.SetRow(this.txtReferencias, 4);
            this.txtReferencias.Size = new System.Drawing.Size(153, 61);
            this.txtReferencias.TabIndex = 46;
            this.txtReferencias.Text = "";
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 3);
            this.simpleButton1.Location = new System.Drawing.Point(175, 284);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 6);
            this.simpleButton1.Size = new System.Drawing.Size(153, 35);
            this.simpleButton1.TabIndex = 47;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_2);
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 6);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(438, 283);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 6);
            this.simpleButton2.Size = new System.Drawing.Size(152, 37);
            this.simpleButton2.TabIndex = 48;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // frmProveedoresMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 343);
            this.Controls.Add(this.tablePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProveedoresMant";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRfiscal.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.LabelControl txtDpis;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox txtReferencias;
        private DevExpress.XtraEditors.TextEdit txtRfiscal;
        private DevExpress.XtraEditors.TextEdit txtTel2;
        private DevExpress.XtraEditors.TextEdit txtTel1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}