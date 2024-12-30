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
using System.Threading;
using DevExpress.Spreadsheet;
using static RemziCicek.DataTableClass;
using System.Data.SqlClient;

namespace RemziCicek
{
    public partial class frmExcelAl : DevExpress.XtraEditors.XtraForm
    {
        public frmExcelAl()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        SqlConnectionObject conn = new SqlConnectionObject();
        private BackgroundWorker _backgroundWorker;
        private ManualResetEvent _workerCompletedEvent = new ManualResetEvent(false);
        private void executeBackground(Action doWorkAction, Action progressAction = null, Action completedAction = null)
        {
            try
            {
                if (_backgroundWorker != null)
                {
                    if (_backgroundWorker.IsBusy)
                    {
                        return;
                    }
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
                this.Enabled = false;
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

        private void frmExcelAl_Load(object sender, EventArgs e)
        {
            dteMONTH.EditValue = DateTime.Now;
        }
        private void tileBarItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Dosyaları (*.xlsx;*.xls)|*.xlsx;*.xls|Tüm Dosyalar (*.*)|*.*";

            // Kullanıcıdan dosyayı seçmesini iste
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtDosyaYolu.Text = openFileDialog.FileName;
            }
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Worksheet worksheet = spreadsheetControl.Document.Worksheets.ActiveWorksheet;

            // Çalışma sayfasının içeriğini temizle
            worksheet.Clear(worksheet.GetDataRange());
            spreadsheetControl.Document.BeginUpdate();
            spreadsheetControl.Document.LoadDocument(txtDosyaYolu.Text, DocumentFormat.Xlsx);
            spreadsheetControl.Document.EndUpdate();

            Worksheet worksheet2 = spreadsheetControl.Document.Worksheets.ActiveWorksheet;
            CellRange usedRange = worksheet2.GetUsedRange();

            // Dolu sütunları dolaşarak sıralı harf isimlerini elde edin
            //for (int columnIndex = usedRange.LeftColumnIndex; columnIndex <= usedRange.RightColumnIndex + 1; columnIndex++)
            //{
            //    // Sütunun harf karşılığını hesaplayın
            //    string columnName = GetColumnName(columnIndex);
            //    // Sütun ismini listeye ekleyin
            //    cmbMarka.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbModel.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbModelTarih.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbPlaka.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKMTarih.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKM.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKategori.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbAlisFiyat.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKiraFirma.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKiraAylikTutar.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKiraAylikTutar.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKiraBasTarih.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //    cmbKiraBitTarih.Items.Add(new ComboBoxItem(columnIndex, columnName));
            //}
            spreadsheetControl.Document.Worksheets.ActiveWorksheet.Cells.AutoFitColumns();
        }
        public static int HarfinSirasi(string harf)
        {
            if (harf == "I")
            {
                harf = "i";
            }
            // Küçük harfleri kontrol etmek için harfin ASCII değerini 97'ye çıkarırız.
            // Büyük harfler için bu gerekli değildir.
            harf = harf.ToLower();

            // Harfin alfabedeki sırasını bulmak için ASCII tablosundaki indeksi kullanırız.
            // Küçük harfler için indeksler 0'dan 25'e kadar, büyük harfler için 0'dan 25'e kadar.
            int sira = harf[0] - 'a' + 1;

            return sira;
        }
        private void tileBarItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            int index = 0;
            if (!toggleSwitch1.IsOn)
            {
                index = 1;
            }
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            Worksheet worksheet = spreadsheetControl.Document.Worksheets.ActiveWorksheet;
            CellRange usedRange = worksheet.GetUsedRange();

            // Sıralama yapılacak sütunu al
            //string siraSutunu = cmbSehir.Text;

            //CellRange range = worksheet.Range[cmbCinsiyet.Text+ (index+1)+":"+cmbTarih.Text+"69999"];
            //worksheet.Sort(range, HarfinSirasi(cmbSehir.Text)-1);

            //worksheet.Sort(usedRange,HarfinSirasi(cmbSehir.Text)-1, true);

            List<Personel> personels = new List<Personel>();
            HashSet<string> uniqueSMENVALSet = new HashSet<string>();

            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = usedRange.RowCount,
                Position = 0,
                ToplamAdet = usedRange.RowCount.ToString(),
            };
            int success = 0;
            int error = 0;
            this.Enabled = false;
            executeBackground(
       () =>
       {
           progressForm.Show(this);
           for (int rowIndex = index; rowIndex < usedRange.RowCount; rowIndex++)
           {
               try
               {
                   DataTableClass.Personel personel = new DataTableClass.Personel();
                   var range = usedRange[rowIndex, HarfinSirasi(txtVal.Text) - 1];
                   var range2 = usedRange[rowIndex, HarfinSirasi(txtKota.Text) - 1];
                   string SMENVAL = (range != null) ? range.Value.ToString() : "";
                   string AMOUNT = (range2 != null) ? range2.Value.ToString() : "250000";
                   if (range2.Value.ToString() != "")
                   {
                       AMOUNT = range2.Value.ToString();
                   }
                   else
                   {
                       AMOUNT = "250000";
                   }
                   if (SMENVAL != "")
                   {
                       string q = String.Format(@"select SMENID from SALESMEN where SMENVAL = '{0}'", usedRange[rowIndex, HarfinSirasi(txtVal.Text) - 1].Value.ToString());
                       string SMENID = conn.GetValue(q);
                       if (uniqueSMENVALSet.Add(SMENVAL))
                       {
                           personel.sira = rowIndex;
                           personel.SMENID = int.Parse(SMENID);
                           personel.DIVVAL = usedRange[rowIndex, HarfinSirasi(txtMagaza.Text) - 1].Value.ToString();
                           personel.SMENVAL = usedRange[rowIndex, HarfinSirasi(txtVal.Text) - 1].Value.ToString();
                           personel.SMENNAME = usedRange[rowIndex, HarfinSirasi(txtName.Text) - 1].Value.ToString();
                           personel.AMOUNT = AMOUNT;
                       }

                       personels.Add(personel);
                       success++;
                   }
                   progressForm.PerformStep(this);
               }
               catch (Exception mesaj)
               {
                   progressForm.PerformStep(this);
                   error++;
                   XtraMessageBox.Show(mesaj.Message);
               }
           }
       },
                              null,
                              () =>
                              {
                                  completeProgress();
                                  progressForm.Hide(this);
                                  var sonuc = converter.ToDataTable(personels);
                                  gridPersonelKota.DataSource = personels;
                                  ViewPersonelKota.OptionsView.BestFitMaxRowCount = -1;
                                  ViewPersonelKota.BestFitColumns(true);
                                  spreadsheetControl.Visible = false;
                                  gridPersonelKota.Visible = true;
                                  gridPersonelKota.Dock = DockStyle.Fill;
                                  btnGuncelle.Visible = true;
                              });
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = ViewPersonelKota.RowCount,
                Position = 0,
                ToplamAdet = ViewPersonelKota.RowCount.ToString(),
            };
            int success = 0;
            int error = 0;
            this.Enabled = false;
            executeBackground(
       () =>
       {
           progressForm.Show(this);
           sql.Open();
           for (int i = 0; i < ViewPersonelKota.RowCount; i++)
           {
               try
               {
                   string SMENID = ViewPersonelKota.GetRowCellValue(i, "SMENID").ToString();
                   string magaza = conn.GetValue($"select DIVVAL from DIVISON where DIVNAME like '%{ ViewPersonelKota.GetRowCellValue(i, "DIVVAL").ToString()}%'");
                   string AMOUNT = ViewPersonelKota.GetRowCellValue(i, "AMOUNT").ToString().Replace(".00 ", "").Replace(".", "").Substring(0, 6);
                   string yil = Convert.ToDateTime(dteMONTH.EditValue.ToString()).ToString("yyyy");
                   string ay = Convert.ToDateTime(dteMONTH.EditValue.ToString()).ToString("yyyy");
                   string tarih = Convert.ToDateTime(dteMONTH.EditValue.ToString()).ToString("yyyy-MM-dd");
                   string kontrol = String.Format(@"select * from SALTARGETSALESMEN where SATGSAYEAR =  YEAR('{0}') and SATGSAMONTH =  MONTH('{0}') and SATGSASMENID = '{1}'", tarih, SMENID);
                   SqlDataAdapter da = new SqlDataAdapter(kontrol, sql);
                   DataTable dt = new DataTable();
                   da.Fill(dt);
                   if (dt.Rows.Count > 0)
                   {
                       string q = String.Format(@"update SALTARGETSALESMEN set SATGSAAMOUNT = '{1}',SATGSARATE = 0 where SATGSASMENID = {0}  and SATGSAYEAR = YEAR('{2}') and SATGSAMONTH = MONTH('{2}')", SMENID, AMOUNT, tarih);
                       SqlCommand cmd = new SqlCommand(q, sql);
                       cmd.ExecuteNonQuery();
                       progressForm.PerformStep(this);
                       success++;
                   }
                   else
                   {
                       string q = String.Format("insert into SALTARGETSALESMEN values('01','{0}','{1}',YEAR('{2}'),MONTH('{2}'),'0','{3}')", magaza,SMENID, tarih, AMOUNT);
                       SqlCommand cmd = new SqlCommand(q, sql);
                       cmd.ExecuteNonQuery();
                       success++;
                       progressForm.PerformStep(this);
                   }

               }
               catch (Exception ex)
               {
                   progressForm.PerformStep(this);
                   error++;
                   XtraMessageBox.Show(ex.Message);
               }
           }
           sql.Close();
       },
            null,
            () =>
            {
                completeProgress();
                progressForm.Hide(this);
                btnGuncelle.Visible = false;
                gridPersonelKota.Visible = false;
                spreadsheetControl.Visible = true;
                txtDosyaYolu.Text = "";
                txtKota.Text = "";
                txtName.Text = "";
                txtVal.Text = "";
                txtMagaza.Text = "";
                Worksheet worksheet = spreadsheetControl.Document.Worksheets.ActiveWorksheet;
                // Çalışma sayfasının içeriğini temizle
                worksheet.Clear(worksheet.GetDataRange());
                XtraMessageBox.Show("Başarılı İşlem Sayısı" + success + " Toplam Hatalı :" + error);
            });
        }

        private void tileBarItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            btnGuncelle.Visible = false;
            gridPersonelKota.Visible = false;
            spreadsheetControl.Visible = true;
            txtDosyaYolu.Text = "";
            txtKota.Text = "";
            txtName.Text = "";
            txtVal.Text = "";
            txtMagaza.Text = "";
            Worksheet worksheet = spreadsheetControl.Document.Worksheets.ActiveWorksheet;
            // Çalışma sayfasının içeriğini temizle
            worksheet.Clear(worksheet.GetDataRange());
        }

    }
}