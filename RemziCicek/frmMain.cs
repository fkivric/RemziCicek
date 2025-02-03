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
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraTab;
using DevExpress.XtraSplashScreen;
using System.Threading;
using RemziCicek.Prim;

namespace RemziCicek
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        void SplashScreen()
        {
            FluentSplashScreenOptions splashScreen = new FluentSplashScreenOptions();
            splashScreen.Title = "ENTEGREF";
            splashScreen.Subtitle = "YÖN avm® Volant Kasa Tools";
            splashScreen.RightFooter = "Başlıyor...";
            splashScreen.LeftFooter = $"CopyRight ® 2023 {Environment.NewLine} Tüm Hahkları Saklıdır.";
            splashScreen.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            splashScreen.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);
            splashScreen.Opacity = 90;
            splashScreen.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(splashScreen, parentForm: this, useFadeIn: true, useFadeOut: true);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void accordionControl_ElementClick(object sender, ElementClickEventArgs e)
        {
            //var MenuName = e.Element.Text;
            //if (MenuName == "İade Hatası Düzelt")
            //{
            //    OpenTabForm(new frmHesapDuzelt());
            //}
            //if (MenuName == "Ödeme Hatası Düzelt")
            //{
            //    OpenTabForm(new frmOdemeDuzelt());
            //}

            //if (MenuName == "İşlem Gören Müşteri Listesi")
            //{
            //    OpenTabForm(new frmMusteriRapor1());
            //}
            //if (MenuName == "Web Ödemesi Mükrer Hata Düzelt")
            //{
            //    OpenTabForm(new frmWebOdemeDuzelt());
            //}
            //if (MenuName == "Tek Ürün Teslimat Kaldırma")
            //{
            //    OpenTabForm(new frmTeslimatKaldır());
            //}
            //if (MenuName == "Müşteri Ödeme Değiştir")
            //{
            //    OpenTabForm(new frmMusteriOdemeDegistir());
            //}
            //if (MenuName == "Günlük Kasa")
            //{
            //    OpenTabForm(new frmGunlukKasa());
            //}
            //if (MenuName == "Kasa Tarih Düzeltme")
            //{
            //    OpenTabForm(new frmKasaTarihDuzelt());
            //}
            //if (MenuName == "Kasa Toplam Düzeltme")
            //{
            //    OpenTabForm(new frmKasaToplamDuzelt());
            //}
            //if (MenuName == "Kasa Hareketi Sil")
            //{
            //    OpenTabForm(new frmKasaHareketSil());
            //}
            //if (MenuName == "Merkeze Gönderilen Tutarı Kasadan Düş")
            //{
            //    OpenTabForm(new frmKasaMerkezeAl());
            //}
            //if (MenuName == "Banka Fark Raporu")
            //{
            //    OpenTabForm(new frmKasaBankaFarki());
            //}
            //if (MenuName == "Banka Gün Toplamı İşlemleri")
            //{
            //    OpenTabForm(new frmKasaBankaIslemleri());
            //}
            //if (MenuName == "Kredi Raporu")
            //{
            //    OpenTabForm(new frmKrediRapor());
            //}
            //if (MenuName == "IYS Müşteri Aktar")
            //{
            //    OpenTabForm(new frmIYS());
            //}
            //if (MenuName == "Peşinat Primi")
            //{
            //    OpenTabForm(new frmPesinatPrimi());
            //}
        }
        bool FormMode = false;
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (xtraTabControl.SelectedTabPage.Name == "anaSayfaTab")
                {
                    return;
                }
                if (xtraTabControl.SelectedTabPage.Controls.Count > 0)
                {
                    foreach (object item in xtraTabControl.SelectedTabPage.Controls)
                    {
                        if (item is Form && item is Form frm)
                        {
                            frm.Close();
                            frm.Dispose();
                        }
                    }
                }
                xtraTabControl.SelectedTabPage.Controls[0].Dispose();
            }
            catch
            {
            }
            xtraTabControl.TabPages.Remove(xtraTabControl.SelectedTabPage);
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }
        public void xtraTabControlSizeRule()
        {
            try
            {
                for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
                {
                    Application.DoEvents();
                    xtraTabControl.TabPages[i].Width = xtraTabControl.Width;
                    xtraTabControl.TabPages[i].Height = xtraTabControl.Height;
                    foreach (Control item in xtraTabControl.TabPages[i].Controls)
                    {
                        Application.DoEvents();
                        xtraTabControl.TabPages[i].Controls.Remove(item);
                        if (item is Form frm)
                        {
                            frm.Dock = DockStyle.Fill;
                            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                            frm.AutoSize = false;
                            frm.Size = new Size(xtraTabControl.TabPages[i].Width, xtraTabControl.TabPages[i].Height);
                        }
                        xtraTabControl.TabPages[i].Controls.Add(item);
                        item.Refresh();
                        Application.DoEvents();
                    }
                    Application.DoEvents();
                }
            }
            catch
            {
            }
        }
        private void xtraTabControl_SizeChanged(object sender, EventArgs e)
        {
            if (!base.DesignMode)
            {
                xtraTabControlSizeRule();
            }
        }
        public void OpenTabForm(Form form)
        {
            bool isFormOpen = false;
            // İlgili formun açık olup olmadığını kontrol etmek için bir bayrak kullanıyoruz.

            for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
            {

                if (xtraTabControl.TabPages[i].Text == form.Text)
                {
                    isFormOpen = true;
                    // Aynı isme sahip bir formun açık olduğunu belirledik.
                    break;
                }
            }
            if (isFormOpen)
            {
                XtraMessageBoxArgs args = new XtraMessageBoxArgs();
                args.AutoCloseOptions.Delay = 2000;
                args.Caption = "Uyarı";
                args.Text = form.Text + "Açık.";
                args.Buttons = new DialogResult[] { DialogResult.OK };
                args.AutoCloseOptions.ShowTimerOnDefaultButton = true;
                form.Focus();
                XtraMessageBox.Show(args).ToString();
                form.Close();
                form.Dispose();
                return;
                // Form zaten açıksa kullanıcıyı uyar ve işlemi sonlandır.
            }
            else
            {
                int imageIndex;
                if (!int.TryParse(form.Tag?.ToString(), out imageIndex))
                {
                    imageIndex = 0; // Eğer dönüşüm başarısız olursa imageIndex'i 0 olarak ayarlar
                }

                XtraTabPage newTabPage = new XtraTabPage();
                newTabPage.Text = form.Text;
                newTabPage.ImageIndex = imageIndex;
                xtraTabControl.TabPages.Add(newTabPage);
                xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                form.MdiParent = this;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.FormBorderStyle = FormBorderStyle.None;
                form.WindowState = FormWindowState.Maximized;
                form.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                form.Show();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult dialogResult =
                CustomMessageBox.ShowMessage("Uygulamayı kapatmak istediğinize emin misiniz ?", "", this, "Detaya Bakınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                    System.Environment.Exit(0);
                else e.Cancel = true;
            }
            catch (Exception eex)
            {
                CustomMessageBox.ShowMessage("Uyarı", eex.Message, this, "Detaya Bakınız", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //XtraMessageBox.Show(eex.Message);
            }
        }
        private void barBtnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            List<XtraTabPage> lRemovePages = new List<XtraTabPage>();
            for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
            {
                foreach (object item2 in xtraTabControl.TabPages[i].Controls)
                {
                    if (item2 is Form && item2 is Form frm)
                    {
                        frm.Dispose();
                    }
                }
                lRemovePages.Add(xtraTabControl.TabPages[i]);
            }
            foreach (XtraTabPage item in lRemovePages)
            {
                xtraTabControl.TabPages.Remove(item);
            }
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        }

        private void barBtnAracMasrafGir_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMasraf());
        }

        private void barBtnGor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMasrafGor());
        }

        private void barBtnYakit_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmArac_TTS());
        }

        private void barBtnAraçRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmAracMasrafRaporu());
        }

        private void barBtnMagazaKota_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMagazaKotasi());
        }

        private void barBtnElemanKota_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPersonelKotaTanımlama());
        }

        private void barBtnSinifCarpan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPrimCarpan());
        }

        private void barBtnOzelGun_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnPrimExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmExcelAl());
        }


        private void barBtnMagazaKotaRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMagazaKotaRaporu());
        }

        private void barBtnPersonelKotaRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPersonelKotaRaporu());
        }
        private void barBtnPrimRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPrimRaporu());
        }

        private void barBtnMagazaKotaRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMagazaSatisKota());
        }

        private void barBtnPrimOzelGunRapor_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barBtnAracAyarlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmSettings());
        }
    }
}