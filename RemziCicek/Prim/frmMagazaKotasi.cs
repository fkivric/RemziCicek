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
using DevExpress.XtraGrid.Views.Grid;

namespace RemziCicek
{
    public partial class frmMagazaKotasi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        SqlConnectionObject conn = new SqlConnectionObject();
        public frmMagazaKotasi()
        {
            InitializeComponent();
        }
        DataTable dtYear = new DataTable();
        string magaza = "";
        //arka plan işlemleri
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
                _backgroundWorker.RunWorkerCompleted += _backgroundWorker_RunWorkerCompleted;
            }
            catch (Exception)
            {

            }

        }
        private void _backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

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
        private void frmMagazaKotasi_Load(object sender, EventArgs e)
        {

            dtYear.Columns.Add("Yil", typeof(int));
            for (int i = 0; i < 3; i++)
            {
                dtYear.Rows.Add(DateTime.Now.AddYears(i*-1).Year);
            }
            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";       
        }

        private void srcYil_EditValueChanged(object sender, EventArgs e)
        {
            if (srcYil.EditValue != null)
            {
                srcBolge.Properties.DataSource = conn.GetData("select distinct DIVREGION from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", sql);
                srcBolge.Properties.DisplayMember = "DIVREGION";
                srcBolge.Properties.ValueMember = "DIVREGION";
                srcBolge.Enabled = true;
                srcMagaza.Enabled = true;
                srcMagaza.EditValue = null;
                srcBolge.EditValue = null;
            }
        }
        private void srcBolge_EditValueChanged(object sender, EventArgs e)
        {
            srcMagaza.Properties.DataSource = conn.GetData($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcBolge.EditValue.ToString()}'", sql);
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
            srcMagaza.EditValue = null;

        }

        DataTable dt = new DataTable();
        private void btnListesi_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Rows.Clear();
            navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
            gridAy.DataSource = conn.GetData("select SATGMMONTH,SATGMMONTHNAME from SALTARGETMONTH", sql);
            string q = @"select * from (
            select DIVVAL,DIVNAME,DIVREGION,'Ana Kotası' as SMENVAL,DIVMDRNAME as SMENNAME,SATGYYEAR,SATGMMONTH,SATGMMONTHNAME,SATGDIAMOUNT,SATGDIRATE from (
            select DIVISON.DIVVAL,DIVREGION,DIVISON.DIVNAME,yil.SATGYYEAR,ay.SATGMMONTH,DIVMDRNAME,ay.SATGMMONTHNAME from [W].[Yonavm_Web_Siparis].[dbo].[VolantMagazaIletisim] i
            left outer join DIVISON DIVISON on DIVISON.DIVVAL = i.DIVVAL
            outer apply (select * from SATGYYEAR) yil
            outer apply (select * from SALTARGETMONTH) ay 
            where DIVSALESTS = 1 and DIVSTS = 1 and DIVISON.DIVVAL not in ('00','WB')) magaza
            outer apply (select SATGDIAMOUNT,SATGDIRATE from SALTARGETDIVISON where SATGDIDIVISON = magaza.DIVVAL and SATGDIYEAR = magaza.SATGYYEAR and SATGDIMONTH = magaza.SATGMMONTH) kota
            ) sonuc";
            string w = "select SMENID,SMENVAL,SMENNAME from SALESMEN where SMENSTS = 1";
            if (srcMagaza.EditValue != null)
            {
                q += $" where DIVVAL = '{srcMagaza.EditValue}'";
                q += $" and SATGYYEAR ='{srcYil.EditValue}'";
            }
            else
            {
                if (srcBolge.EditValue != null)
                {
                    q += $" where DIVREGION = '{srcBolge.EditValue}'";
                    q += $" and SATGYYEAR ='{srcYil.EditValue}'";
                }
                else
                {
                    q += $" where SATGYYEAR ='{srcYil.EditValue}'";
                }
            }
            q += " order by 1,4,8";
            dt = conn.GetData(q, sql);
            //gridMagaza.DataSource = dt;
            srcBolge.Enabled = false;
            srcYil.Enabled = false;
            srcMagaza.Enabled = false;
            btnListesi.Enabled = false;
            btnMagazaGuncelle.Enabled = true;
            CustomMessageBox.ShowMessage("Lütfen istenilern ayı seçin.", "", this, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private List<object> GetSelectedValues(GridView gridView, string columnName)
        {
            List<object> selectedValues = new List<object>();
            foreach (int rowHandle in gridView.GetSelectedRows())
            {
                object value = gridView.GetRowCellValue(rowHandle, columnName);
                if (value != null)
                {
                    selectedValues.Add(value);
                }
            }
            return selectedValues;
        }
        private void ViewAy_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            FilterGridSatici();
        }

        private void ViewSatiscilar_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            FilterGridSatici();
        }
        private void FilterGridSatici()
        {
            List<object> selectedMonths = GetSelectedValues(ViewAy, "SATGMMONTH");

            if (selectedMonths.Count == 0 )
            {
                gridMagaza.DataSource = null;
                return;
            }

            string filterQuery = $"SATGMMONTH IN ({string.Join(",", selectedMonths)})";

            DataView dv = new DataView(dt);
            dv.RowFilter = filterQuery;
            gridMagaza.DataSource = dv;
        }
        private void btnMagazaGuncelle_Click(object sender, EventArgs e)
        {
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = ViewMagaza.RowCount,
                Position = 0,
                ToplamAdet = ViewMagaza.RowCount.ToString()
            };

            int success = 0;
            int error = 0;
            this.Enabled = false;

            executeBackground(
        () =>
        {
            progressForm.Show(this);
            for (int i = 0; i < ViewMagaza.RowCount; i++)
            {

                if (sql.State == ConnectionState.Closed)
                {
                    sql.Open();
                }
                try
                {
                    string q = "";
                    var Month = ViewMagaza.GetRowCellValue(i, "SATGMMONTHNAME").ToString();
                    string ay = conn.GetValue($"select SATGMMONTH from SALTARGETMONTH where SATGMMONTHNAME = '{Month}'");
                    string magaza = ViewMagaza.GetRowCellValue(i, "DIVVAL").ToString();
                    string SATGYYEAR = srcYil.EditValue.ToString();
                    string kota = "0";
                    if (ViewMagaza.GetRowCellValue(i, "SATGDIAMOUNT").ToString() != "")
                    {
                        kota = double.Parse(ViewMagaza.GetRowCellValue(i, "SATGDIAMOUNT").ToString()).ToString();
                    }
                    string carpan = "0";
                    if (ViewMagaza.GetRowCellValue(i, "SATGDIRATE").ToString() != "")
                    {
                        carpan = double.Parse(ViewMagaza.GetRowCellValue(i, "SATGDIRATE").ToString()).ToString();
                    }
                    var kontrol = conn.GetValue($"select count(*) from SALTARGETDIVISON where SATGDIYEAR = {SATGYYEAR} and SATGDIMONTH = {ay} and SATGDIDIVISON = '{magaza}'");
                    if (kontrol == "0")
                    {
                        q = String.Format("insert into SALTARGETDIVISON values ('01','{0}',{1},{2},'{3}','{4}')", magaza, srcYil.EditValue.ToString(), ay, kota, carpan);
                    }
                    else
                    {
                        q = String.Format("update SALTARGETDIVISON set SATGDIRATE = {4}, SATGDIAMOUNT = {0} where SATGDIDIVISON = '{1}' and SATGDIYEAR = {2} and SATGDIMONTH = '{3}'", kota, magaza, srcYil.EditValue.ToString(), ay, carpan);

                    }
                    SqlCommand cmd = new SqlCommand(q, sql);
                    var sonuc = cmd.ExecuteNonQuery();
                    success++;
                    progressForm.PerformStep(this);
                }
                catch (Exception ex)
                {
                    CustomMessageBox.ShowMessage("", ex.Message, this, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    error++;
                    progressForm.PerformStep(this);
                }

            }
        },
                                null,
                                () =>
                                {
                                    completeProgress();
                                    progressForm.Hide(this);
                                    sql.Close();
                                    btnMagazaYeni_Click(null, null);
                                });
        }

        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            gridMagaza.DataSource = null;
            gridAy.DataSource = null;
            srcYil.EditValue = null;
            srcYil.Enabled = true;
            srcBolge.EditValue = null;
            srcBolge.Enabled = false;
            srcMagaza.EditValue = null;
            srcMagaza.Enabled = false;
            btnMagazaGuncelle.Enabled = false;
            btnListesi.Enabled = true;
        }
    }
}