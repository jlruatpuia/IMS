using DevExpress.XtraEditors;
using IMS.Codes;
using System;

namespace IMS
{
    public partial class frmDebitPayment : XtraForm
    {
        wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();
        wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
        wrSuppliers.Supplier s = new wrSuppliers.Supplier();

        public frmDebitPayment()
        {
            InitializeComponent();
            txtPDT.DateTime = DateTime.Now.Date;
            sc = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSuppliersFull();

            lueSNM.Properties.DataSource = sc.dataTable;
            lueSNM.Properties.DisplayMember = "SupplierName";
            lueSNM.Properties.ValueMember = "ID";

            txtCBAL.Text = "0";
            txtAMNT.Text = "0";
            txtNBAL.Text = "0";
        }

        public frmDebitPayment(int SupplierID)
        {
            InitializeComponent();
            txtPDT.DateTime = DateTime.Now.Date;
            sc = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSuppliers();

            lueSNM.Properties.DataSource = sc.dataTable;
            lueSNM.Properties.DisplayMember = "SupplierName";
            lueSNM.Properties.ValueMember = "ID";

            lueSNM.EditValue = SupplierID;
            sc = sup.getSupplierBalanceByID(SupplierID);

            txtCBAL.Text = sc.Value.ToString();

            txtAMNT.Text = "0";
            txtNBAL.Text = "0";
        }

        private void lueSNM_EditValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lueSNM.EditValue);

            sc = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSupplierBalanceByID(id);

            if (sc.Message != null)
            {
                txtCBAL.Text = sc.Message;
                txtCBAL.Enabled = false;
            }
            else
            {
                txtCBAL.Text = sc.Value.ToString();
            }
        }

        private void txtAMNT_EditValueChanged(object sender, EventArgs e)
        {
            double bal = Convert.ToInt32(txtCBAL.Text);
            double val = txtAMNT.Text == "" ? 0 : Convert.ToDouble(txtAMNT.Text);
            txtNBAL.Text = (bal - val).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                sc = new wrSuppliers.Server2Client();
                sup = new wrSuppliers.wsSuppliers();
                wrSuppliers.SupplierAccount s = new wrSuppliers.SupplierAccount();

                string Remarks = txtRMKS.Text == "" ? "Debit Payment" : txtRMKS.Text;
                s.SupplierID = Convert.ToInt32(lueSNM.EditValue);
                s.TransDate = txtPDT.DateTime;
                s.Description = Remarks;
                s.Debit = 0;
                s.Credit = Convert.ToDouble(txtAMNT.Text);
                s.Balance = Convert.ToDouble(txtNBAL.Text);

                sc = sup.addTrans(s);

                if (sc.Message == null)
                {
                    XtraMessageBox.Show("Payment done successfully!");
                    lueSNM.EditValue = null;
                    txtCBAL.Text = "0";
                    txtAMNT.Text = "0";
                    txtNBAL.Text = "0";
                    txtRMKS.Text = "";
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }
    }
}