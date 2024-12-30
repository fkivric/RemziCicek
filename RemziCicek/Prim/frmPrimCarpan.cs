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
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace RemziCicek
{
    public partial class frmPrimCarpan : DevExpress.XtraEditors.XtraForm
    {
        public frmPrimCarpan()
        {
            InitializeComponent();
        }

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
        DataTable dtYear = new DataTable();
        DataTable dtMonths = new DataTable();
        private void frmPrimCarpan_Load(object sender, EventArgs e)
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
        }

        private void btnListesi_Click(object sender, EventArgs e)
        {
            string filitre;
            if (srcAy.EditValue.ToString().Length == 1)
            {
                filitre = srcYil.EditValue.ToString() +"-0"+ srcAy.EditValue.ToString() + "-01";
            }
            else
            {
                filitre = srcYil.EditValue.ToString() +"-"+ srcAy.EditValue.ToString() + "-01";
            }
            

            SqlDataAdapter da = new SqlDataAdapter($"select ClassName,ClassBonus from MDE_GENEL.dbo.Fk_tb_bonus_class ", sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridCarpan.DataSource = dt;
            srcAy.Enabled = false;
            btnGuncelle.Enabled = true;
        }

        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            gridCarpan.DataSource = null;
            srcYil.EditValue = null;
            srcYil.Enabled = true;
            srcAy.EditValue = null;
            srcAy.Enabled = false;
            btnGuncelle.Enabled = false;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ProgressBarFrm progressForm = new ProgressBarFrm()
            {
                Start = 0,
                Finish = ViewCarpan.RowCount,
                Position = 0,
                ToplamAdet = ViewCarpan.RowCount.ToString()
            };

            int success = 0;
            int error = 0;
            this.Enabled = false;
            progressForm.Show(this);
            string ay = srcAy.EditValue.ToString();
            string yil = srcYil.EditValue.ToString();
            for (int i = 0; i < ViewCarpan.RowCount; i++)
            {
                if (sql.State == ConnectionState.Closed)
                {
                    sql.Open();
                }
                try
                {
                    string name = ViewCarpan.GetRowCellValue(i, "ClassName").ToString();
                    string carpan = ViewCarpan.GetRowCellValue(i, "ClassBonus").ToString();
                        string q = String.Format("update MDE_GENEL.dbo.Fk_tb_bonus_class set ClassBonus = '{1}' where ClassName = '{0}'", name, carpan);
                        SqlCommand cmd = new SqlCommand(q, sql);
                        cmd.ExecuteNonQuery();
                        success++;
                        progressForm.PerformStep(this);

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

        private void srcYil_EditValueChanged(object sender, EventArgs e)
        {
            srcAy.Enabled = true;
        }

        private void srcAy_EditValueChanged(object sender, EventArgs e)
        {
            btnListesi.Enabled = true;
        }
    }
}