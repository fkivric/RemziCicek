namespace RemziCicek
{
    partial class frmLogin
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::RemziCicek.frmSplashScreen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tileNavCategory1 = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.lblversion = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.togsKullanici = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmbVolantSirket = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cmbVolantMagaza = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtVolantPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtVolantUser = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.togsKullanici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVolantSirket.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVolantMagaza.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolantPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolantUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 300;
            // 
            // tileNavCategory1
            // 
            this.tileNavCategory1.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationPage1);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1});
            this.navigationFrame.SelectedPage = this.navigationPage1;
            this.navigationFrame.Size = new System.Drawing.Size(695, 293);
            this.navigationFrame.TabIndex = 3;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Controls.Add(this.tablePanel1);
            this.navigationPage1.Controls.Add(this.panel1);
            this.navigationPage1.Controls.Add(this.tablePanel3);
            this.navigationPage1.Controls.Add(this.pictureEdit1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(695, 293);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 152.32F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 64.12F)});
            this.tablePanel1.Controls.Add(this.lblversion);
            this.tablePanel1.Controls.Add(this.togsKullanici);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.cmbVolantSirket);
            this.tablePanel1.Controls.Add(this.cmbVolantMagaza);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.txtVolantPassword);
            this.tablePanel1.Controls.Add(this.txtVolantUser);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(294, 120);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(401, 129);
            this.tablePanel1.TabIndex = 0;
            // 
            // lblversion
            // 
            this.tablePanel1.SetColumn(this.lblversion, 0);
            this.lblversion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblversion.Location = new System.Drawing.Point(3, 26);
            this.lblversion.Name = "lblversion";
            this.tablePanel1.SetRow(this.lblversion, 1);
            this.lblversion.Size = new System.Drawing.Size(146, 26);
            this.lblversion.TabIndex = 10;
            this.lblversion.Text = "label1";
            this.lblversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(3, 107);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 4);
            this.labelControl4.Size = new System.Drawing.Size(146, 19);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Şirket";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(146, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Volan Kullanıcı Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 55);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 2);
            this.labelControl2.Size = new System.Drawing.Size(146, 20);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Volant Parola";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 81);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 3);
            this.labelControl3.Size = new System.Drawing.Size(146, 20);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Mağaza";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureEdit2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 120);
            this.panel1.TabIndex = 4;
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel3.Controls.Add(this.simpleButton2);
            this.tablePanel3.Controls.Add(this.simpleButton1);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tablePanel3.Location = new System.Drawing.Point(294, 249);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(401, 44);
            this.tablePanel3.TabIndex = 2;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Olive;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.tablePanel3.SetColumn(this.simpleButton2, 0);
            this.simpleButton2.Location = new System.Drawing.Point(3, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.tablePanel3.SetRow(this.simpleButton2, 0);
            this.simpleButton2.Size = new System.Drawing.Size(195, 38);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "GİRİŞ";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.IndianRed;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.tablePanel3.SetColumn(this.simpleButton1, 1);
            this.simpleButton1.Location = new System.Drawing.Point(204, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.tablePanel3.SetRow(this.simpleButton1, 0);
            this.simpleButton1.Size = new System.Drawing.Size(195, 38);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "KAPAT";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // togsKullanici
            // 
            this.tablePanel1.SetColumn(this.togsKullanici, 1);
            this.togsKullanici.Enabled = false;
            this.togsKullanici.Location = new System.Drawing.Point(155, 30);
            this.togsKullanici.Name = "togsKullanici";
            this.togsKullanici.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.togsKullanici.Properties.OffText = "";
            this.togsKullanici.Properties.OnText = "";
            this.tablePanel1.SetRow(this.togsKullanici, 1);
            this.togsKullanici.Size = new System.Drawing.Size(243, 18);
            this.togsKullanici.TabIndex = 9;
            // 
            // cmbVolantSirket
            // 
            this.tablePanel1.SetColumn(this.cmbVolantSirket, 1);
            this.cmbVolantSirket.Location = new System.Drawing.Point(155, 107);
            this.cmbVolantSirket.Name = "cmbVolantSirket";
            this.cmbVolantSirket.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVolantSirket.Properties.NullText = "";
            this.cmbVolantSirket.Properties.PopupView = this.searchLookUpEdit2View;
            this.tablePanel1.SetRow(this.cmbVolantSirket, 4);
            this.cmbVolantSirket.Size = new System.Drawing.Size(243, 20);
            this.cmbVolantSirket.TabIndex = 3;
            this.cmbVolantSirket.EditValueChanged += new System.EventHandler(this.cmbVolantSirket_EditValueChanged);
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // cmbVolantMagaza
            // 
            this.tablePanel1.SetColumn(this.cmbVolantMagaza, 1);
            this.cmbVolantMagaza.Enabled = false;
            this.cmbVolantMagaza.Location = new System.Drawing.Point(155, 81);
            this.cmbVolantMagaza.Name = "cmbVolantMagaza";
            this.cmbVolantMagaza.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVolantMagaza.Properties.NullText = "";
            this.cmbVolantMagaza.Properties.PopupView = this.searchLookUpEdit1View;
            this.tablePanel1.SetRow(this.cmbVolantMagaza, 3);
            this.cmbVolantMagaza.Size = new System.Drawing.Size(243, 20);
            this.cmbVolantMagaza.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtVolantPassword
            // 
            this.tablePanel1.SetColumn(this.txtVolantPassword, 1);
            this.txtVolantPassword.Location = new System.Drawing.Point(155, 55);
            this.txtVolantPassword.Name = "txtVolantPassword";
            this.txtVolantPassword.Properties.PasswordChar = '*';
            this.tablePanel1.SetRow(this.txtVolantPassword, 2);
            this.txtVolantPassword.Size = new System.Drawing.Size(243, 20);
            this.txtVolantPassword.TabIndex = 1;
            this.txtVolantPassword.Enter += new System.EventHandler(this.txtVolantPassword_Enter);
            this.txtVolantPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVolantPassword_KeyDown);
            this.txtVolantPassword.Leave += new System.EventHandler(this.txtVolantPassword_Leave);
            // 
            // txtVolantUser
            // 
            this.tablePanel1.SetColumn(this.txtVolantUser, 1);
            this.txtVolantUser.Location = new System.Drawing.Point(155, 3);
            this.txtVolantUser.Name = "txtVolantUser";
            this.tablePanel1.SetRow(this.txtVolantUser, 0);
            this.txtVolantUser.Size = new System.Drawing.Size(243, 20);
            this.txtVolantUser.TabIndex = 0;
            this.txtVolantUser.TextChanged += new System.EventHandler(this.txtVolantUser_TextChanged);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit2.Size = new System.Drawing.Size(401, 120);
            this.pictureEdit2.TabIndex = 0;
            this.pictureEdit2.Visible = false;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(294, 293);
            this.pictureEdit1.TabIndex = 3;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 293);
            this.ControlBox = false;
            this.Controls.Add(this.navigationFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.togsKullanici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVolantSirket.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVolantMagaza.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolantPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVolantUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.TileNavCategory tileNavCategory1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbVolantSirket;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbVolantMagaza;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtVolantPassword;
        private DevExpress.XtraEditors.TextEdit txtVolantUser;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.ToggleSwitch togsKullanici;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversion;
    }
}