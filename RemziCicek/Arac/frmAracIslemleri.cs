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
    public partial class frmAracIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public frmAracIslemleri()
        {
            InitializeComponent();
            dteTarih.DateTime = DateTime.Now;
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject sql = new SqlConnectionObject();

        private void frmAracIslemleri_Load(object sender, EventArgs e)
        {
            Bolge();
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
            DataTable bolge = new DataTable();
            da2.Fill(bolge);
            cmbBolge.DataSource = bolge;
        }
        private void Magaza(string Bolgeid)
        {
            cmbMagaza.DisplayMember = "sAciklama";
            cmbMagaza.ValueMember = "sKodı";

            string query3 = "select * from Magaza where Bolgeid = '" + Bolgeid + "' order by 2";
            SqlDataAdapter da3 = new SqlDataAdapter(query3, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable magaza = new DataTable();
            da3.Fill(magaza);
            cmbMagaza.DataSource = magaza;
        }
        private void Araclar(string magaza)
        {
            if (magaza != "")
            {
                string query = "select Id,Arac_Plakası from Arac a inner join Magaza m on m.sKodı = a.Arac_Magazası where m.sKodı = '" + magaza.Replace(" ", "") + "' order by 2";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                DataTable arac = new DataTable();
                da.Fill(arac);
                cmbArac.DisplayMember = "Arac_Plakası";
                cmbArac.ValueMember = "Arac_Plakası";
                cmbArac.DataSource = arac;
            }
        }
        private void Servis()
        {
            cmbServis.DisplayMember = "sAciklama";
            cmbServis.ValueMember = "id";

            string query4 = "select * from Servis order by 2";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            cmbServis.DataSource = dt;
        }
        private void Islem()
        {
            cmbIslem.DisplayMember = "sAciklama";
            cmbIslem.ValueMember = "id";

            string query5 = "select * from Islem order by 2";
            SqlDataAdapter da5 = new SqlDataAdapter(query5, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            da5.Fill(dt1);
            cmbIslem.DataSource = dt1;
        }

        private void cmbBolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMagaza.Enabled = true;
            Magaza(cmbBolge.SelectedValue.ToString());
        }

        private void cmbMagaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbArac.Enabled = true;
            Araclar(cmbMagaza.SelectedValue.ToString());
        }

        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArac.SelectedValue.ToString() != "0")
            {
                Servis();
                Islem();
                cmbServis.Enabled = true;
                cmbIslem.Enabled = true;
                Listele(cmbArac.SelectedValue.ToString());
            }
        }

        private void viewAracIslemleri_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                var arac = viewAracIslemleri.GetRowCellValue(e.RowHandle, "AracPlaka").ToString();
                var İd = viewAracIslemleri.GetRowCellValue(e.RowHandle, "id").ToString();
                var tarih = viewAracIslemleri.GetRowCellValue(e.RowHandle, "tarih").ToString();
                frmEvraklar evraklar = new frmEvraklar(İd, arac, tarih);
                evraklar.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ekle = "INSERT INTO [dbo].[Arac_Masraf] " +
                "([AracPlaka] " +
                ",[tarih] " +
                ",[Servisid] " +
                ",[Islemid] " +
                ",[Tutar]) " +
                "VALUES (" +
                "'" + cmbArac.SelectedValue.ToString() + "'," +
                "'" + Convert.ToDateTime(dteTarih.EditValue).ToString("dd/MM/yyyy") + "'," +
                "'" + cmbServis.SelectedValue.ToString() + "'," +
                "'" + cmbIslem.SelectedValue.ToString() + "'," +
                "'" + txtTutar.Text + "')";
            SqlCommand cmd = new SqlCommand(ekle, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Listele(cmbArac.SelectedValue.ToString());
        }
        private void Listele(string Arac)
        {
            var q = "Select ms.id,ms.AracPlaka,ms.tarih,ms.servisid,sv.sAciklama as Servis,ms.Islemid,i.sAciklama as Islem,ms.Tutar from Arac_Masraf ms " +
                "left join servis sv on sv.id = ms.Servisid " +
                "left join Islem i on i.id = ms.Islemid where AracPlaka = '" + Arac + "'";
            SqlDataAdapter da4 = new SqlDataAdapter(q, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            gridAracIslemleri.DataSource = dt;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var arac = cmbArac.SelectedValue.ToString();
            var İd = "";
            var tarih = Convert.ToDateTime(dteTarih.EditValue).ToString("dd/MM/yyyy");
            frmEvraklar evraklar = new frmEvraklar(İd, arac, tarih);
            evraklar.ShowDialog();
        }
    }
}