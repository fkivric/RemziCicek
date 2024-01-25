namespace RemziCicek
{
    partial class frmIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIslemler));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtIslem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridIslem = new DevExpress.XtraGrid.GridControl();
            this.cardIslem = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colTrademark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardIslem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
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
            this.ultraPanel1.Size = new System.Drawing.Size(1274, 143);
            this.ultraPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Controls.Add(this.txtIslem);
            this.groupControl2.Controls.Add(this.button4);
            this.groupControl2.Controls.Add(this.button3);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1274, 143);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Islem Turu";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(17, 107);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(175, 21);
            this.txtTutar.TabIndex = 0;
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(14, 52);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(175, 21);
            this.txtIslem.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = global::RemziCicek.Properties.Resources.cleartablestyle_32x32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(320, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 64);
            this.button4.TabIndex = 5;
            this.button4.Text = "Sil";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(216, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "Ekle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "İşlem Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "işlem Bedeli";
            // 
            // gridIslem
            // 
            this.gridIslem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIslem.Location = new System.Drawing.Point(0, 143);
            this.gridIslem.MainView = this.cardIslem;
            this.gridIslem.Name = "gridIslem";
            this.gridIslem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemPictureEdit1});
            this.gridIslem.Size = new System.Drawing.Size(1274, 461);
            this.gridIslem.TabIndex = 3;
            this.gridIslem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardIslem});
            this.gridIslem.Click += new System.EventHandler(this.gridIslem_Click);
            // 
            // cardIslem
            // 
            this.cardIslem.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cardIslem.CardCaptionFormat = "İŞLEM{0}";
            this.cardIslem.CardWidth = 300;
            this.cardIslem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colTrademark,
            this.colName,
            this.colPhoto});
            this.cardIslem.GridControl = this.gridIslem;
            this.cardIslem.Name = "cardIslem";
            this.cardIslem.OptionsBehavior.FieldAutoHeight = true;
            // 
            // colTrademark
            // 
            this.colTrademark.Caption = "İşlem Adı";
            this.colTrademark.FieldName = "sAciklama";
            this.colTrademark.Name = "colTrademark";
            this.colTrademark.Visible = true;
            this.colTrademark.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "Tutar";
            this.colName.FieldName = "lTutar";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colPhoto
            // 
            this.colPhoto.Caption = "Resim";
            this.colPhoto.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 2;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.CustomHeight = 110;
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            this.repositoryItemMemoExEdit1.PopupFormSize = new System.Drawing.Size(350, 150);
            // 
            // colid
            // 
            this.colid.Caption = "gridColumn1";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            // 
            // frmIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 604);
            this.Controls.Add(this.gridIslem);
            this.Controls.Add(this.ultraPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = global::RemziCicek.Properties.Resources.shoppingcart_32x32;
            this.Name = "frmIslemler";
            this.Load += new System.EventHandler(this.frmIslemler_Load);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardIslem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtIslem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutar;
        private DevExpress.XtraGrid.GridControl gridIslem;
        private DevExpress.XtraGrid.Views.Card.CardView cardIslem;
        private DevExpress.XtraGrid.Columns.GridColumn colTrademark;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
    }
}