using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IMS.Codes;
using System;
using IMS.Forms;
using IMS.Controls;

namespace IMS
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            dlaf.LookAndFeel.SkinName = Properties.Settings.Default.WindowTheme;
            Settings.GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
            LoadDashboard();
        }

        void LoadDashboard()
        {
            ucDashboard uc = new ucDashboard() { Dock = DockStyle.Fill };
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.ribbonControl1);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
            bClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void LoadControl(XtraUserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            splt.Panel2.Controls.Clear();
            splt.Panel2.Controls.Add(ctrl);
            bClose.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }
        private void bbNewProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNewProduct frm = new frmNewProduct();
            frm.ShowDialog();
        }

        private void bbExtProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExtProduct frm = new frmExtProduct();
            frm.ShowDialog();
        }

        private void bbSellProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSellProduct frm = new frmSellProduct();
            frm.ShowDialog();
        }

        private void nbiViewProducts_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucProducts uc = new ucProducts() { Dock = DockStyle.Fill };
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.ribbonControl);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bbPurchaseProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPurchase frm = new frmPurchase();
            frm.ShowDialog();
        }
        private void nbiViewSuppliers_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSuppliers uc = new ucSuppliers() { Dock = DockStyle.Fill };
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.ribbonControl);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void nbiViewCustomer_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucCustomers uc = new ucCustomers() { Dock = DockStyle.Fill };
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.ribbonControl);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bCreditPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCreditPayment frm = new frmCreditPayment();
            frm.ShowDialog();
        }

        private void bDebitPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDebitPayment frm = new frmDebitPayment();
            frm.ShowDialog();
        }

        private void nbiViewReports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucReports uc = new ucReports() { Dock = DockStyle.Fill };
            LoadControl(uc);
            MainRibbon.MergeRibbon(uc.ribbonControl1);
            MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDashboard();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowTheme = dlaf.LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.WindowGeometry = Settings.GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        private void bCAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
        }

        private void btnLogOff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //LoadDashboard();
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
        }

        private void bSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSettings frm = new frmSettings();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ShopName = frm.ShopName;
                Properties.Settings.Default.Address = frm.Address;
                Properties.Settings.Default.Phone = frm.PhoneNo;
                Properties.Settings.Default.Email = frm.Email;
                Properties.Settings.Default.Website = frm.Website;
                Properties.Settings.Default.ShortName = frm.ShortName;
                Properties.Settings.Default.Save();
            }
        }

        private void bUsers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ucUsers uc = new ucUsers() { Dock = DockStyle.Fill };
            //LoadControl(uc);
            //MainRibbon.MergeRibbon(uc.ribbonControl);
            //MainRibbon.SelectedPage = MainRibbon.MergedRibbon.SelectedPage;
        }

        private void bbAckup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.Desktop;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(Application.StartupPath + "/ims.mdb", fbd.SelectedPath + "/DB_BACKUP_" + DateTime.Now.Day.ToString("00") + DateTime.Now.Month.ToString("00") + DateTime.Now.Year.ToString() + ".bkp");
            }
        }

        private void bRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog sfd = new OpenFileDialog() { Filter = "Backup File (*.bkp)|*.bkp|All Files (*.*)|*.*" };
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(sfd.FileName, Application.StartupPath + "/ims.mdb", true);
            }
        }

        private void bQuickSell_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmQuickSell frm = new frmQuickSell();
            frm.ShowDialog();
        }

        private void bRInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRevisedInvoice frm = new frmRevisedInvoice();
            frm.ShowDialog();
        }
    }
}
