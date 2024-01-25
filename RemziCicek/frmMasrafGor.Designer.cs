namespace RemziCicek
{
    partial class frmMasrafGor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasrafGor));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dteMasrafstart = new DevExpress.XtraEditors.DateEdit();
            this.dteMasrafend = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.cmbArac = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbMasraf = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridKalemler = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSil = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKalemler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AracID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Plaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MasrafID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Evrak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEvrakGor = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafstart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafstart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafend.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMasraf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKalemler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewKalemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEvrakGor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 84);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(796, 80);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Masraf Ekleme";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(623, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(171, 56);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Listele";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dteMasrafstart);
            this.panelControl2.Controls.Add(this.dteMasrafend);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(351, 22);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(272, 56);
            this.panelControl2.TabIndex = 7;
            // 
            // dteMasrafstart
            // 
            this.dteMasrafstart.EditValue = null;
            this.dteMasrafstart.Location = new System.Drawing.Point(12, 22);
            this.dteMasrafstart.Name = "dteMasrafstart";
            this.dteMasrafstart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafstart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafstart.Size = new System.Drawing.Size(123, 20);
            this.dteMasrafstart.TabIndex = 4;
            // 
            // dteMasrafend
            // 
            this.dteMasrafend.EditValue = null;
            this.dteMasrafend.Location = new System.Drawing.Point(141, 22);
            this.dteMasrafend.Name = "dteMasrafend";
            this.dteMasrafend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafend.Size = new System.Drawing.Size(109, 20);
            this.dteMasrafend.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(111, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(55, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tarih Aralıgı";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.cmbArac);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.cmbMasraf);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 22);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(349, 56);
            this.panelControl3.TabIndex = 4;
            // 
            // cmbArac
            // 
            this.cmbArac.Location = new System.Drawing.Point(12, 23);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArac.Properties.NullText = "Seçiniz...!";
            this.cmbArac.Properties.PopupView = this.searchLookUpEdit2View;
            this.cmbArac.Size = new System.Drawing.Size(162, 20);
            this.cmbArac.TabIndex = 2;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Araç Seç";
            // 
            // cmbMasraf
            // 
            this.cmbMasraf.Location = new System.Drawing.Point(180, 23);
            this.cmbMasraf.Name = "cmbMasraf";
            this.cmbMasraf.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMasraf.Properties.NullText = "Seçiniz...!";
            this.cmbMasraf.Properties.PopupView = this.searchLookUpEdit1View;
            this.cmbMasraf.Size = new System.Drawing.Size(162, 20);
            this.cmbMasraf.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(180, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Masraf Tipi";
            // 
            // gridKalemler
            // 
            this.gridKalemler.ContextMenuStrip = this.contextMenuStrip1;
            this.gridKalemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKalemler.Location = new System.Drawing.Point(0, 84);
            this.gridKalemler.MainView = this.viewKalemler;
            this.gridKalemler.Name = "gridKalemler";
            this.gridKalemler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnEvrakGor});
            this.gridKalemler.Size = new System.Drawing.Size(800, 366);
            this.gridKalemler.TabIndex = 1;
            this.gridKalemler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewKalemler});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // btnSil
            // 
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 22);
            this.btnSil.Text = "Seçili Kaydı Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // viewKalemler
            // 
            this.viewKalemler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.AracID,
            this.Plaka,
            this.gridColumn3,
            this.MasrafID,
            this.gridColumn4,
            this.Adet,
            this.Tutar,
            this.gridColumn5,
            this.Evrak,
            this.gridColumn2});
            this.viewKalemler.GridControl = this.gridKalemler;
            this.viewKalemler.Name = "viewKalemler";
            this.viewKalemler.OptionsView.ShowFooter = true;
            this.viewKalemler.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MASRAFID";
            this.gridColumn1.FieldName = "MASRAFID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // AracID
            // 
            this.AracID.Caption = "AracID";
            this.AracID.FieldName = "AracID";
            this.AracID.Name = "AracID";
            // 
            // Plaka
            // 
            this.Plaka.Caption = "Plaka";
            this.Plaka.FieldName = "ARACPLAKA";
            this.Plaka.Name = "Plaka";
            this.Plaka.Visible = true;
            this.Plaka.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Masraf Tarihi";
            this.gridColumn3.FieldName = "MASRAFTARIHI";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // MasrafID
            // 
            this.MasrafID.Caption = "MasrafID";
            this.MasrafID.FieldName = "MASRAFTIPIID";
            this.MasrafID.Name = "MasrafID";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Masraf Tipi";
            this.gridColumn4.FieldName = "PRONAME";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // Adet
            // 
            this.Adet.Caption = "Adet";
            this.Adet.FieldName = "MASRAFADET";
            this.Adet.Name = "Adet";
            this.Adet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Adet", "{0:0.##}")});
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 3;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "MASRAFTUTAR";
            this.Tutar.Name = "Tutar";
            this.Tutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:0.##}")});
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Toplam";
            this.gridColumn5.FieldName = "Toplam";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Toplam", "{0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // Evrak
            // 
            this.Evrak.Caption = "Evrak";
            this.Evrak.FieldName = "EVRAKYOLU";
            this.Evrak.Name = "Evrak";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Evrak Gör";
            this.gridColumn2.ColumnEdit = this.btnEvrakGor;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // btnEvrakGor
            // 
            this.btnEvrakGor.AutoHeight = false;
            this.btnEvrakGor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.btnEvrakGor.HideSelection = false;
            this.btnEvrakGor.Name = "btnEvrakGor";
            this.btnEvrakGor.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnEvrakGor.Click += new System.EventHandler(this.btnEvrakGor_Click);
            // 
            // frmMasrafGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridKalemler);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMasrafGor.IconOptions.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMasrafGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masraf Gör";
            this.Load += new System.EventHandler(this.frmMasraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafstart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafstart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafend.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMasraf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKalemler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewKalemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEvrakGor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMasraf;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridKalemler;
        private DevExpress.XtraGrid.Views.Grid.GridView viewKalemler;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbArac;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.DateEdit dteMasrafstart;
        private DevExpress.XtraGrid.Columns.GridColumn AracID;
        private DevExpress.XtraGrid.Columns.GridColumn Plaka;
        private DevExpress.XtraGrid.Columns.GridColumn MasrafID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn Evrak;
        private DevExpress.XtraEditors.DateEdit dteMasrafend;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnEvrakGor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSil;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}