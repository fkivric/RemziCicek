namespace RemziCicek
{
    partial class frmEvraklar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvraklar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridDekont = new DevExpress.XtraGrid.GridControl();
            this.ViewDekont = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn164 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn165 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn163 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.txtdekont2 = new DevExpress.XtraEditors.TextEdit();
            this.btndosyasec2 = new DevExpress.XtraEditors.SimpleButton();
            this.btndosyayukle2 = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDekont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDekont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdekont2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridDekont);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(790, 435);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // gridDekont
            // 
            this.gridDekont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDekont.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.gridDekont.Location = new System.Drawing.Point(3, 17);
            this.gridDekont.MainView = this.ViewDekont;
            this.gridDekont.Name = "gridDekont";
            this.gridDekont.Size = new System.Drawing.Size(784, 415);
            this.gridDekont.TabIndex = 17;
            this.gridDekont.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewDekont});
            // 
            // ViewDekont
            // 
            this.ViewDekont.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.gridColumn164,
            this.gridColumn165,
            this.gridColumn163});
            this.ViewDekont.GridControl = this.gridDekont;
            this.ViewDekont.Name = "ViewDekont";
            this.ViewDekont.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.ViewDekont.OptionsFind.ClearFindOnClose = false;
            this.ViewDekont.OptionsFind.SearchInPreview = true;
            this.ViewDekont.OptionsFind.ShowClearButton = false;
            this.ViewDekont.OptionsSelection.MultiSelect = true;
            this.ViewDekont.OptionsView.ShowGroupPanel = false;
            this.ViewDekont.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewDekont_RowClick);
            this.ViewDekont.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.ViewDekont_PopupMenuShowing);
            // 
            // colid
            // 
            this.colid.Caption = "gridColumn1";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // gridColumn164
            // 
            this.gridColumn164.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridColumn164.AppearanceCell.Options.UseFont = true;
            this.gridColumn164.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn164.AppearanceHeader.Options.UseFont = true;
            this.gridColumn164.Caption = "Tarih";
            this.gridColumn164.FieldName = "tarih";
            this.gridColumn164.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn164.Name = "gridColumn164";
            this.gridColumn164.OptionsColumn.AllowEdit = false;
            this.gridColumn164.Visible = true;
            this.gridColumn164.VisibleIndex = 0;
            this.gridColumn164.Width = 147;
            // 
            // gridColumn165
            // 
            this.gridColumn165.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridColumn165.AppearanceCell.Options.UseFont = true;
            this.gridColumn165.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn165.AppearanceHeader.Options.UseFont = true;
            this.gridColumn165.Caption = "Dosya Yolu";
            this.gridColumn165.FieldName = "folder_path";
            this.gridColumn165.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn165.Name = "gridColumn165";
            this.gridColumn165.OptionsColumn.AllowEdit = false;
            this.gridColumn165.Visible = true;
            this.gridColumn165.VisibleIndex = 1;
            this.gridColumn165.Width = 255;
            // 
            // gridColumn163
            // 
            this.gridColumn163.AppearanceCell.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gridColumn163.AppearanceCell.Options.UseFont = true;
            this.gridColumn163.AppearanceHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gridColumn163.AppearanceHeader.Options.UseFont = true;
            this.gridColumn163.Caption = "Dosya Adı";
            this.gridColumn163.FieldName = "file_name";
            this.gridColumn163.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridColumn163.Name = "gridColumn163";
            this.gridColumn163.OptionsColumn.AllowEdit = false;
            this.gridColumn163.Visible = true;
            this.gridColumn163.VisibleIndex = 2;
            this.gridColumn163.Width = 375;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.labelControl48);
            this.panelControl1.Controls.Add(this.txtdekont2);
            this.panelControl1.Controls.Add(this.btndosyasec2);
            this.panelControl1.Controls.Add(this.btndosyayukle2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 371);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(790, 64);
            this.panelControl1.TabIndex = 25;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::RemziCicek.Properties.Resources.apply_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(693, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(82, 33);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "Tamam";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl48
            // 
            this.labelControl48.Location = new System.Drawing.Point(11, 13);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(129, 13);
            this.labelControl48.TabIndex = 32;
            this.labelControl48.Text = "Banka Dekont Örnegi Yükle";
            // 
            // txtdekont2
            // 
            this.txtdekont2.Location = new System.Drawing.Point(10, 30);
            this.txtdekont2.Name = "txtdekont2";
            this.txtdekont2.Size = new System.Drawing.Size(405, 20);
            this.txtdekont2.TabIndex = 31;
            // 
            // btndosyasec2
            // 
            this.btndosyasec2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndosyasec2.ImageOptions.Image")));
            this.btndosyasec2.Location = new System.Drawing.Point(421, 23);
            this.btndosyasec2.Name = "btndosyasec2";
            this.btndosyasec2.Size = new System.Drawing.Size(84, 33);
            this.btndosyasec2.TabIndex = 30;
            this.btndosyasec2.Text = "Gözat..";
            this.btndosyasec2.Click += new System.EventHandler(this.btndosyasec2_Click);
            // 
            // btndosyayukle2
            // 
            this.btndosyayukle2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndosyayukle2.ImageOptions.Image")));
            this.btndosyayukle2.Location = new System.Drawing.Point(511, 23);
            this.btndosyayukle2.Name = "btndosyayukle2";
            this.btndosyayukle2.Size = new System.Drawing.Size(82, 33);
            this.btndosyayukle2.TabIndex = 29;
            this.btndosyayukle2.Text = "Yükle";
            this.btndosyayukle2.Click += new System.EventHandler(this.btndosyayukle2_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 435);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(790, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 435);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(790, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 435);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Bilgisayara İndir";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Whatsapp ile Gönder";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmEvraklar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 435);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEvraklar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEvraklar_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDekont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDekont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtdekont2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridDekont;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewDekont;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn164;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn165;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn163;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl48;
        private DevExpress.XtraEditors.TextEdit txtdekont2;
        private DevExpress.XtraEditors.SimpleButton btndosyasec2;
        private DevExpress.XtraEditors.SimpleButton btndosyayukle2;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}