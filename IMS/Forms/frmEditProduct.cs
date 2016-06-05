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

namespace IMS.Forms
{
    public partial class frmEditProduct : XtraForm
    {
        wrProducts.Server2Client sc = new wrProducts.Server2Client();
        wrProducts.wsProducts prd = new wrProducts.wsProducts();
        void InitCategory()
        {
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.GetCategories();

            lueCAT.Properties.DataSource = sc.dataTable;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";

            lueCAT2.Properties.DataSource = sc.dataTable;
            lueCAT2.Properties.DisplayMember = "CategoryName";
            lueCAT2.Properties.ValueMember = "ID";
        }

        void InitProducts(int CategoryID)
        {
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.GetProductByCategory(CategoryID);

            luePRD.Properties.DataSource = sc.dataTable;
            luePRD.Properties.DisplayMember = "ProductName";
            luePRD.Properties.ValueMember = "ID";
        }
        public frmEditProduct()
        {
            InitializeComponent();

            InitCategory();
        }

        private void lueCAT_EditValueChanged(object sender, EventArgs e)
        {
            if(lueCAT.EditValue != null)
            {
                int cid = Convert.ToInt32(lueCAT.EditValue);

                InitProducts(cid);
            }
        }

        private void luePRD_EditValueChanged(object sender, EventArgs e)
        {
            if(luePRD.EditValue != null)
            {
                int pid = Convert.ToInt32(luePRD.EditValue);

                wrProducts.Product p = new wrProducts.Product();
                prd = new wrProducts.wsProducts();

                p = prd.GetProductByID(pid);

                lueCAT2.EditValue = lueCAT.EditValue;

                txtPNM.Text = p.ProductName;
                txtBVL.EditValue = p.BuyingValue;
                txtSVL.EditValue = p.SellingValue;
                txtQTY.EditValue = p.Quantity;
                txtBCD.EditValue = p.BarCode;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate())
                return;

            wrProducts.Product p = new wrProducts.Product();
            p.ProductID = Convert.ToInt32(luePRD.EditValue);
            p.CategoryID = Convert.ToInt32(lueCAT2.EditValue);
            p.ProductName = txtPNM.EditValue.ToString();
            p.BuyingValue = Convert.ToDouble(txtBVL.EditValue);
            p.SellingValue = Convert.ToDouble(txtSVL.EditValue);
            p.Quantity = Convert.ToInt32(txtQTY.EditValue);
            p.BarCode = txtBCD.Text;

            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.updateProduct(p);
            if (sc.Message != null)
                XtraMessageBox.Show(sc.Message);
            else
                DialogResult = DialogResult.OK;
        }
    }
}