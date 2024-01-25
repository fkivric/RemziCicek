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
using RemziCicek.com.turkiyeshell.ttstest;
using System.Xml;
using System.ServiceModel;
using RemziCicek.ShellServiceClient;

namespace RemziCicek
{
    public partial class frmManu : DevExpress.XtraEditors.XtraForm
    {
        public frmManu()
        {
            InitializeComponent();
        }
        string Kodu = "11818213";
        string Adı = "abbasçınar";
        string Sifre = "Ac221980";
        private void frmManu_Load(object sender, EventArgs e)
        {
        }
        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            TTSWebServicesSoapClient client = new TTSWebServicesSoapClient();
            var result = client.GetPlateStatus(Kodu, Adı, Sifre, "", "", "", "");
            if (result.PROCESSRESULT.Success == true)
            {
                var araclar = new List<Item>();
                var arac = new Item();
                foreach (var item in result.CARD_STATUS)
                {
                    arac.Card_No = item.card_no;
                    arac.Card_Status = item.card_status;
                    arac.Card_Status_Code = item.card_status_code;
                    arac.Plate_Code = item.plate_code;
                    araclar.Add(arac);
                }

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                var dt = converter.ToDataTable(araclar);
                gridControl1.DataSource = araclar;
            }
            else
            {
                XtraMessageBox.Show(result.PROCESSRESULT.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            navigationFrame1.SelectedPage = navigationPage2;
        }

    }
}