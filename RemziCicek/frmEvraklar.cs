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
using System.IO;
using System.Net;
using System.Diagnostics;

namespace RemziCicek
{
    public partial class frmEvraklar : XtraForm
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject sql = new SqlConnectionObject();
        OpenFileDialog file = new OpenFileDialog();
        DateTime _Folderdate = DateTime.Now;
        string pass = "Tools";
        string uys = "07562032?";
        string url = "ftp://212.174.235.106:1021/RemziCicek/";
        string local = "ftp://192.168.4.21/RemziCicek/";
        string folder = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MMMM");

        string Islem = "";
        string Arac = "";
        string _tarih = "";
        public frmEvraklar(string _Islem, string _Arac, string tarih)
        {
            InitializeComponent();
            Arac = _Arac;
            Islem = _Islem;
            if (tarih == "")
            {
                _tarih = Convert.ToString(DateTime.Now);
            }
            else
            {
                _tarih = tarih;
            }
        }
        private void frmEvraklar_Load(object sender, EventArgs e)
        {
            var q = "Select * from Islem_Dekont where Arac = '" + Arac + "'";
            if (Islem != "")
            {
                q = q + " and Islemid = '" + Islem + "'";
            }
            SqlDataAdapter da4 = new SqlDataAdapter(q, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            gridDekont.DataSource = dt;
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


            frmIslem_Pdf gor = new frmIslem_Pdf(tempFileName);
            gor.ShowDialog();

            //var process = new Process();
            //process.StartInfo.FileName = tempFileName;
            //process.Start();

            //process.EnableRaisingEvents = true;

            //    File.Delete(tempFileName);
        }

        string[] fileLIST;
        private void btndosyasec2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "*.Jpg; *.JPEG; *.PDF|*.Jpg; *.JPEG; *.PDF";
            open.Multiselect = true;
            open.Title = "Yüklenecek Dosya Seçin.";
            open.InitialDirectory = "C://Desktop";

            if (open.ShowDialog() == DialogResult.OK)
            {
                fileLIST = open.FileNames;

            }
            else
            {
                MessageBox.Show("Dosya Seçilmedi");
                txtdekont2.Text = null;
            }
            Uploadbulkftpfiles(fileLIST);

        }

