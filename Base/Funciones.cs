using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Base
{
    class Funciones
    {
        private string nombreSistema = "Frufisa";

        private int idEmpleado = 1;

        public string NombreSistema { get => nombreSistema; set => nombreSistema = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public Form MdiParent { get; private set; }

        public string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        internal void openWaitForm(object ssm)
        {
            throw new NotImplementedException();
        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }

        public void openWaitForm(DevExpress.XtraSplashScreen.SplashScreenManager ssm)
        {
            ssm.ShowWaitForm();
            ssm.SetWaitFormDescription("Espere un momento...");
            ssm.SetWaitFormCaption("Cargando");

        }
        public void openWaitForm(DevExpress.XtraSplashScreen.SplashScreenManager ssm, string mensaje)
        {
            ssm.ShowWaitForm();
            ssm.SetWaitFormDescription("Espere un momento...");
            ssm.SetWaitFormCaption(mensaje);

        }
        public void closeWaitForm(DevExpress.XtraSplashScreen.SplashScreenManager ssm)
        {
            ssm.CloseWaitForm();

        }

        //Fotografias
        public byte[] ImgToDatabase(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;

        }
        public Image DatabaseToImg(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }
        public Image ResizeImage(Image oldImage, int targetSize)
        {
            Size newSize = CalculateDimensions(oldImage.Size, targetSize);
            return oldImage.GetThumbnailImage(newSize.Width, newSize.Height, () => false, IntPtr.Zero);
        }
        private Size CalculateDimensions(Size oldSize, int targetSize)
        {
            Size newSize = new Size();

            if (oldSize.Height > oldSize.Width)
            {
                newSize.Width = (int)(oldSize.Width * ((float)targetSize / (float)oldSize.Height));
                newSize.Height = targetSize;
            }

            else
            {
                newSize.Width = targetSize;
                newSize.Height = (int)(oldSize.Height * ((float)targetSize / (float)oldSize.Width));
            }

            return newSize;
        }

        private void Totales(GridView gv, string nombreCol)
        {
            gv.Columns[nombreCol].Summary.Clear();
            GridColumnSummaryItem sSuma = new GridColumnSummaryItem();
            sSuma.SummaryType = SummaryItemType.Sum;
            sSuma.FieldName = nombreCol;
            sSuma.DisplayFormat = "SUMA: {0:c2}";

            //agrega sumatoria al final de la columna
            gv.Columns[nombreCol].Summary.Add(sSuma);
        }

        public void SimboloQ(GridView gv, string nombreCol)
        {

            gv.Columns[nombreCol].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv.Columns[nombreCol].DisplayFormat.FormatString = "c2";
            gv.Columns[nombreCol].BestFit();

        }

        public void SimboloP(GridView gv, string nombreCol)
        {

            gv.Columns[nombreCol].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gv.Columns[nombreCol].DisplayFormat.FormatString = "p2";
            gv.Columns[nombreCol].BestFit();


        }

        // FUNCION DE OCULTAR COLUMNA MEJORADA// 2.0



        public void ocultarColumnas(GridControl gc, GridView gv)
        {
            DataTable prueba = new DataTable();
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].FieldName.Contains("id_"))
                {
                    gv.Columns[i].Visible = false;
                }
                string nuevo = "";
                string nombre = "";

                if (gv.Columns[i].FieldName.Contains("_") && gv.Columns[i].Visible == true)
                {
                    nombre = gv.Columns[i].FieldName;
                    for (int x = 0; x < nombre.Count(); x++)
                    {
                        if (Convert.ToString(nombre[x]) != "_")
                        {
                            nuevo = nuevo + nombre[x];
                        }
                        if (Convert.ToString(nombre[x]) == "_")
                        {
                            nuevo = nuevo + " ";
                        }
                    }
                    if (nuevo == "Saldo GT")
                    {
                        nuevo = "Saldo Q.";
                    }
                    else if (nuevo == "Saldo CR")
                    {
                        nuevo = "Saldo ₡.";
                    }
                    else if (nuevo == "Saldo US")
                    {
                        nuevo = "Saldo $.";
                    }
                    else if (nuevo == "Telefono 1")
                    {
                        nuevo = "Telefono (1)";
                    }
                    else if (nuevo == "Telefono 2")
                    {
                        nuevo = "Telefono (2)";
                    }

                    prueba.Columns.Add(nuevo);
                }
                else
                {
                    nuevo = gv.Columns[i].FieldName;
                    prueba.Columns.Add(nuevo);
                }
            }
            for (int x = 0; x < gv.RowCount; x++)
            {
                prueba.Rows.Add();
                for (int y = 0; y < gv.Columns.Count; y++)
                {
                    prueba.Rows[x][y] =  gv.GetRowCellValue(x, gv.Columns[y].FieldName);
                }
            }
            gv.Columns.Clear();
            gc.DataSource = null;
            gc.DataSource = prueba;
            gc.Refresh();
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].FieldName.Contains("id_"))
                {
                    gv.Columns[i].Visible = false;
                }
            }
        }
        // esta funcion se usaba con aterioridad solo para ocultar los id_

        public void ocultarColumnas2(GridView gv)
        {
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].FieldName.Contains("id_") || gv.Columns[i].FieldName.Contains("C_"))
                {
                    gv.Columns[i].Visible = false;
                }

            }
        }
        public void Cambiarguion(GridView gv)
        {
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].FieldName.Contains("_"))
                {
                    string[] valores;
                    valores = new string[20];
                    valores[i] = gv.Columns[i].FieldName;
                    gv.Columns[i].Visible = false;
                }
            }
        }


        public void ocultarColumnas(GridView gv, string col)
        {
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].FieldName.Equals(col))
                {
                    gv.Columns[i].Visible = false;
                }
            }
        }
  

        public string direccionMac()
        {
            ManagementClass management =
                 new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection adapters = management.GetInstances();

            List<string> macs = new List<string>();
            foreach (ManagementObject adapter in adapters)
            {
                bool isIpEnabled = (bool)(adapter["IPEnabled"] ?? false);
                if (isIpEnabled)
                    macs.Add(adapter["MacAddress"] as string);
                adapter.Dispose();
            }

            return macs[0].ToString();

        }

        public byte[] fileToByte(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            
            // Create a byte array of file stream length
            byte[] bytes = System.IO.File.ReadAllBytes(filename);
            //Read block of bytes from stream into the byte array
            fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
            //Close the File Stream
            fs.Close();
            return bytes; //return the byte data

        }

        //public MemoryStream byteToFile(byte[] archivo)
        //{


        //}
      
        public Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public class DatosMaestroDetalle
        {
            public int No { get; set; }
            public string Producto { get; set; }
            public string Tamaño { get; set; }
            public string Presentacion { get; set; }
            public int Cantidad  { get; set; }
            public float PrecioU { get; set; }

            public int PrecioT { get; set; }

        }
        
    }
}
