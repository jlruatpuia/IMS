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
    public partial class frmExtProduct : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();

        wrProducts.Server2Client sc = new wrProducts.Server2Client();
        wrProducts.wsProducts prd = new wrProducts.wsProducts();
        void InitDataTable()
        {
            //dt.Columns.Add("ProductID", typeof(int));
            dt.Columns.Add("CategoryID", typeof(int));
            dt.Columns.Add("ProductName", typeof(string));
            dt.Columns.Add("BuyingValue", typeof(double));
            dt.Columns.Add("SellingValue", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("BarCode", typeof(string));
        }

        void InitCategory()
        {
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.GetCategories();

            lueCAT.Properties.DataSource = sc.dataTable;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";
        }

        void InitProduct()
        {
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.GetProducts();

            luePNM.Properties.DataSource = sc.dataTable;
            luePNM.Properties.DisplayMember = "ProductName";
            luePNM.Properties.ValueMember = "ProductName";

        }
        public frmExtProduct()
        {
            InitializeComponent();
            InitDataTable();
            InitCategory();
            InitProduct();
        }

        private void lueCAT_EditValueChanged(object sender, EventArgs e)
        {
            if (slueCAT.RowCount <= 0)
                return;
            int CAT = Convert.ToInt32(lueCAT.EditValue);
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            sc = prd.GetProductByCategory(CAT);
            luePNM.Properties.DataSource = sc.dataTable;
            luePNM.Properties.DisplayMember = "ProductName";
            luePNM.Properties.ValueMember = "ProductName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate())
                return;

            int CAT = Convert.ToInt32(lueCAT.EditValue);
            string PNM = luePNM.Text;
            double BVL = Convert.ToDouble(txtBVL.EditValue);
            double SVL = Convert.ToDouble(txtSVL.EditValue);
            int QTY = Convert.ToInt32(txtQTY.EditValue);
            string BCD = txtBCD.Text;

            DataRow row = dt.NewRow();
            row["CategoryID"] = CAT;
            row["ProductName"] = PNM;
            row["BuyingValue"] = BVL;
            row["SellingValue"] = SVL;
            row["Quantity"] = QTY;
            row["BarCode"] = BCD;
            dt.Rows.Add(row);

            grd.DataSource = dt;
            grd.Refresh();
        }

        private void txtBCD_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
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

        
    }
}