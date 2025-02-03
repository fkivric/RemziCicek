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
using DevExpress.XtraGrid.Views.Grid;

namespace RemziCicek
{
    public partial class frmPersonelKotaTanımlama : DevExpress.XtraEditors.XtraForm
    {
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
        private void directoryCreator(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public frmPersonelKotaTanımlama()
        {
            InitializeComponent();
        }
        DataTable dtYear = new DataTable();
        private void frmPersonel_Load(object sender, EventArgs e)
        {
            dtYear.Columns.Add("Yil", typeof(int));

            for (int i = 0; i < 3; i++)
            {
                dtYear.Rows.Add(DateTime.Now.AddYears(i * -1).Year);
            }

            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";

            srcRegion.Properties.DataSource = conn.GetData("select distinct DIVREGION from DIVISON where DIVSTS = 1 and DIVSALESTS = 1",sql);
            srcRegion.Properties.DisplayMember = "DIVREGION";
            srcRegion.Properties.ValueMember = "DIVREGION";

            SqlDataAdapter da = new SqlDataAdapter($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            InitializeContextMenus();
            gridAy.ContextMenuStrip = contextMenuGridAy;
            gridSatiscilar.ContextMenuStrip = contextMenuGridSatiscilar;

        }
        private void InitializeContextMenus()
        {
            // gridAy için context menu
            contextMenuGridAy = new ContextMenuStrip();
            var menuSelectAllAy = new ToolStripMenuItem("Tümünü Seç", null, menuSelectAllAy_Click);
            var menuDeselectAllAy = new ToolStripMenuItem("Tümünü Kaldır", null, menuDeselectAllAy_Click);
            contextMenuGridAy.Items.Add(menuSelectAllAy);
            contextMenuGridAy.Items.Add(menuDeselectAllAy);

            // gridSatiscilar için context menu
            contextMenuGridSatiscilar = new ContextMenuStrip();
            var menuSelectAllSatiscilar = new ToolStripMenuItem("Tümünü Seç", null, menuSelectAllSatiscilar_Click);
            var menuDeselectAllSatiscilar = new ToolStripMenuItem("Tümünü Kaldır", null, menuDeselectAllSatiscilar_Click);
            contextMenuGridSatiscilar.Items.Add(menuSelectAllSatiscilar);
            contextMenuGridSatiscilar.Items.Add(menuDeselectAllSatiscilar);
        }
        private void SelectAllRows(GridView gridView)
        {
            gridView.SelectAll();
        }
        private void DeselectAllRows(GridView gridView)
        {
            gridView.ClearSelection();
        }
        private void menuSelectAllAy_Click(object sender, EventArgs e)
        {
            SelectAllRows(ViewAy);
        }

        private void menuDeselectAllAy_Click(object sender, EventArgs e)
        {
            DeselectAllRows(ViewAy);
        }

        private void menuSelectAllSatiscilar_Click(object sender, EventArgs e)
        {
            SelectAllRows(ViewSatiscilar);
        }

        private void menuDeselectAllSatiscilar_Click(object sender, EventArgs e)
        {
            DeselectAllRows(ViewSatiscilar);
        }
        private void srcYil_EditValueChanged(object sender, EventArgs e)
        {
            srcRegion.Enabled = true;
            srcMagaza.Enabled = true;
            btnListesi.Enabled = true;
        }
        private void srcAy_EditValueChanged(object sender, EventArgs e)
        {
            srcMagaza.Properties.DataSource = conn.GetData($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcRegion.EditValue}'", sql); ;
            srcMagaza.Properties.DisplayMember = "DIVNAME";
            srcMagaza.Properties.ValueMember = "DIVVAL";
        }
        DataTable dt = new DataTable();
        private void btnListesi_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt.Rows.Clear();
            navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
            gridAy.DataSource = conn.GetData("select SATGMMONTH,SATGMMONTHNAME from SALTARGETMONTH", sql);
            string q = @"select * from (
            select DIVVAL,DIVNAME,DIVREGION,SMENID,SMENVAL,SMENNAME,SATGYYEAR,SATGMMONTH,SATGMMONTHNAME,isnull(SATGSAAMOUNT,0) as SATGSAAMOUNT,SATGSARATE from (
            select DIVVAL,DIVNAME,DIVREGION,SMENID,SMENVAL,SMENNAME,yil.SATGYYEAR,ay.SATGMMONTH,ay.SATGMMONTHNAME from SALESMEN
            left outer join DIVISON on DIVVAL = SMENDIVISON
            outer apply (select * from SATGYYEAR) yil
            outer apply (select * from SALTARGETMONTH) ay 
            where SMENSTS = 1 and DIVSALESTS = 1 and DIVSTS = 1 and DIVISON.DIVVAL not in ('00','WB')) satici
            outer apply (select SATGSAAMOUNT,SATGSARATE from SALTARGETSALESMEN where SATGSASMENID= SMENID and SATGSAYEAR = satici.SATGYYEAR and SATGSAMONTH = satici.SATGMMONTH) kota
            ) sonuc";
            string w = "select SMENID,SMENVAL,SMENNAME from SALESMEN where SMENSTS = 1";
            if (srcMagaza.EditValue != null)
            {
                w += $" and SMENDIVISON in ('{srcMagaza.EditValue}')";
                q += $" where DIVVAL = '{srcMagaza.EditValue}'";
                q += $" and SATGYYEAR ='{srcYil.EditValue}'";
            }
            else
            {
                if (srcRegion.EditValue != null)
                {
                    w += $" and SMENDIVISON in (select distinct DIVVAL from DIVISON where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcRegion.EditValue}')";
                    q += $" where DIVREGION = '{srcRegion.EditValue}'";
                    q += $" and SATGYYEAR ='{srcYil.EditValue}'";
                }
                else
                {
                    q += $" where SATGYYEAR ='{srcYil.EditValue}'";
                }
            }
            q += " order by 1,4,8";
            dt = conn.GetData(q, sql);
            gridSatiscilar.DataSource = conn.GetData(w, sql);
            //gridSatici.DataSource = dt;
            btnGuncelle.Enabled = true;
            CustomMessageBox.ShowMessage("Lütfen istenilern ayı ve satıcıyı seçin.", "", this, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            List<object> selectedSellers = GetSelectedValues(ViewSatiscilar, "SMENID");

            if (selectedMonths.Count == 0 || selectedSellers.Count == 0)
            {
                return;
            }

            string filterQuery = $"SATGMMONTH IN ({string.Join(",", selectedMonths)}) AND SMENID IN ({string.Join(",", selectedSellers)})";

            DataView dv = new DataView(dt);
            dv.RowFilter = filterQuery;
            gridSatici.DataSource = dv;

            //var selectedMonths = ViewAy.GetSelectedRows().Select(rowHandle => ViewAy.GetRowCellValue(rowHandle, "SATGMMONTH")).ToList();
            //var selectedSalesmen = ViewSatiscilar.GetSelectedRows().Select(rowHandle => ViewSatiscilar.GetRowCellValue(rowHandle, "SMENID")).ToList();

            //var filteredData = dt.AsEnumerable().Where(row =>
            //    selectedMonths.Contains(row.Field<int>("SATGMMONTH")) &&
            //    selectedSalesmen.Contains(row.Field<int>("SMENID"))
            //).CopyToDataTable();

            //gridSatici.DataSource = filteredData;
        }
        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            gridSatici.DataSource = null;
            gridAy.DataSource = null;
            gridSatiscilar.DataSource = null;
            srcYil.EditValue = null;
            srcYil.Enabled = true;
            srcRegion.EditValue = null;
            srcRegion.Enabled = false;
            srcMagaza.EditValue = null;
            srcMagaza.Enabled = false;
            btnGuncelle.Enabled = false;
            dt.Clear();
            dt.Rows.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var selectAY = ViewAy.GetSelectedRows();
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
            var yil = srcYil.EditValue.ToString();
            progressForm.Show(this);
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
                    var Month = viewSatici.GetRowCellValue(i, "SATGMMONTHNAME").ToString();
                    string magaza = viewSatici.GetRowCellValue(i, "DIVVAL").ToString();
                    string ay = conn.GetValue($"select SATGMMONTH from SALTARGETMONTH where SATGMMONTHNAME = '{Month}'");
                    string SATGYYEAR = srcYil.EditValue.ToString();
                    //string magaza = viewSatici.GetRowCellValue(i, "SMENDIVISON").ToString();
                    string kontrol = conn.GetValue(String.Format(@"select count(*) from SALTARGETSALESMEN where SATGSAYEAR = '{0}' and SATGSAMONTH = '{1}' and SATGSASMENID = '{2}'", srcYil.EditValue, ay, id));
                    if (kontrol == "0")
                    {
                        string q = String.Format("update SALTARGETSALESMEN set SATGSARATE = 20, SATGSAAMOUNT = {0} where SATGSADIVISON = '{1}' and SATGSAYEAR = {2} and SATGSAMONTH = '{3}' and SATGSASMENID = {4}", kota, magaza, srcYil.EditValue.ToString(), ay, id);
                        SqlCommand cmd = new SqlCommand(q, sql);
                        cmd.ExecuteNonQuery();
                        success++;
                        progressForm.PerformStep(this);
                    }
                    else
                    {
                        string q = String.Format("insert into SALTARGETSALESMEN values('01','{0}','{1}','{2}','{3}','20','{4}')", magaza, id, yil, ay, kota);
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

        private void buFiyatıTümüneUygulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = viewSatici.FocusedRowHandle;
            var Tutar = double.Parse(viewSatici.GetRowCellValue(viewSatici.FocusedRowHandle, clickedColumnFieldName).ToString());
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = viewSatici.RowCount,
                Position = 0,
                ToplamAdet = viewSatici.RowCount.ToString(),
            };
            int success = 0;
            int error = 0;
            this.Enabled = false;
            executeBackground(
       () =>
       {
           if (Tutar != 0)
           {
               progressForm.Show(this);
               try
               {
                   for (int i = 0; i < viewSatici.RowCount; i++)
                   {
                       if (i != row)
                       {
                           Invoke((MethodInvoker)delegate
                           {
                               viewSatici.SetRowCellValue(i, clickedColumnFieldName, Tutar);
                           });
                       }
                       progressForm.PerformStep(this);
                       success++;
                   }
               }
               catch (Exception ex)
               {
                   progressForm.PerformStep(this);
                   error++;
                   CustomMessageBox.ShowMessage("Hata için detaya bakın.", ex.Message, this, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
           }
           else
           {
               CustomMessageBox.ShowMessage("Lütfen istenilern ayı ve satıcıyı seçin.", "", this, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
       },
                              null,
                              () =>
                              {
                                  completeProgress();
                                  progressForm.Hide(this);
                              });
        }
        private string clickedColumnFieldName;

        private void contextMenuFiyatGir_Opening(object sender, CancelEventArgs e)
        {
            // ContextMenuStrip açılmadan önce tıklanan sütunu kontrol edin
            if (String.IsNullOrEmpty(clickedColumnFieldName))
            {
                e.Cancel = true; // Tıklanan sütun yoksa menüyü açma
            }
        }

        private void viewSatici_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hitInfo = viewSatici.CalcHitInfo(e.Location);
            if (hitInfo.InRow)
            {
                clickedColumnFieldName = hitInfo.Column.FieldName;
            }
        }
    }
}