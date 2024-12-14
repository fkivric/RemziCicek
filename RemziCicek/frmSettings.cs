using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemziCicek
{
    public partial class frmSettings : XtraForm
    {
        internal MainForm mdiParent;

        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtid.Properties.ReadOnly = true;
            txtUser.Properties.ReadOnly = true;
            txtPass.Properties.ReadOnly = true;
            txtid.Text = Properties.Settings.Default.Kodu;
            txtUser.Text = Properties.Settings.Default.Adı;
            txtPass.Text = Properties.Settings.Default.Sifre;
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Properties.Settings.Default.Kodu = txtid.Text;
            Properties.Settings.Default.Adı = txtUser.Text;
            Properties.Settings.Default.Sifre = txtPass.Text;
            Properties.Settings.Default.Save();
            XtraMessageBox.Show("Güncellendi");

        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            txtid.Properties.ReadOnly = false;
            txtUser.Properties.ReadOnly = false;
            txtPass.Properties.ReadOnly = false;
        }
    }
}
