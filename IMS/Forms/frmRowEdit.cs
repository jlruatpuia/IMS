using DevExpress.XtraEditors;
using IMS.Codes;
using System;
using System.Windows.Forms;

namespace IMS.Forms
{
    public partial class frmRowEdit : XtraForm
    {
        public int categoryID { get; set; }
        public string productName { get; set; }
        public double buyingValue { get; set; }
        public double sellingValue { get; set; }
        public int quantity { get; set; }
        public string barCode { get; set; }


        public frmRowEdit(int RowHandle, int CatID, string PNM, double BVL, double SVL, int QTY, string BCD)
        {
            InitializeComponent();

            wrProducts.Server2Client sc = new wrProducts.Server2Client();
            wrProducts.wsProducts cat = new wrProducts.wsProducts();
            sc = cat.GetCategories();
            lueCAT.Properties.DataSource = sc.dataTable;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";

            lueCAT.EditValue = CatID;
            txtPNM.EditValue = PNM;
            txtBVL.EditValue = BVL;
            txtSVL.EditValue = SVL;
            txtQTY.EditValue = QTY;
            txtBCD.EditValue = BCD;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            categoryID = Convert.ToInt32(lueCAT.EditValue);
            productName = txtPNM.EditValue.ToString();
            buyingValue = Convert.ToDouble(txtBVL.EditValue);
            sellingValue = Convert.ToDouble(txtSVL.EditValue);
            quantity = Convert.ToInt32(txtQTY.EditValue);
            barCode = txtBCD.EditValue.ToString();

            DialogResult = DialogResult.OK;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }
    }
}