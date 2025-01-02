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

namespace RemziCicek
{
    public partial class frmMagazaKotasi : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sql = new SqlConnection(Properties.Settings.Default.VolConnection);
        public frmMagazaKotasi()
        {
            InitializeComponent();
        }
        DataTable dtMonths = new DataTable();
        DataTable dtYear = new DataTable();
        string magaza = "";
        DataTable MGZ = new DataTable();
        private void frmMagazaKotasi_Load(object sender, EventArgs e)
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
                dtYear.Rows.Add(DateTime.Now.AddYears(i*-1).Year);
            }
            srcYil.Properties.DataSource = dtYear;
            srcYil.Properties.DisplayMember = "Yil";
            srcYil.Properties.ValueMember = "Yil";

            SqlDataAdapter dab = new SqlDataAdapter("select distinct DIVREGION from DIVISON where DIVREGION is not NULL", sql);
            DataTable dtb = new DataTable();
            dab.Fill(dtb);
            srcBolge.Properties.DataSource = dtb;
            srcBolge.Properties.DisplayMember = "DIVREGION";
            srcBolge.Properties.ValueMember = "DIVREGION";            
        }

        private void srcYil_EditValueChanged(object sender, EventArgs e)
        {
            if (srcYil.EditValue != null)
            {
                srcBolge.Enabled = true;
            }
        }
        private void srcBolge_EditValueChanged(object sender, EventArgs e)
        {
            MGZ.Clear();
            if (srcBolge.EditValue != null)
            {
                SqlDataAdapter da = new SqlDataAdapter($"select DIVVAL,DIVNAME from DIVISON where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcBolge.EditValue.ToString()}'", sql);
                da.Fill(MGZ);
                srcMagaza.Properties.DataSource = MGZ;
                srcMagaza.Properties.DisplayMember = "DIVNAME";
                srcMagaza.Properties.ValueMember = "DIVVAL";
                srcMagaza.Enabled = true;
                srcMagaza.EditValue = null;
            }
        }

        private void srcMagaza_EditValueChanged(object sender, EventArgs e)
        {
            if (srcMagaza.EditValue != null)
            {
                magaza = srcMagaza.EditValue.ToString();
            }

            btnListesi.Enabled = true;
        }
        private void btnListesi_Click(object sender, EventArgs e)
        {
            string q = "";
            if (srcMagaza.EditValue != "Tümü" && srcMagaza.EditValue !=  null)
            {
                q = $@"SET LANGUAGE Turkish; 
                select AY,AyAdi,DIVVAL,DIVNAME, SATGDIAMOUNT KOTA from (
                select SATGMMONTH as AY, DATENAME(month, DATEADD(month, SATGMMONTH - 1, '1900-01-01')) AS AyAdi,DIVVAL,DIVNAME from SALTARGETMONTH,DIVISON
                where DIVSTS = 1 and DIVSALESTS = 1 and DIVVAL = '{srcMagaza.EditValue.ToString()}'
                ) sira
                left outer join (select * from SALTARGETDIVISON ) kota on SATGDIDIVISON = DIVVAL and SATGDIMONTH = AY and SATGDIYEAR = {srcYil.EditValue.ToString()}";
            }
            else if (srcBolge.EditValue != null)
            {
                q = $@"SET LANGUAGE Turkish; 
                select AY,AyAdi,DIVVAL,DIVNAME, SATGDIAMOUNT KOTA from (
                select SATGMMONTH as AY, DATENAME(month, DATEADD(month, SATGMMONTH - 1, '1900-01-01')) AS AyAdi,DIVVAL,DIVNAME from SALTARGETMONTH,DIVISON
                where DIVSTS = 1 and DIVSALESTS = 1 and DIVREGION = '{srcBolge.EditValue.ToString()}'
                ) sira
                left outer join (select * from SALTARGETDIVISON ) kota on SATGDIDIVISON = DIVVAL and SATGDIMONTH = AY and SATGDIYEAR = {srcYil.EditValue.ToString()}";

                //q = $"SET LANGUAGE Turkish; select SATGDIMONTH as AY, DATENAME(month, DATEADD(month, SATGDIMONTH - 1, '1900-01-01')) AS AyAdi,DIVVAL,DIVNAME, SATGDIAMOUNT KOTA  from SALTARGETDIVISON left outer join DIVISON on DIVVAL = SATGDIDIVISON where DIVREGION = '{srcBolge.EditValue.ToString()}' and SATGDIYEAR = '{srcYil.EditValue.ToString()}' and DIVSALESTS = 1 order by DIVVAL,AY";
            }
            else
            {
                q = $@"SET LANGUAGE Turkish; 
                select AY,AyAdi,DIVVAL,DIVNAME, SATGDIAMOUNT KOTA from (
                select SATGMMONTH as AY, DATENAME(month, DATEADD(month, SATGMMONTH - 1, '1900-01-01')) AS AyAdi,DIVVAL,DIVNAME from SALTARGETMONTH,DIVISON
                where DIVSTS = 1 and DIVSALESTS = 1 
                ) sira
                left outer join (select * from SALTARGETDIVISON ) kota on SATGDIDIVISON = DIVVAL and SATGDIMONTH = AY and SATGDIYEAR = {srcYil.EditValue.ToString()}";

            }
            SqlDataAdapter da = new SqlDataAdapter(q, sql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridMagaza.DataSource = dt;
            srcBolge.Enabled = false;
            srcYil.Enabled = false;
            srcMagaza.Enabled = false;
            btnListesi.Enabled = false;
            btnMagazaGuncelle.Enabled = true;
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
            progressForm.Show(this);
            for (int i = 0; i < ViewMagaza.RowCount; i++)
            {
                if (sql.State == ConnectionState.Closed)
                {
                    sql.Open();
                }
                try
                {
                    string ay = ViewMagaza.GetRowCellValue(i, "AY").ToString();
                    string magaza = ViewMagaza.GetRowCellValue(i, "DIVVAL").ToString();
                    string kota = double.Parse(ViewMagaza.GetRowCellValue(i, "KOTA").ToString()).ToString();
                    string q = String.Format("update SALTARGETDIVISON set SATGDIRATE = 0, SATGDIAMOUNT = {0} where SATGDIDIVISON = '{1}' and SATGDIYEAR = {2} and SATGDIMONTH = '{3}'", kota, magaza, srcYil.EditValue.ToString(), ay);
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

        private void btnMagazaYeni_Click(object sender, EventArgs e)
        {
            gridMagaza.DataSource = null;
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