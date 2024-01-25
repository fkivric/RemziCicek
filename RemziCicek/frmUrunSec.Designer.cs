namespace RemziCicek
{
    partial class frmUrunSec
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
            this.gridUrun = new DevExpress.XtraGrid.GridControl();
            this.ViewUrun = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PROID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PRONAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PROVAL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUrun
            // 
            this.gridUrun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrun.Location = new System.Drawing.Point(20, 60);
            this.gridUrun.MainView = this.ViewUrun;
            this.gridUrun.Name = "gridUrun";
            this.gridUrun.Size = new System.Drawing.Size(760, 370);
            this.gridUrun.TabIndex = 0;
            this.gridUrun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewUrun});
            // 
            // ViewUrun
            // 
            this.ViewUrun.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PROID,
            this.PRONAME,
            this.PROVAL});
            this.ViewUrun.GridControl = this.gridUrun;
            this.ViewUrun.Name = "ViewUrun";
            this.ViewUrun.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.ViewUrun_RowCellClick);
            // 
            // PROID
            // 
            this.PROID.Caption = "PROID";
            this.PROID.FieldName = "PROID";
            this.PROID.Name = "PROID";
            this.PROID.OptionsColumn.AllowEdit = false;
            // 
            // PRONAME
            // 
            this.PRONAME.Caption = "PRONAME";
            this.PRONAME.FieldName = "PRONAME";
            this.PRONAME.Name = "PRONAME";
            this.PRONAME.OptionsColumn.AllowEdit = false;
            this.PRONAME.Visible = true;
            this.PRONAME.VisibleIndex = 0;
            // 
            // PROVAL
            // 
            this.PROVAL.Caption = "PROVAL";
            this.PROVAL.FieldName = "PROVAL";
            this.PROVAL.Name = "PROVAL";
            this.PROVAL.OptionsColumn.AllowEdit = false;
            // 
            // frmUrunSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridUrun);
            this.Name = "frmUrunSec";
            this.Text = "Urun Sec";
            this.Load += new System.EventHandler(this.frmUrunSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUrun;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewUrun;
        private DevExpress.XtraGrid.Columns.GridColumn PROID;
        private DevExpress.XtraGrid.Columns.GridColumn PRONAME;
        private DevExpress.XtraGrid.Columns.GridColumn PROVAL;
    }
}