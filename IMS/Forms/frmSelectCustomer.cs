using IMS.Codes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmSelectCustomer : DevExpress.XtraEditors.XtraForm
    {
        public int CustomerID { get; set; }
        public bool DateSelected { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        wrCustomers.Server2Client sc = new wrCustomers.Server2Client();
        wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
        public frmSelectCustomer()
        {
            InitializeComponent();

            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomers();
            lueCNM.Properties.DataSource = sc.dataTable;
            lueCNM.Properties.DisplayMember = "CustomerName";
            lueCNM.Properties.ValueMember = "ID";

            checkEdit1_CheckedChanged(null, null);
            dtFr.DateTime = DateTime.Now.Date;
            dtTo.DateTime = DateTime.Now.Date;
        }

        public frmSelectCustomer(int ID)
        {
            InitializeComponent();
            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            sc = cus.getCustomers();
            lueCNM.Properties.DataSource = sc.dataTable;
            lueCNM.Properties.DisplayMember = "CustomerName";
            lueCNM.Properties.ValueMember = "ID";
            checkEdit1_CheckedChanged(null, null);
            chkSelect.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                CustomerID = Convert.ToInt32(lueCNM.EditValue);
                if (DateSelected)
                {
                    DateFrom = dtFr.DateTime;
                    DateTo = dtTo.DateTime;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelect.Checked)
            {
                dtFr.Enabled = true;
                dtTo.Enabled = true;
                DateSelected = true;
            }
            else
            {
                dtFr.Enabled = false;
                dtTo.Enabled = false;
                DateSelected = false;
            }
        }
    }
}