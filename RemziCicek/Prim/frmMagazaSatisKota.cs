using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek.Prim
{
    public partial class frmMagazaSatisKota : Form
    {
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        public frmMagazaSatisKota()
        {
            InitializeComponent();
        }

        DataTable dtYear = new DataTable();
        DataTable dtMonths = new DataTable();
        private void frmMagazaSatisKota_Load(object sender, EventArgs e)
        {
            dtMonths.Columns.Add("AY", typeof(string));
            dtMonths.Columns.Add("ayi", typeof(int));

            dtYear.Columns.Add("Yil", typeof(int));

            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < 12; i++)
            {
                dtMonths.Rows.Add(monthNames[i], i + 1);
            }
            for (int i = 0; i < 3; i++)
            {
                dtYear.Rows.Add(DateTime.Now.AddYears(i * -1).Year);
            }
            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";


            srcAy.Properties.DataSource = dtMonths;
            srcAy.Properties.DisplayMember = "AY";
            srcAy.Properties.ValueMember = "ayi";

            SqlDataAdapter da = new SqlDataAdapter($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            srcMagaza.Properties.DataSource = dt;
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
        }

        private void btnPrimListesi_Click(object sender, EventArgs e)
        {
            string magaza = "";
            bool kumu;
            string yil = DateTime.Now.Year.ToString();
            string ay = DateTime.Now.Month.ToString();
            if (srcYil.EditValue != null)
            {
                yil = srcYil.EditValue.ToString();
            }
            if (srcAy.EditValue != null)
            {
                ay = srcAy.EditValue.ToString();
            }
            if (srcMagaza.EditValue != null)
            {
                magaza = srcMagaza.EditValue.ToString();
            }
            if (tglDetay.IsOn)
            {
                kumu = true;
            }
            else
            {
                kumu = false;
            }
            int yyyy = int.Parse(yil);
            int mm = int.Parse(ay);
            DateTime bas = new DateTime(yyyy, mm, 1);
            string btarih = bas.ToString("yyyy-MM-dd");
            string bit = new DateTime(bas.Year, bas.Month, 1).AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
            string q = string.Format("exec Fk_sp_calculate_bonus2 '{0}','{1}','{2}','{3}'", magaza, btarih, bit, kumu);
            SqlDataAdapter da = new SqlDataAdapter(q, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPrim.DataSource = dt;
            dosyaadi = bas.ToString("yyyy-MM-dd") + " Prim Listesi";
        }
        string rootPath1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// "c:\\Siparisler";
        private void directoryCreator(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        string dosyaadi = "";

        private void btnPrimExcel_Click(object sender, EventArgs e)
        {
            string subPathXSLT = rootPath1 + @"\\Mağaza Personel Listeleri\";
            //Directory.Delete(subPathXSLT);
            directoryCreator(subPathXSLT);
            var isim = subPathXSLT + @"\\" + dosyaadi;
            string path = isim.Replace("/", "-") + ".xlsx";
            gridPrim.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);

        }
    }
}
