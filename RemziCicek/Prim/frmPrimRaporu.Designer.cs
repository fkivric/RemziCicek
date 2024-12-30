namespace RemziCicek
{
    partial class frmPrimRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimRaporu));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrimExcel = new DevExpress.XtraEditors.SimpleButton();
            this.tglDetay = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnPrimListesi = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.srcYil = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.srcAy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.srcMagaza = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridPrim = new DevExpress.XtraGrid.GridControl();
            this.ViewPrim = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tglDetay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMagaza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPrimExcel);
            this.groupControl1.Controls.Add(this.tglDetay);
            this.groupControl1.Controls.Add(this.btnPrimListesi);
            this.groupControl1.Controls.Add(this.tablePanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1327, 83);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Filitreler";
            // 
            // btnPrimExcel
            // 
            this.btnPrimExcel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnPrimExcel.Appearance.Options.UseBackColor = true;
            this.btnPrimExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrimExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimExcel.ImageOptions.Image")));
            this.btnPrimExcel.Location = new System.Drawing.Point(819, 23);
            this.btnPrimExcel.Name = "btnPrimExcel";
            this.btnPrimExcel.Size = new System.Drawing.Size(172, 58);
            this.btnPrimExcel.TabIndex = 9;
            this.btnPrimExcel.Text = "Excel Kaydet";
            this.btnPrimExcel.Click += new System.EventHandler(this.btnPrimExcel_Click);
            // 
            // tglDetay
            // 
            this.tglDetay.EditValue = true;
            this.tglDetay.Location = new System.Drawing.Point(1001, 43);
            this.tglDetay.Name = "tglDetay";
            this.tglDetay.Properties.OffText = "Detaylı";
            this.tglDetay.Properties.OnText = "Kümülatif";
            this.tglDetay.Size = new System.Drawing.Size(95, 18);
            this.tglDetay.TabIndex = 8;
            // 
            // btnPrimListesi
            // 
            this.btnPrimListesi.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnPrimListesi.Appearance.Options.UseBackColor = true;
            this.btnPrimListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrimListesi.Location = new System.Drawing.Point(647, 23);
            this.btnPrimListesi.Name = "btnPrimListesi";
            this.btnPrimListesi.Size = new System.Drawing.Size(172, 58);
            this.btnPrimListesi.TabIndex = 7;
            this.btnPrimListesi.Text = "Listele";
            this.btnPrimListesi.Click += new System.EventHandler(this.btnPrimListesi_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel2.Controls.Add(this.labelControl1);
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.srcYil);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.srcAy);
            this.tablePanel2.Controls.Add(this.srcMagaza);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablePanel2.Location = new System.Drawing.Point(2, 23);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(645, 58);
            this.tablePanel2.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.tablePanel2.SetColumn(this.labelControl1, 2);
            this.labelControl1.Location = new System.Drawing.Point(433, 5);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel2.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(69, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mağaza Listesi";
            // 
            // labelControl3
            // 
            this.tablePanel2.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(218, 5);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel2.SetRow(this.labelControl3, 0);
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Prim Ayı";
            // 
            // srcYil
            // 
            this.tablePanel2.SetColumn(this.srcYil, 0);
            this.srcYil.Location = new System.Drawing.Point(3, 31);
            this.srcYil.Name = "srcYil";
            this.srcYil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcYil.Properties.NullText = "Seçiniz...!";
            this.srcYil.Properties.PopupView = this.gridView1;
            this.tablePanel2.SetRow(this.srcYil, 1);
            this.srcYil.Size = new System.Drawing.Size(209, 20);
            this.srcYil.TabIndex = 5;
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
            this.tablePanel2.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 5);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel2.SetRow(this.labelControl2, 0);
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Prim Yılı";
            // 
            // srcAy
            // 
            this.tablePanel2.SetColumn(this.srcAy, 1);
            this.srcAy.Location = new System.Drawing.Point(218, 31);
            this.srcAy.Name = "srcAy";
            this.srcAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcAy.Properties.NullText = "Seçiniz...!";
            this.srcAy.Properties.PopupView = this.searchLookUpEdit2View;
            this.tablePanel2.SetRow(this.srcAy, 1);
            this.srcAy.Size = new System.Drawing.Size(209, 20);
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
            this.tablePanel2.SetColumn(this.srcMagaza, 2);
            this.srcMagaza.Location = new System.Drawing.Point(433, 31);
            this.srcMagaza.Name = "srcMagaza";
            this.srcMagaza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcMagaza.Properties.NullText = "Tüm Mağazalar";
            this.srcMagaza.Properties.PopupView = this.searchLookUpEdit1View;
            this.tablePanel2.SetRow(this.srcMagaza, 1);
            this.srcMagaza.Size = new System.Drawing.Size(209, 20);
            this.srcMagaza.TabIndex = 0;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridPrim
            // 
            this.gridPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPrim.Location = new System.Drawing.Point(0, 83);
            this.gridPrim.MainView = this.ViewPrim;
            this.gridPrim.Name = "gridPrim";
            this.gridPrim.Size = new System.Drawing.Size(1327, 632);
            this.gridPrim.TabIndex = 3;
            this.gridPrim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewPrim});
            // 
            // ViewPrim
            // 
            this.ViewPrim.GridControl = this.gridPrim;
            this.ViewPrim.Name = "ViewPrim";
            this.ViewPrim.OptionsView.ShowGroupPanel = false;
            // 
            // frmPrimRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 715);
            this.Controls.Add(this.gridPrim);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPrimRaporu";
            this.Text = "Prim Raporu";
            this.Load += new System.EventHandler(this.frmPrimRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tglDetay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMagaza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPrim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPrimListesi;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit srcYil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit srcAy;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit srcMagaza;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gridPrim;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewPrim;
        private DevExpress.XtraEditors.ToggleSwitch tglDetay;
        private DevExpress.XtraEditors.SimpleButton btnPrimExcel;
    }
}