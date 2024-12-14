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
using RemziCicek.ShellServiceClient;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using static RemziCicek.Class.Shell;
using DevExpress.XtraPrinting;
using System.Reflection;

namespace RemziCicek
{
    public partial class frmArac_TTS : DevExpress.XtraEditors.XtraForm
    {

        public frmArac_TTS()
        {
            InitializeComponent();            
        }
        public static int sorguadeti = 100;
        public bool SorguHakkı(int islem)
        {
            bool sonuc = false;
            var islemtarihi = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
            string q = string.Format("select * from ARACYAKITSORGU where IslemTarihi = '{0}' and IslemTipi = {1}", islemtarihi, islem);
            SqlDataAdapter da = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                string insertsorgu;
                insertsorgu = string.Format("insert into ARACYAKITSORGU values ({1},'{0}',1)", islemtarihi, islem);
                SqlCommand cmd = new SqlCommand(insertsorgu, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                sonuc = true;
            }
            else
            {
                if (islem == 2)
                {
                    sorguadeti = int.Parse(dt.Rows[0][2].ToString())-1;
                    if (int.Parse(dt.Rows[0][2].ToString()) == 100)
                    {
                        sonuc = false;
                        lblUyarı.Tag = "2";
                    }
                    else
                    {
                        string insertsorgu;
                        insertsorgu = string.Format("UPDATE ARACYAKITSORGU set Adet = Adet+1 where IslemTarihi = '{0}' and IslemTipi = {1}", islemtarihi, islem);
                        SqlCommand cmd = new SqlCommand(insertsorgu, conn);
                        if (conn.State == ConnectionState.Closed)
                        {
                            conn.Open();
                        }
                        cmd.ExecuteNonQuery();
                        sonuc = true;
                        lblUyarı.Tag = "2";
                        lblUyarı.Text = "Günlük Kalan Sorgu Hakkı =" + sorguadeti.ToString();
                    }

                }
                else
                {
                    sonuc = false;
                    lblUyarı.Tag = "1";
                }
            }
            return sonuc;
        }
        SqlConnectionObject sql = new SqlConnectionObject();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnection vol = new SqlConnection(Properties.Settings.Default.VolConnection);
        DataTable bolge = new DataTable();
        string Kodu = Properties.Settings.Default.Kodu;
        string Adı = Properties.Settings.Default.Adı;
        string Sifre = Properties.Settings.Default.Sifre;
        DateTime dt_Hafta = DateTime.Now;
        private void frmArac_TTS_Load(object sender, EventArgs e)
        {
            if (SorguHakkı(1) == true)
            {
                lblUyarı.Visible = true;
                lblUyarı.Text = "Bu gün Bu Sorgu Yapılmadı";
            }
            else
            {

                lblUyarı.Visible = true;
                lblUyarı.Text = "Günlük Sorgu hakkı bitti";
                button4.Tag = 1;
            }
            DateTime ilkgun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(-1);
            DateTime songun = ilkgun.AddMonths(1).AddDays(-1);
            dteStart.EditValue = ilkgun;
            dteEnd.EditValue = new DateTime(ilkgun.Year,ilkgun.Month,ilkgun.Day, 23, 59, 59).AddMonths(1).AddDays(-1);

            dteStart.Properties.MinValue = DateTime.Now.AddMonths(-15);
            dteStart.Properties.MaxValue = DateTime.Now.AddDays(-1);
            dteEnd.Properties.MinValue = DateTime.Now.AddMonths(-15);
            dteEnd.Properties.MaxValue = DateTime.Now.AddDays(-1);
            Bolge();
            //Magazalar("");
        }
        private BackgroundWorker _backgroundWorker;
        private ManualResetEvent _workerCompletedEvent = new ManualResetEvent(false);
        private const string READY_TEXT = "Hazır";
        private void executeBackground(Action doWorkAction, Action progressAction = null, Action completedAction = null)
        {
            try
            {
                if (_backgroundWorker != null)
                {

                    XtraMessageBox.Show("Her oturum açıldığında 1 işlem yapacak. Eğer bu girişteki ilk işlemse uygulama çalışmaktadır. Lütfen Bekleyiniz");
                    return;
                    
                }
                _backgroundWorker = new BackgroundWorker
                {
                    WorkerSupportsCancellation = true
                };
                _backgroundWorker.DoWork += (x, y) =>
                {
                    try
                    {
                        doWorkAction.Invoke();
                    }
                    catch (Exception ex)
                    {
                        y.Cancel = true;
                        XtraMessageBox.Show("Bilinmeyen Hata. Detay : " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // throw;
                    }
                };
                if (progressAction != null)
                {
                    _backgroundWorker.ProgressChanged += (x, y) =>
                    {
                        progressAction.Invoke();
                    };
                }
                if (completedAction != null)
                {
                    _backgroundWorker.RunWorkerCompleted += (x, y) =>
                    {
                        completedAction.Invoke();
                    };
                }
                _backgroundWorker.RunWorkerAsync();
            }
            catch (Exception)
            {

            }

        }
        private void completeProgress()
        {
            try
            {
                _backgroundWorker.Dispose();
                _backgroundWorker = null;
                if (!this.Enabled)
                {
                    this.Enabled = true;
                }

            }
            finally
            {
                //this.Cursor = Cursors.Default;
                _workerCompletedEvent.Set();

            }
        }
        private void directoryCreator(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void Bolge()
        {
            cmbBolge.DisplayMember = "DLAREANAME";
            cmbBolge.ValueMember = "DLAREANAME";

            string query2 = "select DLAREAID,DLAREANAME from DELIVERAREA";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, vol);
            if (vol.State == ConnectionState.Closed)
            {
                vol.Open();
            }
            da2.Fill(bolge);
            cmbBolge.DataSource = bolge;
        }
        private void Magazalar(string Bolge)
        {
            string query = string.Format("select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVREGION = '{0}'",Bolge);
            SqlDataAdapter da = new SqlDataAdapter(query, vol);
            if (vol.State == ConnectionState.Closed)
            {
                vol.Open();
            }
            DataTable magaza = new DataTable();
            da.Fill(magaza);
            cmbMagaza.DisplayMember = "DIVNAME";
            cmbMagaza.ValueMember = "DIVVAL";
            cmbMagaza.DataSource = magaza;
        }
        private void Araclar(string magaza)
        {
            if (magaza != "")
            {
                DataTable arac = new DataTable();
                Dictionary<string, string> araclar = new Dictionary<string, string>();
                araclar.Add("@Magaza", magaza);
                arac=sql.Query("RC_Arac", araclar);


                //string query = "select Id,Arac_Plakası from Arac a inner join Magaza m on m.sKodı = a.Arac_Magazası where m.sKodı = '" + magaza.Replace(" ", "") + "' order by 2";
                //SqlDataAdapter da = new SqlDataAdapter(query, conn);
                //if (conn.State == ConnectionState.Closed)
                //{
                //    conn.Open();
                //}

                
                //da.Fill(arac);
                cmbPlaka.DisplayMember = "Plaka";
                cmbPlaka.ValueMember = "Plaka";
                cmbPlaka.DataSource = arac;
            }
        }
        string baslangıc;
        string bitis;
        string plaka;
        internal MainForm mdiParent;

        private void button4_Click(object sender, EventArgs e)
        {   
            baslangıc = Convert.ToDateTime(dteStart.EditValue).ToString("yyyy-MM-ddTHH:mm:ss");
            bitis = Convert.ToDateTime(dteEnd.EditValue).ToString("yyyy-MM-ddTHH:mm:ss");
            plaka = cmbPlaka.SelectedValue.ToString().Replace(" ", "");

            int sira;

            DataTable dt = new DataTable();
            TTSWebServicesSoapClient client = new TTSWebServicesSoapClient();
            RemziCicek.ShellServiceClient.CUSTOMERSALESTRANSACTIONS result = new CUSTOMERSALESTRANSACTIONS();
            if (togArac.IsOn)
            {
                sira = 1;
                if (lblUyarı.Tag.ToString() != "1")
                {
                    result = client.GetCustomerSalesTransaction(Kodu, Adı, Sifre, Kodu, Convert.ToDateTime(baslangıc), Convert.ToDateTime(bitis), "", "", "", "");
                    lblUyarı.Text = "Günlük Sorgu hakkı bitti";
                    button4.Tag = "1";
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("select * from ARACYAKIT where Tarih between '" + Convert.ToDateTime(baslangıc).ToString("yyyy-MM-dd") + "' and '" + Convert.ToDateTime(bitis).ToString("yyyy-MM-dd") + "'", conn);
                    da.Fill(dt);
                }
            }
            else
            {
                sira = 2;
                   result = client.GetCustomerSalesTransaction(Kodu, Adı, Sifre, "", Convert.ToDateTime(baslangıc), Convert.ToDateTime(bitis), plaka, "", "", "");
                SorguHakkı(2);
                lblUyarı.Text = "Günlük Kalan Sorgu Hakkı =" + sorguadeti.ToString();
            }

            int adet;

            if (result.COUNTOFSALESTRANSACTIONLIST != 0)
            {
                adet = result.COUNTOFSALESTRANSACTIONLIST;
            }
            else
            {
                adet = dt.Rows.Count;
            }
            //var limit = client.GetCardLimitCountandDays(Kodu, Adı, Sifre, "", "", plaka, "");
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = adet,
                Position = 0,
            };

            int success = 0;
            int error = 0;
            this.Enabled = false;
            var Yakitlar = new List<Yakit>();
           progressForm.Show(this);
            try
            {
                if (sira == 1)
                {
                    if (lblUyarı.Tag.ToString() != "1")
                    {
                        if (result.PROCESSRESULT.Success == true)
                        {
                            foreach (var item in result.LISTOFSALESTRANSACTION)
                            {
                                var yk = new Yakit();
                                yk.Sales_Type = item.Sales_type;
                                yk.Plate_Cd = item.Plate_cd;
                                yk.Transaction_Date = item.Transaction_date;
                                yk.Retail_Outlet_Name = item.Retail_outlet_name;
                                yk.Rtl_Otlt_Province = item.Rtl_otlt_province;
                                yk.Fuel_Name = item.Fuel_name;
                                yk.Unit_Price = item.Unit_price;
                                yk.Volume = item.Volume;
                                yk.Sales_Total_Amount = item.Sales_total_amount;
                                yk.Invoice_No = item.Invoice_no;
                                yk.durum = "Aktarım Kontrolü";
                                Yakitlar.Add(yk);
                                progressForm.PerformStep(this);
                                success++;
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show(result.LISTOFSALESTRANSACTION.ToString());
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            var yk = new Yakit();
                            yk.Sales_Type = dt.Rows[i]["YakıtTipi"].ToString();
                            yk.Plate_Cd = dt.Rows[i]["Plaka"].ToString();
                            yk.Transaction_Date = Convert.ToDateTime(dt.Rows[i]["Tarih"].ToString());
                            yk.Retail_Outlet_Name = dt.Rows[i]["IstasyonAdı"].ToString();
                            yk.Rtl_Otlt_Province = dt.Rows[i]["IL"].ToString();
                            yk.Fuel_Name = dt.Rows[i]["YakıtAdı"].ToString();
                            yk.Unit_Price = decimal.Parse(dt.Rows[i]["YakıtFiyatı"].ToString());
                            yk.Volume = decimal.Parse(dt.Rows[i]["YakıtMiktarı"].ToString());
                            yk.Sales_Total_Amount = decimal.Parse(dt.Rows[i]["YakıtTutarı"].ToString());
                            yk.Invoice_No = dt.Rows[i]["FaturaNo"].ToString();
                            yk.durum = "Kayıtlı Liste";
                            Yakitlar.Add(yk);
                            progressForm.PerformStep(this);
                            success++;
                        }
                    }

                }
                else
                {
                    if (result.PROCESSRESULT.Success == true)
                    {
                        foreach (var item in result.LISTOFSALESTRANSACTION)
                        {
                            var yk = new Yakit();
                            yk.Sales_Type = item.Sales_type;
                            yk.Plate_Cd = item.Plate_cd;
                            yk.Transaction_Date = item.Transaction_date;
                            yk.Retail_Outlet_Name = item.Retail_outlet_name;
                            yk.Rtl_Otlt_Province = item.Rtl_otlt_province;
                            yk.Fuel_Name = item.Fuel_name;
                            yk.Unit_Price = item.Unit_price;
                            yk.Volume = item.Volume;
                            yk.Sales_Total_Amount = item.Sales_total_amount;
                            yk.Invoice_No = item.Invoice_no;
                            yk.durum = "Aktarım Kontrolü";
                            Yakitlar.Add(yk);
                            progressForm.PerformStep(this);
                            success++;
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(result.LISTOFSALESTRANSACTION.ToString());
                    }
                }
                //if (result.PROCESSRESULT.Success == true)
                //{
                //    if (button4.Tag.ToString() != "1")
                //    {
                //        foreach (var item in result.LISTOFSALESTRANSACTION)
                //        {
                //            var yk = new Yakit();
                //            yk.Sales_Type = item.Sales_type;
                //            yk.Plate_Cd = item.Plate_cd;
                //            yk.Transaction_Date = item.Transaction_date;
                //            yk.Retail_Outlet_Name = item.Retail_outlet_name;
                //            yk.Rtl_Otlt_Province = item.Rtl_otlt_province;
                //            yk.Fuel_Name = item.Fuel_name;
                //            yk.Unit_Price = item.Unit_price;
                //            yk.Volume = item.Volume;
                //            yk.Sales_Total_Amount = item.Sales_total_amount;
                //            yk.Invoice_No = item.Invoice_no;
                //            yk.durum = "Aktarım Kontrolü";
                //            Yakitlar.Add(yk);
                //            progressForm.PerformStep(this);
                //            success++;
                //        }
                //    }
                //    else
                //    {
                //        for (int i = 0; i < dt.Rows.Count; i++)
                //        {
                //            var yk = new Yakit();
                //            yk.Sales_Type = dt.Rows[i]["YakıtTipi"].ToString();
                //            yk.Plate_Cd = dt.Rows[i]["Plaka"].ToString();
                //            yk.Transaction_Date = Convert.ToDateTime(dt.Rows[i]["Tarih"].ToString());
                //            yk.Retail_Outlet_Name = dt.Rows[i]["IstasyonAdı"].ToString();
                //            yk.Rtl_Otlt_Province = dt.Rows[i]["IL"].ToString();
                //            yk.Fuel_Name = dt.Rows[i]["YakıtAdı"].ToString();
                //            yk.Unit_Price = decimal.Parse(dt.Rows[i]["YakıtFiyatı"].ToString());
                //            yk.Volume = decimal.Parse(dt.Rows[i]["YakıtMiktarı"].ToString());
                //            yk.Sales_Total_Amount = decimal.Parse(dt.Rows[i]["YakıtTutarı"].ToString());
                //            yk.Invoice_No = dt.Rows[i]["FaturaNo"].ToString();
                //            yk.durum = "Kayıtlı Liste";
                //            Yakitlar.Add(yk);
                //            progressForm.PerformStep(this);
                //        }
                //    }
                //}
                //else
                //{
                //    XtraMessageBox.Show(result.LISTOFSALESTRANSACTION.ToString());
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //error++;
            }


            gridControl1.DataSource = Yakitlar;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns(true);
            this.Enabled = true;
            progressForm.Hide(this);
            XtraMessageBox.Show("Alım tamamlandı. Toplam Başarılı : ." + success + " Toplam Hatalı : " + error, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }




        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dteStart_EditValueChanged(object sender, EventArgs e)
        {
            if (dteEnd.EditValue != null)
            {
            }
            else
            {
                dteEnd.EditValue = dteStart.EditValue;
            }
        }

        private void dteEnd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMagaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            Araclar(cmbMagaza.SelectedValue.ToString());
        }

        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            Magazalar(cmbBolge.SelectedValue.ToString());
        }

        private void togArac_Toggled(object sender, EventArgs e)
        {
            if (togArac.IsOn==true)
            {
                if (lblUyarı.Tag.ToString() != "1")
                {
                    cmbBolge.Enabled = false;
                    cmbMagaza.Enabled = false;
                    cmbPlaka.Enabled = false;
                    button4.Enabled = true;
                }
                else
                {
                    button4.Enabled = false;
                    lblUyarı.Text = "günlük Sorgu Limit Doldu";
                    XtraMessageBox.Show("günlük Sorgu Limit Doldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (lblUyarı.Tag.ToString() != "2")
                {
                    cmbBolge.Enabled = true;
                    cmbMagaza.Enabled = true;
                    cmbPlaka.Enabled = true;
                    button4.Enabled = true;
                    lblUyarı.Text = "Günlük Kalan Sorgu Hakkı =" + sorguadeti.ToString();
                }
                else
                {
                    button4.Enabled = false;
                    lblUyarı.Text = "günlük Sorgu Limit Doldu";
                    XtraMessageBox.Show("günlük Sorgu Limit Doldu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
        private void CreateDirectoryIfNotExists(string directoryPath)
        {


            if (!Directory.Exists(directoryPath))
            {
                try
                {
                    Directory.CreateDirectory(directoryPath);
                    MessageBox.Show($"'{directoryPath}' dizini oluşturuldu Dosya buraya kaydedilecek", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"'{directoryPath}' dizini oluşturulurken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExcell_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Arac Masraf", "Shell Kontrol", Convert.ToDateTime(dteStart.EditValue.ToString()).ToString("yyyyMMdd") + ".xls");
            CreateDirectoryIfNotExists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Arac Masraf","Shell Kontrol"));


            gridView1.ExportToXls(filePath, new XlsExportOptions
            {
                ExportMode = XlsExportMode.SingleFile,
                TextExportMode = TextExportMode.Value,
                ShowGridLines = true,
                FitToPrintedPageWidth = true,
                FitToPrintedPageHeight = true,                
            });
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int toplam = gridView1.RowCount;
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = toplam,
                Position = 0,
            };

            int success = 0;
            int error = 0;
            this.Enabled = false;
           progressForm.Show(this);
           try
           {
               for (int i = 0; i < gridView1.RowCount; i++)
               {
                   Dictionary<string, string> yk = new Dictionary<string, string>();
                   yk.Add("YakıtTipi", gridView1.GetRowCellValue(i, "Sales_Type").ToString());
                   string originalValue = gridView1.GetRowCellValue(i, "Plate_Cd").ToString();
                   string trimmedValue = originalValue.TrimStart('0');
                   yk.Add("Plaka", trimmedValue);
                   yk.Add("Tarih", Convert.ToDateTime(gridView1.GetRowCellValue(i, "Transaction_Date").ToString()).ToString("yyyy-MM-dd"));
                   yk.Add("IstasyonAdı", gridView1.GetRowCellValue(i, "Retail_Outlet_Name").ToString());
                   yk.Add("IL", gridView1.GetRowCellValue(i, "Rtl_Otlt_Province").ToString());
                   yk.Add("YakıtAdı", gridView1.GetRowCellValue(i, "Fuel_Name").ToString());
                   yk.Add("YakıtFiyatı", gridView1.GetRowCellValue(i, "Unit_Price").ToString());
                   yk.Add("YakıtMiktarı", gridView1.GetRowCellValue(i, "Volume").ToString());
                    yk.Add("YakıtTutarı", gridView1.GetRowCellValue(i, "Sales_Total_Amount").ToString());
                    yk.Add("FaturaNo", gridView1.GetRowCellValue(i, "Invoice_No").ToString());
                    var dt = sql.MDEQuery("ARACYAKITEKLE", yk);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        gridView1.SetRowCellValue(i, "durum", "Aktarıldı");
                        gridView1.RefreshRow(i);
                        progressForm.PerformStep(this);
                        success++;
                    }
                    else if (dt.Rows[0][0].ToString() == "2")
                    {
                        gridView1.SetRowCellValue(i, "durum", "Takip Dışı Araç");
                        gridView1.RefreshRow(i);
                        progressForm.PerformStep(this);
                    }
                    else
                    {
                        gridView1.SetRowCellValue(i, "durum", "Güncellendi");
                        gridView1.RefreshRow(i);
                        progressForm.PerformStep(this);
                        error++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                error++;
            }

            //},
            //              null,
            //              () =>
            //              {
            this.Enabled = true;
            //              completeProgress();
            progressForm.Hide(this);
            XtraMessageBox.Show("Toplam Başarılı : ." + success + " Adet; Toplam Hatalı : " + error + " Adet Kayıt Yapıldı Listeyi kontrol edin", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //              });

        }
    }
}