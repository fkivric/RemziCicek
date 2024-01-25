namespace RemziCicek
{
    partial class frmAracIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAracIslemleri));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cmbServis = new System.Windows.Forms.ComboBox();
            this.cmbIslem = new System.Windows.Forms.ComboBox();
            this.cmbMagaza = new System.Windows.Forms.ComboBox();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dteTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.gridAracIslemleri = new DevExpress.XtraGrid.GridControl();
            this.viewAracIslemleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArac = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServisadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslemadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIslem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAracIslemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAracIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            this.ultraPanel1.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.groupControl2);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraPanel2);
            this.ultraPanel1.ClientArea.Controls.Add(this.button3);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(1332, 129);
            this.ultraPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.groupControl2.Controls.Add(this.cmbServis);
            this.groupControl2.Controls.Add(this.cmbIslem);
            this.groupControl2.Controls.Add(this.cmbMagaza);
            this.groupControl2.Controls.Add(this.cmbBolge);
            this.groupControl2.Controls.Add(this.cmbArac);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1161, 71);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Araç Bilgisi";
            // 
            // cmbServis
            // 
            this.cmbServis.Enabled = false;
            this.cmbServis.FormattingEnabled = true;
            this.cmbServis.Location = new System.Drawing.Point(700, 44);
            this.cmbServis.Name = "cmbServis";
            this.cmbServis.Size = new System.Drawing.Size(223, 21);
            this.cmbServis.TabIndex = 1;
            // 
            // cmbIslem
            // 
            this.cmbIslem.Enabled = false;
            this.cmbIslem.FormattingEnabled = true;
            this.cmbIslem.Location = new System.Drawing.Point(929, 44);
            this.cmbIslem.Name = "cmbIslem";
            this.cmbIslem.Size = new System.Drawing.Size(223, 21);
            this.cmbIslem.TabIndex = 1;
            // 
            // cmbMagaza
            // 
            this.cmbMagaza.Enabled = false;
            this.cmbMagaza.FormattingEnabled = true;
            this.cmbMagaza.Location = new System.Drawing.Point(242, 44);
            this.cmbMagaza.Name = "cmbMagaza";
            this.cmbMagaza.Size = new System.Drawing.Size(223, 21);
            this.cmbMagaza.TabIndex = 1;
            this.cmbMagaza.SelectedIndexChanged += new System.EventHandler(this.cmbMagaza_SelectedIndexChanged);
            // 
            // cmbBolge
            // 
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(13, 44);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(223, 21);
            this.cmbBolge.TabIndex = 1;
            this.cmbBolge.SelectedIndexChanged += new System.EventHandler(this.cmbBolge_SelectedIndexChanged);
            // 
            // cmbArac
            // 
            this.cmbArac.Enabled = false;
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(471, 44);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(223, 21);
            this.cmbArac.TabIndex = 1;
            this.cmbArac.SelectedIndexChanged += new System.EventHandler(this.cmbArac_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Servis Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(929, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yapılan Islem";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Araç Mağazası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Araç Bölesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arac Plakası";
            // 
            // ultraPanel2
            // 
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.simpleButton1);
            this.ultraPanel2.ClientArea.Controls.Add(this.dteTarih);
            this.ultraPanel2.ClientArea.Controls.Add(this.txtTutar);
            this.ultraPanel2.ClientArea.Controls.Add(this.label1);
            this.ultraPanel2.ClientArea.Controls.Add(this.label5);
            this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ultraPanel2.Location = new System.Drawing.Point(0, 71);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(1330, 56);
            this.ultraPanel2.TabIndex = 35;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.simpleButton1.Enabled = false;
            this.simpleButton1.ImageOptions.Image = global::RemziCicek.Properties.Resources.openhyperlink_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(1195, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 52);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Araçın\r\nTüm \r\nMasrafları";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dteTarih
            // 
            this.dteTarih.EditValue = null;
            this.dteTarih.Location = new System.Drawing.Point(13, 23);
            this.dteTarih.Name = "dteTarih";
            this.dteTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteTarih.Size = new System.Drawing.Size(223, 20);
            this.dteTarih.TabIndex = 7;
            // 
            // txtTutar
            // 
            this.txtTutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTutar.Location = new System.Drawing.Point(242, 23);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(223, 21);
            this.txtTutar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Islem Tutarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Islem Tarihi";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1195, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 52);
            this.button3.TabIndex = 5;
            this.button3.Text = "Masraf\r\nEkle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridAracIslemleri
            // 
            this.gridAracIslemleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAracIslemleri.Location = new System.Drawing.Point(0, 129);
            this.gridAracIslemleri.MainView = this.viewAracIslemleri;
            this.gridAracIslemleri.Name = "gridAracIslemleri";
            this.gridAracIslemleri.Size = new System.Drawing.Size(1332, 602);
            this.gridAracIslemleri.TabIndex = 2;
            this.gridAracIslemleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewAracIslemleri});
            // 
            // viewAracIslemleri
            // 
            this.viewAracIslemleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colArac,
            this.colTarih,
            this.colServisadi,
            this.colServis,
            this.colIslemadi,
            this.colIslem,
            this.colTutar});
            this.viewAracIslemleri.GridControl = this.gridAracIslemleri;
            this.viewAracIslemleri.Name = "viewAracIslemleri";
            this.viewAracIslemleri.OptionsView.ColumnAutoWidth = false;
            this.viewAracIslemleri.OptionsView.ShowGroupPanel = false;
            this.viewAracIslemleri.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.viewAracIslemleri_RowClick);
            // 
            // colid
            // 
            this.colid.Caption = "id";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.FixedWidth = true;
            // 
            // colArac
            // 
            this.colArac.Caption = "Araç";
            this.colArac.FieldName = "AracPlaka";
            this.colArac.Name = "colArac";
            this.colArac.OptionsColumn.AllowEdit = false;
            this.colArac.OptionsColumn.FixedWidth = true;
            this.colArac.Visible = true;
            this.colArac.VisibleIndex = 0;
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.FieldName = "tarih";
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.OptionsColumn.FixedWidth = true;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 1;
            this.colTarih.Width = 92;
            // 
            // colServisadi
            // 
            this.colServisadi.Caption = "Servis";
            this.colServisadi.FieldName = "Servis";
            this.colServisadi.Name = "colServisadi";
            this.colServisadi.Visible = true;
            this.colServisadi.VisibleIndex = 2;
            this.colServisadi.Width = 187;
            // 
            // colServis
            // 
            this.colServis.Caption = "Servis id";
            this.colServis.FieldName = "Servisid";
            this.colServis.Name = "colServis";
            this.colServis.OptionsColumn.AllowEdit = false;
            this.colServis.OptionsColumn.FixedWidth = true;
            this.colServis.Width = 105;
            // 
            // colIslemadi
            // 
            this.colIslemadi.Caption = "Islem Adı";
            this.colIslemadi.FieldName = "Islem";
            this.colIslemadi.Name = "colIslemadi";
            this.colIslemadi.Visible = true;
            this.colIslemadi.VisibleIndex = 3;
            this.colIslemadi.Width = 197;
            // 
            // colIslem
            // 
            this.colIslem.Caption = "Islem id";
            this.colIslem.FieldName = "Islemid";
            this.colIslem.Name = "colIslem";
            this.colIslem.OptionsColumn.AllowEdit = false;
            this.colIslem.OptionsColumn.FixedWidth = true;
            this.colIslem.Width = 137;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.FieldName = "Tutar";
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.OptionsColumn.FixedWidth = true;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 4;
            this.colTutar.Width = 193;
            // 
            // frmAracIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 731);
            this.Controls.Add(this.gridAracIslemleri);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "frmAracIslemleri";
            this.Text = "frmAracIslemleri";
            this.Load += new System.EventHandler(this.frmAracIslemleri_Load);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ClientArea.PerformLayout();
            this.ultraPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAracIslemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewAracIslemleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ComboBox cmbServis;
        private System.Windows.Forms.ComboBox cmbIslem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbMagaza;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridAracIslemleri;
        private DevExpress.XtraGrid.Views.Grid.GridView viewAracIslemleri;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colArac;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colServis;
        private DevExpress.XtraGrid.Columns.GridColumn colIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.DateEdit dteTarih;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colServisadi;
        private DevExpress.XtraGrid.Columns.GridColumn colIslemadi;
    }
}