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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;

namespace IMS.Forms
{
    public partial class frmPurchase : XtraForm
    {
        DataTable dt = new DataTable();

        wrPurchases.Server2Client sc = new wrPurchases.Server2Client();
        wrPurchases.wsPurchases pur = new wrPurchases.wsPurchases();
        wrSettings.wrSettings stg = new wrSettings.wrSettings();
        wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();

        public double TotalAmount { get; private set; }
        public double SupplierBalance { get; set; }


        void InitInvoice()
        {
            string SHN = Properties.Settings.Default.ShortName;
            txtINV.Text = stg.GetInvoiceNo(DateTime.Now.Date, "Purchase", SHN);
        }
        void InitDataTable()
        {
            dt.Columns.Add("Category", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("BuyingValue", typeof(double));
            dt.Columns.Add("SellingValue", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("BarCode", typeof(string));
        }
        void InitSuppliers()
        {
            sc = new wrPurchases.Server2Client();
            wrSuppliers.Server2Client s2c = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            s2c = sup.getSuppliers();
            lueSUP.Properties.DataSource = s2c.dataTable;
            lueSUP.Properties.DisplayMember = "SupplierName";
            lueSUP.Properties.ValueMember = "ID";
        }

        void InitCategories()
        {
            wrProducts.Server2Client s2c = new wrProducts.Server2Client();
            wrProducts.wsProducts cat = new wrProducts.wsProducts();
            s2c = cat.GetCategories();
            lueCAT1.Properties.DataSource = s2c.dataTable;
            lueCAT1.Properties.DisplayMember = "CategoryName";
            lueCAT1.Properties.ValueMember = "ID";
            lueCAT2.Properties.DataSource = s2c.dataTable;
            lueCAT2.Properties.DisplayMember = "CategoryName";
            lueCAT2.Properties.ValueMember = "ID";
        }

        public frmPurchase()
        {
            InitializeComponent();
            InitInvoice();
            dtpPDT.DateTime = DateTime.Now.Date;
            InitDataTable();
            InitSuppliers();
            InitCategories();
        }

        private void lueCAT1_EditValueChanged(object sender, EventArgs e)
        {
            if(lueCAT1.EditValue != null)
            {
                int cid = Convert.ToInt32(lueCAT1.EditValue);
                wrProducts.Server2Client s2c = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                s2c = prd.GetProductByCategory(cid);

                luePNM1.Properties.DataSource = s2c.dataTable;
                luePNM1.Properties.DisplayMember = "ProductName";
                luePNM1.Properties.ValueMember = "ID";
            }
        }

        private void luePNM1_EditValueChanged(object sender, EventArgs e)
        {
            if(luePNM1.EditValue != null)
            {
                int pid = Convert.ToInt32(luePNM1.EditValue);
                wrProducts.Server2Client s2c = new wrProducts.Server2Client();
                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                wrProducts.Product p = new wrProducts.Product();
                p = prd.GetProductByID(pid);

                txtBVL1.EditValue = p.BuyingValue;
                txtSVL1.EditValue = p.SellingValue;
                txtQTY1.EditValue = 1;
            }
        }
        private void txtBCD1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();
                r["Category"] = Convert.ToInt32(lueCAT1.EditValue);
                r["ProductName"] = luePNM1.Text;
                r["BuyingValue"] = Convert.ToDouble(txtBVL1.EditValue);
                r["SellingValue"] = Convert.ToDouble(txtSVL1.EditValue);
                r["Quantity"] = Convert.ToInt32(txtQTY1.EditValue);
                r["Amount"] = Convert.ToDouble(txtBVL1.EditValue) * Convert.ToInt32(txtQTY1.EditValue);
                r["BarCode"] = txtBCD1.Text;
                dt.Rows.Add(r);

                grd.DataSource = dt;
                grd.Refresh();

                txtBCD1.Text = "";
                txtBCD1.Focus();

                //txtAMT.EditValue = colAMT.SummaryText;
                double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
                txtAMT.Text = TotalAmount.ToString();
                txtPAM.Text = TotalAmount.ToString();
            }
        }

