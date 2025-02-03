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
using System.Threading;
using System.IO;

namespace RemziCicek
{
    public partial class frmPersonel : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
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
        private void directoryCreator(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public frmPersonel()
        {
            InitializeComponent();
        }
        DataTable dtYear = new DataTable();
        DataTable dtMonths = new DataTable();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            dtMonths.Columns.Add("AY", typeof(string));
            dtMonths.Columns.Add("ayi", typeof(int));

            dtYear.Columns.Add("Yil", typeof(int));

            string[] monthNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
            for (int i = 0; i < 12; i++)
            {
                dtMonths.Rows.Add(monthNames[i], i + 1);
            }
            for (int i = 0; i < 3; i++)
            {
                dtYear.Rows.Add(DateTime.Now.AddYears(i * -1).Year);
            }
            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";


            srcAy.Properties.DataSource = dtMonths;
            srcAy.Properties.DisplayMember = "AY";
            srcAy.Properties.ValueMember = "ayi";

            SqlDataAdapter da = new SqlDataAdapter($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            srcMagaza.Properties.DataSource = dt;
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
        }
        private void srcYil_EditValueChanged(object sender, EventArgs e)
        {
            srcAy.Enabled = true;
        }
        private void srcAy_EditValueChanged(object sender, EventArgs e)
        {
            srcMagaza.Enabled = true;
        }
        private void srcMagaza_EditValueChanged(object sender, EventArgs e)
        {
            btnListesi.Enabled = true;
        }

        private void btnListesi_Click(object sender, EventArgs e)
        {
            string yil = srcYil.EditValue.ToString();
            string ay = srcAy.EditValue.ToString();
            if (yil != null && ay != null)
            {
                string q = String.Format(@"select SMENID,SMENVAL,SMENNAME,isnull(SATGSAAMOUNT,0) as SATGSAAMOUNT,SMENDIVISON from SALESMEN 
                outer apply (select SATGSAAMOUNT from SALTARGETSALESMEN where SATGSASMENID = SMENID and SATGSAYEAR = '{0}' and SATGSAMONTH = '{1}' ) kota
                where SMENDIVISON ='{2}' and SMENSTS = 1
                order by SMENNAME", yil, ay, srcMagaza.EditValue.ToString());
                SqlDataAdapter da = new SqlDataAdapter(q, sql);
                //SqlDataAdapter da = new SqlDataAdapter($"Select SMENID,SMENVAL,SMENNAME,SATGSAAMOUNT from SALESMEN left outer join SALTARGETSALESMEN on SMENID = SATGSASMENID where SMENSTS = 1 and SATGSAYEAR = {yil} and SATGSAMONTH = {ay} and SMENDIVISON = '{srcMagaza.EditValue.ToString()}' ", sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridSatici.DataSource = dt;
                btnGuncelle.Enabled = true;
            }
        }

        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            gridSatici.DataSource = null;
            srcYil.EditValue = null;
            srcYil.Enabled = true;
            srcAy.EditValue = null;
            srcAy.Enabled = false;
            srcMagaza.EditValue = null;
            srcMagaza.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = viewSatici.RowCount,
                Position = 0,
                ToplamAdet = viewSatici.RowCount.ToString()
            };

            int success = 0;
            int error = 0;
            this.Enabled = false;
            progressForm.Show(this);
            string ay = srcAy.EditValue.ToString();
            string yil = srcYil.EditValue.ToString();
            string magaza = srcMagaza.EditValue.ToString();
            for (int i = 0; i < viewSatici.RowCount; i++)
            {
                if (sql.State == ConnectionState.Closed)
                {
                    sql.Open();
                }
                try
                {
                    string kota = double.Parse(viewSatici.GetRowCellValue(i, "SATGSAAMOUNT").ToString()).ToString();
                    string id = double.Parse(viewSatici.GetRowCellValue(i, "SMENID").ToString()).ToString();
                    //string magaza = viewSatici.GetRowCellValue(i, "SMENDIVISON").ToString();
                    string kontrol = String.Format(@"select * from SALTARGETSALESMEN where SATGSAYEAR = '{0}' and SATGSAMONTH = '{1}' and SATGSASMENID = '{2}'", srcYil.EditValue, srcAy.EditValue, id);
                    SqlDataAdapter da = new SqlDataAdapter(kontrol, sql);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        string q = String.Format("update SALTARGETSALESMEN set SATGSARATE = 0, SATGSAAMOUNT = {0} where SATGSADIVISON = '{1}' and SATGSAYEAR = {2} and SATGSAMONTH = '{3}' and SATGSASMENID = {4}", kota, magaza, srcYil.EditValue.ToString(), ay, id);
                        SqlCommand cmd = new SqlCommand(q, sql);
                        cmd.ExecuteNonQuery();
                        success++;
                        progressForm.PerformStep(this);
                    }
                    else
                    {
                        string q = String.Format("insert into SALTARGETSALESMEN values('01','{0}','{1}','{2}','{3}','0','{4}')", magaza, id, yil, ay, kota);
                        SqlCommand cmd = new SqlCommand(q, sql);
                        cmd.ExecuteNonQuery();
                        success++;
                        progressForm.PerformStep(this);
                    }

                }
                catch (Exception)
                {
                    error++;
                    progressForm.PerformStep(this);
                }
            }
            sql.Close();
            progressForm.Hide(this);
            this.Enabled = true;
            btnMagazaYeni_Click(null, null);
        }
    }
}