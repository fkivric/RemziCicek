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
    public partial class frmAracSec : MetroFramework.Forms.MetroForm
    {
        SqlConnection vol = new SqlConnection(Properties.Settings.Default.VolConnection);
        public string PLAKA = "";
        public string BOLGE = "";
        public string ARACID = "";
        public frmAracSec()
        {
            InitializeComponent();
        }

        private void frmAracSec_Load(object sender, EventArgs e)
        {
            string qq = string.Format(@"CREATE TABLE #ARAC
            (
	            DSHIPVAL		varchar(6),
	            DSHIPNAME		varchar(60),
	            DSHIPDIVLIST	varchar(200)
            )

            declare @DSHIPVAL		varchar(6),
		            @DSHIPNAME		varchar(60),
		            @DSHIPDIVLIST	varchar(200)

            declare CRS_ARAC cursor for

            select DSHIPVAL,DSHIPNAME,DSHIPDIVLIST from DEFSHIPMENT where DSHIPSTS = 1
            open CRS_ARAC
            fetch next from CRS_ARAC into @DSHIPVAL,@DSHIPNAME,@DSHIPDIVLIST
            while @@FETCH_STATUS = 0
            begin
	            if @DSHIPDIVLIST like '%,%'
	            begin
		            insert into #ARAC
		            select @DSHIPVAL,@DSHIPNAME,Items from (
	            select * from MDE_GENEL.dbo.FK_fn_Split(@DSHIPDIVLIST,',')) magaza
	            end
	            else
	            begin
		            insert into #ARAC
		            select @DSHIPVAL,@DSHIPNAME,isnull(@DSHIPDIVLIST,'00')
	            end
            fetch next from CRS_ARAC into @DSHIPVAL,@DSHIPNAME,@DSHIPDIVLIST
            end
            close CRS_ARAC
            deallocate CRS_ARAC

            select DSHIPVAL,DSHIPNAME,DIVNAME,DIVREGION from #ARAC
            left outer join VDB_YON01.dbo.DIVISON on DIVVAL = DSHIPDIVLIST
            where DSHIPVAL not in (
            'ARAS',
            'CEVA',
            'HOROZ',
            'MARS',
            'MNG',
            'PTT',
            'YURT')
            order by 3,2,4
            drop table #ARAC
            ");
            SqlDataAdapter da = new SqlDataAdapter(qq, vol);
            DataTable dt = new DataTable();
            da.Fill(dt);
            ViewAracSec.OptionsView.ShowIndicator = true;
            ViewAracSec.IndicatorWidth = 40;
            gridAracSec.DataSource = dt;
        }

        private void ViewAracSec_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                ARACID = ViewAracSec.GetRowCellValue(e.RowHandle, "DSHIPVAL").ToString();
                PLAKA = ViewAracSec.GetRowCellValue(e.RowHandle, "DSHIPNAME").ToString();
                BOLGE = ViewAracSec.GetRowCellValue(e.RowHandle, "DIVREGION").ToString();
                this.Close();
                this.Dispose();
            }
        }
    }
}
