
namespace Base.Partida
{
    partial class frmPartidasMant
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
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditarSelecionado = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminarDetalle = new DevExpress.XtraEditors.SimpleButton();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.txtHaber = new DevExpress.XtraEditors.TextEdit();
            this.txtDebe = new DevExpress.XtraEditors.TextEdit();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtPartida = new DevExpress.XtraEditors.TextEdit();
            this.txtFolio = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHaber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 77.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 79.07F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3F)});
            this.tablePanel2.Controls.Add(this.simpleButton2);
            this.tablePanel2.Controls.Add(this.simpleButton1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel2.Location = new System.Drawing.Point(0, 697);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 40.28F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12F)});
            this.tablePanel2.Size = new System.Drawing.Size(1654, 61);
            this.tablePanel2.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.tablePanel2.SetColumn(this.simpleButton2, 2);
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(823, 5);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel2.SetRow(this.simpleButton2, 0);
            this.simpleButton2.Size = new System.Drawing.Size(798, 37);
            this.simpleButton2.TabIndex = 44;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.tablePanel2.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(32, 6);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel2.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(787, 35);
            this.simpleButton1.TabIndex = 43;
            this.simpleButton1.Text = "Aceptar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tablePanel4
            // 
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20.4F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 116.22F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26.71F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.5F)});
            this.tablePanel4.Controls.Add(this.simpleButton3);
            this.tablePanel4.Controls.Add(this.btnEditarSelecionado);
            this.tablePanel4.Controls.Add(this.btnEliminarDetalle);
            this.tablePanel4.Controls.Add(this.txtDescripcion);
            this.tablePanel4.Controls.Add(this.labelControl6);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel4.Location = new System.Drawing.Point(0, 61);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 41.76F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.45F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 34.79F)});
            this.tablePanel4.Size = new System.Drawing.Size(1654, 104);
            this.tablePanel4.TabIndex = 4;
            // 
            // simpleButton3
            // 
            this.tablePanel4.SetColumn(this.simpleButton3, 0);
            this.simpleButton3.Location = new System.Drawing.Point(3, 7);
            this.simpleButton3.Name = "simpleButton3";
            this.tablePanel4.SetRow(this.simpleButton3, 0);
            this.simpleButton3.Size = new System.Drawing.Size(197, 23);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Agregar";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btnEditarSelecionado
            // 
            this.tablePanel4.SetColumn(this.btnEditarSelecionado, 0);
            this.btnEditarSelecionado.Enabled = false;
            this.btnEditarSelecionado.Location = new System.Drawing.Point(3, 44);
            this.btnEditarSelecionado.Name = "btnEditarSelecionado";
            this.tablePanel4.SetRow(this.btnEditarSelecionado, 1);
            this.btnEditarSelecionado.Size = new System.Drawing.Size(197, 23);
            this.btnEditarSelecionado.TabIndex = 3;
            this.btnEditarSelecionado.Text = "Editar seleccionado";
            this.btnEditarSelecionado.Click += new System.EventHandler(this.btnEditarSelecionado_Click);
            // 
            // btnEliminarDetalle
            // 
            this.tablePanel4.SetColumn(this.btnEliminarDetalle, 0);
            this.btnEliminarDetalle.Enabled = false;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(3, 77);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.tablePanel4.SetRow(this.btnEliminarDetalle, 2);
            this.btnEliminarDetalle.Size = new System.Drawing.Size(197, 23);
            this.btnEliminarDetalle.TabIndex = 2;
            this.btnEliminarDetalle.Text = "Eliminar seleccionado";
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // txtDescripcion
            // 
            this.tablePanel4.SetColumn(this.txtDescripcion, 1);
            this.txtDescripcion.Location = new System.Drawing.Point(206, 41);
            this.txtDescripcion.MaxLength = 300;
            this.txtDescripcion.Name = "txtDescripcion";
            this.tablePanel4.SetRow(this.txtDescripcion, 1);
            this.txtDescripcion.Size = new System.Drawing.Size(1153, 29);
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.Text = "";
            // 
            // labelControl6
            // 
            this.tablePanel4.SetColumn(this.labelControl6, 1);
            this.labelControl6.Location = new System.Drawing.Point(206, 12);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel4.SetRow(this.labelControl6, 0);
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Descripción ";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.txtHaber);
            this.tablePanel1.Controls.Add(this.txtDebe);
            this.tablePanel1.Controls.Add(this.deFecha);
            this.tablePanel1.Controls.Add(this.txtPartida);
            this.tablePanel1.Controls.Add(this.txtFolio);
            this.tablePanel1.Controls.Add(this.labelControl5);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel1.Size = new System.Drawing.Size(1654, 61);
            this.tablePanel1.TabIndex = 3;
            // 
            // txtHaber
            // 
            this.tablePanel1.SetColumn(this.txtHaber, 4);
            this.txtHaber.Location = new System.Drawing.Point(830, 33);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Properties.Mask.EditMask = "n2";
            this.txtHaber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtHaber, 1);
            this.txtHaber.Size = new System.Drawing.Size(261, 20);
            this.txtHaber.TabIndex = 9;
            // 
            // txtDebe
            // 
            this.tablePanel1.SetColumn(this.txtDebe, 2);
            this.txtDebe.Location = new System.Drawing.Point(296, 33);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Properties.Mask.EditMask = "n2";
            this.txtDebe.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tablePanel1.SetRow(this.txtDebe, 1);
            this.txtDebe.Size = new System.Drawing.Size(261, 20);
            this.txtDebe.TabIndex = 8;
            // 
            // deFecha
            // 
            this.tablePanel1.SetColumn(this.deFecha, 6);
            this.deFecha.EditValue = null;
            this.deFecha.Location = new System.Drawing.Point(1364, 3);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.deFecha, 0);
            this.deFecha.Size = new System.Drawing.Size(261, 20);
            this.deFecha.TabIndex = 7;
            // 
            // txtPartida
            // 
            this.tablePanel1.SetColumn(this.txtPartida, 4);
            this.txtPartida.Location = new System.Drawing.Point(830, 3);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Properties.Mask.EditMask = "000000000";
            this.txtPartida.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPartida.Properties.MaxLength = 999999999;
            this.tablePanel1.SetRow(this.txtPartida, 0);
            this.txtPartida.Size = new System.Drawing.Size(261, 20);
            this.txtPartida.TabIndex = 6;
            // 
            // txtFolio
            // 
            this.tablePanel1.SetColumn(this.txtFolio, 2);
            this.txtFolio.Location = new System.Drawing.Point(296, 3);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Properties.Mask.EditMask = "0000";
            this.txtFolio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFolio.Properties.MaxLength = 9999;
            this.tablePanel1.SetRow(this.txtFolio, 0);
            this.txtFolio.Size = new System.Drawing.Size(261, 20);
            this.txtFolio.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.tablePanel1.SetColumn(this.labelControl5, 3);
            this.labelControl5.Location = new System.Drawing.Point(563, 37);
            this.labelControl5.Name = "labelControl5";
            this.tablePanel1.SetRow(this.labelControl5, 1);
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Total haber";
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 1);
            this.labelControl4.Location = new System.Drawing.Point(30, 37);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 1);
            this.labelControl4.Size = new System.Drawing.Size(55, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Total debe:";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 5);
            this.labelControl3.Location = new System.Drawing.Point(1097, 6);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(33, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Fecha:";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 3);
            this.labelControl2.Location = new System.Drawing.Point(563, 6);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(93, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Número de partida:";
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(30, 6);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Número de folio:";
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 2.04F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 108.68F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1.76F)});
            this.tablePanel3.Controls.Add(this.gridControl1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(0, 165);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.4F)});
            this.tablePanel3.Size = new System.Drawing.Size(1654, 532);
            this.tablePanel3.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.tablePanel3.SetColumn(this.gridControl1, 1);
            this.gridControl1.Location = new System.Drawing.Point(33, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.tablePanel3.SetRow(this.gridControl1, 0);
            this.gridControl1.Size = new System.Drawing.Size(1592, 526);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // frmPartidasMant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1654, 758);
            this.Controls.Add(this.tablePanel3);
            this.Controls.Add(this.tablePanel4);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tablePanel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPartidasMant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPartidasMant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHaber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPartida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFolio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private DevExpress.XtraEditors.TextEdit txtHaber;
        private DevExpress.XtraEditors.TextEdit txtDebe;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.TextEdit txtPartida;
        private DevExpress.XtraEditors.TextEdit txtFolio;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnEditarSelecionado;
        private DevExpress.XtraEditors.SimpleButton btnEliminarDetalle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}