namespace RemziCicek
{
    partial class frmSettings
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtid.Location = new System.Drawing.Point(14, 101);
            this.txtid.Name = "txtid";
            this.txtid.Properties.PasswordChar = '*';
            this.txtid.Size = new System.Drawing.Size(349, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.Location = new System.Drawing.Point(14, 141);
            this.txtUser.Name = "txtUser";
            this.txtUser.Properties.PasswordChar = '*';
            this.txtUser.Size = new System.Drawing.Size(349, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(14, 186);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(349, 20);
            this.txtPass.TabIndex = 2;
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 140;
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 4;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl1.Size = new System.Drawing.Size(404, 81);
            this.tileControl1.TabIndex = 2;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem3);
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.tileItem3.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Silver;
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement1.Text = "Güncelle";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem3.Elements.Add(tileItemElement1);
            this.tileItem3.Id = 3;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem3.Name = "tileItem3";
            this.tileItem3.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Black;
            this.tileItem1.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Blue;
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement2.Text = "Kaydet";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItem2.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.DarkSlateBlue;
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            tileItemElement3.Text = "Çıkış";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem2.Elements.Add(tileItemElement3);
            this.tileItem2.Enabled = false;
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Small;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(144, 86);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Shell Kullanıcı Kodu";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(148, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Shell Kullanıcı Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(137, 167);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Shell Kullanıcı Parolası";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 228);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tileControl1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtid);
            this.IconOptions.ShowIcon = false;
            this.Name = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem3;
    }
}