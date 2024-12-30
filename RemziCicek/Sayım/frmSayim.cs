using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek
{
    public partial class frmSayim : XtraForm
    {
        SqlConnectionObject conn = new SqlConnectionObject();
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        public frmSayim()
        {
            try
            {
                SplashScreen();
                InitializeComponent();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 300, this);
            }
        }
        private void MGZ()
        {
            srcMagaza.Properties.DataSource = conn.GetData(@"select DIVVAL,DIVNAME,DIVREGION from DIVISON
            where DIVSTS = 1
            and exists(select * from CENSUS
                       inner join DEFSTORAGE on DSTORID = CENSTORID
                        where DSTORVAL = DIVVAL
                        and CENCONFIRM = 0
                        and CENDATE >= GETDATE() - 1) 
            order by 2", sql);
            srcMagaza.Properties.ValueMember = "DIVVAL";
            srcMagaza.Properties.DisplayMember = "DIVNAME";
        }
        void SplashScreen()
        {
            FluentSplashScreenOptions splashScreen = new FluentSplashScreenOptions();
            splashScreen.Title = "YÖN AVM";
            splashScreen.Subtitle = "YÖN avm® Volant İşlem Düzeltme";
            splashScreen.RightFooter = "Başlıyor...";
            splashScreen.LeftFooter = $"CopyRight ® 2024 {Environment.NewLine} Tüm Hahkları Saklıdır.";
            splashScreen.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            splashScreen.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);
            splashScreen.Opacity = 90;
            splashScreen.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(splashScreen, parentForm: this, useFadeIn: true, useFadeOut: true);
        }
        //arka plan işlemleri
        private BackgroundWorker _backgroundWorker;
        private ManualResetEvent _workerCompletedEvent = new ManualResetEvent(false);
        private const string READY_TEXT = "Hazır";
        private void executeBackground(Action doWorkAction, Action progressAction = null, Action completedAction = null)
        {
            try
            {
                if (_backgroundWorker != null)
                {


                    if (_backgroundWorker.IsBusy)
                    {
                        XtraMessageBox.Show("Her oturum açıldığında 1 işlem yapacak. Eğer bu girişteki ilk işlemse uygulama çalışmaktadır. Lütfen Bekleyiniz");
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
        private void CreateDirectoryIfNotExists(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                    MessageBox.Show($"'{directoryPath}' dizini oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{directoryPath}' dizini oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmSayim_Load(object sender, EventArgs e)
        {
            MGZ();
            ViewRapor.Columns["PROUNAME"].GroupIndex = 0;

            // Expand all groups 
            ViewRapor.ExpandAllGroups();
        }

        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            string q = String.Format(@"select PROUNAME,DSTORID,PROVAL,PRONAME,sum(CENCHQUAN) as SAYILAN from CENSUS
                LEFT OUTER JOIN DEFSTORAGE ON DSTORID=CENSTORID 
                LEFT OUTER JOIN DIVISON on DIVVAL = DSTORDIVISON
                LEFT OUTER JOIN CENSUSCHILD on CENID = CENCHCENID
				LEFT OUTER JOIN PRODUCTS on PROID = CENCHPROID
				LEFT OUTER JOIN PRODUCTSUNITED ON PROUID = PROPROUID
                where DIVVAL in ('WB') and DATEPART(YYYY,CENDATE) = DATEPART(YYYY,GETDATE())
	            and CENCONFIRM = 0
                group by PROUNAME,DSTORID,PROVAL,PRONAME", srcMagaza.EditValue);
            gridRapor.DataSource = conn.GetData(q, sql);
            ViewRapor.OptionsView.BestFitMaxRowCount = -1;
            ViewRapor.BestFitColumns(true);
            tileBarItem2.Enabled = true;
            tileBarItem3.Enabled = true;
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Sayım Sonucu", srcMagaza.SelectedText);
            CreateDirectoryIfNotExists(path);
            string file = Path.Combine(path, srcMagaza.SelectedText + ".xlsx");
            ViewRapor.ExportToXlsx(file);
            //Process.Start(path + ".xlsx");
        }

        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            gridRapor.DataSource = null;
            MGZ();
            tileBarItem2.Enabled = false;
            tileBarItem3.Enabled = false;            
            srcMagaza.EditValue = null;
        }
    }
}
