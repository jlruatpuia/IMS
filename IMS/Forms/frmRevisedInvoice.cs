using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using IMS.Codes;
using System;
using System.Data;
using System.Windows.Forms;

namespace IMS.Forms
{
    public partial class frmRevisedInvoice : XtraForm
    {
        wrSales.Server2Client sc = new wrSales.Server2Client();
        wrSales.wsSales sls = new wrSales.wsSales();
        wrSettings.wrSettings stg = new wrSettings.wrSettings();
        public frmRevisedInvoice()
        {
            InitializeComponent();

            InitInvoiceNo();
            InitCustomers();
            InitProducts();
        }

        void InitInvoiceNo()
        {
            sc = new wrSales.Server2Client();
            sls = new wrSales.wsSales();
            sc = sls.GetSales();

            lueINV.Properties.DataSource = sc.dataTable;
            lueINV.Properties.DisplayMember = "InvoiceNo";
            lueINV.Properties.ValueMember = "InvoiceNo";
        }

        void InitCustomers()
        {
            wrCustomers.Server2Client scc = new wrCustomers.Server2Client();
            wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            scc = cus.getCustomers();

            lueCUS.Properties.DataSource = scc.dataTable;
            lueCUS.Properties.DisplayMember = "CustomerName";
            lueCUS.Properties.ValueMember = "ID";
        }

        void InitProducts()
        {
            wrProducts.Server2Client spc = new wrProducts.Server2Client();
            wrProducts.wsProducts prd = new wrProducts.wsProducts();
            spc = prd.GetProducts();

            repPNM.DataSource = spc.dataTable;
            repPNM.DisplayMember = "ProductName";
            repPNM.ValueMember = "ID";
        }

        private void lueINV_EditValueChanged(object sender, EventArgs e)
        {
            if (lueINV.EditValue == null) return;

            string INV = lueINV.EditValue.ToString();
            wrSales.Customer c = new wrSales.Customer();
            sls = new wrSales.wsSales();
            c = sls.GetCustomerByInvoice(INV);

            lueCUS.EditValue = c.CustomerID;

            sc = new wrSales.Server2Client();
            sls = new wrSales.wsSales();

            sc = sls.getSalesByInvoice(INV);
            dtpSDT.DateTime = DateTime.Parse(sc.dataTable.Rows[0].ItemArray[0].ToString());

            grd.DataSource = sc.dataTable;

            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            txtAMT.Text = TotalAmount.ToString();
            txtPAM.Text = TotalAmount.ToString();
        }

        private void lueINV_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                lueINV.EditValue = null;
                lueCUS.EditValue = null;
            }
        }

        public double BuyingValue { get; set; }

        private void repPNM_EditValueChanged(object sender, EventArgs e)
        {
            //int PID = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
            //wrProducts.Server2Client spc = new wrProducts.Server2Client();
            //wrProducts.wsProducts prd = new wrProducts.wsProducts();
            //wrProducts.Product p = new wrProducts.Product();
            //p = prd.GetProductByID(PID);
            //grv.SetFocusedRowCellValue(colSVL, p.SellingValue);
        }

        private void grv_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int qty = 0;
            double prc = 0;
            switch (e.Column.Caption)
            {
                case "Particulars":
                    int PID = Convert.ToInt32(grv.GetFocusedRowCellValue(colPID));
                    wrProducts.Server2Client spc = new wrProducts.Server2Client();
                    wrProducts.wsProducts prd = new wrProducts.wsProducts();
                    wrProducts.Product p = new wrProducts.Product();
                    p = prd.GetProductByID(PID);
                    grv.SetFocusedRowCellValue(colBVL, p.BuyingValue);
                    grv.SetFocusedRowCellValue(colSVL, p.SellingValue);
                    grv.UpdateCurrentRow();
                    break;
                case "Quantity":
                    qty = Convert.ToInt32(grv.GetFocusedRowCellValue(colQTY));
                    prc = Convert.ToDouble(grv.GetFocusedRowCellValue(colSVL));
                    grv.SetFocusedRowCellValue(colAMT, qty * prc);
                    grv.UpdateCurrentRow();
                    break;
                case "Rate":
                    qty = Convert.ToInt32(grv.GetFocusedRowCellValue(colQTY));
                    prc = Convert.ToDouble(grv.GetFocusedRowCellValue(colSVL));
                    grv.SetFocusedRowCellValue(colAMT, qty * prc);
                    grv.UpdateCurrentRow();
                    break;
            }
            
        }

        private void grv_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            txtAMT.Text = TotalAmount.ToString();
            txtPAM.Text = TotalAmount.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sc = new wrSales.Server2Client();
            sls = new wrSales.wsSales();
            wrSales.Sale ss = new wrSales.Sale();
            wrSales.SaleDetail sd = new wrSales.SaleDetail();

            sc = sls.DeleteSalesByInvoice(lueINV.EditValue.ToString());

            if(sc.Message == null)
            {
                ss.InvoiceNo = lueINV.EditValue.ToString();
                ss.SaleDate = dtpSDT.DateTime;
                ss.CustomerID = Convert.ToInt32(lueCUS.EditValue);
                ss.Amount = Convert.ToDouble(txtAMT.EditValue);
                ss.Discount = Convert.ToDouble(txtDSC.EditValue);
                ss.Payment = Convert.ToDouble(txtPAM.EditValue);
                ss.Balance = Convert.ToDouble(txtBAL.EditValue);

                sc = sls.AddSale(ss);
                if (sc.Message != null)
                {
                    XtraMessageBox.Show(sc.Message);
                    return;
                }

                for(int i  = 0; i <= grv.RowCount - 1; i++)
                {
                    sd.InvoiceNo = lueINV.EditValue.ToString(); ;
                    sd.ProductID = Convert.ToInt32(grv.GetRowCellValue(i, colPID));
                    sd.Quantity = Convert.ToInt32(grv.GetRowCellValue(i, colQTY));
                    sd.BuyingValue = Convert.ToDouble(grv.GetRowCellValue(i, colBVL));
                    sd.SellingValue = Convert.ToDouble(grv.GetRowCellValue(i, colSVL));
                    sd.Amount = sd.Quantity * sd.SellingValue;
                }
            }
        }
    }
}