
namespace Base.Venta
{
    partial class frmVentaMaestroDetalle
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentaMaestroDetalle));
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.txtPrecioUnita = new DevExpress.XtraEditors.TextEdit();
            this.txtPedido = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPrecioUni = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.txtProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtTamaño = new DevExpress.XtraEditors.TextEdit();
            this.txtPresentacion = new DevExpress.XtraEditors.TextEdit();
            this.txtExistencias = new DevExpress.XtraEditors.TextEdit();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnita.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTamaño.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F)});
            this.tablePanel2.Controls.Add(this.simpleButton5);
            this.tablePanel2.Controls.Add(this.simpleButton4);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel2.Location = new System.Drawing.Point(0, 699);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F)});
            this.tablePanel2.Size = new System.Drawing.Size(1362, 59);
            this.tablePanel2.TabIndex = 1;
            // 
            // simpleButton5
            // 
            this.tablePanel2.SetColumn(this.simpleButton5, 2);
            this.simpleButton5.Location = new System.Drawing.Point(684, 8);
            this.simpleButton5.Name = "simpleButton5";
            this.tablePanel2.SetRow(this.simpleButton5, 1);
            this.simpleButton5.Size = new System.Drawing.Size(670, 43);
            this.simpleButton5.TabIndex = 2;
            this.simpleButton5.Text = "Cancelar";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.tablePanel2.SetColumn(this.simpleButton4, 1);
            this.simpleButton4.Location = new System.Drawing.Point(8, 9);
            this.simpleButton4.Name = "simpleButton4";
            this.tablePanel2.SetRow(this.simpleButton4, 1);
            this.simpleButton4.Size = new System.Drawing.Size(670, 41);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "Agregar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 160F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F)});
            this.tablePanel3.Controls.Add(this.gridControl1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 101);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 160F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 5F)});
            this.tablePanel3.Size = new System.Drawing.Size(1362, 598);
            this.tablePanel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.tablePanel3.SetColumn(this.gridControl1, 1);
            this.gridControl1.Location = new System.Drawing.Point(8, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel3.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(1346, 582);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // txtPrecioUnita
            // 
            this.tablePanel1.SetColumn(this.txtPrecioUnita, 9);
            this.txtPrecioUnita.EditValue = "1";
            this.txtPrecioUnita.Location = new System.Drawing.Point(1134, 41);
            this.txtPrecioUnita.Name = "txtPrecioUnita";
            this.txtPrecioUnita.Properties.Mask.EditMask = "f2";
            this.txtPrecioUnita.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtPrecioUnita, 1);
            this.txtPrecioUnita.Size = new System.Drawing.Size(208, 20);
            this.txtPrecioUnita.TabIndex = 34;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Ingrese el precio unitario";
            this.vpValidar.SetValidationRule(this.txtPrecioUnita, conditionValidationRule2);
            this.txtPrecioUnita.EditValueChanged += new System.EventHandler(this.txtPrecioUnita_EditValueChanged_1);
            this.txtPrecioUnita.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtPrecioUnita_EditValueChanging_1);
            // 
            // txtPedido
            // 
            this.tablePanel1.SetColumn(this.txtPedido, 6);
            this.txtPedido.EditValue = "1";
            this.txtPedido.Location = new System.Drawing.Point(692, 41);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Properties.Mask.EditMask = "f2";
            this.txtPedido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtPedido, 1);
            this.txtPedido.Size = new System.Drawing.Size(208, 20);
            this.txtPedido.TabIndex = 33;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Ingrese una cantidad";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtPedido, conditionValidationRule1);
            this.txtPedido.EditValueChanged += new System.EventHandler(this.txtPedido_EditValueChanged_1);
            this.txtPedido.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.txtPedido_EditValueChanging_1);
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(21, 10);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Producto:";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(21, 44);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Existencias:";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 4);
            this.labelControl5.Location = new System.Drawing.Point(463, 44);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(36, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Pedido:";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 7);
            this.labelControl6.Location = new System.Drawing.Point(905, 44);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 1);
            this.labelControl6.Size = new System.Drawing.Size(72, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Precio unitario:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 7);
            this.labelControl2.Location = new System.Drawing.Point(905, 10);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Presentación:";
            // 
            // lblPrecioUni
            // 
            this.tablePanel1.SetColumn(this.lblPrecioUni, 8);
            this.lblPrecioUni.Location = new System.Drawing.Point(1119, 44);
            this.lblPrecioUni.Name = "lblPrecioUni";
            this.tablePanel1.SetRow(this.lblPrecioUni, 1);
            this.lblPrecioUni.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioUni.TabIndex = 18;
            // 
            // labelControl8
            // 
            this.tablePanel1.SetColumn(this.labelControl8, 4);
            this.labelControl8.Location = new System.Drawing.Point(463, 10);
            this.labelControl8.Name = "labelControl8";
            this.tablePanel1.SetRow(this.labelControl8, 0);
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 19;
            this.labelControl8.Text = "Tamaño:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 7);
            this.labelControl3.Location = new System.Drawing.Point(905, 78);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 2);
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 20;
            this.labelControl3.Text = "Total:";
            // 
            // txtTotal
            // 
            this.tablePanel1.SetColumn(this.txtTotal, 9);
            this.txtTotal.EditValue = "1";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1134, 74);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Mask.EditMask = "f2";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtTotal, 2);
            this.txtTotal.Size = new System.Drawing.Size(208, 20);
            this.txtTotal.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.tablePanel1.SetColumn(this.lblTotal, 8);
            this.lblTotal.Location = new System.Drawing.Point(1119, 78);
            this.lblTotal.Name = "lblTotal";
            this.tablePanel1.SetRow(this.lblTotal, 2);
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 22;
            // 
            // txtProducto
            // 
            this.tablePanel1.SetColumn(this.txtProducto, 3);
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(249, 7);
            this.txtProducto.Name = "txtProducto";
            this.tablePanel1.SetRow(this.txtProducto, 0);
            this.txtProducto.Size = new System.Drawing.Size(208, 20);
            this.txtProducto.TabIndex = 29;
            // 
            // txtTamaño
            // 
            this.tablePanel1.SetColumn(this.txtTamaño, 6);
            this.txtTamaño.Enabled = false;
            this.txtTamaño.Location = new System.Drawing.Point(692, 7);
            this.txtTamaño.Name = "txtTamaño";
            this.tablePanel1.SetRow(this.txtTamaño, 0);
            this.txtTamaño.Size = new System.Drawing.Size(208, 20);
            this.txtTamaño.TabIndex = 30;
            // 
            // txtPresentacion
            // 
            this.tablePanel1.SetColumn(this.txtPresentacion, 9);
            this.txtPresentacion.Enabled = false;
            this.txtPresentacion.Location = new System.Drawing.Point(1134, 7);
            this.txtPresentacion.Name = "txtPresentacion";
            this.tablePanel1.SetRow(this.txtPresentacion, 0);
            this.txtPresentacion.Size = new System.Drawing.Size(208, 20);
            this.txtPresentacion.TabIndex = 31;
            // 
            // txtExistencias
            // 
            this.tablePanel1.SetColumn(this.txtExistencias, 3);
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(249, 41);
            this.txtExistencias.Name = "txtExistencias";
            this.tablePanel1.SetRow(this.txtExistencias, 1);
            this.txtExistencias.Size = new System.Drawing.Size(208, 20);
            this.txtExistencias.TabIndex = 32;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 15F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 60F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.txtPrecioUnita);
            this.tablePanel1.Controls.Add(this.txtPedido);
            this.tablePanel1.Controls.Add(this.txtExistencias);
            this.tablePanel1.Controls.Add(this.txtPresentacion);
            this.tablePanel1.Controls.Add(this.txtTamaño);
            this.tablePanel1.Controls.Add(this.txtProducto);
            this.tablePanel1.Controls.Add(this.lblTotal);
            this.tablePanel1.Controls.Add(this.txtTotal);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl8);
            this.tablePanel1.Controls.Add(this.lblPrecioUni);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel1.Size = new System.Drawing.Size(1362, 101);
            this.tablePanel1.TabIndex = 0;
            // 
            // frmVentaMaestroDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 758);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tablePanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentaMaestroDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVentaMant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVentaMaestroDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioUnita.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPedido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTamaño.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExistencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.TextEdit txtPrecioUnita;
        private DevExpress.XtraEditors.TextEdit txtPedido;
        private DevExpress.XtraEditors.TextEdit txtExistencias;
        private DevExpress.XtraEditors.TextEdit txtPresentacion;
        private DevExpress.XtraEditors.TextEdit txtTamaño;
        private DevExpress.XtraEditors.TextEdit txtProducto;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        public DevExpress.XtraEditors.LabelControl lblTotal;
        public DevExpress.XtraEditors.LabelControl lblPrecioUni;
    }
}