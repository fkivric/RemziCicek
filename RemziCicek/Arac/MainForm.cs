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
using DevExpress.XtraBars.Navigation;
using DevExpress.Utils;
using DevExpress.XtraTab;
using RemziCicek.Class;

namespace RemziCicek
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        string version = "";
        public MainForm()
        {
            InitializeComponent();
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment ad = System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                this.Text = "Version : " + ad.CurrentVersion.Major + "." + ad.CurrentVersion.Minor + "." + ad.CurrentVersion.Build + "." + ad.CurrentVersion.Revision;
                version = ad.CurrentVersion.Revision.ToString();
            }
            else
            {
                string _s1 = Application.ProductVersion; // versiyon
                this.Text = "Version : " + _s1;
                version = _s1;
            }
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            //navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            var index = tileBarGroupTables.Items.IndexOf(e.Item);
            string tabPageText = getTabPagesText(sender, e.Item.Name);
            bool tabPageExists = false;
            foreach (XtraTabPage tabPage in xtraTabControl.TabPages)
            {
                if (tabPage.Text == tabPageText)
                {
                    tabPageExists = true;
                    xtraTabControl.SelectedTabPage = tabPage;
                    break;
                }
            }
            if (!tabPageExists)
            {
                if (index == 0)
                {
                    try
                    {
                        xtraTabControl.TabPages.Add(tabPageText);
                        xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                        frmMasraf childForm = new frmMasraf();
                        childForm.mdiParent = this;
                        childForm.TopLevel = false;
                        childForm.Dock = DockStyle.Fill;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.WindowState = FormWindowState.Maximized;
                        childForm.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                        childForm.Show();
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message);
                    }
                }
                else if (index == 1)
                {
                    try
                    {
                        xtraTabControl.TabPages.Add(tabPageText);
                        xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                        frmMasrafGor childForm = new frmMasrafGor();
                        childForm.mdiParent = this;
                        childForm.TopLevel = false;
                        childForm.Dock = DockStyle.Fill;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.WindowState = FormWindowState.Maximized;
                        childForm.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                        childForm.Show();
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message);
                    }
                }
                else if (index == 2)
                {
                    try
                    {
                        xtraTabControl.TabPages.Add(tabPageText);
                        xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                        frmArac_TTS childForm = new frmArac_TTS();
                        childForm.mdiParent = this;
                        childForm.TopLevel = false;
                        childForm.Dock = DockStyle.Fill;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.WindowState = FormWindowState.Maximized;
                        childForm.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                        childForm.Show();
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message);
                    }

                }
                else if (index == 3)
                {
                    try
                    {
                        xtraTabControl.TabPages.Add(tabPageText);
                        xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                        frmAracMasrafRaporu childForm = new frmAracMasrafRaporu();
                        childForm.mdiParent = this;
                        childForm.TopLevel = false;
                        childForm.Dock = DockStyle.Fill;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        childForm.WindowState = FormWindowState.Maximized;
                        childForm.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                        childForm.Show();
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message);
                    }
                }
                if (tabPageText == "btnSettings")
                {
                    try
                    {
                        xtraTabControl.TabPages.Add(tabPageText);
                        xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
                        frmSettings childForm = new frmSettings();
                        childForm.mdiParent = this;
                        childForm.TopLevel = false;
                        childForm.Dock = DockStyle.Fill;
                        childForm.FormBorderStyle = FormBorderStyle.None;
                        //childForm.WindowState = FormWindowState.Maximized;
                        childForm.Parent = xtraTabControl.TabPages[xtraTabControl.TabPages.Count - 1];
                        childForm.Show();
                    }
                    catch (Exception exp)
                    {
                        XtraMessageBox.Show(exp.Message);
                    }
                }
            }
        }

        public string getTabPagesText(object sender, string text)
        {
            try
            {
                TileBarItem acco = sender as TileBarItem;
                if (acco != null)
                {
                    return acco.Name;
                }
                else
                {
                    TileBar acco2 = sender as TileBar;
                    return acco2.SelectedItem.Name;
                }
            }
            catch
            {
                return text;
            }
        }
        public void xtraTabControlSizeRule()
        {
            try
            {
                for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
                {
                    Application.DoEvents();
                    xtraTabControl.TabPages[i].Width = xtraTabControl.Width;
                    xtraTabControl.TabPages[i].Height = xtraTabControl.Height;
                    foreach (Control item in xtraTabControl.TabPages[i].Controls)
                    {
                        Application.DoEvents();
                        xtraTabControl.TabPages[i].Controls.Remove(item);
                        if (item is Form frm)
                        {
                            frm.Dock = DockStyle.Fill;
                            frm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                            frm.AutoSize = false;
                            frm.Size = new Size(xtraTabControl.TabPages[i].Width, xtraTabControl.TabPages[i].Height);
                        }
                        xtraTabControl.TabPages[i].Controls.Add(item);
                        item.Refresh();
                        Application.DoEvents();
                    }
                    Application.DoEvents();
                }
            }
            catch
            {
            }
        }
        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (!base.DesignMode)
            {
                xtraTabControlSizeRule();
            }
        }

        private void tileBarItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            List<XtraTabPage> lRemovePages = new List<XtraTabPage>();
            for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
            {
                //i == xtraTabControl.SelectedTabPageIndex || 
                if (!(xtraTabControl.TabPages[i].Name != "anaSayfaTab"))
                {
                    continue;
                }
                foreach (object item in xtraTabControl.TabPages[i].Controls)
                {
                    if (item is Form && item is Form frm)
                    {
                        frm.Dispose();
                    }
                }
                lRemovePages.Add(xtraTabControl.TabPages[i]);
            }
            foreach (XtraTabPage item2 in lRemovePages)
            {
                xtraTabControl.TabPages.Remove(item2);
            }
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            //Point pt = base.Location;
            //pt.Offset(base.Width / 2, base.Height / 2);
            //radialMenu.ShowPopup(pt);
            //radialMenu.Expand();
        }

        private void SekmeleriKapatItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            radialMenu.HidePopup();
            List<XtraTabPage> lRemovePages = new List<XtraTabPage>();
            for (int i = 0; i < xtraTabControl.TabPages.Count; i++)
            {
                if (i == xtraTabControl.SelectedTabPageIndex || !(xtraTabControl.TabPages[i].Name != "anaSayfaTab"))
                {
                    continue;
                }
                foreach (object item in xtraTabControl.TabPages[i].Controls)
                {
                    if (item is Form && item is Form frm)
                    {
                        frm.Dispose();
                    }
                }
                lRemovePages.Add(xtraTabControl.TabPages[i]);
            }
            foreach (XtraTabPage item2 in lRemovePages)
            {
                xtraTabControl.TabPages.Remove(item2);
            }
            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
        
    
        }
        private void LoadShortCuts()
        {

        }
    }
}
