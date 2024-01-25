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
    public partial class frmServisler : DevExpress.XtraEditors.XtraForm
    {
        public frmServisler()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString);
        SqlConnectionObject sql = new SqlConnectionObject();
        private void frmServisler_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sv = new Dictionary<string, string>();
            sv.Add("@saciklama", txtServis.Text);
            var sonuc = sql.Query("Servisinsert", sv);
            string mesaj = sonuc.Rows[0][0].ToString();
            XtraMessageBox.Show(mesaj);
            Yenile();
            txtServis.Text = "";
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
            gridServis.DataSource = dt;
        }

        private void cardServis_DoubleClick(object sender, EventArgs e)
        {
            groupControl2.Tag = cardServis.GetRowCellValue(cardServis.FocusedRowHandle, "id").ToString();
            txtServis.Text = "";
            txtServis.Text = cardServis.GetRowCellValue(cardServis.FocusedRowHandle, "sAciklama").ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.YonavmAracDatasıConnectionString))
            {
                String query = "delete Servis where id = '@id'";

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