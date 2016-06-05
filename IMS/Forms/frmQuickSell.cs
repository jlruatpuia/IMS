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
using IMS.Codes;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace IMS.Forms
{
    public partial class frmQuickSell : XtraForm
    {
        DataTable dt = new DataTable();

        wrSales.Server2Client sc = new wrSales.Server2Client();
        wrSales.wsSales sls = new wrSales.wsSales();
        wrSettings.wrSettings stg = new wrSettings.wrSettings();

        public double CustomerBalance;
        //Customer cc = new Customer();
        public double BuyingValue { get; set; }
        public string BarCode { get; set; }
        public double TotalAmount { get; private set; }
        public frmQuickSell()
        {
            InitializeComponent();
            InitDataTable();

            lblInfo.Text = string.Empty;
            dtpSDT.DateTime = DateTime.Now.Date;

            InitInvoiceNo();
            InitCategories();
            InitProducts();
        }
        void InitInvoiceNo()
        {
            string SHN = Properties.Settings.Default.ShortName;
            txtINV.Text = stg.GetQuickInvoiceNo(DateTime.Now.Date, SHN);
        }
        void InitDataTable()
        {
            dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("BarCode", typeof(string));
            dt.Columns.Add("BuyingValue", typeof(double));
            dt.Columns.Add("SellingValue", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Amount", typeof(double));
        }
        void InitCategories()
        {
            wrProducts.Server2Client spc = new wrProducts.Server2Client();
            wrProducts.wsProducts prd = new wrProducts.wsProducts();
            spc = prd.GetCategories();
            lueCAT.Properties.DataSource = spc.dataTable;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";
        }

        void InitProducts()
        {
            wrProducts.Server2Client spc = new wrProducts.Server2Client();
            wrProducts.wsProducts prd = new wrProducts.wsProducts();
            spc = prd.GetProducts();
            luePNM.Properties.DataSource = spc.dataTable;
            luePNM.Properties.DisplayMember = "ProductName";
            luePNM.Properties.ValueMember = "ID";
        }

        void Clear()
        {
            //txtBVL.EditValue = 0;
            txtSVL.EditValue = 0;
            txtQTY.EditValue = 0;
        }

        void Reset()
        {
            //lueCNM.EditValue = null;
            //luePNM.EditValue = null;
            txtSVL.EditValue = 0;
            txtQTY.EditValue = 0;
            txtAMT.EditValue = 0;
            txtAMT.EditValue = 0;
            txtPAM.EditValue = 0;
            txtBAL.EditValue = 0;
        }

        private void txtBCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                wrProducts.Server2Client spc = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                wrProducts.Product p = new wrProducts.Product();
                
                p = prd.GetProductByBarCode(txtBCD.Text);
                if (p.Quantity < 1)
                {
                    lblInfo.Text = "Product not available!";
                    txtBCD.Text = "";
                    txtBCD.Focus();
                    return;
                }
                if (p.Message == null)
                {
                    DataRow r = dt.NewRow();
                    r["ProductID"] = p.ProductID;
                    r["ProductName"] = p.ProductName;
                    r["BarCode"] = p.BarCode;
                    r["BuyingValue"] = p.BuyingValue;
                    r["SellingValue"] = p.SellingValue;
                    r["Quantity"] = 1;
                    r["Amount"] = 1 * p.SellingValue;

                    dt.Rows.Add(r);
                    grd.DataSource = dt;
                    grd.Refresh();

                    double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
                    txtAMT.Text = TotalAmount.ToString();
                    txtPAM.Text = TotalAmount.ToString();

                    txtBCD.Text = "";
                    txtBCD.Focus();
                }
                else
                {
                    lblInfo.Text = p.Message;
                }

            }
        }

        private void lueCAT_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCAT.EditValue == null)
            {
                InitProducts();
            }
            else
            {
                int CID = Convert.ToInt32(lueCAT.EditValue);
                wrProducts.Server2Client spc = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                spc = prd.GetProductByCategory(CID);

                luePNM.Properties.DataSource = spc.dataTable;
                luePNM.Properties.DisplayMember = "ProductName";
                luePNM.Properties.ValueMember = "ID";
            }
        }

        private void luePNM_EditValueChanged(object sender, EventArgs e)
        {
            if (luePNM.EditValue == null)
            {
                Clear();
            }
            else
            {
                int PID = Convert.ToInt32(luePNM.EditValue);
                wrProducts.Server2Client spc = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                wrProducts.Product p = new wrProducts.Product();
                p = prd.GetProductByID(PID);
                BuyingValue = p.BuyingValue;
                txtSVL.EditValue = p.SellingValue;
                txtQTY.Properties.MaxValue = p.Quantity;
                BarCode = p.BarCode;
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQTY.Text) <= 0) return;
            DataRow r = dt.NewRow();
            r["ProductID"] = Convert.ToInt32(luePNM.EditValue);
            r["ProductName"] = luePNM.Text;
            r["BarCode"] = BarCode;
            r["BuyingValue"] = BuyingValue;
            r["SellingValue"] = Convert.ToDouble(txtSVL.EditValue);
            r["Quantity"] = Convert.ToInt32(txtQTY.EditValue);
            r["Amount"] = Convert.ToDouble(txtSVL.EditValue) * Convert.ToInt32(txtQTY.EditValue);

            dt.Rows.Add(r);
            grd.DataSource = dt;
            grd.Refresh();

            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            txtAMT.Text = TotalAmount.ToString();
            txtPAM.Text = TotalAmount.ToString();
        }

        private void grv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator)
            {
                string rowno = null;
                if (e.RowHandle == -1)
                    rowno = "";
                else
                    rowno = (e.RowHandle + 1).ToString();
                e.Info.DisplayText = rowno;
            }
        }

        private void txtDSC_EditValueChanged(object sender, EventArgs e)
        {
            double Amount = 0;
            double Discount = 0;

            if (txtAMT.EditValue != null || txtAMT.Text != "")
                Amount = Convert.ToDouble(txtAMT.EditValue);
            else
                Amount = 0;

            if (txtDSC.EditValue != null || txtDSC.Text != "")
                Discount = Convert.ToDouble(txtDSC.EditValue);
            else
                Discount = 0;
            txtPAM.Text = (Amount - Discount).ToString();
        }

        private void txtPAM_EditValueChanged(object sender, EventArgs e)
        {
            double Amount = 0;
            double Discount = 0;
            double Paid = 0;
            if (txtAMT.EditValue != null || txtAMT.Text != "")
                Amount = Convert.ToDouble(txtAMT.EditValue);
            else
                Amount = 0;

            if (txtDSC.EditValue != null || txtDSC.Text != "")
                Discount = Convert.ToDouble(txtDSC.EditValue);
            else
                Discount = 0;

            if (txtPAM.EditValue != null || txtPAM.Text != "")
                Paid = Convert.ToDouble(txtPAM.EditValue);
            else
                Paid = 0;

            double toPay = Amount - Discount;
            txtBAL.Text = (toPay - Paid).ToString();
        }

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colDel)
            {
                if (XtraMessageBox.Show("Do you really want to remove this product from Sales list?", "Confirm remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grv.DeleteRow(hi.RowHandle);
                    TotalAmount = Convert.ToDouble(colAMT.SummaryText);
                    txtAMT.EditValue = TotalAmount;
                    txtPAM.EditValue = TotalAmount;
                }
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (grv.RowCount <= 0)
            {
                XtraMessageBox.Show("Please add some product to sell");
                return;
            }

            wrCustomers.Server2Client scc = new wrCustomers.Server2Client();
            wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            scc = cus.CreateDefaultCustomer();
            int CusID = scc.Count;

            wrSales.Sale s = new wrSales.Sale();

            s.InvoiceNo = txtINV.Text;
            s.SaleDate = dtpSDT.DateTime;
            s.CustomerID = CusID;
            s.Amount = Convert.ToDouble(txtAMT.EditValue);
            s.Discount = Convert.ToDouble(txtDSC.EditValue);
            s.Payment = Convert.ToDouble(txtPAM.EditValue);
            s.Balance = Convert.ToDouble(txtBAL.EditValue);

            sls = new wrSales.wsSales();
            sc = sls.AddSale(s);
            if (sc.Message != null)
            {
                XtraMessageBox.Show(sc.Message);
                return;
            }


            for (int i = 0; i <= grv.RowCount - 1; i++)
            {
                wrProducts.Server2Client spc = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                wrSales.Server2Client ssc = new wrSales.Server2Client();
                wrSales.SaleDetail sd = new wrSales.SaleDetail();
                sd.InvoiceNo = txtINV.Text;
                sd.ProductID = Convert.ToInt32(grv.GetRowCellValue(i, colPID));
                sd.Quantity = Convert.ToInt32(grv.GetRowCellValue(i, colQTY));
                sd.BuyingValue = Convert.ToDouble(grv.GetRowCellValue(i, colBVL));
                sd.SellingValue = Convert.ToDouble(grv.GetRowCellValue(i, colSVL));
                sd.Amount = sd.Quantity * sd.SellingValue;

                ssc = sls.AddSaleDetails(sd);
                spc = prd.updateQuantity(sd.ProductID, sd.Quantity, "-");
            }

            XtraMessageBox.Show("Product(s) Sold!");
            grd.DataSource = null;
            InitInvoiceNo();
            lueCAT.EditValue = null;
            luePNM.EditValue = null;
            lueCAT.Properties.DataSource = null;
            luePNM.Properties.DataSource = null;
            InitCategories();
            InitProducts();
            Reset();
        }
    }
}