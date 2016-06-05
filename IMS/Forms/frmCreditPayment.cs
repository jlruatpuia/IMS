using DevExpress.XtraEditors;
using IMS.Codes;
using System;

namespace IMS
{
    public partial class frmCreditPayment : XtraForm
    {
        wrCustomers.Server2Client sc = new wrCustomers.Server2Client();
        wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
        public frmCreditPayment()
        {
            InitializeComponent();

            txtPDT.DateTime = DateTime.Now.Date;
            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomers();

            lueCNM.Properties.DataSource = sc.dataTable;
            lueCNM.Properties.DisplayMember = "CustomerName";
            lueCNM.Properties.ValueMember = "ID";

            txtCBAL.Text = "0";
            txtAMNT.Text = "0";
            txtNBAL.Text = "0";
        }

        public frmCreditPayment(int CustomerID)
        {
            InitializeComponent();

            txtPDT.DateTime = DateTime.Now.Date;
            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomers();

            lueCNM.Properties.DataSource = sc.dataTable;
            lueCNM.Properties.DisplayMember = "CustomerName";
            lueCNM.Properties.ValueMember = "ID";

            lueCNM.EditValue = CustomerID;
            sc = cus.getCustomerBalanceByID(CustomerID);

            txtCBAL.Text = sc.Value.ToString();
            
            txtAMNT.Text = "0";
            txtNBAL.Text = "0";
        }

        private void lueCNM_EditValueChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lueCNM.EditValue);

            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomerBalanceByID(id);

            if(sc.Message != null)
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
                sc = new wrCustomers.Server2Client();
                wrCustomers.CustomerAccount c = new wrCustomers.CustomerAccount();

                string Remarks = txtRMKS.Text == "" ? "Credit Payment" : txtRMKS.Text;
                c.CustomerID = Convert.ToInt32(lueCNM.EditValue);
                c.TransDate = txtPDT.DateTime;
                c.Description = Remarks;
                c.Debit = 0;
                c.Credit = Convert.ToDouble(txtAMNT.Text);
                c.Balance = Convert.ToDouble(txtNBAL.Text);

                cus = new wrCustomers.wsCustomers();
                sc = cus.addTrans(c);

                if (sc.Message == null)
                {
                    XtraMessageBox.Show("Payment done successfully!");
                    lueCNM.EditValue = null;
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