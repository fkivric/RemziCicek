using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace RemziCicek
{
    public partial class frmMasrafPDF : XtraForm
    {
        string _url = "";
        public frmMasrafPDF(string url)
        {
            InitializeComponent();
            _url = url;
        }


        private void KasaMerkezDekont_Pdf_Load(object sender, EventArgs e)
        {
            {
                //Stream data = response.GetResponseStream();
                pdfViewer1.LoadDocument(_url);
            }        
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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
