using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;

namespace RemziCicek
{
    public partial class frmMagazaKotaRaporu : DevExpress.XtraEditors.XtraForm
    {
        public frmMagazaKotaRaporu()
        {
            InitializeComponent();
        }

        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        string rootPath1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);// "c:\\Siparisler";
        private BackgroundWorker _backgroundWorker;
        private ManualResetEvent _workerCompletedEvent = new ManualResetEvent(false);
        private void executeBackground(Action doWorkAction, Action progressAction = null, Action completedAction = null)
        {
            try
            {
                if (_backgroundWorker != null)
                {
                    if (_backgroundWorker.IsBusy)
                    {
                        return;
                    }
                }
                _backgroundWorker = new BackgroundWorker
                {
                    WorkerSupportsCancellation = true
                };
                _backgroundWorker.DoWork += (x, y) =>
                {
                    try
                    {
                        doWorkAction.Invoke();
                    }
                    catch (Exception ex)
                    {
                        y.Cancel = true;
                        XtraMessageBox.Show("Bilinmeyen Hata. Detay : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // throw;
                    }
                };
                if (progressAction != null)
                {
                    _backgroundWorker.ProgressChanged += (x, y) =>
                    {
                        progressAction.Invoke();
                    };
                }
                if (completedAction != null)
                {
                    _backgroundWorker.RunWorkerCompleted += (x, y) =>
                    {
                        completedAction.Invoke();
                    };
                }
                this.Enabled = false;
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception)
            {

            }

        }
        private void completeProgress()
        {
            try
            {
                _backgroundWorker.Dispose();
                _backgroundWorker = null;
                if (!this.Enabled)
                {
                    this.Enabled = true;
                }

            }
            finally
            {
                //this.Cursor = Cursors.Default;
                _workerCompletedEvent.Set();

            }
        }
        private void directoryCreator(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        string dosyaadi = "";
        DataTable dtYear = new DataTable();
        string magaza = "";
        DataTable MGZ = new DataTable();
        private void frmKotaRaporu_Load(object sender, EventArgs e)
        {
            dtYear.Columns.Add("Yil", typeof(int));

            for (int i = 0; i < 3; i++)
            {
                dtYear.Rows.Add(DateTime.Now.AddYears(i * -1).Year);
            }

            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";

            SqlDataAdapter day = new SqlDataAdapter("select SATGMMONTH, SATGMMONTHNAME from SALTARGETMONTH", sql);
            DataTable dtMonths = new DataTable();
            day.Fill(dtMonths);            
            srcAy.Properties.DataSource = dtMonths;
            srcAy.Properties.DisplayMember = "SATGMMONTHNAME";
            srcAy.Properties.ValueMember = "SATGMMONTH";

            SqlDataAdapter dab = new SqlDataAdapter("select distinct DIVREGION from DIVISON where DIVREGION is not NULL", sql);
            DataTable dtb = new DataTable();
            dab.Fill(dtb);
            srcBolge.Properties.DataSource = dtb;
            srcBolge.Properties.DisplayMember = "DIVREGION";
            srcBolge.Properties.ValueMember = "DIVREGION";

            SqlDataAdapter da = new SqlDataAdapter($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", sql);
            DataTable dt = new DataTable();
            da.Fill(MGZ);
            srcMagaza.Properties.DataSource = MGZ;
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
        }

        private void btnListesi_Click(object sender, EventArgs e)
        {
            string q = @"select * from (
            select DIVVAL,DIVNAME,DIVREGION,'Ana Kotası' as SMENVAL,DIVMDRNAME as SMENNAME,SATGYYEAR,SATGMMONTH,SATGMMONTHNAME,SATGDIAMOUNT,SATGDIRATE from (
            select DIVISON.DIVVAL,DIVREGION,DIVISON.DIVNAME,yil.SATGYYEAR,ay.SATGMMONTH,DIVMDRNAME,ay.SATGMMONTHNAME from [W].[Yonavm_Web_Siparis].[dbo].[VolantMagazaIletisim] i
            left outer join DIVISON DIVISON on DIVISON.DIVVAL = i.DIVVAL
            outer apply (select * from SATGYYEAR) yil
            outer apply (select * from SALTARGETMONTH) ay 
            where DIVSALESTS = 1 and DIVSTS = 1 and DIVISON.DIVVAL not in ('00','WB')) magaza
            outer apply (select SATGDIAMOUNT,SATGDIRATE from SALTARGETDIVISON where SATGDIDIVISON = magaza.DIVVAL and SATGDIYEAR = magaza.SATGYYEAR and SATGDIMONTH = magaza.SATGMMONTH) kota
            ) sonuc
            where 1=1 "; 

            if(srcYil.EditValue != null)
            {
                q = q + String.Format(@" and SATGYYEAR = '{0}'", srcYil.EditValue.ToString());
            }
            else
            {
                q = q + " and SATGSAYEAR = YEAR(getdate()))";
            }
            if(srcAy.EditValue != null)
            {
                q = q + String.Format(@" and SATGMMONTH = '{0}'", srcAy.EditValue.ToString());
            }
            else
            {
                q = q + " and SATGMMONTH = MONTH(getdate())) kota";
            }
            if (srcBolge.EditValue != null)
            {
                q = q + String.Format(@" where DIVREGION = '{0}'", srcBolge.EditValue.ToString());
            }
            if (srcMagaza.EditValue != null)
            {
                q = q + String.Format(@" and DIVVAL = '{0}'", srcMagaza.EditValue.ToString());
            }
            
            q = q + @" order by 2,3,1";
            SqlDataAdapter da = new SqlDataAdapter(q, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridKotaListesi.DataSource = dt;
            btnGuncelle.Enabled = true;
        }
        
        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            gridKotaListesi.DataSource = null;
            btnGuncelle.Enabled = false;
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (srcMagaza.EditValue != null)
            {
                dosyaadi = srcMagaza.EditValue.ToString();
            }
            else
            {
                if (srcBolge.EditValue != null)
                {
                    dosyaadi = srcBolge.EditValue.ToString();
                }
                else
                {
                    dosyaadi = "Tüm Bölgelerdeki Tüm Mağazalar";
                }
            }
            string subPathXSLT = rootPath1 + @"\\Mağaza Personel Listeleri\";
            //Directory.Delete(subPathXSLT);
            directoryCreator(subPathXSLT);
            var isim = subPathXSLT + @"\\" + dosyaadi;
            string path = isim.Replace("/", "-") + ".xlsx";
            gridKotaListesi.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
            btnMagazaYeni_Click(null, null);
        }

        private void srcBolge_EditValueChanged(object sender, EventArgs e)
        {
            srcMagaza.Properties.DataSource = null;
            MGZ.Clear();
            string query;
            if (srcBolge.EditValue == null)
            {
                query = $"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1";
            }
            else
            {
                query = $"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcBolge.EditValue.ToString()}'";
            }
            SqlDataAdapter da = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            da.Fill(MGZ);
            srcMagaza.Properties.DataSource = MGZ;
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
        }
    }
}