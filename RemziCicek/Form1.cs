using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RemziCicek
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            try
            {
                SplashScreen();
                Thread.Sleep(700);
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "McSkin";
                DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
                defaultLookAndFeel.LookAndFeel.SkinName = "McSkin";
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
                Control.CheckForIllegalCrossThreadCalls = false;
                InitializeComponent();
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 300, this);
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false, 300, this);
            }
        }
        void SplashScreen()
        {
            FluentSplashScreenOptions splashScreen = new FluentSplashScreenOptions();
            splashScreen.Title = "YÖN AVM®";
            splashScreen.Subtitle = "YÖN avm® Araç Takip Modülü";
            splashScreen.RightFooter = "Başlıyor...";
            splashScreen.LeftFooter = $"CopyRight ® FKivriç {Environment.NewLine} Tüm Hahkları Saklıdır.";
            splashScreen.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            splashScreen.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);
            splashScreen.Opacity = 90;
            splashScreen.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(splashScreen, parentForm: this, useFadeIn: true, useFadeOut: true);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                this.Text = "Version : " + ad.CurrentVersion.Major + "." + ad.CurrentVersion.Minor + "." + ad.CurrentVersion.Build + "." + ad.CurrentVersion.Revision;                
            }
            else
            {
                string _s1 = Application.ProductVersion; // versiyon
                this.Text = "Version : " + _s1;
            }
        }

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
                        //XtraMessageBox.Show("Her oturum açıldığında 1 işlem yapacak. Eğer bu girişteki ilk işlemse uygulama çalışmaktadır. Lütfen Bekleyiniz");
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

        private void ultraExplorerBar1_ItemClick(object sender, Infragistics.Win.UltraWinExplorerBar.ItemEventArgs e)
        {
            switch (e.Item.Key.ToString())
            {
                case "10":
                    OpenForm(new frmMasraf());
                    break;
                case "20":
                    OpenForm(new frmArac_TTS());
                    break;
                case "90":
                    OpenForm(new frmMasrafGor());
                    break;
                case "91":
                    MessageBox.Show("Yapılıyor");
                    break;
                case "92":
                    OpenForm(new frmAracMasrafRaporu());
                    break;
            }
        }
        public void OpenForm(Form toOpen)
        {
            #region eski form

            //int var = 0;
            //foreach (Form child in MdiChildren)
            //{
            //    if (child.Name == toOpen.Name)
            //    {
            //        //child.Close();
            //        var = 1;
            //        XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            //        args.AutoCloseOptions.Delay = 2000;
            //        args.Caption = "Uyarı";
            //        args.Text = toOpen.Text.ToString() + "Açık.";
            //        args.Buttons = new DialogResult[] { DialogResult.OK };
            //        args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
            //        XtraMessageBox.Show(args).ToString();
            //        toOpen.Close();
            //        toOpen.Dispose();
            //        toOpen.Focus();
            //    }
            //}
            //if (var == 0)
            //{
            //    toOpen.MdiParent = this;
            //    toOpen.Show();
            //}
            #endregion
            bool isOpen = false;

            foreach (Form child in MdiChildren)
            {
                if (child.Name == toOpen.Name)
                {
                    isOpen = true;
                    break;
                }
            }

            if (isOpen)
            {
                DialogResult result = XtraMessageBox.Show(
                    toOpen.Text + " Açık. Kapatmak için Hayır Geçiş Yapmak için Evet seçin!",
                    "Uyarı",
                    MessageBoxButtons.YesNoCancel
                );

                switch (result)
                {
                    case DialogResult.Yes:
                        // Form'u öne getir
                        foreach (Form child in MdiChildren)
                        {
                            if (child.Name == toOpen.Name)
                            {
                                child.BringToFront();
                                child.Focus();
                                break;
                            }
                        }
                        break;

                    case DialogResult.No:
                        // Form'u kapat
                        foreach (Form child in MdiChildren)
                        {
                            if (child.Name == toOpen.Name)
                            {
                                child.BringToFront();
                                child.Close();
                                break;
                            }
                        }
                        break;

                    case DialogResult.Cancel:
                        // İptal işlemi
                        break;
                }
            }
            else
            {
                toOpen.MdiParent = this;
                toOpen.Show();
            }
        }
    }
}
