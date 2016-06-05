using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//using IMS.Forms;
using IMS.Codes;
using DevExpress.XtraReports.UI;
using IMS.Reports;
using IMS.Forms;

namespace IMS.Controls
{
    public partial class ucReports : XtraUserControl
    {
        
        public ucReports()
        {
            InitializeComponent();

            if (dv.Document == null)
                rpPreview.Visible = false;
            chkALL.Checked = true;
            checkEdit1.Checked = true;
            wrCustomers.Server2Client csc = new wrCustomers.Server2Client();
            wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            csc = cus.getCustomers();
            lueCUS.Properties.DataSource = csc.dataTable;
            lueCUS.Properties.DisplayMember = "CustomerName";
            lueCUS.Properties.ValueMember = "ID";

            wrSuppliers.Server2Client ssc = new wrSuppliers.Server2Client();
            wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
            ssc = sup.getSuppliers();
            lueSUP.Properties.DataSource = ssc.dataTable;
            lueSUP.Properties.DisplayMember = "SupplierName";
            lueSUP.Properties.ValueMember = "ID";
        }

        private void bProductList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void bCustomersList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrCustomers.Server2Client sc = new wrCustomers.Server2Client();
            wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomersFull();

            rptCustomers rpt = new rptCustomers() { DataSource = sc.dataTable };
            
            XRSummary tbal = new XRSummary();

            rpt.lbCNM.DataBindings.Add("Text", null, "CustomerName");
            rpt.lbADR.DataBindings.Add("Text", null, "Address");
            rpt.lbPHN.DataBindings.Add("Text", null, "Phone");
            rpt.lbEML.DataBindings.Add("Text", null, "Email");
            rpt.lbBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");
            rpt.lbTBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");

            tbal.FormatString = "{0:C2}";
            tbal.Running = SummaryRunning.Report;
            rpt.lbTBAL.Summary = tbal;

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bSuppliersList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();
            wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSuppliersFull();

            rptSuppliers rpt = new rptSuppliers() { DataSource = sc.dataTable };

            XRSummary tbal = new XRSummary();

            rpt.lbCNM.DataBindings.Add("Text", null, "SupplierName");
            rpt.lbADR.DataBindings.Add("Text", null, "Address");
            rpt.lbPHN.DataBindings.Add("Text", null, "Phone");
            rpt.lbEML.DataBindings.Add("Text", null, "Email");
            rpt.lbBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");
            rpt.lbTBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");

            tbal.FormatString = "{0:C2}";
            tbal.Running = SummaryRunning.Report;
            rpt.lbTBAL.Summary = tbal;

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bSoldProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelect frm = new frmSelect();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                wrSales.Server2Client sc;
                wrSales.wsSales s;
                
                rptSoldProducts rpt = new rptSoldProducts();

