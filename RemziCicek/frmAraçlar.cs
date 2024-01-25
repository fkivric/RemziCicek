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
using ExcelDataReader;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Data.SqlClient;
using RemziCicek.ShellServiceClient;

namespace RemziCicek
{
    public partial class frmAraçlar : XtraForm
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.VolConnection);
        SqlConnectionObject sql = new SqlConnectionObject();
        DataTable bolge = new DataTable();
        DataTable magaza = new DataTable();

        string Kodu = Properties.Settings.Default.Kodu;
        string Adı = Properties.Settings.Default.Adı;
        string Sifre = Properties.Settings.Default.Sifre;
        public frmAraçlar()
        {
            InitializeComponent();
            //cmbYil.DataSource = CultureInfo.InvariantCulture.DateTimeFormat
            //                                          .MonthNames.Take(12).ToList();
            //cmbYil.SelectedItem = CultureInfo.InvariantCulture.DateTimeFormat
            //                                        .MonthNames[DateTime.Now.AddMonths(-1).Month - 1];

            cmbYil.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            cmbYil.SelectedItem = DateTime.Now.Year;
        }

        private void frmAraçlar_Load(object sender, EventArgs e)
        {
            RegistryKey key2 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\FK_Arac");
            var sonuc = key2.GetValue("ApplicationSetupComplate");
            Arac();
            Bolge();
            Magaza();
            //Marka();
            //Model();

            if (Properties.Settings.Default.servisGuncelle == false)
            {
                btnTTSAraclarCek.Visible = true;
            }
            else
            {
                btnTTSAraclarCek.Visible = false;
            }
        }
        private void Marka()
        {
            cmbMarka.DisplayMember = "sAciklama";
            cmbMarka.ValueMember = "id";

            string query4 = "select * from Marka order by 2";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            cmbMarka.DataSource = dt;
        }
        private void Model()
        {
            cmbModel.DisplayMember = "sAciklama";
            cmbModel.ValueMember = "id";

            string query5 = "select * from Model order by 2";
            SqlDataAdapter da5 = new SqlDataAdapter(query5, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            da5.Fill(dt1);
            cmbModel.DataSource = dt1;
        }
        private void Magaza()
        {
            cmbMagaza.DisplayMember = "sAciklama";
            cmbMagaza.ValueMember = "sKodı";

            string query3 = "select * from Magaza order by 2";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da3.Fill(magaza);
            cmbMagaza.DataSource = magaza;
        }
        private void Bolge()
        {
            cmbBolge.DisplayMember = "sAciklama";
            cmbBolge.ValueMember = "id";

            string query2 = "select * from Bolge order by 2";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            da2.Fill(bolge);
            cmbBolge.DataSource = bolge;
        }
        private void Arac()
        {
            string query = "select " +
                  " a.Id as aracid, " +
                  " isnull(a.Arac_Plakası, '') as Plaka, " +
                  " isnull(a.Arac_Bolge, '')as Arac_Bolgeid, " +
                  " isnull(bl.sAciklama, '') as Arac_BolgeAdi, " +
                  " isnull(a.Arac_Magazası, '') as Arac_Magazaid, " +
                  " isnull(mg.sAciklama, '') as Arac_MagazaAdi, " +
                  " isnull(a.Arac_Markası, '') as Arac_Markaid, " +
                  " isnull(mr.sAciklama, '') as Arac_MarkaAdi, " +
                  " isnull(a.Arac_Modeli, '') as Arac_Modelid, " +
                  " isnull(md.sAciklama, '') as Arac_ModelAdi, " +
                  " isnull(a.Arac_Yıl, '') as Arac_Yıl, " +
                  " isnull(a.Arac_Kilometre, '') as Arac_Kilometre " +
                  " from arac a " +
                  " left join Model md on md.id = a.Arac_Modeli " +
                  " left join Marka mr on mr.id = a.Arac_Markası " +
                  " left join Bolge bl on bl.id = a.Arac_Bolge " +
                  " left join Magaza mg on mg.sKodı = a.Arac_Magazası " +
                  " where active = '1'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable arac = new DataTable();
            da.Fill(arac);
            gridAraclar.DataSource = null;
            gridAraclar.DataSource = arac;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> valuparam = new Dictionary<string, string>();
            valuparam.Add("@id", groupControl2.Tag.ToString());
            valuparam.Add("@Arac_Plakası", txtPlaka.Text);
            valuparam.Add("@Arac_Markası", cmbMarka.SelectedValue.ToString());
            valuparam.Add("@Arac_Modeli", cmbModel.SelectedValue.ToString());
            valuparam.Add("@Arac_Yıl", cmbYil.SelectedItem.ToString());
            valuparam.Add("@Arac_Kilometre", txtkm.Text);
            valuparam.Add("@Arac_Bolge", cmbBolge.SelectedValue.ToString());
            valuparam.Add("@Arac_Magazası", cmbMagaza.SelectedValue.ToString());
            valuparam.Add("@Arac_CihazNo", "");
            valuparam.Add("@Arac_Card_Status_Code", "");
            valuparam.Add("@Arac_Card_Status", "");
            valuparam.Add("@ReturnDesc", "0");
            sql.Query("AracUpdate", valuparam);
            Arac();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> valuparam = new Dictionary<string, string>();
            valuparam.Add("@id", groupControl2.Tag.ToString());
            valuparam.Add("@Arac_Plakası", txtPlaka.Text.Replace(" ",""));
            valuparam.Add("@Arac_Markası", cmbMarka.SelectedValue.ToString());
            valuparam.Add("@Arac_Modeli", cmbModel.SelectedValue.ToString());
            valuparam.Add("@Arac_Yıl", cmbYil.SelectedItem.ToString());
            valuparam.Add("@Arac_Kilometre", txtkm.Text);
            valuparam.Add("@Arac_Bolge", cmbBolge.SelectedValue.ToString());
            valuparam.Add("@Arac_Magazası", cmbMagaza.SelectedValue.ToString().Replace(" ",""));
            valuparam.Add("@Arac_CihazNo", "");
            valuparam.Add("@Arac_Card_Status_Code", "");
            valuparam.Add("@Arac_Card_Status", "");
            valuparam.Add("@ReturnDesc", "1");
            sql.Query("AracUpdate", valuparam);
            Arac();
        }

        private void ViewAraclar_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                txtPlaka.Text = "";
                txtkm.Text = "";
                var dd = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Yıl").ToString();
                groupControl2.Tag       = ViewAraclar.GetRowCellValue(e.RowHandle, "aracid").ToString();
                txtPlaka.Text           = ViewAraclar.GetRowCellValue(e.RowHandle, "Plaka").ToString();
                cmbMarka.SelectedValue   = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Markaid").ToString();
                cmbModel.SelectedValue = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Modelid").ToString();
                cmbYil.SelectedItem = int.Parse(ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Yıl").ToString().Replace(" ", ""));
                txtkm.Text              = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Kilometre").ToString();
                cmbBolge.SelectedValue = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Bolgeid").ToString();
                cmbMagaza.SelectedValue = ViewAraclar.GetRowCellValue(e.RowHandle, "Arac_Magazaid").ToString();
            }
        }

        private void btnTTSAraclarCek_Click(object sender, EventArgs e)
        {

            TTSWebServicesSoapClient client = new TTSWebServicesSoapClient();
            var result = client.GetPlateStatus(Kodu, Adı, Sifre, "", "", "", "");
            if (result.CARD_STATUS.Count() > ViewAraclar.RowCount)
            {

                if (result.PROCESSRESULT.Success == true)
                {
                    var araclar = new List<Item>();
                    foreach (var item in result.CARD_STATUS)
                    {
                        var arac = new Item();
                        arac.Card_No = item.card_no;
                        arac.Card_Status = item.card_status;
                        arac.Card_Status_Code = item.card_status_code;
                        arac.Plate_Code = item.plate_code;
                        araclar.Add(arac);
                    }

                    ListtoDataTableConverter converter = new ListtoDataTableConverter();
                    var dt = converter.ToDataTable(araclar);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Dictionary<string, string> TTS = new Dictionary<string, string>();
                        TTS.Add("@id", "");
                        TTS.Add("@Arac_Plakası", dt.Rows[i]["Plate_Code"].ToString());
                        TTS.Add("@Arac_Markası", "");
                        TTS.Add("@Arac_Modeli", "");
                        TTS.Add("@Arac_Yıl", "");
                        TTS.Add("@Arac_Kilometre", "");
                        TTS.Add("@Arac_Bolge", "");
                        TTS.Add("@Arac_Magazası", "");
                        TTS.Add("@Arac_CihazNo", dt.Rows[i]["Card_No"].ToString());
                        TTS.Add("@Arac_Card_Status_Code", dt.Rows[i]["Card_Status_Code"].ToString());
                        TTS.Add("@Arac_Card_Status", dt.Rows[i]["Card_Status"].ToString());
                        TTS.Add("@ReturnDesc", "2");
                        sql.Query("AracUpdate", TTS);
                    }
                }
                else
                {
                    XtraMessageBox.Show(result.PROCESSRESULT.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Properties.Settings.Default.servisGuncelle = true;
            Properties.Settings.Default.Save();
            frmAraçlar_Load(null, null);
        }
    }
}