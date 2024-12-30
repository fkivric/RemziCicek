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
    public partial class frmYapıSec : XtraForm
    {        
        public frmYapıSec()
        {
            InitializeComponent();
        }

        private void frmYapıSec_Load(object sender, EventArgs e)
        {

        }

        private void btnArac_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm arac = new MainForm();
            arac.ShowDialog();
            this.Show();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrimMain frmPrim = new frmPrimMain();
            frmPrim.ShowDialog();
            this.Show();
        }

        private void btnSayım_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSayımMain frmSayım = new frmSayımMain();
            frmSayım.ShowDialog();
            this.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
