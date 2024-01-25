namespace RemziCicek
{
    partial class frmServisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServisler));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtServis = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gridServis = new DevExpress.XtraGrid.GridControl();
            this.cardServis = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardServis)).BeginInit();
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
            this.ultraPanel1.Size = new System.Drawing.Size(1274, 112);
            this.ultraPanel1.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.txtServis);
            this.groupControl2.Controls.Add(this.button4);
            this.groupControl2.Controls.Add(this.button3);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1274, 112);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Servis Bilgisi";
            // 
            // txtServis
            // 
            this.txtServis.Location = new System.Drawing.Point(14, 52);
            this.txtServis.Name = "txtServis";
            this.txtServis.Size = new System.Drawing.Size(175, 21);
            this.txtServis.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = global::RemziCicek.Properties.Resources.cleartablestyle_32x32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(320, 39);
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
            this.button3.Location = new System.Drawing.Point(216, 39);
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
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Servis Adı";
            // 
            // gridServis
            // 
            this.gridServis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridServis.Location = new System.Drawing.Point(0, 112);
            this.gridServis.MainView = this.cardServis;
            this.gridServis.Name = "gridServis";
            this.gridServis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoExEdit1,
            this.repositoryItemPictureEdit1});
            this.gridServis.Size = new System.Drawing.Size(1274, 492);
            this.gridServis.TabIndex = 3;
            this.gridServis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardServis});
            // 
            // cardServis
            // 
            this.cardServis.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cardServis.CardCaptionFormat = "Servis{0}";
            this.cardServis.CardWidth = 300;
            this.cardServis.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colAdı});
            this.cardServis.GridControl = this.gridServis;
            this.cardServis.Name = "cardServis";
            this.cardServis.OptionsBehavior.FieldAutoHeight = true;
            this.cardServis.DoubleClick += new System.EventHandler(this.cardServis_DoubleClick);
            // 
            // colid
            // 
            this.colid.Caption = "Sıra No";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colAdı
            // 
            this.colAdı.Caption = "Servis Adı";
            this.colAdı.FieldName = "sAciklama";
            this.colAdı.Name = "colAdı";
            this.colAdı.Visible = true;
            this.colAdı.VisibleIndex = 1;
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
            // frmServisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 604);
            this.Controls.Add(this.gridServis);
            this.Controls.Add(this.ultraPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.LargeImage = global::RemziCicek.Properties.Resources.shoppingcart_32x32;
            this.Name = "frmServisler";
            this.Load += new System.EventHandler(this.frmServisler_Load);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardServis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtServis;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridServis;
        private DevExpress.XtraGrid.Views.Card.CardView cardServis;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colAdı;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
    }
}