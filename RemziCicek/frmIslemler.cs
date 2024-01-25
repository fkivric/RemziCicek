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
    public partial class frmIslemler : DevExpress.XtraEditors.XtraForm
    {
        public frmIslemler()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject sql = new SqlConnectionObject();
        private void frmIslemler_Load(object sender, EventArgs e)
        {
            string query5 = "select * from Islem order by 2";
            SqlDataAdapter da5 = new SqlDataAdapter(query5, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt1 = new DataTable();
            da5.Fill(dt1);
            gridIslem.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sv = new Dictionary<string, string>();
            sv.Add("@saciklama", txtIslem.Text);
            sv.Add("@Tutar", txtTutar.Text);
            var sonuc = sql.Query("Isleminsert", sv);
            string mesaj = sonuc.Rows[0][0].ToString();
            XtraMessageBox.Show(mesaj);
            Yenile();
            txtIslem.Text = "";
            txtTutar.Text = "";
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString))
            //{
            //    String query = "insert into Islem (sAciklama,lTutar) values ('@saciklama','@lTutar')";

            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        command.Parameters.AddWithValue("@saciklama", txtIslem.Text);
            //        command.Parameters.AddWithValue("@lTutar", txtTutar.Text);

            //        connection.Open();
            //        int result = command.ExecuteNonQuery();

            //        // Check Error
            //        if (result < 0)
            //            Console.WriteLine("Eklenmedi Kontrol edin");
            //    }
            //}
        }
        private void Yenile()
        {
            string query4 = "select * from Servis order by 2";
            SqlDataAdapter da4 = new SqlDataAdapter(query4, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            DataTable dt = new DataTable();
            da4.Fill(dt);
            gridIslem.DataSource = dt;
        }

        private void gridIslem_Click(object sender, EventArgs e)
        {
            groupControl2.Tag = cardIslem.GetRowCellValue(cardIslem.FocusedRowHandle, "id").ToString();
            txtIslem.Text = "";
            txtTutar.Text = "";
            txtIslem.Text = cardIslem.GetRowCellValue(cardIslem.FocusedRowHandle, "sAciklama").ToString();
            txtTutar.Text = cardIslem.GetRowCellValue(cardIslem.FocusedRowHandle, "lTutar").ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString))
            {
                String query = "delete Islem where id = '@id'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", groupControl2.Tag.ToString());

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Eklenmedi Kontrol edin");
                }
            }
        }
    }
}