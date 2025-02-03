namespace RemziCicek
{
    partial class frmPrimMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnMagazaKotası = new DevExpress.XtraBars.BarButtonItem();
            this.btnElemanKotası = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnKotaRaporu = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnCarpan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.btnMagazaKotası,
            this.btnElemanKotası,
            this.barButtonItem2,
            this.btnKotaRaporu,
            this.btnExcelAl,
            this.btnCarpan,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 12;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1121, 132);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "İşlem Menü";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnMagazaKotası
            // 
            this.btnMagazaKotası.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.btnMagazaKotası.Caption = "Mağaza Kota Tanımlama";
            this.btnMagazaKotası.Id = 2;
            this.btnMagazaKotası.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMagazaKotası.ImageOptions.Image")));
            this.btnMagazaKotası.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMagazaKotası.ImageOptions.LargeImage")));
            this.btnMagazaKotası.Name = "btnMagazaKotası";
            this.btnMagazaKotası.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMagazaKotası_ItemClick);
            // 
            // btnElemanKotası
            // 
            this.btnElemanKotası.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.btnElemanKotası.Caption = "Satış Elemanı Kota Tanımlama";
            this.btnElemanKotası.Id = 3;
            this.btnElemanKotası.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnElemanKotası.ImageOptions.Image")));
            this.btnElemanKotası.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnElemanKotası.ImageOptions.LargeImage")));
            this.btnElemanKotası.Name = "btnElemanKotası";
            this.btnElemanKotası.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnElemanKotası_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem2.Caption = "Prim Raporu";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnKotaRaporu
            // 
            this.btnKotaRaporu.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.btnKotaRaporu.Caption = "Mağaza & Personel Kota Raporu";
            this.btnKotaRaporu.Id = 5;
            this.btnKotaRaporu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKotaRaporu.ImageOptions.Image")));
            this.btnKotaRaporu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKotaRaporu.ImageOptions.LargeImage")));
            this.btnKotaRaporu.Name = "btnKotaRaporu";
            this.btnKotaRaporu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKotaRaporu_ItemClick);
            // 
            // btnExcelAl
            // 
            this.btnExcelAl.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.btnExcelAl.Caption = "Excel İle Güncelle";
            this.btnExcelAl.Id = 6;
            this.btnExcelAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAl.ImageOptions.Image")));
            this.btnExcelAl.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelAl.ImageOptions.LargeImage")));
            this.btnExcelAl.Name = "btnExcelAl";
            this.btnExcelAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExcelAl_ItemClick);
            // 
            // btnCarpan
            // 
            this.btnCarpan.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.btnCarpan.Caption = "Satış Sınıf Çarpanı Güncelle";
            this.btnCarpan.Id = 7;
            this.btnCarpan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpan.ImageOptions.Image")));
            this.btnCarpan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCarpan.ImageOptions.LargeImage")));
            this.btnCarpan.Name = "btnCarpan";
            this.btnCarpan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCarpan_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem3.Caption = "Özel Gün Prim Raporu";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            this.barButtonItem4.Caption = "Özel Gün Tanımlama";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Mağaza Prim Durumu";
            this.barButtonItem6.Id = 11;
            this.barButtonItem6.ImageOptions.Image = global::RemziCicek.Properties.Resources.newemployee_16x16;
            this.barButtonItem6.ImageOptions.LargeImage = global::RemziCicek.Properties.Resources.newemployee_32x32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kota Tanımlamaları";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMagazaKotası);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Mağaza İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnElemanKotası);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCarpan);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnExcelAl);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Satış Personeli İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKotaRaporu);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Kota Kontrol";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Özel Gün Ve Kota Tanımlama";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Prim Raporları";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Prim Hesaplama";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Özel Gün Prim Raporu";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 756);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1121, 25);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 132);
            this.xtraTabControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl.Size = new System.Drawing.Size(1121, 624);
            this.xtraTabControl.TabIndex = 37;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            this.xtraTabControl.SizeChanged += new System.EventHandler(this.xtraTabControl_SizeChanged);
            // 
            // radialMenu1
            // 
            this.radialMenu1.Name = "radialMenu1";
            this.radialMenu1.Ribbon = this.ribbon;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmPrimMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 781);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmPrimMain.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "frmPrimMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Prim İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnMagazaKotası;
        private DevExpress.XtraBars.BarButtonItem btnElemanKotası;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnKotaRaporu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnExcelAl;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarButtonItem btnCarpan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
    }
}