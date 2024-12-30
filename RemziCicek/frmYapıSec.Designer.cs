namespace RemziCicek
{
    partial class frmYapıSec
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
            this.btnSayım = new System.Windows.Forms.Button();
            this.btnPrim = new System.Windows.Forms.Button();
            this.btnArac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSayım
            // 
            this.btnSayım.AutoEllipsis = true;
            this.btnSayım.BackgroundImage = global::RemziCicek.Properties.Resources.barcode_reader;
            this.btnSayım.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSayım.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSayım.Font = new System.Drawing.Font("Bodoni MT Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnSayım.ForeColor = System.Drawing.Color.Black;
            this.btnSayım.Location = new System.Drawing.Point(361, 0);
            this.btnSayım.Name = "btnSayım";
            this.btnSayım.Size = new System.Drawing.Size(158, 85);
            this.btnSayım.TabIndex = 1;
            this.btnSayım.Text = "Sayım İşlemleri";
            this.btnSayım.UseVisualStyleBackColor = false;
            this.btnSayım.Click += new System.EventHandler(this.btnSayım_Click);
            // 
            // btnPrim
            // 
            this.btnPrim.AutoEllipsis = true;
            this.btnPrim.BackgroundImage = global::RemziCicek.Properties.Resources.cash;
            this.btnPrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrim.Font = new System.Drawing.Font("Bodoni MT Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrim.ForeColor = System.Drawing.Color.Black;
            this.btnPrim.Location = new System.Drawing.Point(158, 0);
            this.btnPrim.Name = "btnPrim";
            this.btnPrim.Size = new System.Drawing.Size(203, 85);
            this.btnPrim.TabIndex = 1;
            this.btnPrim.Text = "Prim Sistemi";
            this.btnPrim.UseVisualStyleBackColor = false;
            this.btnPrim.Click += new System.EventHandler(this.btnPrim_Click);
            // 
            // btnArac
            // 
            this.btnArac.AutoEllipsis = true;
            this.btnArac.BackgroundImage = global::RemziCicek.Properties.Resources.truck_40px;
            this.btnArac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArac.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArac.Font = new System.Drawing.Font("Bodoni MT Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnArac.ForeColor = System.Drawing.Color.Black;
            this.btnArac.Location = new System.Drawing.Point(0, 0);
            this.btnArac.Name = "btnArac";
            this.btnArac.Size = new System.Drawing.Size(158, 85);
            this.btnArac.TabIndex = 1;
            this.btnArac.Text = "Araç Takip";
            this.btnArac.UseVisualStyleBackColor = false;
            this.btnArac.Click += new System.EventHandler(this.btnArac_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Eras Medium ITC", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(0, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAPAT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmYapıSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 113);
            this.ControlBox = false;
            this.Controls.Add(this.btnPrim);
            this.Controls.Add(this.btnSayım);
            this.Controls.Add(this.btnArac);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = global::RemziCicek.Properties.Resources.logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYapıSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmYapıSec_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArac;
        private System.Windows.Forms.Button btnPrim;
        private System.Windows.Forms.Button btnSayım;
        private System.Windows.Forms.Button button1;
    }
}