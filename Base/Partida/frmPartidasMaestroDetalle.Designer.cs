
namespace Base.Partida
{
    partial class frmPartidasMaestroDetalle
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
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.checkDebe = new DevExpress.XtraEditors.CheckEdit();
            this.checkHeber = new DevExpress.XtraEditors.CheckEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lookNomenclatura = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDebe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHeber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookNomenclatura.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // txtMonto
            // 
            this.tablePanel1.SetColumn(this.txtMonto, 2);
            this.txtMonto.EditValue = "1";
            this.txtMonto.Location = new System.Drawing.Point(260, 18);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "f2";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.tablePanel1.SetRow(this.txtMonto, 0);
            this.txtMonto.Size = new System.Drawing.Size(234, 20);
            this.txtMonto.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 1);
            this.labelControl7.Location = new System.Drawing.Point(19, 22);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 0);
            this.labelControl7.Size = new System.Drawing.Size(34, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Monto:";
            // 
            // simpleButton1
            // 
            this.tablePanel1.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(18, 297);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel1.SetRow(this.simpleButton1, 5);
            this.simpleButton1.Size = new System.Drawing.Size(236, 33);
            this.simpleButton1.TabIndex = 39;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.tablePanel1.SetColumn(this.simpleButton2, 2);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(259, 297);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel1.SetRow(this.simpleButton2, 5);
            this.simpleButton2.Size = new System.Drawing.Size(236, 33);
            this.simpleButton2.TabIndex = 40;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // checkDebe
            // 
            this.tablePanel1.SetColumn(this.checkDebe, 2);
            this.checkDebe.Location = new System.Drawing.Point(260, 75);
            this.checkDebe.Name = "checkDebe";
            this.checkDebe.Properties.Caption = "Debe";
            this.tablePanel1.SetRow(this.checkDebe, 1);
            this.checkDebe.Size = new System.Drawing.Size(234, 20);
            this.checkDebe.TabIndex = 41;
            this.checkDebe.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // checkHeber
            // 
            this.tablePanel1.SetColumn(this.checkHeber, 2);
            this.checkHeber.Location = new System.Drawing.Point(260, 132);
            this.checkHeber.Name = "checkHeber";
            this.checkHeber.Properties.Caption = "Haber";
            this.checkHeber.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.tablePanel1.SetRow(this.checkHeber, 2);
            this.checkHeber.Size = new System.Drawing.Size(234, 20);
            this.checkHeber.TabIndex = 42;
            this.checkHeber.CheckedChanged += new System.EventHandler(this.checkHeber_CheckedChanged);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.lookNomenclatura);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.checkHeber);
            this.tablePanel1.Controls.Add(this.checkDebe);
            this.tablePanel1.Controls.Add(this.simpleButton2);
            this.tablePanel1.Controls.Add(this.simpleButton1);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.txtMonto);
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
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel1.Size = new System.Drawing.Size(513, 363);
            this.tablePanel1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(19, 193);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Nomenclatura";
            // 
            // lookNomenclatura
            // 
            this.tablePanel1.SetColumn(this.lookNomenclatura, 2);
            this.lookNomenclatura.Location = new System.Drawing.Point(260, 189);
            this.lookNomenclatura.Name = "lookNomenclatura";
            this.lookNomenclatura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookNomenclatura.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("No", "No"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_nom", "id_nom", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.tablePanel1.SetRow(this.lookNomenclatura, 3);
            this.lookNomenclatura.Size = new System.Drawing.Size(234, 20);
            this.lookNomenclatura.TabIndex = 44;
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(19, 79);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 1);
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 43;
            this.labelControl1.Text = "Debe/Haber:";
            // 
            // frmPartidasMaestroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 363);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmPartidasMaestroDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.Load += new System.EventHandler(this.frmPartidasMaestroDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDebe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkHeber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookNomenclatura.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.CheckEdit checkHeber;
        private DevExpress.XtraEditors.CheckEdit checkDebe;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookNomenclatura;
    }
}