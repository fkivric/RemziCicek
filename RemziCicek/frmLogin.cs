using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using RemziCicek.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static VolantMusteriDuzel.Class.Volant;
using RemziCicek.Properties;
using System.Data.SqlClient;
using System.Reflection.Emit;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors.Design;
using System.Threading;
using System.Net.Http;
using Microsoft.Win32;
using System.Diagnostics;
using static RemziCicek.Class.Entegref;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Globalization;

namespace RemziCicek
{

    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private string clientName;
        public static string userID;

        private readonly HttpClient httpClient;
        bool isSettings;
        bool checkok;
        string IslemName = "";
        public static string VKN = null;
        public static string SOCODE = "";
        string version = "";
        public static int lisansKalan = 0;
        string ProductName = "";
        SqlConnectionObject conn = new SqlConnectionObject();
        SqlConnection Entgref = new SqlConnection("Server=31.145.19.56;Database=Netbil_Connector; User ID=fatih;Password=05101981;");
        public frmLogin()
        {
            InitializeComponent();

            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://lisans.entegref.com/");
            if (VKN == null)
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
                var keyVKN = key.GetValue("ApplicationVKN");
                if (keyVKN == null)
                {
                    key.SetValue("ApplicationVKN", Properties.Settings.Default.VKN);
                }
                if (!string.IsNullOrEmpty(key.GetValue("ApplicationVKN").ToString()))
                {
                    VKN = key.GetValue("ApplicationVKN").ToString();
                }
                else
                {
                    VKN = Properties.Settings.Default.VKN;
                }
            }
        }
        private List<eDatabase> lDatabase;
        List<Firma> firmas = new List<Firma>();
        private async void frmLogin_LoadAsync(object sender, EventArgs e)
        {
            ProductName = System.Reflection.Assembly.GetEntryAssembly().GetName().Name.ToString(); // proje adı
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                lblversion.Text = "Version : " + ad.CurrentVersion.Major + "." + ad.CurrentVersion.Minor + "." + ad.CurrentVersion.Build + "." + ad.CurrentVersion.Revision;
                version = ad.CurrentVersion.Revision.ToString();
            }
            else
            {
                string _s1 = Application.ProductVersion; // versiyon
                lblversion.Text = "Version : " + _s1;
                version = _s1;
            }
            VolXml();
            DataCek();
            DataTable Compny = Sorgu("select distinct CATALOG_NAME from INFORMATION_SCHEMA.SCHEMATA", Settings.Default.VolConnection);
            cmbVolantSirket.Properties.DataSource = firmas;// Compny;
            cmbVolantSirket.Properties.DisplayMember = "COMPANYNAME";
            cmbVolantSirket.Properties.ValueMember = "COMPANYDB";
            cmbVolantSirket.EditValue = Compny.Rows[0]["CATALOG_NAME"];
            string company = Properties.Settings.Default.Company;
            if (company.Contains("YON") || company.Contains("KAMALAR"))
            {
                pictureEdit2.Visible = true;
            }

            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
            string[] valueNames = key2.GetValueNames();
            if (!valueNames.Contains("ApplicationSetupComplate"))
            {
                if (!valueNames.Contains("ComputerLisansingID"))
                {
                    //CustomMessageBox.ShowMessage("Lütfen Bekleyin: ", "Propgram Lisanslanıyor", this, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var pcİsmi = key2.GetValue("ComputerName");
                    var pcModeli = key2.GetValue("ComputerID");
                    var Cpuid = key2.GetValue("CPU");
                    var Motherboardid = key2.GetValue("motherboardid");
                    Entegref client = new Entegref();
                    string response = await client.UpdateLicensingUser(VKN, pcİsmi.ToString(), pcModeli.ToString(), version, ProductName);
                    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseData);
                    List<Sonuc> myDeserializedClass = JsonConvert.DeserializeObject<List<Sonuc>>(response);
                    var ConnectionLisansingID = myDeserializedClass[0].message;
                    string response2 = await client.UpdateLicensing(VKN, ConnectionLisansingID.ToString(), Cpuid.ToString(), Motherboardid.ToString(), ProductName);
                    List<Sonuc> myDeserializedClass2 = JsonConvert.DeserializeObject<List<Sonuc>>(response2);
                    if (!valueNames.Contains("ApplicationSecretPhase"))
                    {
                        //string SecretPhase = key2.GetValue("ApplicationSecretPhase").ToString();

                        //if (string.IsNullOrEmpty(SecretPhase))
                        //{
                        Lisansing(VKN);
                        //await Task.Delay(1000);
                        RegistryKey lisans = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
                        SKGL.Validate validate = new SKGL.Validate();
                        validate.secretPhase = VKN;
                        validate.Key = lisans.GetValue("ApplicationSecretPhase").ToString();
                        txtLisansing2.Text = "Başlangıç Tarihi : \r\n " + validate.CreationDate.ToShortDateString();
                        txtLisansing3.Text = "Sona Erme Tarihi : \r\n " + validate.ExpireDate.ToShortDateString();
                        txtLisansing1.Text = "Kalan Gün : \r\n " + validate.DaysLeft;
                        lisansKalan = validate.DaysLeft;

                        if (Properties.Settings.Default.EntegrefSecretPhase != "")
                        {

                            key2.SetValue("ApplicationSetupComplate", "true");
                            key2.SetValue("ApplicationSecretPhase", Properties.Settings.Default.EntegrefSecretPhase);// Properties.Settings.Default.EntegrefSecretPhase);
                        }
                        if (validate.DaysLeft > 20)
                        {
                            pnlLisans.Visible = false;
                            this.Size = new Size(718, 325);
                        }
                        //}
                    }
                    key2.SetValue("ComputerLisansingID", myDeserializedClass2[0].message);
                    key2.SetValue("ApplicationSetupComplate", true);
                    key2.Close();
                }
            }
            else
            {
                var vknvar = key2.GetValue("ApplicationVKN");
                var pcİsmi = key2.GetValue("ComputerName");
                Entegref client = new Entegref();
                string response = await client.Versiyon(vknvar.ToString(), pcİsmi.ToString(), ProductName);
                //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseData);
                List<Sonuc> myDeserializedClass = JsonConvert.DeserializeObject<List<Sonuc>>(response);
                if (myDeserializedClass[0].message == "Yok")
                {
                    string response2 = await client.Versiyon(vknvar.ToString(), pcİsmi.ToString(), ProductName);
                }
                else
                {
                    int new_version = int.Parse(myDeserializedClass[0].message.Replace(".", ""));
                    int last_version = int.Parse(version.Replace(".", ""));
                    if (new_version > last_version)
                    {
                        this.Enabled = false;
                        try
                        {
                            string pathToUpdater = @"Kasa Update.exe"; // updater.exe dosyasının adını belirtin

                            ProcessStartInfo startInfo = new ProcessStartInfo
                            {
                                FileName = pathToUpdater,
                                WindowStyle = ProcessWindowStyle.Normal // İsteğe bağlı: Pencere stili
                            };

                            Process.Start(startInfo);
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            CustomMessageBox.ShowMessage("Güncelleme Var Hata = " + ex.Message, "Güncelleme var Oto güncelleme Çalışmadı! Elle güncelleyiniz.\r\n Seçenekler = \r\n 1-) C:\\Program Files (x86)\\Entegref Yazılım Tic. Ltd.Şti\\EntegreF Connector\\updater.exe dosya yoluna gidip güncelleme programını çalıştırınız.\r\n 2-) Başlat butonundan Updater aratarak çıkanı çalıştırınız", this, "Güncelleme Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Enabled = true;
                        }
                    }
                }
                SKGL.Validate validate = new SKGL.Validate();
                validate.secretPhase = VKN;
                validate.Key = key2.GetValue("ApplicationSecretPhase").ToString();
                txtLisansing2.Text = "Başlangıç Tarihi : \r\n " + validate.CreationDate.ToShortDateString();
                txtLisansing3.Text = "Sona Erme Tarihi : \r\n " + validate.ExpireDate.ToShortDateString();
                txtLisansing1.Text = "Kalan Gün : \r\n" + validate.DaysLeft;
                lisansKalan = validate.DaysLeft;
                if (Properties.Settings.Default.EntegrefSecretPhase != "")
                {

                    key2.SetValue("ApplicationSetupComplate", "true");
                    key2.SetValue("ApplicationSecretPhase", Properties.Settings.Default.EntegrefSecretPhase);// Properties.Settings.Default.EntegrefSecretPhase);
                }
                if (validate.DaysLeft > 20)
                {
                    pnlLisans.Visible = false;
                    this.Size = new Size(718, 325);
                }
                else
                {
                    CustomMessageBox.ShowMessage("Entegref ile iletişime geçerek Lütfen Lisansınızı uzatınız", "", this, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (lisansKalan <= 0)
            {
                CustomMessageBox.ShowMessage("Entegref ile iletişime geçerek Lütfen Lisansınızı uzatınız", "Kullanım süreniz dolmuştur. Programnı Kullanmay devam etmek için lütfen Yeni Lisans Anahtarı Satın Alın", this, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //XtraMessageBox.Show("Entegref ile iletişime geçerek Lütfen Lisansınızı uzatınız");
                Properties.Settings.Default.EntegrefSecretPhase = "";
                Properties.Settings.Default.Save();
                Application.Exit();
            }

            pnlLisans.Visible = false;
            this.Size = new Size(718, 325);
        }

        DateTime now = DateTime.Now;
        string bugun = "";
        bool yenigun = false;
        private async void Lisansing(string vknid)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var request = new HttpRequestMessage(HttpMethod.Post, "http://lisans.entegref.com/token");
                    //var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44371/token");
                    request.Content = new StringContent("grant_type=password&username=admin&password=Madam3169");

                    // İstek başlığına gerekli kimlik doğrulama bilgilerini ekleyin
                    //string clientId = "your_client_id";
                    //string clientSecret = "your_client_secret";
                    //string credentials = System.Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(clientId + ":" + clientSecret));
                    //request.Headers.Add("Authorization", "Basic " + credentials);

                    // İsteği gönderin ve yanıtı alın
                    HttpResponseMessage responses = await client.SendAsync(request);

                    // Yanıtın başarılı olup olmadığını kontrol edin
                    if (responses.IsSuccessStatusCode)
                    {
                        string responseData = await responses.Content.ReadAsStringAsync();
                        Token myDeserializedClass = JsonConvert.DeserializeObject<Token>(responseData);
                        Properties.Settings.Default.EntegrefAIPToken = myDeserializedClass.access_token;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("API isteği başarısız: " + responses.StatusCode, "Servis Uyarısı");
                    }
                }

                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Properties.Settings.Default.EntegrefAIPToken);
                HttpResponseMessage response = await httpClient.GetAsync($"api/data/Lisans?VKN={vknid}&AppName={ProductName}");
                string Timer;
                HttpResponseMessage time = await httpClient.GetAsync("api/data/forall");
                Timer = await time.Content.ReadAsStringAsync();
                ReturnModel Zaman = JsonConvert.DeserializeObject<ReturnModel>(Timer);
                string originalDateTimeString = Zaman.message;
                //if (bugun == originalDateTimeString)
                //{
                yenigun = true;
                if (Properties.Settings.Default.YeniGun != bugun)
                {
                    yenigun = false;
                }
                else
                {
                    yenigun = true;
                }


                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    //Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(responseData);
                    List<Sonuc> myDeserializedClass = JsonConvert.DeserializeObject<List<Sonuc>>(responseData);
                    foreach (var item in myDeserializedClass)
                    {
                        if (item.status)
                        {
                            SKGL.Validate validate = new SKGL.Validate();
                            validate.secretPhase = VKN;
                            validate.Key = item.message;
                            Properties.Settings.Default.EntegrefSecretPhase = item.message;
                            Properties.Settings.Default.Save();

                            txtLisansing2.Text = "Başlangıç Tarihi : \r\n " + validate.CreationDate.ToShortDateString();
                            txtLisansing3.Text = "Sona Erme Tarihi : \r\n " + validate.ExpireDate.ToShortDateString();
                            txtLisansing1.Text = "Kalan Gün : \r\n " + validate.DaysLeft;
                            //txtLisansing2.Text = "Lisans Başlanğıç Tarihi:" + validate.CreationDate.ToShortDateString() + "\r\n" + "Lisans Sona Erme Tarihi:" + validate.ExpireDate.ToShortDateString() + "\r\n" + "Lisans Kullanım Kalan Gün:" + validate.DaysLeft;

                            var assembly = typeof(Program).Assembly;
                            var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
                            var id = attribute.Value;
                            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\EntegreFYonAvmTools");
                            key.SetValue("ApplicationSetupComplate", "true");
                            key.SetValue("ApplicationGUID", id);
                            key.SetValue("ApplicationSecretPhase", item.message);// Properties.Settings.Default.EntegrefSecretPhase);
                            key.Close();
                        }
                        else
                        {
                            MessageBox.Show(item.message, "Dikkat", MessageBoxButtons.YesNo);
                        }
                    }
                }
                else
                {
                    CustomMessageBox.ShowMessage("API isteği başarısız: ", response.Content.ToString(), this, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //}
                //else
                //{
                //    CustomMessageBox.ShowMessage("Sistem Saati dogru değil kontrol ediniz.", "", this, "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void VolXml()
        {
            string ConStrg = "";
            try
            {
                clientName = SystemInformation.ComputerName;
                if (!File.Exists("C:\\Program Files (x86)\\Volant Yazılım\\Volant Erp Setup\\VolErpConnection.xml"))
                {
                    throw new Exception("VolErpConnection Dosyası Eksik!");
                }
                XmlTextReader reader = new XmlTextReader("C:\\Program Files (x86)\\Volant Yazılım\\Volant Erp Setup\\VolErpConnection.xml");
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element && reader.Name == "PARAMS") || reader.NodeType != XmlNodeType.Element || !(reader.Name == "DB"))
                    {
                        continue;
                    }
                    eDatabase rDatabase = new eDatabase();
                    try
                    {
                        ConStrg = string.Format("Server={0};Database={1};User Id={2};Password={3};",
                        reader.GetAttribute("SERVERNAME").TextSifreCoz(),
                        reader.GetAttribute("DATABASE").TextSifreCoz(),
                        reader.GetAttribute("LOGIN").TextSifreCoz(),
                        reader.GetAttribute("PASSWORD").TextSifreCoz());
                    }
                    catch
                    {
                        ConStrg = string.Format("Server={0};Database={1};User Id={2};Password={3};",
                        reader.GetAttribute("SERVERNAME").ToString(),
                        reader.GetAttribute("DATABASE").ToString(),
                        reader.GetAttribute("LOGIN").ToString(),
                        reader.GetAttribute("PASSWORD").ToString());
                    }

                    Settings.Default.Company = reader.GetAttribute("DATABASE").ToString();
                }
                Settings.Default.VolConnection = ConStrg;
                Settings.Default.Save();

                reader.Close();
            }
            catch (Exception exp)
            {
                XtraMessageBox.Show(exp.Message);
            }
        }
        void DataCek()
        {
            List<AllDataBase> allDatas = new List<AllDataBase>() ;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.VolConnection))
            {
                connection.Open();

                DataTable databases = connection.GetSchema("Databases");
                foreach (DataRow database in databases.Rows)
                {
                    AllDataBase dts = new AllDataBase { DbNAme = database["database_name"].ToString() };
                    allDatas.Add(dts);
                    string databaseName = database["database_name"].ToString();
                    var dd = Sorgu(string.Format("select COMPANYVAL,COMPANYNAME from {0}.dbo.COMPANY", database["database_name"]), Settings.Default.VolConnection);
                    if (dd != null)
                    {
                        var ff = new Firma();
                        ff.COMPANYNAME = dd.Rows[0]["COMPANYNAME"].ToString();
                        ff.COMPANYDB = database["database_name"].ToString();
                        if (!firmas.Any(f => f.COMPANYNAME == ff.COMPANYNAME))
                        {
                            firmas.Add(ff);
                        }
                    }
                }
                connection.Close();
            }
        }
        void FirmaBilgileri()
        {
            cmbVolantMagaza.Properties.DataSource = null;
            DataTable Divison = Sorgu("select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", Settings.Default.VolConnection);
            cmbVolantMagaza.Properties.DataSource = Divison;
            cmbVolantMagaza.Properties.DisplayMember = "DIVNAME";
            cmbVolantMagaza.Properties.ValueMember = "DIVVAL";
            cmbVolantMagaza.EditValue = Divison.Rows[0]["DIVVAL"];
            var ftp = Sorgu("select MTFTPIP,MTFTPUSER,MTFTPPASSWORD from MANAGEMENT", Settings.Default.VolConnection);
            Properties.Settings.Default.VolFtpHost = ftp.Rows[0]["MTFTPIP"].ToString();
            Properties.Settings.Default.VolFtpUser = ftp.Rows[0]["MTFTPUSER"].ToString();
            Properties.Settings.Default.VolFtpPass = ftp.Rows[0]["MTFTPPASSWORD"].ToString();
            Properties.Settings.Default.Save();
        }
        private void cmbVolantSirket_EditValueChanged(object sender, EventArgs e)
        {
            Settings.Default.VolConnection = Settings.Default.VolConnection.Replace(Settings.Default.Company.ToString(), cmbVolantSirket.EditValue.ToString());
            Settings.Default.Company = cmbVolantSirket.EditValue.ToString();
            Settings.Default.Save();
            FirmaBilgileri();
            string company = cmbVolantSirket.EditValue.ToString();
            if (company.Contains("YON"))
            {
                pictureEdit2.Visible = true;
                pictureEdit2.Image = Properties.Resources.YON_AVM_400;
            }
            else if (company.Contains("KAMALAR"))
            {
                pictureEdit2.Visible = true;
                pictureEdit2.Image = Properties.Resources.Kamalar_logo;
            }
            else
            {
                pictureEdit2.Visible = false;
            }
        }       
        public DataTable Sorgu(string sorgu, string connection)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var yetki = Sorgu(string.Format(@"select * from SOCIAL where SOCODE = '{0}' and SOENTERKEY = '{1}'", txtVolantUser.Text, txtVolantPassword.Text), Settings.Default.VolConnection);

            if (yetki.Rows.Count > 0)
            {
                userID = yetki.Rows[0][0].ToString();
                this.Hide();
                frmMain newmain = new frmMain();
                newmain.ShowDialog();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Giriş Bilgilerinizi Kontrol Ediniz");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtVolantPassword_Enter(object sender, EventArgs e)
        {
            if (txtVolantPassword.Text == "Parola")
            {
                txtVolantPassword.Properties.PasswordChar = '*';
                txtVolantPassword.ForeColor = SystemColors.WindowText;
                txtVolantPassword.Text = "";
            }
        }

        private void txtVolantPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton2_Click(null, null);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
                Application.Exit();
            }

        }

        private void txtVolantPassword_Leave(object sender, EventArgs e)
        {
            if (txtVolantPassword.Text.Length == 0)
            {
                txtVolantPassword.Properties.PasswordChar = '\0';
                txtVolantPassword.Text = "Parola";
                txtVolantPassword.ForeColor = SystemColors.GrayText;
            }
        }        

        private void txtVolantUser_TextChanged(object sender, EventArgs e)
        {
            var sonuc = Sorgu("select SONAME +SPACE(1)+SOSURNAME from SOCIAL left outer join DEPARTMENT on DEPVAL = SODEPART where SOCODE = '" + txtVolantUser.Text + "'", Settings.Default.VolConnection);
            if (sonuc.Rows.Count > 0)
            {
                togsKullanici.IsOn = true; 
                togsKullanici.Properties.OnText = sonuc.Rows[0][0].ToString();
            }
            else
            {
                togsKullanici.IsOn = false;
            }
        }
    }
}