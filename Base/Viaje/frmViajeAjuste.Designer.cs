
namespace Base.Viaje
{
    partial class frmViajeAjuste
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookDescripcion = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDes = new DevExpress.XtraEditors.TextEdit();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.listItem = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70.02F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.18F)});
            this.tablePanel1.Controls.Add(this.listItem);
            this.tablePanel1.Controls.Add(this.txtCantidad);
            this.tablePanel1.Controls.Add(this.txtDes);
            this.tablePanel1.Controls.Add(this.lookDescripcion);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 34.64F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.96F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 46.4F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(610, 181);
            this.tablePanel1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(22, 41);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 1);
            this.labelControl3.Size = new System.Drawing.Size(58, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Descripcion:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(22, 121);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(129, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Incrementar/Decrementar:";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(22, 78);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cantidad:";
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75.8F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 70.02F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 9.18F)});
            this.tablePanel2.Controls.Add(this.simpleButton5);
            this.tablePanel2.Controls.Add(this.simpleButton4);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 181);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(610, 84);
            this.tablePanel2.TabIndex = 1;
            // 
            // simpleButton5
            // 
            this.tablePanel2.SetColumn(this.simpleButton5, 2);
            this.simpleButton5.Location = new System.Drawing.Point(311, 7);
            this.simpleButton5.Name = "simpleButton5";
            this.tablePanel2.SetRow(this.simpleButton5, 0);
            this.simpleButton5.Size = new System.Drawing.Size(261, 43);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Cancelar";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.tablePanel2.SetColumn(this.simpleButton4, 1);
            this.simpleButton4.Location = new System.Drawing.Point(22, 8);
            this.simpleButton4.Name = "simpleButton4";
            this.tablePanel2.SetRow(this.simpleButton4, 0);
            this.simpleButton4.Size = new System.Drawing.Size(283, 41);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Aceptar";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(22, 8);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 0);
            this.labelControl4.Size = new System.Drawing.Size(47, 13);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "Producto:";
            // 
            // lookDescripcion
            // 
            this.tablePanel1.SetColumn(this.lookDescripcion, 2);
            this.lookDescripcion.Location = new System.Drawing.Point(311, 4);
            this.lookDescripcion.Name = "lookDescripcion";
            this.lookDescripcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookDescripcion.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_lot", "id_lot", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Producto", "Producto"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Tamaño", "Tamaño"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Presentación", "Presentación"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Comprado", "Comprado")});
            this.tablePanel1.SetRow(this.lookDescripcion, 0);
            this.lookDescripcion.Size = new System.Drawing.Size(261, 20);
            this.lookDescripcion.TabIndex = 12;
            // 
            // txtDes
            // 
            this.tablePanel1.SetColumn(this.txtDes, 2);
            this.txtDes.Location = new System.Drawing.Point(311, 38);
            this.txtDes.Name = "txtDes";
            this.tablePanel1.SetRow(this.txtDes, 1);
            this.txtDes.Size = new System.Drawing.Size(261, 20);
            this.txtDes.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.tablePanel1.SetColumn(this.txtCantidad, 2);
            this.txtCantidad.Location = new System.Drawing.Point(311, 74);
            this.txtCantidad.Name = "txtCantidad";
            this.tablePanel1.SetRow(this.txtCantidad, 2);
            this.txtCantidad.Size = new System.Drawing.Size(261, 20);
            this.txtCantidad.TabIndex = 14;
            // 
            // listItem
            // 
            this.tablePanel1.SetColumn(this.listItem, 2);
            this.listItem.Items.AddRange(new object[] {
            "Incrementar",
            "Decrementar"});
            this.listItem.Location = new System.Drawing.Point(311, 105);
            this.listItem.Name = "listItem";
            this.tablePanel1.SetRow(this.listItem, 3);
            this.listItem.Size = new System.Drawing.Size(261, 45);
            this.listItem.TabIndex = 15;
            // 
            // frmViajeAjuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 265);
            this.Controls.Add(this.tablePanel2);
            this.Controls.Add(this.tablePanel1);
            this.Name = "frmViajeAjuste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViajeAjuste";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ListBoxControl listItem;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.TextEdit txtDes;
        private DevExpress.XtraEditors.LookUpEdit lookDescripcion;
    }
}