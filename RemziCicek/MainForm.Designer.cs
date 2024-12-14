namespace RemziCicek
{
    partial class MainForm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroupTables = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.AracMasrafGiris = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.AracMasrafGor = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.AracYakitGiris = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.AracMasrafRapor = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarItem2 = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btnSettings = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.anaSayfaTab = new DevExpress.XtraTab.XtraTabPage();
            this.radialMenu = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.SekmeleriKapatItem = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar
            // 
            this.tileBar.AllowGlyphSkinning = true;
            this.tileBar.AllowSelectedItem = true;
            this.tileBar.AppearanceGroupText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.tileBar.AppearanceGroupText.Options.UseForeColor = true;
            this.tileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tileBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar.DropDownButtonWidth = 30;
            this.tileBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar.Groups.Add(this.tileBarGroupTables);
            this.tileBar.Groups.Add(this.tileBarGroup2);
            this.tileBar.IndentBetweenGroups = 10;
            this.tileBar.IndentBetweenItems = 10;
            this.tileBar.ItemPadding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tileBar.Location = new System.Drawing.Point(0, 0);
            this.tileBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tileBar.MaxId = 9;
            this.tileBar.MaximumSize = new System.Drawing.Size(0, 110);
            this.tileBar.MinimumSize = new System.Drawing.Size(100, 110);
            this.tileBar.Name = "tileBar";
            this.tileBar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tileBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.None;
            this.tileBar.SelectionBorderWidth = 2;
            this.tileBar.SelectionColorMode = DevExpress.XtraBars.Navigation.SelectionColorMode.UseItemBackColor;
            this.tileBar.ShowGroupText = false;
            this.tileBar.Size = new System.Drawing.Size(1442, 110);
            this.tileBar.TabIndex = 1;
            this.tileBar.Text = "tileBar";
            this.tileBar.WideTileWidth = 150;
            this.tileBar.SelectedItemChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroupTables
            // 
            this.tileBarGroupTables.Items.Add(this.AracMasrafGiris);
            this.tileBarGroupTables.Items.Add(this.AracMasrafGor);
            this.tileBarGroupTables.Items.Add(this.AracYakitGiris);
            this.tileBarGroupTables.Items.Add(this.AracMasrafRapor);
            this.tileBarGroupTables.Name = "tileBarGroupTables";
            this.tileBarGroupTables.Text = "TABLES";
            // 
            // AracMasrafGiris
            // 
            this.AracMasrafGiris.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.AracMasrafGiris.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AracMasrafGiris.AppearanceItem.Normal.Options.UseBackColor = true;
            this.AracMasrafGiris.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.ImageUri.Uri = "business%20objects/bo_order_item";
            tileItemElement1.Text = "Araç Masraf Girişi";
            this.AracMasrafGiris.Elements.Add(tileItemElement1);
            this.AracMasrafGiris.Name = "AracMasrafGiris";
            this.AracMasrafGiris.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // AracMasrafGor
            // 
            this.AracMasrafGor.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.AracMasrafGor.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AracMasrafGor.AppearanceItem.Normal.Options.UseBackColor = true;
            this.AracMasrafGor.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = global::RemziCicek.Properties.Resources.driving_32x32;
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement2.Text = "Araç Masraf Gör";
            this.AracMasrafGor.Elements.Add(tileItemElement2);
            this.AracMasrafGor.Id = 8;
            this.AracMasrafGor.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AracMasrafGor.Name = "AracMasrafGor";
            this.AracMasrafGor.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // AracYakitGiris
            // 
            this.AracYakitGiris.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.AracYakitGiris.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AracYakitGiris.AppearanceItem.Normal.Options.UseBackColor = true;
            this.AracYakitGiris.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement3.ImageOptions.ImageUri.Uri = "reports/gaugestylehalfcircular";
            tileItemElement3.Text = "Araç Yakıt Bilgisi";
            this.AracYakitGiris.Elements.Add(tileItemElement3);
            this.AracYakitGiris.Id = 2;
            this.AracYakitGiris.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AracYakitGiris.Name = "AracYakitGiris";
            this.AracYakitGiris.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // AracMasrafRapor
            // 
            this.AracMasrafRapor.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.AracMasrafRapor.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AracMasrafRapor.AppearanceItem.Normal.Options.UseBackColor = true;
            this.AracMasrafRapor.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement4.Text = "Raporlar";
            this.AracMasrafRapor.Elements.Add(tileItemElement4);
            this.AracMasrafRapor.Id = 3;
            this.AracMasrafRapor.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.AracMasrafRapor.Name = "AracMasrafRapor";
            this.AracMasrafRapor.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tileBarItem2);
            this.tileBarGroup2.Items.Add(this.btnSettings);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tileBarItem2
            // 
            this.tileBarItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Black;
            this.tileBarItem2.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.tileBarItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement5.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement5.ImageOptions.ImageUri.Uri = "Delete";
            tileItemElement5.Text = "Sekmeleri Kapat";
            this.tileBarItem2.Elements.Add(tileItemElement5);
            this.tileBarItem2.Id = 6;
            this.tileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem2.Name = "tileBarItem2";
            this.tileBarItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem2_ItemClick);
            // 
            // btnSettings
            // 
            this.btnSettings.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.btnSettings.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Black;
            this.btnSettings.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnSettings.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement6.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement6.ImageOptions.ImageToTextIndent = 0;
            tileItemElement6.ImageOptions.ImageUri.Uri = "scheduling/viewsettings";
            tileItemElement6.Text = "Ayarlar";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.btnSettings.Elements.Add(tileItemElement6);
            this.btnSettings.Id = 7;
            this.btnSettings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.CheckedChanged += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBar_SelectedItemChanged);
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 110);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.anaSayfaTab;
            this.xtraTabControl.Size = new System.Drawing.Size(1442, 451);
            this.xtraTabControl.TabIndex = 2;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.anaSayfaTab});
            // 
            // anaSayfaTab
            // 
            this.anaSayfaTab.ImageOptions.ImageUri.Uri = "AddItem";
            this.anaSayfaTab.Name = "anaSayfaTab";
            this.anaSayfaTab.Size = new System.Drawing.Size(1440, 407);
            this.anaSayfaTab.Text = "Main";
            // 
            // radialMenu
            // 
            this.radialMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.SekmeleriKapatItem)});
            this.radialMenu.Manager = this.barManager1;
            this.radialMenu.Name = "radialMenu";
            // 
            // SekmeleriKapatItem
            // 
            this.SekmeleriKapatItem.Caption = "Tüm Sekmeleri Kapat";
            this.SekmeleriKapatItem.Id = 0;
            this.SekmeleriKapatItem.Name = "SekmeleriKapatItem";
            this.SekmeleriKapatItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SekmeleriKapatItem_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.SekmeleriKapatItem});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1442, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1442, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1442, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 561);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.tileBar);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::RemziCicek.Properties.Resources.logo;
            this.Name = "MainForm";
            this.Text = "Araç Takip Ssitemi";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroupTables;
        private DevExpress.XtraBars.Navigation.TileBarItem AracMasrafGiris;
        private DevExpress.XtraBars.Navigation.TileBarItem AracYakitGiris;
        private DevExpress.XtraBars.Navigation.TileBarItem AracMasrafRapor;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage anaSayfaTab;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem2;
        private DevExpress.XtraBars.BarButtonItem SekmeleriKapatItem;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Navigation.TileBarItem btnSettings;
        private DevExpress.XtraBars.Navigation.TileBarItem AracMasrafGor;
    }
}