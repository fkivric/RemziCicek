namespace RemziCicek
{
    partial class frmAraçlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçlar));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnTTSAraclarCek = new DevExpress.XtraEditors.SimpleButton();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbYil = new System.Windows.Forms.ComboBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbMagaza = new System.Windows.Forms.ComboBox();
            this.cmbBolge = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.gridAraclar = new DevExpress.XtraGrid.GridControl();
            this.ViewAraclar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolgeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBolge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMagazaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMagaza = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarkaID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYıl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKilometre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAraclar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            // 
            // ultraPanel1.ClientArea
            // 
            this.ultraPanel1.ClientArea.Controls.Add(this.groupControl2);
            this.ultraPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ultraPanel1.Location = new System.Drawing.Point(0, 0);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(1274, 176);
            this.ultraPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTTSAraclarCek);
            this.groupControl2.Controls.Add(this.txtPlaka);
            this.groupControl2.Controls.Add(this.txtkm);
            this.groupControl2.Controls.Add(this.button4);
            this.groupControl2.Controls.Add(this.cmbYil);
            this.groupControl2.Controls.Add(this.cmbMarka);
            this.groupControl2.Controls.Add(this.button3);
            this.groupControl2.Controls.Add(this.cmbMagaza);
            this.groupControl2.Controls.Add(this.cmbBolge);
            this.groupControl2.Controls.Add(this.cmbModel);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1274, 176);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Araç Bilgisi";
            // 
            // btnTTSAraclarCek
            // 
            this.btnTTSAraclarCek.Location = new System.Drawing.Point(1144, 29);
            this.btnTTSAraclarCek.Name = "btnTTSAraclarCek";
            this.btnTTSAraclarCek.Size = new System.Drawing.Size(118, 141);
            this.btnTTSAraclarCek.TabIndex = 6;
            this.btnTTSAraclarCek.Text = "Shel Arac Çek";
            this.btnTTSAraclarCek.Click += new System.EventHandler(this.btnTTSAraclarCek_Click);
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(14, 52);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(175, 21);
            this.txtPlaka.TabIndex = 0;
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(210, 95);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(175, 21);
            this.txtkm.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(564, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = "Güncelle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbYil
            // 
            this.cmbYil.FormattingEnabled = true;
            this.cmbYil.Location = new System.Drawing.Point(210, 139);
            this.cmbYil.Name = "cmbYil";
            this.cmbYil.Size = new System.Drawing.Size(175, 21);
            this.cmbYil.TabIndex = 1;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(14, 95);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(175, 21);
            this.cmbMarka.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(460, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbMagaza
            // 
            this.cmbMagaza.FormattingEnabled = true;
            this.cmbMagaza.Location = new System.Drawing.Point(439, 55);
            this.cmbMagaza.Name = "cmbMagaza";
            this.cmbMagaza.Size = new System.Drawing.Size(223, 21);
            this.cmbMagaza.TabIndex = 1;
            // 
            // cmbBolge
            // 
            this.cmbBolge.FormattingEnabled = true;
            this.cmbBolge.Location = new System.Drawing.Point(210, 55);
            this.cmbBolge.Name = "cmbBolge";
            this.cmbBolge.Size = new System.Drawing.Size(223, 21);
            this.cmbBolge.TabIndex = 1;
            // 
            // cmbModel
            // 
            this.cmbModel.Location = new System.Drawing.Point(14, 139);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(175, 21);
            this.cmbModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yıl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Araç Plakası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Araç Kilometresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(436, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Araç Mağazası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(210, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Araç Bölesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // ultraPanel2
            // 
            // 
            // ultraPanel2.ClientArea
            // 
            this.ultraPanel2.ClientArea.Controls.Add(this.gridAraclar);
            this.ultraPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ultraPanel2.Location = new System.Drawing.Point(0, 176);
            this.ultraPanel2.Name = "ultraPanel2";
            this.ultraPanel2.Size = new System.Drawing.Size(1274, 428);
            this.ultraPanel2.TabIndex = 1;
            // 
            // gridAraclar
            // 
            this.gridAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAraclar.Location = new System.Drawing.Point(0, 0);
            this.gridAraclar.MainView = this.ViewAraclar;
            this.gridAraclar.Name = "gridAraclar";
            this.gridAraclar.Size = new System.Drawing.Size(1274, 428);
            this.gridAraclar.TabIndex = 2;
            this.gridAraclar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewAraclar});
            // 
            // ViewAraclar
            // 
            this.ViewAraclar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colPlaka,
            this.colBolgeID,
            this.colBolge,
            this.colMagazaID,
            this.colMagaza,
            this.colMarkaID,
            this.colMarka,
            this.colModelID,
            this.colModel,
            this.colYıl,
            this.colKilometre});
            this.ViewAraclar.GridControl = this.gridAraclar;
            this.ViewAraclar.Name = "ViewAraclar";
            this.ViewAraclar.OptionsView.ColumnAutoWidth = false;
            this.ViewAraclar.OptionsView.RowAutoHeight = true;
            this.ViewAraclar.OptionsView.ShowAutoFilterRow = true;
            this.ViewAraclar.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewAraclar_RowClick);
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "aracid";
            this.colID.Name = "colID";
            // 
            // colPlaka
            // 
            this.colPlaka.Caption = "Plaka";
            this.colPlaka.FieldName = "Plaka";
            this.colPlaka.Name = "colPlaka";
            this.colPlaka.OptionsColumn.AllowEdit = false;
            this.colPlaka.OptionsColumn.FixedWidth = true;
            this.colPlaka.Visible = true;
            this.colPlaka.VisibleIndex = 0;
            this.colPlaka.Width = 170;
            // 
            // colBolgeID
            // 
            this.colBolgeID.Caption = "BolgeID";
            this.colBolgeID.FieldName = "Arac_Bolgeid";
            this.colBolgeID.Name = "colBolgeID";
            // 
            // colBolge
            // 
            this.colBolge.Caption = "Bağlı Olduğu Bölge";
            this.colBolge.FieldName = "Arac_BolgeAdi";
            this.colBolge.Name = "colBolge";
            this.colBolge.OptionsColumn.AllowEdit = false;
            this.colBolge.OptionsColumn.FixedWidth = true;
            this.colBolge.Visible = true;
            this.colBolge.VisibleIndex = 1;
            this.colBolge.Width = 195;
            // 
            // colMagazaID
            // 
            this.colMagazaID.Caption = "MagazaID";
            this.colMagazaID.FieldName = "Arac_Magazaid";
            this.colMagazaID.Name = "colMagazaID";
            // 
            // colMagaza
            // 
            this.colMagaza.Caption = "Bağlı Oluğu Mağaza";
            this.colMagaza.FieldName = "Arac_MagazaAdi";
            this.colMagaza.Name = "colMagaza";
            this.colMagaza.OptionsColumn.AllowEdit = false;
            this.colMagaza.OptionsColumn.FixedWidth = true;
            this.colMagaza.Visible = true;
            this.colMagaza.VisibleIndex = 2;
            this.colMagaza.Width = 158;
            // 
            // colMarkaID
            // 
            this.colMarkaID.Caption = "MarkaID";
            this.colMarkaID.FieldName = "Arac_Markaid";
            this.colMarkaID.Name = "colMarkaID";
            // 
            // colMarka
            // 
            this.colMarka.Caption = "Marka";
            this.colMarka.FieldName = "Arac_MarkaAdi";
            this.colMarka.Name = "colMarka";
            this.colMarka.OptionsColumn.AllowEdit = false;
            this.colMarka.OptionsColumn.FixedWidth = true;
            this.colMarka.Visible = true;
            this.colMarka.VisibleIndex = 3;
            this.colMarka.Width = 160;
            // 
            // colModelID
            // 
            this.colModelID.Caption = "ModelID";
            this.colModelID.FieldName = "Arac_Modelid";
            this.colModelID.Name = "colModelID";
            // 
            // colModel
            // 
            this.colModel.Caption = "Model";
            this.colModel.FieldName = "Arac_ModelAdi";
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.OptionsColumn.FixedWidth = true;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 4;
            this.colModel.Width = 190;
            // 
            // colYıl
            // 
            this.colYıl.Caption = "Yılı";
            this.colYıl.FieldName = "Arac_Yıl";
            this.colYıl.Name = "colYıl";
            this.colYıl.OptionsColumn.AllowEdit = false;
            this.colYıl.OptionsColumn.FixedWidth = true;
            this.colYıl.Visible = true;
            this.colYıl.VisibleIndex = 5;
            this.colYıl.Width = 170;
            // 
            // colKilometre
            // 
            this.colKilometre.Caption = "Kilometresi";
            this.colKilometre.FieldName = "Arac_Kilometre";
            this.colKilometre.Name = "colKilometre";
            this.colKilometre.OptionsColumn.AllowEdit = false;
            this.colKilometre.OptionsColumn.FixedWidth = true;
            this.colKilometre.Visible = true;
            this.colKilometre.VisibleIndex = 6;
            this.colKilometre.Width = 158;
            // 
            // frmAraçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 604);
            this.Controls.Add(this.ultraPanel2);
            this.Controls.Add(this.ultraPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = global::RemziCicek.Properties.Resources.transit_32x32;
            this.Name = "frmAraçlar";
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "frmAraçlar";
            this.Load += new System.EventHandler(this.frmAraçlar_Load);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAraclar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAraclar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.TextBox txtPlaka;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private DevExpress.XtraGrid.GridControl gridAraclar;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewAraclar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbMagaza;
        private System.Windows.Forms.ComboBox cmbBolge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.Columns.GridColumn colPlaka;
        private DevExpress.XtraGrid.Columns.GridColumn colMarka;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colYıl;
        private DevExpress.XtraGrid.Columns.GridColumn colBolge;
        private DevExpress.XtraGrid.Columns.GridColumn colMagaza;
        private DevExpress.XtraGrid.Columns.GridColumn colKilometre;
        private System.Windows.Forms.ComboBox cmbYil;
        private DevExpress.XtraEditors.SimpleButton btnTTSAraclarCek;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colBolgeID;
        private DevExpress.XtraGrid.Columns.GridColumn colMagazaID;
        private DevExpress.XtraGrid.Columns.GridColumn colMarkaID;
        private DevExpress.XtraGrid.Columns.GridColumn colModelID;
    }
}