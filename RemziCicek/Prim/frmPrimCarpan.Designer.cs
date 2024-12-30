namespace RemziCicek
{
    partial class frmPrimCarpan
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnMagazaYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnListesi = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.srcYil = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.srcAy = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.gridCarpan = new DevExpress.XtraGrid.GridControl();
            this.ViewCarpan = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCarpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarpan)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(1117, 83);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Filitreler";
            // 
            // btnMagazaYeni
            // 
            this.btnMagazaYeni.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnMagazaYeni.Appearance.Options.UseBackColor = true;
            this.btnMagazaYeni.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMagazaYeni.Location = new System.Drawing.Point(633, 23);
            this.btnMagazaYeni.Name = "btnMagazaYeni";
            this.btnMagazaYeni.Size = new System.Drawing.Size(219, 58);
            this.btnMagazaYeni.TabIndex = 11;
            this.btnMagazaYeni.Text = "Yeni";
            this.btnMagazaYeni.Click += new System.EventHandler(this.btnMagazaYeni_Click);
            // 
            // btnListesi
            // 
            this.btnListesi.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnListesi.Appearance.Options.UseBackColor = true;
            this.btnListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListesi.Enabled = false;
            this.btnListesi.Location = new System.Drawing.Point(414, 23);
            this.btnListesi.Name = "btnListesi";
            this.btnListesi.Size = new System.Drawing.Size(219, 58);
            this.btnListesi.TabIndex = 10;
            this.btnListesi.Text = "Listele";
            this.btnListesi.Click += new System.EventHandler(this.btnListesi_Click);
            // 
            // tablePanel2
            // 
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 33F)});
            this.tablePanel2.Controls.Add(this.labelControl3);
            this.tablePanel2.Controls.Add(this.srcYil);
            this.tablePanel2.Controls.Add(this.labelControl2);
            this.tablePanel2.Controls.Add(this.srcAy);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablePanel2.Location = new System.Drawing.Point(2, 23);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 24F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(412, 58);
            this.tablePanel2.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.tablePanel2.SetColumn(this.labelControl3, 1);
            this.labelControl3.Location = new System.Drawing.Point(209, 5);
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
            this.srcYil.Size = new System.Drawing.Size(200, 20);
            this.srcYil.TabIndex = 5;
            this.srcYil.EditValueChanged += new System.EventHandler(this.srcYil_EditValueChanged);
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
            this.srcAy.Enabled = false;
            this.srcAy.Location = new System.Drawing.Point(209, 31);
            this.srcAy.Name = "srcAy";
            this.srcAy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcAy.Properties.NullText = "Seçiniz...!";
            this.srcAy.Properties.PopupView = this.searchLookUpEdit2View;
            this.tablePanel2.SetRow(this.srcAy, 1);
            this.srcAy.Size = new System.Drawing.Size(200, 20);
            this.srcAy.TabIndex = 1;
            this.srcAy.EditValueChanged += new System.EventHandler(this.srcAy_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup3});
            this.navBarControl1.Location = new System.Drawing.Point(1085, 83);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 320;
            this.navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(32, 555);
            this.navBarControl1.TabIndex = 20;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 577);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1085, 61);
            this.panelControl1.TabIndex = 21;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Enabled = false;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 15);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(145, 34);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gridCarpan
            // 
            this.gridCarpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCarpan.Location = new System.Drawing.Point(0, 83);
            this.gridCarpan.MainView = this.ViewCarpan;
            this.gridCarpan.Name = "gridCarpan";
            this.gridCarpan.Size = new System.Drawing.Size(1085, 494);
            this.gridCarpan.TabIndex = 22;
            this.gridCarpan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewCarpan});
            // 
            // ViewCarpan
            // 
            this.ViewCarpan.GridControl = this.gridCarpan;
            this.ViewCarpan.Name = "ViewCarpan";
            this.ViewCarpan.OptionsView.ShowFooter = true;
            this.ViewCarpan.OptionsView.ShowGroupPanel = false;
            // 
            // frmPrimCarpan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 638);
            this.Controls.Add(this.gridCarpan);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmPrimCarpan";
            this.Text = "frmPrimCarpan";
            this.Load += new System.EventHandler(this.frmPrimCarpan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            this.tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcYil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcAy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCarpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCarpan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnMagazaYeni;
        private DevExpress.XtraEditors.SimpleButton btnListesi;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SearchLookUpEdit srcYil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SearchLookUpEdit srcAy;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraGrid.GridControl gridCarpan;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewCarpan;
    }
}