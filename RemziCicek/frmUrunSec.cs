using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek
{
    public partial class frmUrunSec : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.VolConnection);
        public string stokKodu = "";
        public string stokAdi = "";
        public string stokId = "";
        public frmUrunSec()
        {
            InitializeComponent();
        }

        private void frmUrunSec_Load(object sender, EventArgs e)
        {
            string q = string.Format(@"select * from PRODUCTS where PROKIND = 9");
            SqlDataAdapter da = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridUrun.DataSource = dt;
        }

        private void ViewUrun_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {

        }

        private void ViewUrun_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {

                stokId = ViewUrun.GetRowCellValue(e.RowHandle, "PROID").ToString();
                stokKodu = ViewUrun.GetRowCellValue(ViewUrun.FocusedRowHandle, "PROVAL").ToString();
                stokAdi = ViewUrun.GetRowCellValue(ViewUrun.FocusedRowHandle, "PRONAME").ToString();
                this.Close();
                this.Dispose();
            }
        }
    }
}
