namespace RemziCicek
{
    partial class frmMagazaKotaRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagazaKotaRaporu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnMagazaYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnListesi = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.srcBolge = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.srcAy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.srcMagaza = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.srcYil = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridKotaListesi = new DevExpress.XtraGrid.GridControl();
            this.ViewKotaListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcBolge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMagaza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKotaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewKotaListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnMagazaYeni);
            this.groupControl1.Controls.Add(this.btnListesi);
            this.groupControl1.Controls.Add(this.tablePanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1207, 83);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Filitreler";
            // 
            // btnMagazaYeni
            // 
            this.btnMagazaYeni.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnMagazaYeni.Appearance.Options.UseBackColor = true;
            this.btnMagazaYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMagazaYeni.Location = new System.Drawing.Point(866, 16);
            this.btnMagazaYeni.Name = "btnMagazaYeni";
            this.btnMagazaYeni.Size = new System.Drawing.Size(219, 65);
            this.btnMagazaYeni.TabIndex = 11;
            this.btnMagazaYeni.Text = "Yeni";
            this.btnMagazaYeni.Click += new System.EventHandler(this.btnMagazaYeni_Click);
            // 
            // btnListesi
            // 
            this.btnListesi.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnListesi.Appearance.Options.UseBackColor = true;
            this.btnListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListesi.Location = new System.Drawing.Point(647, 16);
            this.btnListesi.Name = "btnListesi";
            this.btnListesi.Size = new System.Drawing.Size(219, 65);
            this.btnListesi.TabIndex = 10;
            this.btnListesi.Text = "Listele";
            this.btnListesi.Click += new System.EventHandler(this.btnListesi_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.srcBolge);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.srcAy);
            this.tablePanel2.Controls.Add(this.srcMagaza);
            this.tablePanel2.Controls.Add(this.labelControl4);
            this.tablePanel2.Controls.Add(this.srcYil);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablePanel2.Location = new System.Drawing.Point(2, 16);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(645, 65);
            this.tablePanel2.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 3);
            this.labelControl1.Location = new System.Drawing.Point(487, 5);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mağaza Listesi";
            // 
            // labelControl3
            // 
            this.tablePanel2.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(164, 5);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Prim Ayı";
            // 
            // srcBolge
            // 
            this.tablePanel2.SetColumn(this.srcBolge, 2);
            this.srcBolge.Location = new System.Drawing.Point(326, 34);
            this.srcBolge.Name = "srcBolge";
            this.srcBolge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcBolge.Properties.NullText = "Tüm Bölgeler...!";
            this.srcBolge.Properties.PopupView = this.gridView1;
            this.tablePanel2.SetRow(this.srcBolge, 1);
            this.srcBolge.Size = new System.Drawing.Size(155, 20);
            this.srcBolge.TabIndex = 5;
            this.srcBolge.EditValueChanged += new System.EventHandler(this.srcBolge_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.tablePanel2.SetColumn(this.labelControl2, 2);
            this.labelControl2.Location = new System.Drawing.Point(326, 5);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(30, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Bölge";
            // 
            // srcAy
            // 
            this.tablePanel2.SetColumn(this.srcAy, 1);
            this.srcAy.Location = new System.Drawing.Point(164, 34);
            this.srcAy.Name = "srcAy";
            this.srcAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcAy.Properties.NullText = "Tüm Aylar...!";
            this.srcAy.Properties.PopupView = this.searchLookUpEdit2View;
            this.tablePanel2.SetRow(this.srcAy, 1);
            this.srcAy.Size = new System.Drawing.Size(155, 20);
            this.srcAy.TabIndex = 1;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // srcMagaza
            // 
            this.tablePanel2.SetColumn(this.srcMagaza, 3);
            this.srcMagaza.Location = new System.Drawing.Point(487, 34);
            this.srcMagaza.Name = "srcMagaza";
            this.srcMagaza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcMagaza.Properties.NullText = "Tüm Magazalar...!";
            this.srcMagaza.Properties.PopupView = this.searchLookUpEdit1View;
            this.tablePanel2.SetRow(this.srcMagaza, 1);
            this.srcMagaza.Size = new System.Drawing.Size(155, 20);
            this.srcMagaza.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl4
            // 
            this.tablePanel2.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 5);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel2.SetRow(this.labelControl4, 0);
            this.labelControl4.Size = new System.Drawing.Size(99, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Prim Yılı (ZORUNLU)";
            // 
            // srcYil
            // 
            this.tablePanel2.SetColumn(this.srcYil, 0);
            this.srcYil.Location = new System.Drawing.Point(3, 34);
            this.srcYil.Name = "srcYil";
            this.srcYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcYil.Properties.NullText = "Seçiniz...!";
            this.srcYil.Properties.PopupView = this.gridView2;
            this.tablePanel2.SetRow(this.srcYil, 1);
            this.srcYil.Size = new System.Drawing.Size(155, 20);
            this.srcYil.TabIndex = 1;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(32, 557);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1175, 61);
            this.panelControl1.TabIndex = 21;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGuncelle.Location = new System.Drawing.Point(2, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(1171, 57);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Excel Kaydet";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gridKotaListesi
            // 
            this.gridKotaListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKotaListesi.Location = new System.Drawing.Point(32, 83);
            this.gridKotaListesi.MainView = this.ViewKotaListesi;
            this.gridKotaListesi.Name = "gridKotaListesi";
            this.gridKotaListesi.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.gridKotaListesi.Size = new System.Drawing.Size(1175, 474);
            this.gridKotaListesi.TabIndex = 22;
            this.gridKotaListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewKotaListesi});
            // 
            // ViewKotaListesi
            // 
            this.ViewKotaListesi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn6,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn7,
            this.gridColumn5});
            this.ViewKotaListesi.GridControl = this.gridKotaListesi;
            this.ViewKotaListesi.Name = "ViewKotaListesi";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "sira";
            this.gridColumn1.FieldName = "sira";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Bölge";
            this.gridColumn2.FieldName = "DIVREGION";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Ay";
            this.gridColumn6.FieldName = "SATGMMONTHNAME";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Mağaza Kodu";
            this.gridColumn3.FieldName = "DIVVAL";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Mağaza Adı";
            this.gridColumn4.FieldName = "DIVNAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Kota";
            this.gridColumn7.ColumnEdit = this.repositoryItemTextEdit1;
            this.gridColumn7.FieldName = "SATGDIAMOUNT";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.DisplayFormat.FormatString = "n2";
            this.repositoryItemTextEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Çarpan";
            this.gridColumn5.FieldName = "SATGDIRATE";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "İşlemler";
            this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupClientHeight = 491;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.NavigationPaneVisible = false;
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer3.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(320, 617);
            this.navBarGroupControlContainer3.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup3});
            this.navBarControl1.Location = new System.Drawing.Point(0, 83);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 320;
            this.navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(32, 535);
            this.navBarControl1.TabIndex = 20;
            this.navBarControl1.Visible = false;
            // 
            // frmMagazaKotaRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 618);
            this.Controls.Add(this.gridKotaListesi);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmMagazaKotaRaporu";
            this.Text = "Mağaza Kota Raporu";
            this.Load += new System.EventHandler(this.frmKotaRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcBolge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMagaza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKotaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewKotaListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnMagazaYeni;
        private DevExpress.XtraEditors.SimpleButton btnListesi;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit srcBolge;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit srcAy;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit srcMagaza;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraGrid.GridControl gridKotaListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewKotaListesi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SearchLookUpEdit srcYil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}