                if (frm.RetVal == 0)
                {
                    sc = new wrSales.Server2Client();
                    s = new wrSales.wsSales();
                    sc = s.getSoldProductsByDate(frm.DateOn);
                    rpt.DataSource = sc.dataTable;

                    rpt.lbTTL.Text = "Products sold On " + frm.DateOn.ToShortDateString();
                    XRSummary stt = new XRSummary();
                    XRSummary gtt = new XRSummary();

                    GroupField grp = new GroupField("SaleDate");
                    rpt.GroupHeader1.GroupFields.Add(grp);

                    rpt.lbSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");
                    rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
                    rpt.lbPID.DataBindings.Add("Text", null, "BarCode");
                    rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
                    rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
                    rpt.lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
                    rpt.lbSTT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
                    rpt.lbGTT.DataBindings.Add("Text", null, "Amount", "{0:C2}");

                    stt.FormatString = "{0:C2}";
                    gtt.FormatString = "{0:C2}";

                    stt.Running = SummaryRunning.Group;
                    gtt.Running = SummaryRunning.Report;

                    rpt.lbSTT.Summary = stt;
                    rpt.lbGTT.Summary = gtt;

                    dv.PrintingSystem = rpt.PrintingSystem;
                    rpt.CreateDocument(true);
                }
                else if(frm.RetVal == 1)
                {
                    sc = new wrSales.Server2Client();
                    s = new wrSales.wsSales();
                    sc = s.getSoldProductsByDates(frm.DateFrom, frm.DateTo);
                    rpt.DataSource = sc.dataTable;

                    rpt.lbTTL.Text = "Products sold Between " + frm.DateFrom.ToShortDateString() + " and " + frm.DateTo.ToShortDateString();
                    XRSummary stt = new XRSummary();
                    XRSummary gtt = new XRSummary();

                    GroupField grp = new GroupField("SaleDate");
                    rpt.GroupHeader1.GroupFields.Add(grp);

                    rpt.lbSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");
                    rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
                    rpt.lbPID.DataBindings.Add("Text", null, "BarCode");
                    rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
                    rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
                    rpt.lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
                    rpt.lbSTT.DataBindings.Add("Text", null, "Amount", "{0:C2}");
                    rpt.lbGTT.DataBindings.Add("Text", null, "Amount", "{0:C2}");

                    stt.FormatString = "{0:C2}";
                    gtt.FormatString = "{0:C2}";

                    stt.Running = SummaryRunning.Group;
                    gtt.Running = SummaryRunning.Report;

                    rpt.lbSTT.Summary = stt;
                    rpt.lbGTT.Summary = gtt;

                    dv.PrintingSystem = rpt.PrintingSystem;
                    rpt.CreateDocument(true);
                }
                else
                {
                    sc = new wrSales.Server2Client();
                    s = new wrSales.wsSales();
                    //sc = s.getSoldByInvoice(frm.InvoiceNo);
                    sc = s.getSoldProductsByInvoiceNo(frm.InvoiceNo);
                    XRSummary total = new XRSummary();

                    rptCashMemo rpc = new rptCashMemo() { DataSource = sc.dataTable };
                    rpc.lblCNM.DataBindings.Add("Text", null, "CustomerName");
                    rpc.lblADR.DataBindings.Add("Text", null, "Address");
                    rpc.lblPHN.DataBindings.Add("Text", null, "Phone");

                    rpc.lblINV.DataBindings.Add("Text", null, "InvoiceNo");
                    rpc.lblSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");

                    rpc.lblPNM.DataBindings.Add("Text", null, "ProductName");
                    rpc.lbSNO.DataBindings.Add("Text", null, "BarCode");
                    rpc.lblQTY.DataBindings.Add("Text", null, "Quantity");
                    rpc.lblPRC.DataBindings.Add("Text", null, "SellingValue", "{0:c}");
                    rpc.lblDSC.DataBindings.Add("Text", null, "Discount", "{0:C2}");
                    rpc.lblAMT.DataBindings.Add("Text", null, "Amount", "{0:c}");
                    rpc.lblTTL.DataBindings.Add("Text", null, "Amount", "{0:c}");

                    total.FormatString = "{0:C2}";
                    total.Running = SummaryRunning.Report;
                    rpc.lblTTL.Summary = total;
                    //rpt.lblTTL.Text = s.Amount.ToString("c2");
                    double dsc = 0;
                    int amt = 0;
                    for (int i = 0; i <= sc.dataTable.Rows.Count - 1; i++)
                    {
                        dsc += Convert.ToDouble(sc.dataTable.Rows[i].ItemArray[10]);
                        amt += Convert.ToInt32(sc.dataTable.Rows[i].ItemArray[9]);
                    }
                    if(dsc <= 0)
                    {
                        rpc.xrLabel8.Visible = false;
                        rpc.lblDSC.Visible = false;
                    }
                    rpc.lblAMW.Text = "Rupees " + Utils.NumbersToWords(Convert.ToInt32(amt)) + " only";
                    dv.PrintingSystem = rpc.PrintingSystem;
                    rpc.CreateDocument(true);
                }

                
            }
        }
        
        private void bPurchasedProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmSelect frm = new frmSelect();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                wrPurchases.Server2Client sc;
                wrPurchases.wsPurchases p = new wrPurchases.wsPurchases();
                rptPurchasedProducts rpt = new rptPurchasedProducts();
                if (frm.RetVal == 0)
                {
                    sc = new wrPurchases.Server2Client();
                    p = new wrPurchases.wsPurchases();
                    sc = p.getPurchasedProductsByDate(frm.DateOn);
                    rpt.DataSource = sc.dataTable;

                    rpt.lbTTL.Text = "Products purchased On " + frm.DateOn.ToShortDateString();
                }
                else if (frm.RetVal == 1)
                {
                    sc = new wrPurchases.Server2Client();
                    p = new wrPurchases.wsPurchases();
                    sc = p.getPurchasedProductsByDates(frm.DateFrom, frm.DateTo);
                    rpt.DataSource = sc.dataTable;

                    rpt.lbTTL.Text = "Products purchased Between " + frm.DateFrom.ToShortDateString() + " and " + frm.DateTo.ToShortDateString();
                }
                else
                {
                    sc = new wrPurchases.Server2Client();
                    p = new wrPurchases.wsPurchases();
                    sc = p.getPurchasedProductsByInvoice(frm.InvoiceNo);
                    rpt.DataSource = sc.dataTable;

                    rpt.lbTTL.Text = "Purchase detail of Invoice No " + frm.InvoiceNo;
                }

                XRSummary stt = new XRSummary();
                XRSummary gtt = new XRSummary();

                GroupField grp = new GroupField("PurchaseDate");
                rpt.GroupHeader1.GroupFields.Add(grp);

                rpt.lbPDT.DataBindings.Add("Text", null, "PurchaseDate", "{0:dd-MM-yyyy}");
                rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
                rpt.lbBCD.DataBindings.Add("Text", null, "BarCode");
                rpt.lbSVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
                rpt.lbQTY.DataBindings.Add("Text", null, "SumOfQuantity");
                rpt.lbAMT.DataBindings.Add("Text", null, "SumOfAmount", "{0:C2}");
                rpt.lbSTT.DataBindings.Add("Text", null, "SumOfAmount", "{0:C2}");
                rpt.lbGTT.DataBindings.Add("Text", null, "SumOfAmount", "{0:C2}");

                stt.FormatString = "{0:C2}";
                gtt.FormatString = "{0:C2}";

                stt.Running = SummaryRunning.Group;
                gtt.Running = SummaryRunning.Report;

                rpt.lbSTT.Summary = stt;
                rpt.lbGTT.Summary = gtt;

                dv.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument(true);
            }
            
        }
        private void bProfitLoss_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelect frm = new frmSelect(false);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                wrSales.Server2Client sc = new wrSales.Server2Client();
                wrSales.wsSales s = new wrSales.wsSales();
                string dt = null;
                if (frm.RetVal == 0)
                {
                    sc = s.getProfitLossByDate(frm.DateOn);
                    dt = "Date " + frm.DateOn.ToShortDateString();
                }
                else
                {
                    sc = s.getProfitLossByDates(frm.DateFrom, frm.DateTo);
                    dt = "Between " + frm.DateFrom.ToShortDateString() + " and " + frm.DateTo.ToShortDateString();
                }

                rptPL rpt = new rptPL() { DataSource = sc.dataTable };

                XRSummary gsv = new XRSummary();
                XRSummary gbv = new XRSummary();
                XRSummary gpf = new XRSummary();

                rpt.lbDT.Text = dt;
                rpt.lbSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");
                rpt.lbSVL.DataBindings.Add("Text", null, "TotalSellingValue", "{0:C2}");
                rpt.lbBVL.DataBindings.Add("Text", null, "TotalBuyingValue", "{0:C2}");
                rpt.lbPFT.DataBindings.Add("Text", null, "Profit", "{0:C2}");
                rpt.lbGSV.DataBindings.Add("Text", null, "TotalSellingValue", "{0:C2}");
                rpt.lbGBV.DataBindings.Add("Text", null, "TotalBuyingValue", "{0:C2}");
                rpt.lbGPF.DataBindings.Add("Text", null, "Profit", "{0:C2}");

                gsv.FormatString = "{0:C2}";
                gbv.FormatString = "{0:C2}";
                gpf.FormatString = "{0:C2}";


                gsv.Running = SummaryRunning.Report;
                gbv.Running = SummaryRunning.Report;
                gpf.Running = SummaryRunning.Report;

                rpt.lbGSV.Summary = gsv;
                rpt.lbGBV.Summary = gbv;
                rpt.lbGPF.Summary = gpf;

                dv.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument(true);
            }
        }

        private void bCreditPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelectCustomer frm = new frmSelectCustomer();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                wrCustomers.Server2Client sc = new wrCustomers.Server2Client();
                wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
                wrCustomers.Customer c = new wrCustomers.Customer();
                
                double bal = 0;
                c = cus.getCustomer(frm.CustomerID);
                rptCreditPayment rpt = new rptCreditPayment();

                XRSummary tdr = new XRSummary();
                XRSummary tcr = new XRSummary();

                rpt.lbCNM.Text = c.CustomerName;
                rpt.lbADR.Text = c.Address;
                rpt.lbPHN.Text = c.Phone;
                rpt.lbEML.Text = c.Email;

                if (!frm.DateSelected)
                {
                    sc = cus.getCustomerBalanceByID(frm.CustomerID);
                    bal = sc.Value;
                    sc = cus.getTransactionDetails(frm.CustomerID);
                    rpt.DataSource = sc.dataTable;
                }
                else
                {
                    sc = cus.getCustomerBalanceByDates(frm.CustomerID, frm.DateFrom, frm.DateTo);
                    bal = sc.Value;
                    //DataTable dt = cus.AccountStatement(frm.CustomerID, frm.DateFrom, frm.DateTo).dataTable;
                    sc = cus.AccountStatement(frm.CustomerID, frm.DateFrom, frm.DateTo);
                    rpt.DataSource = sc.dataTable;
                }
                rpt.lbTDT.DataBindings.Add("Text", null, "TransDate", "{0:dd-MM-yyyy}");
                rpt.lbRMK.DataBindings.Add("Text", null, "Description");
                rpt.lbTDR.DataBindings.Add("Text", null, "Debit", "{0:c}");
                rpt.lbTCR.DataBindings.Add("Text", null, "Credit", "{0:c}");
                rpt.lbBAL.DataBindings.Add("Text", null, "Balance", "{0:c}");
                rpt.lblTDR.DataBindings.Add("Text", null, "Debit", "{0:C2}");
                rpt.lblTCR.DataBindings.Add("Text", null, "Credit", "{0:C2}");
                rpt.lblTBL.Text = bal.ToString("c2");
                tdr.FormatString = "{0:C2}";
                tcr.FormatString = "{0:C2}";
                tdr.Running = SummaryRunning.Report;
                tcr.Running = SummaryRunning.Report;
                rpt.lblTCR.Summary = tdr;
                rpt.lblTDR.Summary = tcr;
                
                dv.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument(true);
            }
        }
        private void bDebitPayment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            frmSelectSupplier frm = new frmSelectSupplier();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();
                wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
                wrSuppliers.Supplier s = new wrSuppliers.Supplier(); 
                double bal = 0;
                s = sup.getSupplier(frm.SupplierID);
                rptDebitPayment rpt = new rptDebitPayment();

                XRSummary tdr = new XRSummary();
                XRSummary tcr = new XRSummary();

                rpt.lbSNM.Text = s.SupplierName;
                rpt.lbADR.Text = s.Address;
                rpt.lbPHN.Text = s.Phone;
                rpt.lbEML.Text = s.Email;

                if (!frm.DateSelected)
                {
                    sc = sup.getSupplierBalanceByID(frm.SupplierID);
                    bal = sc.Value;
                    sc = sup.getTransactionDetails(frm.SupplierID);
                    rpt.DataSource = sc.dataTable;
                }
                else
                {
                    sc = sup.getSupplierBalanceByDates(frm.SupplierID, frm.DateFrom, frm.DateTo);
                    bal = sc.Value;
                    sc = sup.AccountStatement(frm.SupplierID, frm.DateFrom, frm.DateTo);
                    rpt.DataSource = sc.dataTable;
                }
                rpt.lbTDT.DataBindings.Add("Text", null, "TransDate", "{0:dd-MM-yyyy}");
                rpt.lbRMK.DataBindings.Add("Text", null, "Description");
                rpt.lbTDR.DataBindings.Add("Text", null, "Debit", "{0:c}");
                rpt.lbTCR.DataBindings.Add("Text", null, "Credit", "{0:c}");
                rpt.lbBAL.DataBindings.Add("Text", null, "Balance", "{0:c}");
                rpt.lblTDR.DataBindings.Add("Text", null, "Debit", "{0:C2}");
                rpt.lblTCR.DataBindings.Add("Text", null, "Credit", "{0:C2}");
                rpt.lblTBL.Text = bal.ToString("c2");
                tdr.FormatString = "{0:C2}";
                tcr.FormatString = "{0:C2}";
                tdr.Running = SummaryRunning.Report;
                tcr.Running = SummaryRunning.Report;
                rpt.lblTCR.Summary = tdr;
                rpt.lblTDR.Summary = tcr;

                dv.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument(true);
            }
        }
        private void dv_DocumentChanged(object sender, EventArgs e)
        {
            ribbonStatusBar1.Dispose();
            if(dv.Document != null)
            {
                rpPreview.Visible = true;
                ribbonControl1.SelectedPage = rpPreview;
            }
        }

        private void bPCATS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrProducts.Server2Client sc = new wrProducts.Server2Client();
            wrProducts.wsProducts pd = new wrProducts.wsProducts();
            sc = pd.ProductListByCategorySimplified();

            rptProductByCat rpt = new rptProductByCat() { DataSource = sc.dataTable };

            GroupField grp = new GroupField("CategoryName");

            rpt.groupHeader.GroupFields.Add(grp);

            rpt.lbCAT.DataBindings.Add("Text", null, "CategoryName");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "SumOfQuantity");
            rpt.lbBCD.Text = "";
            //rpt.lbSBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            //rpt.lbSSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            //rpt.lbSQTY.DataBindings.Add("Text", null, "Quantity");
            //rpt.lbGBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            //rpt.lbGSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            //rpt.lbGQTY.DataBindings.Add("Text", null, "Quantity");

            //sbvl.FormatString = "{0:C2}";
            //ssvl.FormatString = "{0:C2}";
            //gbvl.FormatString = "{0:C2}";
            //gsvl.FormatString = "{0:C2}";

            //sbvl.Running = SummaryRunning.Group;
            //ssvl.Running = SummaryRunning.Group;
            //sqty.Running = SummaryRunning.Group;

            //gbvl.Running = SummaryRunning.Report;
            //gsvl.Running = SummaryRunning.Report;
            //gqty.Running = SummaryRunning.Report;

            //rpt.lbSBVL.Summary = sbvl;
            //rpt.lbSSVL.Summary = ssvl;
            //rpt.lbSQTY.Summary = sqty;

            //rpt.lbGBVL.Summary = gbvl;
            //rpt.lbGSVL.Summary = gsvl;
            //rpt.lbGQTY.Summary = gqty;

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bPCATX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrProducts.Server2Client sc = new wrProducts.Server2Client();
            wrProducts.wsProducts pd = new wrProducts.wsProducts();
            sc = pd.ProductListByCategoryExtended();

            rptProductByCat rpt = new rptProductByCat() { DataSource = sc.dataTable };

            GroupField grp = new GroupField("CategoryName");

            rpt.groupHeader.GroupFields.Add(grp);

            rpt.lbCAT.DataBindings.Add("Text", null, "CategoryName");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
            rpt.lbBCD.DataBindings.Add("Text", null, "BarCode");
            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bPSUPS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrProducts.Server2Client sc = new wrProducts.Server2Client();
            wrProducts.wsProducts pd = new wrProducts.wsProducts();
            sc = pd.ProductListBySupplierSimple();

            rptProductBySup rpt = new rptProductBySup() { DataSource = sc.dataTable };

            GroupField grp = new GroupField("SupplierName");

            rpt.groupHeader.GroupFields.Add(grp);

            rpt.lbSUP.DataBindings.Add("Text", null, "SupplierName");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "SumOfQuantity");
            rpt.lbBCD.Text = "";
            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bPSUPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            wrProducts.Server2Client sc = new wrProducts.Server2Client();
            wrProducts.wsProducts pd = new wrProducts.wsProducts();
            sc = pd.ProductListBySupplierExtended();

            rptProductBySup rpt = new rptProductBySup() { DataSource = sc.dataTable };

            GroupField grp = new GroupField("SupplierName");

            rpt.groupHeader.GroupFields.Add(grp);

            rpt.lbSUP.DataBindings.Add("Text", null, "SupplierName");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbBVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
            rpt.lbBCD.DataBindings.Add("Text", null, "BarCode");
            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);
        }

        private void bInvoiceNo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSelect frm = new frmSelect(false);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                wrSales.Server2Client sc = new wrSales.Server2Client();
                wrSales.wsSales s = new wrSales.wsSales();
                string dt = null;
                if (frm.RetVal == 0)
                {
                    sc = s.getProfitLossByDate(frm.DateOn);
                    dt = "Date " + frm.DateOn.ToShortDateString();
                }
                else
                {
                    sc = s.getProfitLossByDates(frm.DateFrom, frm.DateTo);
                    dt = "Between " + frm.DateFrom.ToShortDateString() + " and " + frm.DateTo.ToShortDateString();
                }

                rptPL rpt = new rptPL() { DataSource = sc.dataTable };

                XRSummary gsv = new XRSummary();
                XRSummary gbv = new XRSummary();
                XRSummary gpf = new XRSummary();

                rpt.lbDT.Text = dt;
                rpt.lbSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");
                rpt.lbSVL.DataBindings.Add("Text", null, "TotalSellingValue", "{0:C2}");
                rpt.lbBVL.DataBindings.Add("Text", null, "TotalBuyingValue", "{0:C2}");
                rpt.lbPFT.DataBindings.Add("Text", null, "Profit", "{0:C2}");
                rpt.lbGSV.DataBindings.Add("Text", null, "TotalSellingValue", "{0:C2}");
                rpt.lbGBV.DataBindings.Add("Text", null, "TotalBuyingValue", "{0:C2}");
                rpt.lbGPF.DataBindings.Add("Text", null, "Profit", "{0:C2}");

                gsv.FormatString = "{0:C2}";
                gbv.FormatString = "{0:C2}";
                gpf.FormatString = "{0:C2}";


                gsv.Running = SummaryRunning.Report;
                gbv.Running = SummaryRunning.Report;
                gpf.Running = SummaryRunning.Report;

                rpt.lbGSV.Summary = gsv;
                rpt.lbGBV.Summary = gbv;
                rpt.lbGPF.Summary = gpf;

                dv.PrintingSystem = rpt.PrintingSystem;
                rpt.CreateDocument(true);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(lueCUS.EditValue);

            wrSales.Server2Client sc = new wrSales.Server2Client();
            wrSales.wsSales s = new wrSales.wsSales();
            rptCustomerSales rpt = new rptCustomerSales();

            if (chkALL.Checked)
            {
                sc = s.SalesToCustomerByID(CID);
                rpt.DataSource = sc.dataTable;
                rpt.lbTTL.Text = "Product(s) sold to Customer";
            }
            else
            {
                sc = s.SalesToCustomerByDates(CID, dtpFR.DateTime, dtpTO.DateTime);
                rpt.DataSource = sc.dataTable;
                rpt.lbTTL.Text = "Product(s) sold to Customer between " + dtpFR.DateTime.ToShortDateString() + " and " + dtpTO.DateTime.ToShortDateString();
            }

            GroupField grp = new GroupField("SaleDate");
            rpt.GroupHeader1.GroupFields.Add(grp);

            wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            wrCustomers.Customer c = new wrCustomers.Customer();
            c = cus.getCustomer(CID);

            rpt.lbCNM.Text = c.CustomerName;
            rpt.lbADR.Text = c.Address;
            rpt.lbPHN.Text = c.Phone;
            rpt.lbSDT.DataBindings.Add("Text", null, "SaleDate", "{0:dd-MM-yyyy}");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbSNO.DataBindings.Add("Text", null, "BarCode");
            rpt.lbSVL.DataBindings.Add("Text", null, "SellingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "Quantity");
            rpt.lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);

            popCustomer.HidePopup();
        }

        private void chkALL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkALL.Checked)
            {
                dtpFR.Enabled = false;
                dtpTO.Enabled = false;
            }
            else
            {
                dtpFR.Enabled = true;
                dtpTO.Enabled = true;
                dtpFR.DateTime = DateTime.Now.Date;
                dtpTO.DateTime = DateTime.Now.Date;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                dtFrm.Enabled = false;
                dtTos.Enabled = false;
            }
            else
            {
                dtFrm.Enabled = true;
                dtTos.Enabled = true;
                dtFrm.DateTime = DateTime.Now.Date;
                dtTos.DateTime = DateTime.Now.Date;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(lueSUP.EditValue);

            wrPurchases.Server2Client sc = new wrPurchases.Server2Client();
            wrPurchases.wsPurchases pp = new wrPurchases.wsPurchases();
            rptSupplierPurchase rpt = new rptSupplierPurchase();

            if (checkEdit1.Checked)
            {
                sc = pp.PurchaseFromSupplierByID(CID);
                rpt.DataSource = sc.dataTable;
                rpt.lbTTL.Text = "Product(s) purchased from Supplier";
            }
            else
            {
                sc = pp.PurchaseFromSupplierByDates(CID, dtFrm.DateTime, dtTos.DateTime);
                rpt.DataSource = sc.dataTable;
                rpt.lbTTL.Text = "Product(s) purchased from Supplier between " + dtFrm.DateTime.ToShortDateString() + " and " + dtTos.DateTime.ToShortDateString();
            }

            GroupField grp = new GroupField("PurchaseDate");
            rpt.GroupHeader1.GroupFields.Add(grp);

            wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
            wrSuppliers.Supplier s = new wrSuppliers.Supplier();
            s = sup.getSupplier(CID);

            rpt.lbSNM.Text = s.SupplierName;
            rpt.lbADR.Text = s.Address;
            rpt.lbPHN.Text = s.Phone;
            rpt.lbSDT.DataBindings.Add("Text", null, "PurchaseDate", "{0:dd-MM-yyyy}");
            rpt.lbPNM.DataBindings.Add("Text", null, "ProductName");
            rpt.lbSNO.DataBindings.Add("Text", null, "BarCode");
            rpt.lbSVL.DataBindings.Add("Text", null, "BuyingValue", "{0:C2}");
            rpt.lbQTY.DataBindings.Add("Text", null, "TotalQuantity");
            rpt.lbAMT.DataBindings.Add("Text", null, "Amount", "{0:C2}");

            dv.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument(true);

            popSupplier.HidePopup();
        }
    }
}
