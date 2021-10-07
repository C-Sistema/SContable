namespace Base
{
    partial class frmVisor
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.pcFoto = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new DevExpress.XtraEditors.SimpleButton();
            this.vpValidar = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.ssm = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Base.frmWait), true, true);
            this.ofArchivo = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.xtraOpenFileDialog2 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(617, 636);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 49);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Text = "Borrar";

            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCargarImagen.Location = new System.Drawing.Point(418, 636);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(111, 49);
            this.btnCargarImagen.TabIndex = 59;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // pcFoto
   
            // btnAceptar
            // 
            this.btnAceptar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(233, 636);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(111, 49);
            this.btnAceptar.TabIndex = 61;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ssm
            // 
            this.ssm.ClosingDelay = 500;
            // 
            // ofArchivo
            // 
            this.ofArchivo.FileName = "ofArchivo";
            // 
            // xtraOpenFileDialog2
            // 
            this.xtraOpenFileDialog2.FileName = "xtraOpenFileDialog2";
            // 
            // frmVisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 731);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pcFoto);
            this.Name = "frmVisor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Visor de Imágenes";
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vpValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnCargarImagen;
        private DevExpress.XtraEditors.SimpleButton btnAceptar;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider vpValidar;
        private DevExpress.XtraSplashScreen.SplashScreenManager ssm;
        public System.Windows.Forms.PictureBox pcFoto;
        private DevExpress.XtraEditors.XtraOpenFileDialog ofArchivo;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog2;
    }
}