using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using Infragistics.Olap.Xmla;
using System.IO;
using System.Diagnostics;

namespace RemziCicek
{
    public partial class frmAracMasrafRaporu : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection arac = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        public frmAracMasrafRaporu()
        {
            InitializeComponent();
            var settings = new XmlaInitialSettings
            {
                ServerUrl = "http://sampledata.infragistics.com/olap/msmdpump.dll",
                Catalog = "Adventure Works DW Standard Edition",
                Cube = "Adventure Works",
                Rows = "[Date]. [Calendar]",
                Columns = "[Product]. [Category]",
                Measures = "[Measures]. [Reseller Sales Amount]"
            };
            var dataSource = new XmlaDataSource(settings);
            //ultraPivotGrid1.DataSource = dataSource;
            // Bind the DataSelector to the same datasource as the pivot grid.
            mdxDataSelector1.DataSource = dataSource;
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        private void frmAracMasrafRaporu_Load(object sender, EventArgs e)
        {


            DateTime ilkgun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-1);
            DateTime songun = ilkgun.AddMonths(1).AddDays(-1);
            dteStart.EditValue = ilkgun;
            dteEnd.EditValue = new DateTime(ilkgun.Year, ilkgun.Month, ilkgun.Day, 23, 59, 59).AddMonths(1).AddDays(-1);

            dteStart.Properties.MaxValue = DateTime.Now.AddDays(-1);
            dteEnd.Properties.MinValue = DateTime.Now.AddMonths(-15);
            dteEnd.Properties.MaxValue = DateTime.Now.AddDays(-1);


            dteStart2.EditValue = ilkgun.AddMonths(1);
            dteEnd2.EditValue = new DateTime(ilkgun.Year, ilkgun.Month, ilkgun.Day, 23, 59, 59).AddMonths(1).AddDays(-1);

            dteStart2.Properties.MaxValue = DateTime.Now.AddDays(-1);
            dteEnd2.Properties.MinValue = DateTime.Now.AddMonths(-15);
            dteEnd2.Properties.MaxValue = DateTime.Now;
            gridYakit.Visible = false;
            pivotGridControl1.Visible = true;
            pivotGridControl1.Dock = DockStyle.Fill;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (togyakit.IsOn == false)
            {
                string q = @"CREATE TABLE #ARAC
                (
	                DSHIPVAL		varchar(6),
	                DSHIPNAME		varchar(60),
	                DSHIPDIVLIST	varchar(200)
                )

                declare @DSHIPVAL		varchar(6),
		                @DSHIPNAME		varchar(60),
		                @DSHIPDIVLIST	varchar(200)

                declare CRS_ARAC cursor for

                select DSHIPVAL,DSHIPNAME,substring(isnull(DSHIPDIVLIST,'00'),1,2) from VDB_YON01.dbo.DEFSHIPMENT where DSHIPSTS = 1
                and DSHIPVAL not in (
                'ARAS',
                'CEVA',
                'HOROZ',
                'MARS',
                'MNG',
                'PTT',
                'YURT',
                'BORUSA',
                'MOBILY')
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

                select DSHIPNAME as PLAKA,DIVNAME as MAĞAZA,isnull(DIVREGION,'MERKEZ') as BOLGE
                ,yakit.YakıtFiyatı,yakit.YakıtMiktarı,yakit.YakıtTutarı
                from #ARAC
                outer apply (select distinct substring(DIVNAME,1,CHARINDEX(' ',DIVNAME)) as DIVNAME,DIVREGION from VDB_YON01.dbo.DIVISON where DIVVAL = DSHIPDIVLIST) MAGAZA
                outer apply (select Plaka,COUNT(YakıtFiyatı) as YakıtFiyatı,sum([YakıtMiktarı]) as YakıtMiktarı,sum([YakıtTutarı]) as YakıtTutarı FROM ARACYAKIT where Plaka = DSHIPNAME 
                group by Plaka) yakit
                --group by DSHIPVAL,DSHIPNAME,DIVREGION,DIVNAME
                order by 2,3
                drop table #ARAC";
                SqlDataAdapter da = new SqlDataAdapter(q, arac);
                DataTable dt = new DataTable();
                da.Fill(dt);
                pivotGridControl1.DataSource = dt;
                gridYakit.Visible = false;
                pivotGridControl1.Visible = true;
                pivotGridControl1.Dock = DockStyle.Fill;
            }
            else
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

