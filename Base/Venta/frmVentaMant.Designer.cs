
namespace Base.Venta
{
    partial class frmVentaMant
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.lookMoneda = new DevExpress.XtraEditors.LookUpEdit();
            this.lookCliente = new DevExpress.XtraEditors.LookUpEdit();
            this.lookEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.deFechaCredito = new DevExpress.XtraEditors.DateEdit();
            this.CheckCredito = new DevExpress.XtraEditors.CheckEdit();
            this.txtFactura = new DevExpress.XtraEditors.TextEdit();
            this.lblTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblMoneda = new DevExpress.XtraEditors.LabelControl();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCredito.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCredito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
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
            this.tablePanel2.Size = new System.Drawing.Size(1621, 59);
            this.tablePanel2.TabIndex = 1;
            // 
            // simpleButton5
            // 
            this.tablePanel2.SetColumn(this.simpleButton5, 2);
            this.simpleButton5.Location = new System.Drawing.Point(814, 8);
            this.simpleButton5.Name = "simpleButton5";
            this.tablePanel2.SetRow(this.simpleButton5, 1);
            this.simpleButton5.Size = new System.Drawing.Size(800, 43);
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
            this.simpleButton4.Size = new System.Drawing.Size(800, 41);
            this.simpleButton4.TabIndex = 1;
            this.simpleButton4.Text = "Aceptar";
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
            this.tablePanel3.Size = new System.Drawing.Size(1621, 598);
            this.tablePanel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.tablePanel3.SetColumn(this.gridControl1, 1);
            this.gridControl1.Location = new System.Drawing.Point(8, 8);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel3.SetRow(this.gridControl1, 1);
            this.gridControl1.Size = new System.Drawing.Size(1605, 582);
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
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(24, 10);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Factura #:";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(24, 44);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Cliente:";
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 4);
            this.labelControl5.Location = new System.Drawing.Point(550, 44);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(45, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Moneda: ";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 7);
            this.labelControl6.Location = new System.Drawing.Point(1077, 44);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 1);
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Total:";
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
            this.tablePanel1.Controls.Add(this.txtTotal);
            this.tablePanel1.Controls.Add(this.lookMoneda);
            this.tablePanel1.Controls.Add(this.lookCliente);
            this.tablePanel1.Controls.Add(this.lookEmpleado);
            this.tablePanel1.Controls.Add(this.deFechaCredito);
            this.tablePanel1.Controls.Add(this.CheckCredito);
            this.tablePanel1.Controls.Add(this.txtFactura);
            this.tablePanel1.Controls.Add(this.lblTotal);
            this.tablePanel1.Controls.Add(this.lblMoneda);
            this.tablePanel1.Controls.Add(this.btnEliminar);
            this.tablePanel1.Controls.Add(this.btnEditar);
            this.tablePanel1.Controls.Add(this.btnAgregar);
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
            this.tablePanel1.Size = new System.Drawing.Size(1621, 101);
            this.tablePanel1.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.tablePanel1.SetColumn(this.txtTotal, 9);
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(1347, 41);
            this.txtTotal.Name = "txtTotal";
            this.tablePanel1.SetRow(this.txtTotal, 1);
            this.txtTotal.Size = new System.Drawing.Size(250, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // lookMoneda
            // 
            this.tablePanel1.SetColumn(this.lookMoneda, 6);
            this.lookMoneda.Location = new System.Drawing.Point(821, 41);
            this.lookMoneda.Name = "lookMoneda";
            this.lookMoneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMoneda.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_mon", "id_mon", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Iso", "Iso"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Simbolo", "Simbolo")});
            this.tablePanel1.SetRow(this.lookMoneda, 1);
            this.lookMoneda.Size = new System.Drawing.Size(250, 20);
            this.lookMoneda.TabIndex = 24;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Seleccione una moneda";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.lookMoneda, conditionValidationRule1);
            this.lookMoneda.EditValueChanged += new System.EventHandler(this.lookMoneda_EditValueChanged);
            // 
            // lookCliente
            // 
            this.tablePanel1.SetColumn(this.lookCliente, 3);
            this.lookCliente.Location = new System.Drawing.Point(295, 41);
            this.lookCliente.Name = "lookCliente";
            this.lookCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookCliente.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_clie", "id_clie", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.tablePanel1.SetRow(this.lookCliente, 1);
            this.lookCliente.Size = new System.Drawing.Size(250, 20);
            this.lookCliente.TabIndex = 23;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Seleccione un cliente";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.lookCliente, conditionValidationRule2);
            // 
            // lookEmpleado
            // 
            this.tablePanel1.SetColumn(this.lookEmpleado, 9);
            this.lookEmpleado.Location = new System.Drawing.Point(1347, 7);
            this.lookEmpleado.Name = "lookEmpleado";
            this.lookEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookEmpleado.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", "Apellido"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_emp", "id_emp", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.tablePanel1.SetRow(this.lookEmpleado, 0);
            this.lookEmpleado.Size = new System.Drawing.Size(250, 20);
            this.lookEmpleado.TabIndex = 22;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Seleccione un empleado";
            conditionValidationRule3.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.lookEmpleado, conditionValidationRule3);
            // 
            // deFechaCredito
            // 
            this.tablePanel1.SetColumn(this.deFechaCredito, 6);
            this.deFechaCredito.EditValue = new System.DateTime(((long)(0)));
            this.deFechaCredito.Location = new System.Drawing.Point(821, 7);
            this.deFechaCredito.Name = "deFechaCredito";
            this.deFechaCredito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaCredito.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.deFechaCredito, 0);
            this.deFechaCredito.Size = new System.Drawing.Size(250, 20);
            this.deFechaCredito.TabIndex = 21;
            // 
            // CheckCredito
            // 
            this.tablePanel1.SetColumn(this.CheckCredito, 4);
            this.CheckCredito.Location = new System.Drawing.Point(550, 7);
            this.CheckCredito.Name = "CheckCredito";
            this.CheckCredito.Properties.Caption = "Credito";
            this.tablePanel1.SetRow(this.CheckCredito, 0);
            this.CheckCredito.Size = new System.Drawing.Size(250, 20);
            this.CheckCredito.TabIndex = 20;
            this.CheckCredito.CheckedChanged += new System.EventHandler(this.CheckCredito_CheckedChanged);
            // 
            // txtFactura
            // 
            this.tablePanel1.SetColumn(this.txtFactura, 3);
            this.txtFactura.Location = new System.Drawing.Point(295, 7);
            this.txtFactura.Name = "txtFactura";
            this.tablePanel1.SetRow(this.txtFactura, 0);
            this.txtFactura.Size = new System.Drawing.Size(250, 20);
            this.txtFactura.TabIndex = 19;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Ingrese un numero de factura";
            conditionValidationRule4.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information;
            this.vpValidar.SetValidationRule(this.txtFactura, conditionValidationRule4);
            // 
            // lblTotal
            // 
            this.tablePanel1.SetColumn(this.lblTotal, 8);
            this.lblTotal.Location = new System.Drawing.Point(1332, 44);
            this.lblTotal.Name = "lblTotal";
            this.tablePanel1.SetRow(this.lblTotal, 1);
            this.lblTotal.Size = new System.Drawing.Size(8, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Q";
            // 
            // lblMoneda
            // 
            this.tablePanel1.SetColumn(this.lblMoneda, 5);
            this.lblMoneda.Location = new System.Drawing.Point(806, 44);
            this.lblMoneda.Name = "lblMoneda";
            this.tablePanel1.SetRow(this.lblMoneda, 1);
            this.lblMoneda.Size = new System.Drawing.Size(8, 13);
            this.lblMoneda.TabIndex = 17;
            this.lblMoneda.Text = "Q";
            // 
            // btnEliminar
            // 
            this.tablePanel1.SetColumn(this.btnEliminar, 4);
            this.btnEliminar.Location = new System.Drawing.Point(550, 73);
            this.btnEliminar.Name = "btnEliminar";
            this.tablePanel1.SetRow(this.btnEliminar, 2);
            this.btnEliminar.Size = new System.Drawing.Size(250, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar seleccionado";
            this.btnEliminar.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnEditar
            // 
            this.tablePanel1.SetColumn(this.btnEditar, 3);
            this.btnEditar.Location = new System.Drawing.Point(295, 73);
            this.btnEditar.Name = "btnEditar";
            this.tablePanel1.SetRow(this.btnEditar, 2);
            this.btnEditar.Size = new System.Drawing.Size(250, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar seleccionado";
            this.btnEditar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnAgregar
            // 
            this.tablePanel1.SetColumn(this.btnAgregar, 1);
            this.btnAgregar.Location = new System.Drawing.Point(24, 73);
            this.btnAgregar.Name = "btnAgregar";
            this.tablePanel1.SetRow(this.btnAgregar, 2);
            this.btnAgregar.Size = new System.Drawing.Size(250, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 7);
            this.labelControl2.Location = new System.Drawing.Point(1077, 10);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Empleado:";
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // frmVentaMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1621, 758);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmVentaMant";
            this.Text = "frmVentaMant";
            this.Load += new System.EventHandler(this.frmVentaMant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMoneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCredito.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckCredito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.LabelControl lblTotal;
        private DevExpress.XtraEditors.LabelControl lblMoneda;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.LookUpEdit lookCliente;
        private DevExpress.XtraEditors.LookUpEdit lookEmpleado;
        private DevExpress.XtraEditors.DateEdit deFechaCredito;
        private DevExpress.XtraEditors.CheckEdit CheckCredito;
        private DevExpress.XtraEditors.TextEdit txtFactura;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        public DevExpress.XtraEditors.LookUpEdit lookMoneda;
    }
}