
namespace Base
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.lblInformacion = new DevExpress.XtraEditors.LabelControl();
            this.lblRecuperarcontra = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 3.7F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 101.52F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4.78F)});
            this.tablePanel2.Controls.Add(this.lblInformacion);
            this.tablePanel2.Controls.Add(this.lblRecuperarcontra);
            this.tablePanel2.Controls.Add(this.simpleButton1);
            this.tablePanel2.Controls.Add(this.txtPass);
            this.tablePanel2.Controls.Add(this.txtUsuario);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel2.Location = new System.Drawing.Point(0, 114);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.83F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 18.17F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.2F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.8F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(430, 345);
            this.tablePanel2.TabIndex = 1;
            // 
            // lblInformacion
            // 
            this.tablePanel2.SetColumn(this.lblInformacion, 1);
            this.lblInformacion.Location = new System.Drawing.Point(17, 38);
            this.lblInformacion.Name = "lblInformacion";
            this.tablePanel2.SetRow(this.lblInformacion, 1);
            this.lblInformacion.Size = new System.Drawing.Size(63, 13);
            this.lblInformacion.TabIndex = 10;
            this.lblInformacion.Text = "labelControl4";
            this.lblInformacion.Visible = false;
            // 
            // lblRecuperarcontra
            // 
            this.tablePanel2.SetColumn(this.lblRecuperarcontra, 1);
            this.lblRecuperarcontra.Location = new System.Drawing.Point(17, 295);
            this.lblRecuperarcontra.Name = "lblRecuperarcontra";
            this.tablePanel2.SetRow(this.lblRecuperarcontra, 7);
            this.lblRecuperarcontra.Size = new System.Drawing.Size(107, 13);
            this.lblRecuperarcontra.TabIndex = 9;
            this.lblRecuperarcontra.Text = "Recuperar contraseña";
            // 
            // simpleButton1
            // 
            this.tablePanel2.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(17, 236);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel2.SetRow(this.simpleButton1, 6);
            this.simpleButton1.Size = new System.Drawing.Size(391, 42);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Iniciar sesión";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel2.SetColumn(this.txtPass, 1);
            this.txtPass.Location = new System.Drawing.Point(17, 190);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPass.Properties.Appearance.Options.UseFont = true;
            this.txtPass.Properties.PasswordChar = '*';
            this.tablePanel2.SetRow(this.txtPass, 5);
            this.txtPass.Size = new System.Drawing.Size(391, 26);
            this.txtPass.TabIndex = 7;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtUsuario
            // 
            this.tablePanel2.SetColumn(this.txtUsuario, 1);
            this.txtUsuario.Location = new System.Drawing.Point(17, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.tablePanel2.SetRow(this.txtUsuario, 3);
            this.txtUsuario.Size = new System.Drawing.Size(391, 20);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.tablePanel2.SetColumn(this.labelControl3, 1);
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 3);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(160, 29);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Iniciar sesión";
            // 
            // labelControl2
            // 
            this.tablePanel2.SetColumn(this.labelControl2, 1);
            this.labelControl2.Location = new System.Drawing.Point(17, 153);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 4);
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Contraseña:";
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 1);
            this.labelControl1.Location = new System.Drawing.Point(17, 65);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 2);
            this.labelControl1.Size = new System.Drawing.Size(94, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nombre de usuario:";
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 6.58F)});
            this.tablePanel1.Controls.Add(this.pictureEdit1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(430, 114);
            this.tablePanel1.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = global::Base.Properties.Resources.Imagen11;
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.pictureEdit1, 0);
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.tablePanel1.SetRow(this.pictureEdit1, 0);
            this.pictureEdit1.Size = new System.Drawing.Size(424, 108);
            this.pictureEdit1.TabIndex = 0;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 459);
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.tablePanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Enter += new System.EventHandler(this.frmLogin_Enter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.HyperlinkLabelControl lblRecuperarcontra;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblInformacion;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}