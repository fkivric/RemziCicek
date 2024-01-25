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

namespace RemziCicek
{
    public partial class frmIslem_Pdf : DevExpress.XtraEditors.XtraForm
    {
        string _url = "";
        public frmIslem_Pdf(string url)
        {
            InitializeComponent();
            _url = url;
        }

        private void frmIslem_Pdf_Load(object sender, EventArgs e)
        {
            pdfViewer1.LoadDocument(_url);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            pdfViewer1.Print();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}