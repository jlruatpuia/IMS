namespace IMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainRibbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.bbNewProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bbExtProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bbSellProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bbPurchaseProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bCreditPayment = new DevExpress.XtraBars.BarButtonItem();
            this.bDebitPayment = new DevExpress.XtraBars.BarButtonItem();
            this.bClose = new DevExpress.XtraBars.BarButtonItem();
            this.bCAT = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOff = new DevExpress.XtraBars.BarButtonItem();
            this.bSettings = new DevExpress.XtraBars.BarButtonItem();
            this.bUsers = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbAckup = new DevExpress.XtraBars.BarButtonItem();
            this.bRestore = new DevExpress.XtraBars.BarButtonItem();
            this.bQuickSell = new DevExpress.XtraBars.BarButtonItem();
            this.bRInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSales = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgProduct = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.splt = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiViewProducts = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiViewSuppliers = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiViewCustomer = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiViewReports = new DevExpress.XtraNavBar.NavBarItem();
            this.dlaf = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.bServicing = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splt)).BeginInit();
            this.splt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainRibbon
            // 
            this.MainRibbon.ExpandCollapseItem.Id = 0;
            this.MainRibbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MainRibbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.bbNewProduct,
            this.bbExtProduct,
            this.bbSellProduct,
            this.bbPurchaseProduct,
            this.bCreditPayment,
            this.bDebitPayment,
            this.bClose,
            this.bCAT,
            this.btnLogOff,
            this.bSettings,
            this.bUsers,
            this.barSubItem1,
            this.bbAckup,
            this.bRestore,
            this.bQuickSell,
            this.bRInvoice,
            this.bServicing});
            this.MainRibbon.Location = new System.Drawing.Point(0, 0);
            this.MainRibbon.MaxItemId = 21;
            this.MainRibbon.Name = "MainRibbon";
            this.MainRibbon.PageHeaderItemLinks.Add(this.bClose);
            this.MainRibbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.MainRibbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.MainRibbon.Size = new System.Drawing.Size(1049, 143);
            this.MainRibbon.Toolbar.ItemLinks.Add(this.btnLogOff);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // bbNewProduct
            // 
            this.bbNewProduct.Caption = "Add New";
            this.bbNewProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("bbNewProduct.Glyph")));
            this.bbNewProduct.Id = 3;
            this.bbNewProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbNewProduct.LargeGlyph")));
            this.bbNewProduct.Name = "bbNewProduct";
            this.bbNewProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbNewProduct_ItemClick);
            // 
            // bbExtProduct
            // 
            this.bbExtProduct.Caption = "Add Existing";
            this.bbExtProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("bbExtProduct.Glyph")));
            this.bbExtProduct.Id = 4;
            this.bbExtProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbExtProduct.LargeGlyph")));
            this.bbExtProduct.Name = "bbExtProduct";
            this.bbExtProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbExtProduct_ItemClick);
            // 
            // bbSellProduct
            // 
            this.bbSellProduct.Caption = "&Sell";
            this.bbSellProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("bbSellProduct.Glyph")));
            this.bbSellProduct.Id = 6;
            this.bbSellProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbSellProduct.LargeGlyph")));
            this.bbSellProduct.Name = "bbSellProduct";
            this.bbSellProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbSellProduct_ItemClick);
            // 
            // bbPurchaseProduct
            // 
            this.bbPurchaseProduct.Caption = "Purchase";
            this.bbPurchaseProduct.Glyph = ((System.Drawing.Image)(resources.GetObject("bbPurchaseProduct.Glyph")));
            this.bbPurchaseProduct.Id = 7;
            this.bbPurchaseProduct.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbPurchaseProduct.LargeGlyph")));
            this.bbPurchaseProduct.Name = "bbPurchaseProduct";
            this.bbPurchaseProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbPurchaseProduct_ItemClick);
            // 
            // bCreditPayment
            // 
            this.bCreditPayment.Caption = "Credit Payment";
            this.bCreditPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("bCreditPayment.Glyph")));
            this.bCreditPayment.Id = 8;
            this.bCreditPayment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bCreditPayment.LargeGlyph")));
            this.bCreditPayment.Name = "bCreditPayment";
            this.bCreditPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bCreditPayment_ItemClick);
            // 
            // bDebitPayment
            // 
            this.bDebitPayment.Caption = "Debit Payment";
            this.bDebitPayment.Glyph = ((System.Drawing.Image)(resources.GetObject("bDebitPayment.Glyph")));
            this.bDebitPayment.Id = 9;
            this.bDebitPayment.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDebitPayment.LargeGlyph")));
            this.bDebitPayment.Name = "bDebitPayment";
            this.bDebitPayment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDebitPayment_ItemClick);
            // 
            // bClose
            // 
            this.bClose.Caption = "Close";
            this.bClose.Glyph = ((System.Drawing.Image)(resources.GetObject("bClose.Glyph")));
            this.bClose.Id = 10;
            this.bClose.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bClose.LargeGlyph")));
            this.bClose.Name = "bClose";
            this.bClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bClose_ItemClick);
            // 
            // bCAT
            // 
            this.bCAT.Caption = "Category";
            this.bCAT.Glyph = ((System.Drawing.Image)(resources.GetObject("bCAT.Glyph")));
            this.bCAT.Id = 11;
            this.bCAT.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bCAT.LargeGlyph")));
            this.bCAT.Name = "bCAT";
            this.bCAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bCAT_ItemClick);
            // 
            // btnLogOff
            // 
            this.btnLogOff.Caption = "Log Out";
            this.btnLogOff.Id = 12;
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOff_ItemClick);
            // 
            // bSettings
            // 
            this.bSettings.Caption = "Settings";
            this.bSettings.Glyph = ((System.Drawing.Image)(resources.GetObject("bSettings.Glyph")));
            this.bSettings.Id = 13;
            this.bSettings.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bSettings.LargeGlyph")));
            this.bSettings.Name = "bSettings";
            this.bSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bSettings_ItemClick);
            // 
            // bUsers
            // 
            this.bUsers.Caption = "Accounts";
            this.bUsers.Glyph = ((System.Drawing.Image)(resources.GetObject("bUsers.Glyph")));
            this.bUsers.Id = 14;
            this.bUsers.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bUsers.LargeGlyph")));
            this.bUsers.Name = "bUsers";
            this.bUsers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.bUsers.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bUsers_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Database";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 15;
            this.barSubItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.LargeGlyph")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbAckup),
            new DevExpress.XtraBars.LinkPersistInfo(this.bRestore)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bbAckup
            // 
            this.bbAckup.Caption = "Backup";
            this.bbAckup.Id = 16;
            this.bbAckup.Name = "bbAckup";
            this.bbAckup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAckup_ItemClick);
            // 
            // bRestore
            // 
            this.bRestore.Caption = "Restore";
            this.bRestore.Id = 17;
            this.bRestore.Name = "bRestore";
            this.bRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bRestore_ItemClick);
            // 
            // bQuickSell
            // 
            this.bQuickSell.Caption = "Quick Sell";
            this.bQuickSell.Glyph = ((System.Drawing.Image)(resources.GetObject("bQuickSell.Glyph")));
            this.bQuickSell.Id = 18;
            this.bQuickSell.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bQuickSell.LargeGlyph")));
            this.bQuickSell.Name = "bQuickSell";
            this.bQuickSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bQuickSell_ItemClick);
            // 
            // bRInvoice
            // 
            this.bRInvoice.Caption = "Revise Invoice";
            this.bRInvoice.Glyph = ((System.Drawing.Image)(resources.GetObject("bRInvoice.Glyph")));
            this.bRInvoice.Id = 19;
            this.bRInvoice.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bRInvoice.LargeGlyph")));
            this.bRInvoice.Name = "bRInvoice";
            this.bRInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bRInvoice_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSales,
            this.rpgProduct,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Main";
            // 
            // rpgSales
            // 
            this.rpgSales.ItemLinks.Add(this.bQuickSell);
            this.rpgSales.ItemLinks.Add(this.bbSellProduct, true);
            this.rpgSales.ItemLinks.Add(this.bbPurchaseProduct);
            this.rpgSales.ItemLinks.Add(this.bCreditPayment, true);
            this.rpgSales.ItemLinks.Add(this.bDebitPayment);
            this.rpgSales.ItemLinks.Add(this.bRInvoice, true);
            this.rpgSales.ItemLinks.Add(this.bServicing);
            this.rpgSales.Name = "rpgSales";
            this.rpgSales.ShowCaptionButton = false;
            this.rpgSales.Text = "Transactions";
            // 
            // rpgProduct
            // 
            this.rpgProduct.ItemLinks.Add(this.bbNewProduct);
            this.rpgProduct.ItemLinks.Add(this.bbExtProduct);
            this.rpgProduct.ItemLinks.Add(this.bCAT);
            this.rpgProduct.Name = "rpgProduct";
            this.rpgProduct.ShowCaptionButton = false;
            this.rpgProduct.Text = "Products";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Skins";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bSettings);
            this.ribbonPageGroup1.ItemLinks.Add(this.bUsers);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Settings";
            // 
            // splt
            // 
            this.splt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splt.Location = new System.Drawing.Point(0, 143);
            this.splt.Name = "splt";
            this.splt.Panel1.Controls.Add(this.navBarControl1);
            this.splt.Panel1.Text = "Panel1";
            this.splt.Panel2.Text = "Panel2";
            this.splt.Size = new System.Drawing.Size(1049, 553);
            this.splt.SplitterPosition = 234;
            this.splt.TabIndex = 1;
            this.splt.Text = "splitContainerControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiViewProducts,
            this.nbiViewCustomer,
            this.nbiViewReports,
            this.nbiViewSuppliers});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 234;
            this.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControl1.OptionsNavPane.ShowOverflowButton = false;
            this.navBarControl1.OptionsNavPane.ShowOverflowPanel = false;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(234, 553);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Navigation";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiViewProducts),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiViewSuppliers),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiViewCustomer),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiViewReports)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // nbiViewProducts
            // 
            this.nbiViewProducts.Caption = "Products";
            this.nbiViewProducts.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiViewProducts.LargeImage")));
            this.nbiViewProducts.Name = "nbiViewProducts";
            this.nbiViewProducts.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiViewProducts.SmallImage")));
            this.nbiViewProducts.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiViewProducts_LinkClicked);
            // 
            // nbiViewSuppliers
            // 
            this.nbiViewSuppliers.Caption = "Suppliers";
            this.nbiViewSuppliers.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiViewSuppliers.LargeImage")));
            this.nbiViewSuppliers.Name = "nbiViewSuppliers";
            this.nbiViewSuppliers.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiViewSuppliers.SmallImage")));
            this.nbiViewSuppliers.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiViewSuppliers_LinkClicked);
            // 
            // nbiViewCustomer
            // 
            this.nbiViewCustomer.Caption = "Customers";
            this.nbiViewCustomer.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiViewCustomer.LargeImage")));
            this.nbiViewCustomer.Name = "nbiViewCustomer";
            this.nbiViewCustomer.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiViewCustomer.SmallImage")));
            this.nbiViewCustomer.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiViewCustomer_LinkClicked);
            // 
            // nbiViewReports
            // 
            this.nbiViewReports.Caption = "Reports";
            this.nbiViewReports.LargeImage = ((System.Drawing.Image)(resources.GetObject("nbiViewReports.LargeImage")));
            this.nbiViewReports.Name = "nbiViewReports";
            this.nbiViewReports.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiViewReports.SmallImage")));
            this.nbiViewReports.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiViewReports_LinkClicked);
            // 
            // bServicing
            // 
            this.bServicing.Caption = "Servicing";
            this.bServicing.Glyph = ((System.Drawing.Image)(resources.GetObject("bServicing.Glyph")));
            this.bServicing.Id = 20;
            this.bServicing.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bServicing.LargeGlyph")));
            this.bServicing.Name = "bServicing";
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 696);
            this.Controls.Add(this.splt);
            this.Controls.Add(this.MainRibbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Ribbon = this.MainRibbon;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainRibbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splt)).EndInit();
            this.splt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl MainRibbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.SplitContainerControl splt;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarButtonItem bbNewProduct;
        private DevExpress.XtraBars.BarButtonItem bbExtProduct;
        private DevExpress.XtraBars.BarButtonItem bbSellProduct;
        private DevExpress.XtraBars.BarButtonItem bbPurchaseProduct;
        private DevExpress.XtraNavBar.NavBarItem nbiViewProducts;
        private DevExpress.XtraNavBar.NavBarItem nbiViewCustomer;
        private DevExpress.XtraBars.BarButtonItem bCreditPayment;
        private DevExpress.XtraBars.BarButtonItem bDebitPayment;
        private DevExpress.XtraNavBar.NavBarItem nbiViewReports;
        private DevExpress.XtraBars.BarButtonItem bClose;
        private DevExpress.LookAndFeel.DefaultLookAndFeel dlaf;
        private DevExpress.XtraBars.BarButtonItem bCAT;
        private DevExpress.XtraNavBar.NavBarItem nbiViewSuppliers;
        private DevExpress.XtraBars.BarButtonItem btnLogOff;
        private DevExpress.XtraBars.BarButtonItem bSettings;
        private DevExpress.XtraBars.BarButtonItem bUsers;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbAckup;
        private DevExpress.XtraBars.BarButtonItem bRestore;
        private DevExpress.XtraBars.BarButtonItem bQuickSell;
        private DevExpress.XtraBars.BarButtonItem bRInvoice;
        private DevExpress.XtraBars.BarButtonItem bServicing;
    }
}

