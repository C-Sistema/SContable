using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core.Objects;
using Base.BD;

namespace Base.Usuario
{
    public partial class frmModuloMant : DevExpress.XtraEditors.XtraForm
    {
        Funciones fc = new Funciones();
        string id = null;
        Image reciboluzImg;
        Image dpiImg;
        bool bandera;

        public frmModuloMant(string id = null)
        {
            InitializeComponent();
            bandera = true;
            if (id != null)
            {
                this.id = id;
                cargarDatos();

                bandera = false;
            }
        }
        private void cargarDatos()
        {
            try
            {
                fc.openWaitForm(ssm);
                using (DBSistemaContable db = new DBSistemaContable())
                {
                    DataTable valores = new DataTable();
                    var datos = db.pac_modulo_2(id, "", "", "").ToArray();

                    txtNombre.EditValue = datos[0].Modulo;
                    txtModPos.EditValue = datos[0].Posicion;


                }
                fc.closeWaitForm(ssm);
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show(this, ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            using (DBSistemaContable db = new DBSistemaContable())
            {
                using (var dbTransaccion = db.Database.BeginTransaction())
                {
                    try
                    {
                        ObjectParameter ban = new ObjectParameter("ban", 0);
                        ObjectParameter res = new ObjectParameter("res", "");
                        if (id == null)
                        {
                            fc.openWaitForm(ssm);
                            //agregamos pam para insertar
                            db.pam_modulo(1, null, txtNombre.Text, Convert.ToByte(txtModPos.Text), ban, res);
                            fc.closeWaitForm(ssm);
                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (ban.Value.ToString() == "1")
                            {

                                this.Close();
                            }
                        }
                        else
                        {
                            fc.openWaitForm(ssm);

                            db.pam_modulo(2, Convert.ToUInt16(id), txtNombre.Text, Convert.ToByte(txtModPos.Text), ban, res);

                            fc.closeWaitForm(ssm);
                            XtraMessageBox.Show(this, res.Value.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (ban.Value.ToString() == "1")
                            {

                                this.Close();
                            }
                        }
                        dbTransaccion.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbTransaccion.Rollback();
                        XtraMessageBox.Show(ex.ToString(), fc.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

