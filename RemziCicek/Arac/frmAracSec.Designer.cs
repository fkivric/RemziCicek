namespace RemziCicek
{
    partial class frmAracSec
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
            this.gridAracSec = new DevExpress.XtraGrid.GridControl();
            this.ViewAracSec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAracSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAracSec)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAracSec
            // 
            this.gridAracSec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAracSec.Location = new System.Drawing.Point(20, 60);
            this.gridAracSec.MainView = this.ViewAracSec;
            this.gridAracSec.Name = "gridAracSec";
            this.gridAracSec.Size = new System.Drawing.Size(539, 556);
            this.gridAracSec.TabIndex = 0;
            this.gridAracSec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewAracSec});
            // 
            // ViewAracSec
            // 
            this.ViewAracSec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.ViewAracSec.GridControl = this.gridAracSec;
            this.ViewAracSec.Name = "ViewAracSec";
            this.ViewAracSec.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.ViewAracSec_RowCellClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ARACID";
            this.gridColumn1.FieldName = "DSHIPVAL";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PLAKA";
            this.gridColumn2.FieldName = "DSHIPNAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MAĞAZA";
            this.gridColumn3.FieldName = "DIVNAME";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "BÖLGE";
            this.gridColumn4.FieldName = "DIVREGION";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // frmAracSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 636);
            this.Controls.Add(this.gridAracSec);
            this.Name = "frmAracSec";
            this.Text = "Araç Seç";
            this.Load += new System.EventHandler(this.frmAracSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAracSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAracSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridAracSec;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewAracSec;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}