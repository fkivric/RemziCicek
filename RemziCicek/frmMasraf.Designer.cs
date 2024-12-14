namespace RemziCicek
{
    partial class frmMasraf
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dteMasrafTarihi = new DevExpress.XtraEditors.DateEdit();
            this.cmbMasraf = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtAdet = new DevExpress.XtraEditors.TextEdit();
            this.gridKalemler = new DevExpress.XtraGrid.GridControl();
            this.viewKalemler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AracID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Plaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MasrafID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Adet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Evrak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbArac = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.btnKaydet = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMasraf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKalemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKalemler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArac.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1217, 84);
            this.panelControl1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.dteMasrafTarihi);
            this.groupControl1.Controls.Add(this.cmbMasraf);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtFiyat);
            this.groupControl1.Controls.Add(this.txtAdet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1213, 80);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Masraf Ekleme";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(779, 43);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(103, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Excel den Veri Ekle";
            // 
            // dteMasrafTarihi
            // 
            this.dteMasrafTarihi.EditValue = null;
            this.dteMasrafTarihi.Location = new System.Drawing.Point(346, 46);
            this.dteMasrafTarihi.Name = "dteMasrafTarihi";
            this.dteMasrafTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteMasrafTarihi.Size = new System.Drawing.Size(164, 20);
            this.dteMasrafTarihi.TabIndex = 4;
            // 
            // cmbMasraf
            // 
            this.cmbMasraf.Location = new System.Drawing.Point(177, 46);
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
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(673, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 20);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Ekle";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(567, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Birim Fiyat";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(346, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Tarih";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(516, 27);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Adet";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Araç Seç";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(177, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Masraf Tipi";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(567, 46);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 0;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(516, 46);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(45, 20);
            this.txtAdet.TabIndex = 0;
            // 
            // gridKalemler
            // 
            this.gridKalemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKalemler.Location = new System.Drawing.Point(0, 84);
            this.gridKalemler.MainView = this.viewKalemler;
            this.gridKalemler.Name = "gridKalemler";
            this.gridKalemler.Size = new System.Drawing.Size(1217, 371);
            this.gridKalemler.TabIndex = 1;
            this.gridKalemler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewKalemler});
            // 
            // viewKalemler
            // 
            this.viewKalemler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AracID,
            this.gridColumn1,
            this.Plaka,
            this.MasrafID,
            this.gridColumn4,
            this.Adet,
            this.Tutar,
            this.gridColumn2,
            this.Evrak});
            this.viewKalemler.GridControl = this.gridKalemler;
            this.viewKalemler.Name = "viewKalemler";
            this.viewKalemler.OptionsView.ColumnAutoWidth = false;
            this.viewKalemler.OptionsView.ShowFooter = true;
            this.viewKalemler.OptionsView.ShowGroupPanel = false;
            // 
            // AracID
            // 
            this.AracID.Caption = "AracID";
            this.AracID.FieldName = "AracID";
            this.AracID.Name = "AracID";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tarih";
            this.gridColumn1.FieldName = "TARIH";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // Plaka
            // 
            this.Plaka.Caption = "Plaka";
            this.Plaka.FieldName = "Plaka";
            this.Plaka.Name = "Plaka";
            this.Plaka.Visible = true;
            this.Plaka.VisibleIndex = 0;
            // 
            // MasrafID
            // 
            this.MasrafID.Caption = "MasrafID";
            this.MasrafID.FieldName = "MasrafID";
            this.MasrafID.Name = "MasrafID";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Masraf Tipi";
            this.gridColumn4.FieldName = "MasrafTipi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // Adet
            // 
            this.Adet.Caption = "Adet";
            this.Adet.FieldName = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Adet", "{0:0.##}")});
            this.Adet.Visible = true;
            this.Adet.VisibleIndex = 3;
            // 
            // Tutar
            // 
            this.Tutar.Caption = "Tutar";
            this.Tutar.FieldName = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Tutar", "{0:0.##}")});
            this.Tutar.Visible = true;
            this.Tutar.VisibleIndex = 4;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Toplam";
            this.gridColumn2.FieldName = "Toplam";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Toplam", "{0:0.##}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            // 
            // Evrak
            // 
            this.Evrak.Caption = "Evrak";
            this.Evrak.FieldName = "Evrak";
            this.Evrak.Name = "Evrak";
            this.Evrak.Visible = true;
            this.Evrak.VisibleIndex = 6;
            // 
            // cmbArac
            // 
            this.cmbArac.Location = new System.Drawing.Point(11, 48);
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
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btnKaydet);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AppearanceItem.Normal.BackColor = System.Drawing.Color.Blue;
            this.btnKaydet.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.White;
            this.btnKaydet.AppearanceItem.Normal.Options.UseBackColor = true;
            this.btnKaydet.AppearanceItem.Selected.BackColor = System.Drawing.Color.White;
            this.btnKaydet.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btnKaydet.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btnKaydet.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileItemElement1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left;
            tileItemElement1.ImageOptions.ImageUri.Uri = "business%20objects/bo_validation";
            tileItemElement1.Text = "Kaydet";
            this.btnKaydet.Elements.Add(tileItemElement1);
            this.btnKaydet.Id = 0;
            this.btnKaydet.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // tileBar1
            // 
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.ItemPadding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.tileBar1.ItemSize = 40;
            this.tileBar1.Location = new System.Drawing.Point(0, 455);
            this.tileBar1.MaxId = 1;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1217, 67);
            this.tileBar1.TabIndex = 3;
            this.tileBar1.Text = "tileBar1";
            // 
            // frmMasraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 522);
            this.Controls.Add(this.gridKalemler);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.cmbArac);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMasraf";
            this.Text = "Masraf Girişi";
            this.Load += new System.EventHandler(this.frmMasraf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteMasrafTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMasraf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKalemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKalemler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArac.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbMasraf;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraGrid.GridControl gridKalemler;
        private DevExpress.XtraGrid.Views.Grid.GridView viewKalemler;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbArac;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.DateEdit dteMasrafTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn AracID;
        private DevExpress.XtraGrid.Columns.GridColumn Plaka;
        private DevExpress.XtraGrid.Columns.GridColumn MasrafID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn Adet;
        private DevExpress.XtraGrid.Columns.GridColumn Tutar;
        private DevExpress.XtraGrid.Columns.GridColumn Evrak;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btnKaydet;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}