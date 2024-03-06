using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek
{
	public partial class frmMasraf : Form
	{
		SqlConnection vol = new SqlConnection(Properties.Settings.Default.VolConnection);

        SqlConnection arac = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject conn = new SqlConnectionObject();

        DataTable masraflistesi = new DataTable();

        public frmMasraf()
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = "McSkin";
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.XtraEditors.WindowsFormsSettings.AllowDefaultSvgImages = DevExpress.Utils.DefaultBoolean.False;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("TR-tr");
            InitializeComponent();
		}

		private void frmMasraf_Load(object sender, EventArgs e)
        {
            masraflistesi.Columns.Add("AracID");
            masraflistesi.Columns.Add("Plaka");
            masraflistesi.Columns.Add("TARIH");
            masraflistesi.Columns.Add("MasrafID");
            masraflistesi.Columns.Add("MasrafTipi");
            masraflistesi.Columns.Add("Adet");
            masraflistesi.Columns.Add("Tutar");
            masraflistesi.Columns.Add("Toplam");
            masraflistesi.Columns.Add("Evrak");
            Arac();
			MasrafTipi();
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
			string q = string.Format(@"select PROID,PRONAME from PRODUCTS where PROKIND = 6");
			SqlDataAdapter da = new SqlDataAdapter(q, vol);
			DataTable dt = new DataTable();
			da.Fill(dt);
			cmbMasraf.Properties.DisplayMember = "PRONAME";
			cmbMasraf.Properties.ValueMember = "PROID";
			cmbMasraf.Properties.DataSource = dt;
		}

		string Fullpath = "";
		string pass = "Kama";
		string uys = "Kama2023!";
		string url = "ftp://192.168.4.22//Arac/";
        internal MainForm mdiParent;

        public void FtpTransfer(string fullPath)
		{

			string From = "/"+ cmbArac.Text + "//" + Convert.ToDateTime(dteMasrafTarihi.EditValue).ToString("yyyyMMdd") +"//"+ Path.GetFileName(fullPath);
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
            if (cmbArac.Text != "Seçiniz...!")
            {
                if (cmbMasraf.Text != "Seçiniz...!")
                {
                    OpenFileDialog file = new OpenFileDialog();
                    file.InitialDirectory = "C://Desktop";
                    //Your opendialog box title name.
                    file.Title = "Yüklenecek Dosya Seçin.";
                    //which type file format you want to upload in database. just add them. default =  "Select Valid Document(*.pdf; *.Jpg; *.JPEG)|*.pdf; *.docx; *.xlsx; *.html";
                    file.Filter = "PDF DOSYALAR; Jpg RESİM; JPEG RESİM; Png RESİM)|*.pdf; *.Jpg; *.JPEG; *.png";
                    //FilterIndex property represents the index of the filter currently selected in the file dialog box.
                    file.FilterIndex = 4;
                    try
                    {
                        if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (file.CheckFileExists)
                            {
                                Fullpath = System.IO.Path.GetFullPath(file.FileName);
                                masraflistesi.Rows.Add(cmbArac.EditValue, cmbArac.Text,dteMasrafTarihi.EditValue, cmbMasraf.EditValue.ToString(), cmbMasraf.Text, txtAdet.Text, txtFiyat.Text,(int.Parse(txtAdet.Text.ToString())*double.Parse(txtFiyat.Text.ToString())).ToString(), Fullpath);
                                gridKalemler.DataSource = masraflistesi;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Dosya Seçilmedi");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Masraf Seçiniz");
                    cmbMasraf.Focus();
                }
            }
            else
            {
                MessageBox.Show("Araç Seçiniz");
                cmbArac.Focus();
            }

            //string filename = System.IO.Path.GetFileName(viewKalemler.GetRowCellValue(viewKalemler.FocusedRowHandle, "DosyaYolu").ToString());
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {

                for (int i = 0; i < viewKalemler.RowCount; i++)
                {
                    string ftp = url + "/" + cmbArac.Text;
                    CreateFolderFTP(ftp);
                    CreateFolderFTP(ftp + "//" + Convert.ToDateTime(dteMasrafTarihi.EditValue).ToString("yyyyMMdd"));
                    FtpTransfer(Fullpath);
                    var ftppath = ftp + "//" + Convert.ToDateTime(dteMasrafTarihi.EditValue).ToString("yyyyMMdd") + "//" + Path.GetFileName(Fullpath);
                    Dictionary<string, string> evrak = new Dictionary<string, string>();
                    evrak.Add("@evrakyolu", ftppath);
                    var evrakyolu = conn.MDEQuery("ARACEVRAKEKLE", evrak);

                    if (evrakyolu.Rows.Count > 0)
                    {

                        Dictionary<string, string> masraf = new Dictionary<string, string>();
                        masraf.Add("@ARACID", viewKalemler.GetRowCellValue(i, "AracID").ToString());
                        masraf.Add("@ARACPLAKA", viewKalemler.GetRowCellValue(i, "Plaka").ToString());
                        masraf.Add("@MASRAFTIPIID", viewKalemler.GetRowCellValue(i, "MasrafID").ToString());
                        masraf.Add("@MASRAFTARIHI", Convert.ToDateTime(viewKalemler.GetRowCellValue(i, "TARIH").ToString()).ToString("yyyy-MM-dd").ToString());
                        masraf.Add("@MASRAFADET", viewKalemler.GetRowCellValue(i, "Adet").ToString());
                        masraf.Add("@MASRAFTUTAR", viewKalemler.GetRowCellValue(i, "Tutar").ToString());
                        masraf.Add("@MASRAFEVRAKID", evrakyolu.Rows[0][0].ToString());
                        conn.MDEInsert("ARACMASRAFEKLE", masraf);
                    }
                    else
                    {
                        MessageBox.Show("Resim Yüklenemedi");
                    }

                }
                gridKalemler.DataSource = null;
                masraflistesi.Rows.Clear();
                MessageBox.Show("Masraflar Yüklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }	
}