                select DSHIPVAL,DSHIPNAME,substring(isnull(DSHIPDIVLIST,'00'),1,2) from VDB_YON01.dbo.DEFSHIPMENT where DSHIPSTS = 1
                and DSHIPVAL not in (
                'ARAS',
                'CEVA',
                'HOROZ',
                'MARS',
                'MNG',
                'PTT',
                'YURT',
                'BORUSA',
                'MOBILY')
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

                select DSHIPNAME as PLAKA,DIVNAME as MAĞAZA,isnull(DIVREGION,'MERKEZ') as BOLGE,IL,IstasyonAdı
                ,YakıtFiyatı,YakıtMiktarı,YakıtTutarı
                from #ARAC
			    left outer join ARACYAKIT on Plaka = DSHIPNAME
                outer apply (select distinct substring(DIVNAME,1,CHARINDEX(' ',DIVNAME)) as DIVNAME,DIVREGION from VDB_YON01.dbo.DIVISON where DIVVAL = DSHIPDIVLIST) MAGAZA
                --outer apply (select Plaka,COUNT(YakıtFiyatı) as YakıtFiyatı,sum([YakıtMiktarı]) as YakıtMiktarı,sum([YakıtTutarı]) as YakıtTutarı FROM ARACYAKIT where Plaka = DSHIPNAME 
                --group by Plaka) yakit
			    where ARACYAKIT.Tarih between '{0}' and '{1}'
                --group by DSHIPVAL,DSHIPNAME,DIVREGION,DIVNAME
                order by 1,3,2
                drop table #ARAC",Convert.ToDateTime(dteStart.EditValue).ToString("yyyy-MM-dd"), Convert.ToDateTime(dteEnd.EditValue).ToString("yyyy-MM-dd"));

                SqlDataAdapter da2 = new SqlDataAdapter(qq, arac);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                gridYakit.DataSource = dt2;
                gridYakit.Visible = true;
                pivotGridControl1.Visible = false;
                gridYakit.Dock = DockStyle.Fill;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string q = string.Format(@"select DSHIPNAME,PRONAME,MASRAFTARIHI,MASRAFADET,MASRAFTUTAR,MASRAFADET*MASRAFTUTAR  from VDB_YON01..DEFSHIPMENT
            left outer join ARACMASRAF on DSHIPVAL = convert(varchar(10),ARACID)
            left outer join VDB_YON01..PRODUCTS on PROID = MASRAFTIPIID
            where DSHIPSTS = 1 and MASRAFID is not NULL
            and MASRAFTARIHI between '{0}' and '{1}'", Convert.ToDateTime(dteStart2.EditValue).ToString("yyyy-MM-dd"), Convert.ToDateTime(dteEnd2.EditValue).ToString("yyyy-MM-dd"));
            SqlDataAdapter da = new SqlDataAdapter(q, arac);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridMasraf.DataSource = dt;
        }

        private void CreateDirectoryIfNotExists(string directoryPath)
        {


            if (!Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                    MessageBox.Show($"'{directoryPath}' dizini oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{directoryPath}' dizini oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExcel1_Click(object sender, EventArgs e)
        {
            if (togyakit.IsOn==false)
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ARAC MASRAF RAPORLARI", " YAKIT MASRAFI");
                CreateDirectoryIfNotExists(path);
                string file = Path.Combine(path, "Yakıt Kümülatif.xlsx");
                pivotGridControl1.ExportToXlsx(file);
                Process.Start(file);
            }
            else
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ARAC MASRAF RAPORLARI", " YAKIT MASRAFI");
                CreateDirectoryIfNotExists(path);
                string file = Path.Combine(path, "Yakıt Detayli.xlsx");
                gridYakit.ExportToXlsx(file);
                Process.Start(file);
            }
        }

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "ARAC MASRAF RAPORLARI", " DİGER MASRAFLAR");
            CreateDirectoryIfNotExists(path);
            string file = Path.Combine(path, Convert.ToDateTime(dteStart2.EditValue).ToString("yyyy-MM")+"-"+ Convert.ToDateTime(dteEnd2.EditValue).ToString("yyyy-MM") + ".xlsx");
            gridMasraf.ExportToXlsx(file);
            Process.Start(file);
        }
    }
}