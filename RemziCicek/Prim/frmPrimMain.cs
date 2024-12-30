using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace RemziCicek
{
    public partial class frmPrimMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string version = "";
        public frmPrimMain()
        {
            try
            {
                SplashScreen();
                InitializeComponent();
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                    this.Text = "Version : " + ad.CurrentVersion.Major + "." + ad.CurrentVersion.Minor + "." + ad.CurrentVersion.Build + "." + ad.CurrentVersion.Revision;
                    version = ad.CurrentVersion.Revision.ToString();
                }
                else
                {
                    string _s1 = Application.ProductVersion; // versiyon
                    this.Text = "Version : " + _s1;
                    version = _s1;
                }
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

        void SplashScreen()
        {
            FluentSplashScreenOptions splashScreen = new FluentSplashScreenOptions();
            splashScreen.Title = "YÖN AVM";
            splashScreen.Subtitle = "YÖN avm® Mağaza Prim Sistemi";
            splashScreen.RightFooter = "Başlıyor...";
            splashScreen.LeftFooter = $"CopyRight ® 2023 {Environment.NewLine} Tüm Hahkları Saklıdır.";
            splashScreen.LoadingIndicatorType = FluentLoadingIndicatorType.Dots;
            splashScreen.OpacityColor = System.Drawing.Color.FromArgb(16, 110, 190);
            splashScreen.Opacity = 90;
            splashScreen.AppearanceLeftFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowFluentSplashScreen(splashScreen, parentForm: this, useFadeIn: true, useFadeOut: true);
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

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
            if (FormMode)
            {
                bool isOpen = false;

                foreach (Form child in MdiChildren)
                {
                    if (child.Name == form.Name)
                    {
                        isOpen = true;
                        break;
                    }
                }

                if (isOpen)
                {
                    DialogResult result = XtraMessageBox.Show(
                        form.Text + " Açık. Kapatmak için Hayır Geçiş Yapmak için Evet seçin!",
                        "Uyarı",
                        MessageBoxButtons.YesNoCancel
                    );

                    switch (result)
                    {
                        case DialogResult.Yes:
                            // Form'u öne getir
                            foreach (Form child in MdiChildren)
                            {
                                if (child.Name == form.Name)
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
                                if (child.Name == form.Name)
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
                    form.MdiParent = this;
                    form.Show();
                }
            }
            else
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
                    xtraTabControl.TabPages.Add(form.Text);
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
        }

        private void btnMagazaKotası_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmMagazaKotasi());
        }

        private void btnElemanKotası_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPersonel());
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPrimRaporu());
        }

        private void btnKotaRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmKotaRaporu());
        }

        private void btnExcelAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmExcelAl());
        }

        private void btnCarpan_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenTabForm(new frmPrimCarpan());
        }
    }
}