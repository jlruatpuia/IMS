using IMS.Codes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        wrCustomers.Server2Client sc = new wrCustomers.Server2Client();
        wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
        wrCustomers.Customer c = new wrCustomers.Customer();

        Timer tmr = new Timer();
        int counter = 0;
        public int _id { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
            lbMSG.Text = string.Empty;
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(this.tmr_tick);
        }

        public frmCustomer(string something)
        {
            InitializeComponent();
            btnSave.Text = "&Add";
        }

        public frmCustomer(int ID)
        {
            InitializeComponent();
            lbMSG.Text = string.Empty;
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(this.tmr_tick);

            sc = new wrCustomers.Server2Client();
            cus = new wrCustomers.wsCustomers();
            c = new wrCustomers.Customer();

            c = cus.getCustomer(ID);
            _id = ID;
            txtCNM.Text = c.CustomerName;
            txtADR.Text = c.Address;
            txtPHN.Text = c.Phone;
            txtEML.Text = c.Email;
            //txtBAL.Text = cus.Balance.ToString();

            btnSave.Text = "&Update";
        }

        void reset()
        {
            txtCNM.Text = "";
            txtADR.Text = "";
            txtPHN.Text = "";
            txtEML.Text = "";
            //txtBAL.Text = "0";
            txtCNM.Focus();
        }
        private void tmr_tick(object sender, EventArgs e)
        {
            counter++;
            if(counter == 2)
            {
                lbMSG.Text = string.Empty;
                
                tmr.Stop();
                counter = 0;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "&Update")
            {
                if (dxVP.Validate())
                {
                    sc = new wrCustomers.Server2Client();
                    cus = new wrCustomers.wsCustomers();
                    c = new wrCustomers.Customer();
                    c.CustomerID = _id;
                    c.CustomerName = txtCNM.Text;
                    c.Address = txtADR.Text;
                    c.Phone = txtPHN.Text;
                    c.Email = txtEML.Text;
                    //cus.Balance = Convert.ToInt32(txtBAL.Text);
                    sc = cus.updateCustomer(c);
                    if (sc.Message == null)
                    {
                        lbMSG.Text = "Customer details updated!";
                        Close();
                    }
                    else
                        lbMSG.Text = sc.Message;
                }
            }
            else if(btnSave.Text == "&Save")
            {
                if (dxVP.Validate())
                {
                    sc = new wrCustomers.Server2Client();
                    cus = new wrCustomers.wsCustomers();
                    c = new wrCustomers.Customer();
                    c.CustomerName = txtCNM.Text;
                    c.Address = txtADR.Text;
                    c.Phone = txtPHN.Text;
                    c.Email = txtEML.Text;
                    //cus.Balance = Convert.ToInt32(txtBAL.Text);
                    sc = cus.addCustomer(c);
                    if (sc.Message == null)
                    {
                        lbMSG.Text = "New Customer added!";
                        reset();
                    }
                    else
                        lbMSG.Text = sc.Message;
                    tmr.Enabled = true;
                    tmr.Start();
                }
            }
            else
            {
                if (dxVP.Validate())
                {
                    sc = new wrCustomers.Server2Client();
                    cus = new wrCustomers.wsCustomers();
                    c = new wrCustomers.Customer();
                    c.CustomerName = txtCNM.Text;
                    c.Address = txtADR.Text;
                    c.Phone = txtPHN.Text;
                    c.Email = txtEML.Text;
                    //cus.Balance = Convert.ToInt32(txtBAL.Text);
                    sc = cus.addCustomer(c);
                    _id = sc.Count;
                    if (sc.Message == null)
                    {
                        //sc = new wrCustomers.Server2Client();
                        //cus = new wrCustomers.wsCustomers();
                        //sc = cus.getMaxID();
                        DialogResult = DialogResult.OK;
                    }
                    else
                        lbMSG.Text = sc.Message;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}