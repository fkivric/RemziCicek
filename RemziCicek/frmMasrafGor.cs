using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek
{
	public partial class frmMasrafGor : XtraForm
	{
		SqlConnection vol = new SqlConnection(Properties.Settings.Default.VolConnection);

        SqlConnection arac = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject conn = new SqlConnectionObject();


        DataTable masraflistesi = new DataTable();
		public frmMasrafGor()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "McSkin";
            DefaultLookAndFeel defaultLookAndFeel = new DefaultLookAndFeel();
            defaultLookAndFeel.LookAndFeel.SkinName = "McSkin";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = true;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
		}

		private void frmMasraf_Load(object sender, EventArgs e)
        {
            dteMasrafstart.EditValue = DateTime.Now;
            dteMasrafend.EditValue = DateTime.Now;
            Arac();
			MasrafTipi();
            masraflistesi.Columns.Add("AracID");
            masraflistesi.Columns.Add("Plaka");
            masraflistesi.Columns.Add("MasrafID");
            masraflistesi.Columns.Add("MasrafTipi");
            masraflistesi.Columns.Add("Adet");
            masraflistesi.Columns.Add("Tutar");
            masraflistesi.Columns.Add("Evrak");
		}
		void Arac()
		{
            string qw = @"select DSHIPVAL,DSHIPNAME from DEFSHIPMENT where DSHIPSTS = 1
            and DSHIPVAL not in (
            'ARAS',
            'BORUSA',
            'CEVA',
            'HOROZ',
            'MARS',
            'MNG',
            'MOBILY',
            'PTT',
            'YURT'
            )";

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
			SqlDataAdapter da = new SqlDataAdapter(qw, vol);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cmbArac.Properties.DisplayMember = "DSHIPNAME";
			cmbArac.Properties.ValueMember = "DSHIPVAL";
			cmbArac.Properties.DataSource = dt;
		}
		void MasrafTipi()
		{
			string q = string.Format(@"select PROVAL,PRONAME from PRODUCTS where PROKIND = 6");
			SqlDataAdapter da = new SqlDataAdapter(q, vol);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cmbMasraf.Properties.DisplayMember = "PRONAME";
			cmbMasraf.Properties.ValueMember = "PROVAL";
			cmbMasraf.Properties.DataSource = dt;
		}

		string Fullpath = "";
		string pass = "Kama";
		string uys = "Kama2023!";
		string url = "ftp://192.168.4.22//Arac/";
		string folder = "";
		public void FtpTransfer(string fullPath)
		{

			string From = "/"+ cmbArac.Text + "//" + Convert.ToDateTime(dteMasrafstart.EditValue).ToString("yyyyMMdd") +"//"+ Path.GetFileName(fullPath);
			string To = url + From;

            //string newName = "";
            //string s1 = fullPath;


            using (WebClient client = new WebClient())
			{
				client.Credentials = new NetworkCredential(pass, uys);
				client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, fullPath);
				//client.UploadFileAsync(new Uri(To), newName, fullPath);


				//FtpWebRequest FTP;
				//try
				//{
				//    FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(To));
				//    FTP.UseBinary = true;
				//    string yeniisim = newName;
				//    FTP.RenameTo = yeniisim;
				//    FTP.Credentials = new NetworkCredential(pass, uys);
				//    FTP.Method = WebRequestMethods.Ftp.Rename;
				//    FtpWebResponse response = (FtpWebResponse)FTP.GetResponse();
				//    Console.WriteLine(response.StatusDescription);
				//}
				//catch (Exception ex)
				//{
				//    Console.WriteLine(ex.Message);
				//}


			}

		}

		public void CreateFolderFTP(string directoryPath)
		{
			try
			{
				string path = directoryPath; //_magaza.Replace(" ", "") + "/" + Convert.ToDateTime(_tarih).ToString("yyyy") + "-" + Convert.ToDateTime(_tarih).ToString("MMMM");
				string xmlPath = path;
				FtpWebRequest request = (FtpWebRequest)WebRequest.Create(xmlPath);
				request.Method = WebRequestMethods.Ftp.MakeDirectory;
				request.Credentials = new NetworkCredential(pass, uys);
				FtpWebResponse response = (FtpWebResponse)request.GetResponse();
			}
			catch (Exception ex)
			{

			}
		}
		private void CreateDirectoryIfNotExists(string directoryPath)
		{


			if (!Directory.Exists(directoryPath))
			{
				try
				{
                    CreateFolderFTP(directoryPath);
					//Directory.CreateDirectory(directoryPath);
					MessageBox.Show($"'{directoryPath}' dizini oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show($"'{directoryPath}' dizini oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void simpleButton1_Click(object sender, EventArgs e)
		{
            string bugun = Convert.ToDateTime(DateTime.Now).ToString("yyyyMMdd");
            string raporubasgun = Convert.ToDateTime(dteMasrafstart.EditValue).ToString("yyyyMMdd");
            string raporusongun = Convert.ToDateTime(dteMasrafend.EditValue).ToString("yyyyMMdd");
            string qq = string.Format(@"	select MASRAFID,ARACID,ARACPLAKA,MASRAFTARIHI,PRONAME,MASRAFADET,MASRAFTUTAR,(MASRAFADET*MASRAFTUTAR) as Toplam ,EVRAKYOLU from ARACMASRAF
	        left outer join ARACEVRAK on MASRAFEVRAKID = EVRAKID
	        left outer join VDB_YON01.dbo.PRODUCTS on PROID = MASRAFTIPIID
            where MASRAFTARIHI between '{0}' and '{1}'", raporubasgun, raporusongun);
            if (cmbArac.Text != "Seçiniz...!")
            {
                qq = qq + string.Format(@"and ARACPLAKA = '{0}'", cmbArac.Text);
            }
            if (cmbMasraf.Text != "Seçiniz...!")
            {
                qq = qq + string.Format(@"AND MASRAFTIPIID = {0}", cmbMasraf.EditValue.ToString());
            }
            SqlDataAdapter da = new SqlDataAdapter(qq, arac);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                gridKalemler.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Masraf Kaydı Yok");
            }
        }

        private void btnEvrakGor_Click(object sender, EventArgs e)
        {
            var file_name = viewKalemler.GetRowCellValue(viewKalemler.FocusedRowHandle, "EVRAKYOLU").ToString();
            if (file_name.EndsWith("pdf") == true || file_name.EndsWith("PDF") == true)
            {
                //KasaMerkezDekont_Pdf pdf = new KasaMerkezDekont_Pdf(url + _magaza.Replace(" ", "") + "/" + folder_path + "/" + file_name);
                //pdf.ShowDialog();
                PDF(file_name, pass, uys);
                //OpenWithDefaultProgram(url + _magaza.Replace(" ", "") + "/" + folder_path + "/" + file_name);
            }
            else
            {
                ShowPhoto(file_name, pass, uys);
            }
        }

        public void ShowPhoto(String uri, String username, String password)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(username, password);
            byte[] imageByte = ftpClient.DownloadData(uri);


            var tempFileName = Path.GetTempFileName();
            System.IO.File.WriteAllBytes(tempFileName, imageByte);

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFiles);

            // create our startup process and argument
            var psi = new ProcessStartInfo(
                "rundll32.exe",
                String.Format(
                    "\"{0}{1}\", ImageView_Fullscreen {2}",
                    Environment.Is64BitOperatingSystem ?
                        path.Replace(" (x86)", "") :
                        path
                        ,
                    @"\Windows Photo Viewer\PhotoViewer.dll",
                    tempFileName)
                );

            psi.UseShellExecute = false;

            var viewer = Process.Start(psi);
            // cleanup when done...
            viewer.EnableRaisingEvents = true;
            viewer.Exited += (o, args) =>
            {
                File.Delete(tempFileName);
            };
        }

        public void PDF(String uri, String username, String password)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(username, password);
            byte[] imageByte = ftpClient.DownloadData(uri);


            var tempFileName = Path.GetTempFileName().Replace("tmp", "pdf");
            System.IO.File.WriteAllBytes(tempFileName, imageByte);

            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.ProgramFiles);


            frmMasrafPDF gor = new frmMasrafPDF(tempFileName);
            gor.ShowDialog();

            //var process = new Process();
            //process.StartInfo.FileName = tempFileName;
            //process.Start();

            //process.EnableRaisingEvents = true;

            //    File.Delete(tempFileName);



        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var ss = viewKalemler.GetRowCellValue(viewKalemler.FocusedRowHandle, "MASRAFID").ToString();
                string masrafsilq = string.Format(@"delete ARACMASRAF where MASRAFID = {0}", ss);
                SqlCommand cmd = new SqlCommand(masrafsilq, arac);
                if (arac.State == ConnectionState.Closed)
                {
                    arac.Open();
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi");
                simpleButton1_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