        public void CreateFolderFTP()
        {
            try
            {
                string path = Arac.Replace(" ", "") ;
                string xmlPath = url + path;
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(xmlPath);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(pass, uys);
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();


                string url3 = "ftp://212.174.235.106:1021/RemziCicek/";
                string path2 = Arac.Replace(" ", "") + "/" + Convert.ToDateTime(_tarih).ToString("yyyy") + "-" + Convert.ToDateTime(_tarih).ToString("MMMM");
                string xmlPath2 = url3 + path2;
                FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create(xmlPath2);
                request2.Method = WebRequestMethods.Ftp.MakeDirectory;
                request2.Credentials = new NetworkCredential(pass, uys);
                FtpWebResponse response2 = (FtpWebResponse)request2.GetResponse();
            }
            catch (Exception ex)
            {

            }
        }
        public void FtpTransfer(string fullPath)
        {
            CreateFolderFTP();
            folder = Convert.ToDateTime(_tarih).ToString("yyyy") + "-" + Convert.ToDateTime(_tarih).ToString("MMMM");
            string path = Arac.Replace(" ", "") + "/" + Convert.ToDateTime(_tarih).ToString("yyyy") + "-" + Convert.ToDateTime(_tarih).ToString("MMMM");
            string From = path + "/" + Path.GetFileName(fullPath);
            string To = url + From;

            var selectedRows = ViewDekont.RowCount.ToString();
            int adet = 0;
            adet = Convert.ToInt32(selectedRows);
            adet = adet + 1;

            string newName = "";
            string s1 = fullPath;
            string s2 = "jpg";
            string s3 = "jpeg";
            string s4 = "pdf";

            string s5 = "JPG";
            string s6 = "JPEG";
            string s7 = "PDF";



            bool b = s1.Contains(s2);
            bool c = s1.Contains(s3);
            bool d = s1.Contains(s4);
            bool f = s1.Contains(s5);
            bool g = s1.Contains(s6);
            bool h = s1.Contains(s7);

            if (b)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.jpg";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".jpg";
                }
            }

            if (c)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.jpeg";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".jpeg";
                }
            }

            if (d)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.pdf";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".pdf";
                }
            }
            if (f)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.JPG";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".JPG";
                }
            }
            if (g)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.JPEG";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".JPEG";
                }
            }
            if (h)
            {
                if (selectedRows == "0")
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.PDF";
                }
                else
                {
                    newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + adet + ".PDF";
                }
            }

            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential(pass, uys);
                client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, fullPath);
                //client.UploadFileAsync(new Uri(To), newName, fullPath);


                FtpWebRequest FTP;
                try
                {
                    FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(To));
                    FTP.UseBinary = true;
                    string yeniisim = newName;
                    FTP.RenameTo = yeniisim;
                    FTP.Credentials = new NetworkCredential(pass, uys);
                    FTP.Method = WebRequestMethods.Ftp.Rename;
                    FtpWebResponse response = (FtpWebResponse)FTP.GetResponse();
                    Console.WriteLine(response.StatusDescription);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

        }
        string Fullpath = "";
        private void btndosyayukle2_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(file.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Dosya Seçilmedi");
                }
                else
                {

                    //string folder = _avid.Replace(" ", "");
                    //we already define our connection globaly. We are just calling the object of connection.
                    FtpTransfer(Fullpath);

                    int selectedRows = ViewDekont.RowCount + 1;


                    string newName = "";
                    string s1 = filename;
                    string s2 = "jpg";
                    string s3 = "jpeg";
                    string s4 = "pdf";

                    string s5 = "JPG";
                    string s6 = "JPEG";
                    string s7 = "PDF";



                    bool b = s1.Contains(s2);
                    bool c = s1.Contains(s3);
                    bool d = s1.Contains(s4);
                    bool f = s1.Contains(s5);
                    bool g = s1.Contains(s6);
                    bool h = s1.Contains(s7);

                    if (b)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.jpg";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".jpg";
                        }
                    }

                    if (c)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.jpeg";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".jpeg";
                        }
                    }

                    if (d)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.pdf";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".pdf";
                        }
                    }
                    if (f)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.JPG";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".JPG";
                        }
                    }
                    if (g)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.JPEG";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".JPEG";
                        }
                    }
                    if (h)
                    {
                        if (selectedRows == 0)
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_1.PDF";
                        }
                        else
                        {
                            newName = Arac + "-" + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy").Replace("-", "_") + "_" + selectedRows + ".PDF";
                        }
                    }
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = new SqlCommand("insert into Islem_Dekont(Islemid,Arac,tarih,folder_path,file_name) values ('"+Islem + "','"  + Arac + "','" + Convert.ToDateTime(_tarih).ToString("dd - MM - yyyy") + "','" + folder + "','" + newName + "')", conn);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    XtraMessageBox.Show(Fullpath + " Seçilen Dosya " + newName + " İsmi İle " + Convert.ToDateTime(_tarih).ToString("dd-MM-yyyy") + " Tarihli Kasaya Yüklendi", "Bilgi");
                    txtdekont2.Text = null;
                    yenile();
                }

                //KasaMerkezDekont_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yenile()
        {
            var q = "Select * from Islem_Dekont where Islemid = '" + Islem + "' and Arac = '" + Arac + "'";
            SqlDataAdapter da4 = new SqlDataAdapter(q, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            gridDekont.DataSource = dt;
        }

        private void ViewDekont_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                var file_name = ViewDekont.GetRowCellValue(e.RowHandle, "file_name").ToString();
                var folder_path = ViewDekont.GetRowCellValue(e.RowHandle, "folder_path").ToString();
                if (file_name.EndsWith("pdf") == true || file_name.EndsWith("PDF") == true)
                {
                    //KasaMerkezDekont_Pdf pdf = new KasaMerkezDekont_Pdf(url + _magaza.Replace(" ", "") + "/" + folder_path + "/" + file_name);
                    //pdf.ShowDialog();
                    PDF(url + Arac.Replace(" ", "") + "/" + folder_path + "/" + file_name, pass, uys);
                    //OpenWithDefaultProgram(url + _magaza.Replace(" ", "") + "/" + folder_path + "/" + file_name);
                }
                else
                {
                    ShowPhoto(url + Arac.Replace(" ", "") + "/" + folder_path + "/" + file_name, pass, uys);
                }
            }
            else if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Right)
            {
                popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ViewDekont_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            var file_name = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "file_name").ToString();
            var folder_path = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "folder_path").ToString();            
            popupMenu1.ShowPopup(barManager1, new Point(MousePosition.X, MousePosition.Y));
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var file_name = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "file_name").ToString();
            var folder_path = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "folder_path").ToString();
            //var to = url.ToString() + Arac.Replace(" ", "") + "/" + folder_path + "/" + file_name;
            string newFolder="";
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                newFolder = Path.GetDirectoryName(folderBrowser.FileName);
                
            }
            var  asdf = newFolder + @"\" + file_name;


                using (WebClient client = new WebClient())
                {
                //    client.Credentials = new NetworkCredential(pass, uys);
                //    client.DownloadFile(to, @"E:\" + file_name);

                FtpWebRequest request =  (FtpWebRequest)WebRequest.Create(url.ToString() + Arac.Replace(" ", "") + "/" + folder_path + "/" + file_name);
                request.Credentials = new NetworkCredential(pass, uys);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                using (Stream ftpStream = request.GetResponse().GetResponseStream())
                using (Stream fileStream = File.Create(newFolder +@"\"+ file_name))
                {
                    ProgressBarFrm progressForm = new ProgressBarFrm()
                    {
                        Start = 0,
                        Finish = (int)fileStream.Length,
                        Position = 0,
                    };
                    progressForm.Show(this);
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = ftpStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, read);
                        //Console.WriteLine("Downloaded {0} bytes", fileStream.Position);
                    }
                    
                        progressForm.Hide(this);
                    
                }
            }
            XtraMessageBox.Show(file_name + " isimli dosya "+ newFolder +" kaydedildi");
        }



        public void Uploadbulkftpfiles(string[] list)
        {
            var file_name = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "file_name").ToString();
            var folder_path = ViewDekont.GetRowCellValue(ViewDekont.FocusedRowHandle, "folder_path").ToString();
            bool ife;// is folder exists
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url.ToString() + Arac.Replace(" ", "") + "/" + folder_path + "/");
                request.Credentials = new NetworkCredential(pass, uys);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                ife = true;
            }
            catch (Exception)
            {

                ife = false;
            }

            /////////////////////////////////////////////begin of upload process

            if (ife)//the folder is already exists
            {
                foreach (var str in list)
                {
                    try
                    {
                        FtpWebRequest requestUP2 = (FtpWebRequest)WebRequest.Create(url.ToString() + Arac.Replace(" ", "") + "/" + folder_path + "/" + str);
                        requestUP2.Credentials = new NetworkCredential(pass, uys);
                        requestUP2.Method = WebRequestMethods.Ftp.UploadFile;
                        requestUP2.KeepAlive = false;
                        requestUP2.UsePassive = true;
                        using (Stream fileStream = File.OpenRead("ftp://ftpsite.com/folder" + str))
                        using (Stream ftpStream = requestUP2.GetRequestStream())
                        {
                            fileStream.CopyTo(ftpStream);
                        }
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }

                }
            }
            else if (!ife)
            {
                //CREATE THE FOLDER
                try
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp:ftpsite/folder");
                    request.Credentials = new NetworkCredential("UserName", "Password");
                    request.Method = WebRequestMethods.Ftp.MakeDirectory;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                }
                catch (Exception excr) { MessageBox.Show(excr.Message); }



                //UPLOAD THE FILES
                foreach (var str in list)
                {
                    try
                    {
                        FtpWebRequest requestUP2 = (FtpWebRequest)WebRequest.Create("ftp://ftpsite.com/folder" + str);
                        requestUP2.Credentials = new NetworkCredential("UserName", "Password");
                        requestUP2.Method = WebRequestMethods.Ftp.UploadFile;
                        requestUP2.KeepAlive = false;
                        requestUP2.UsePassive = true;
                        using (Stream fileStream = File.OpenRead("ftp://ftpsite.com/folder" + str))
                        using (Stream ftpStream = requestUP2.GetRequestStream())
                        {
                            fileStream.CopyTo(ftpStream);
                        }
                    }
                    catch (Exception ex1)
                    {

                        MessageBox.Show(ex1.Message);
                    }

                }
            }
        }
    }
}