        private void txtBCD2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataRow r = dt.NewRow();
                r["Category"] = Convert.ToInt32(lueCAT2.EditValue);
                r["ProductName"] = txtPNM2.Text;
                r["BuyingValue"] = Convert.ToDouble(txtBVL2.EditValue);
                r["SellingValue"] = Convert.ToDouble(txtSVL2.EditValue);
                r["Quantity"] = Convert.ToInt32(txtQTY2.EditValue);
                r["Amount"] = Convert.ToDouble(txtBVL2.EditValue) * Convert.ToInt32(txtQTY2.EditValue);
                r["BarCode"] = txtBCD2.Text;
                dt.Rows.Add(r);

                grd.DataSource = dt;
                grd.Refresh();

                txtBCD2.Text = "";
                txtBCD2.Focus();

                double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
                txtAMT.Text = TotalAmount.ToString();
                txtPAM.Text = TotalAmount.ToString();
            }
        }

        private void grv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
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

        private void grv_Click(object sender, EventArgs e)
        {
            GridHitInfo hi = grv.CalcHitInfo(grd.PointToClient(MousePosition));
            if (hi.InRowCell && hi.Column == colDel)
            {
                if (XtraMessageBox.Show("Do you really want to remove this product from Purchase list?", "Confirm remove", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grv.DeleteRow(hi.RowHandle);
                    TotalAmount = Convert.ToDouble(colAMT.SummaryText);
                    txtAMT.EditValue = TotalAmount;
                    txtPAM.EditValue = TotalAmount;
                }
            }
        }
        private void txtINV_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if(e.Button.Index == 0)
            {
                InitInvoice();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            sc = new wrPurchases.Server2Client();
            pur = new wrPurchases.wsPurchases();
            wrPurchases.Purchase prc = new wrPurchases.Purchase();
            //Products prd = new Products();

            prc.InvoiceNo = txtINV.Text;
            prc.PurchaseDate = dtpPDT.DateTime;
            prc.SupplierID = Convert.ToInt32(lueSUP.EditValue);
            prc.Amount = Convert.ToDouble(txtAMT.EditValue);
            prc.Payment = Convert.ToDouble(txtPAM.EditValue);
            prc.Balance = Convert.ToDouble(txtBAL.EditValue);
                        
            sc = pur.addPurchase(prc);
            if(sc.Message != null)
            {
                XtraMessageBox.Show(sc.Message);
                return;
            }

            sup = new wrSuppliers.wsSuppliers();
            wrSuppliers.Server2Client s2c = new wrSuppliers.Server2Client();
            wrSuppliers.SupplierAccount s = new wrSuppliers.SupplierAccount();
            
            s.SupplierID  = Convert.ToInt32(lueSUP.EditValue);
            s.TransDate = dtpPDT.DateTime;
            s.Description = "Invoice No " + txtINV.Text;
            s.Debit = Convert.ToDouble(txtAMT.EditValue);
            s.Credit = Convert.ToDouble(txtPAM.EditValue);
            s.Balance = SupplierBalance + Convert.ToDouble(txtBAL.Text);
            s2c = sup.addTrans(s);
            if (sc.Message != null)
            {
                XtraMessageBox.Show(sc.Message);
                return;
            }

            Guid g;
            for(int i= 0; i <= grv.RowCount  -1; i++)
            {
                int cid = Convert.ToInt32(grv.GetRowCellValue(i, colCID));
                string pnm = grv.GetRowCellValue(i, colPNM).ToString();
                double bvl = Convert.ToDouble(grv.GetRowCellValue(i, colBVL));
                double svl = Convert.ToDouble(grv.GetRowCellValue(i, colSVL));
                int qty = Convert.ToInt32(grv.GetRowCellValue(i, colQTY));
                double amt = Convert.ToDouble(grv.GetRowCellValue(i, colAMT));
                string bcd = grv.GetRowCellValue(i, colBCD).ToString();

                wrPurchases.PurchaseDetail pdt = new wrPurchases.PurchaseDetail();
                pdt.InvoiceNo = txtINV.Text;
                g = Guid.NewGuid();
                pdt.ProductCode = g.ToString();
                pdt.BuyingValue = bvl;
                pdt.SellingValue = svl;
                pdt.Quantity = qty;
                pdt.Amount = amt;
                sc = pur.addPurchaseDetails(pdt);
                if(sc.Message != null)
                {
                    XtraMessageBox.Show(sc.Message);
                    return;
                }

                wrProducts.wsProducts prd = new wrProducts.wsProducts();
                wrProducts.Product p = new wrProducts.Product();
                wrProducts.Server2Client spc = new wrProducts.Server2Client();

                p.CategoryID = cid;
                p.SupplierID = Convert.ToInt32(lueSUP.EditValue);
                p.ProductCode = g.ToString();
                p.ProductName = pnm;
                p.BuyingValue = bvl;
                p.SellingValue = svl;
                p.SupplierID = Convert.ToInt32(lueSUP.EditValue);
                p.Quantity = qty;
                p.BarCode = bcd;

                spc = prd.AddProduct(p);
                if (sc.Message != null)
                {
                    XtraMessageBox.Show(sc.Message);
                    return;
                }
            }

            XtraMessageBox.Show("Product(s) purchased successfully!");
            InitInvoice();
            dtpPDT.DateTime = DateTime.Now.Date;
            dt = new DataTable();
            InitDataTable();
            InitSuppliers();
            InitCategories();
            grd.DataSource = null;
        }

        private void txtPAM_EditValueChanged(object sender, EventArgs e)
        {
            double Amount = 0;
            double Paid = 0;
            if (txtAMT.EditValue != null || txtAMT.Text != "")
                Amount = Convert.ToDouble(txtAMT.EditValue);
            else
                Amount = 0;

            if (txtPAM.EditValue != null || txtPAM.Text != "")
                Paid = Convert.ToDouble(txtPAM.EditValue);
            else
                Paid = 0;

            txtBAL.Text = (Amount - Paid).ToString();
        }

        private void lueSUP_EditValueChanged(object sender, EventArgs e)
        {
            int id = lueSUP.EditValue == null ? 0 : Convert.ToInt32(lueSUP.EditValue);
            wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();
            wrSuppliers.wsSuppliers sa = new wrSuppliers.wsSuppliers();
            wrSuppliers.Supplier sup = new wrSuppliers.Supplier();
            //c = cus.getCustomer(id);
            sc = sa.getSupplierBalanceByID(id);
            SupplierBalance = sc.Value;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["Category"] = Convert.ToInt32(lueCAT1.EditValue);
            r["ProductName"] = luePNM1.Text;
            r["BuyingValue"] = Convert.ToDouble(txtBVL1.EditValue);
            r["SellingValue"] = Convert.ToDouble(txtSVL1.EditValue);
            r["Quantity"] = Convert.ToInt32(txtQTY1.EditValue);
            r["Amount"] = Convert.ToDouble(txtBVL1.EditValue) * Convert.ToInt32(txtQTY1.EditValue);
            r["BarCode"] = txtBCD1.Text;
            dt.Rows.Add(r);

            grd.DataSource = dt;
            grd.Refresh();

            txtBCD1.Text = "";
            txtBCD1.Focus();

            //txtAMT.EditValue = colAMT.SummaryText;
            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            txtAMT.Text = TotalAmount.ToString();
            txtPAM.Text = TotalAmount.ToString();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            DataRow r = dt.NewRow();
            r["Category"] = Convert.ToInt32(lueCAT2.EditValue);
            r["ProductName"] = txtPNM2.Text;
            r["BuyingValue"] = Convert.ToDouble(txtBVL2.EditValue);
            r["SellingValue"] = Convert.ToDouble(txtSVL2.EditValue);
            r["Quantity"] = Convert.ToInt32(txtQTY2.EditValue);
            r["Amount"] = Convert.ToDouble(txtBVL2.EditValue) * Convert.ToInt32(txtQTY2.EditValue);
            r["BarCode"] = txtBCD2.Text;
            dt.Rows.Add(r);

            grd.DataSource = dt;
            grd.Refresh();

            txtBCD2.Text = "";
            txtBCD2.Focus();

            double TotalAmount = Convert.ToDouble(colAMT.SummaryText);
            txtAMT.Text = TotalAmount.ToString();
            txtPAM.Text = TotalAmount.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lueSUP_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmSuppliers frm = new frmSuppliers("Something");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    InitSuppliers();
                    lueSUP.EditValue = frm._id;
                }
            }
        }
    }
}