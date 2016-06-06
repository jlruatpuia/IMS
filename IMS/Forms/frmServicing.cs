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

namespace IMS.Forms
{
    public partial class frmServicing : XtraForm
    {
        //wrSettings.Server2Client sc = new wrSettings.Server2Client();
        //wrSettings.wrSettings stg = new wrSettings.wrSettings();
        
        wrSettings.Servicing s = new wrSettings.Servicing();
        public frmServicing()
        {
            InitializeComponent();
            dtpSDT.DateTime = DateTime.Now.Date;
            InvoiceNo();
        }

        private void InvoiceNo()
        {
            wrSettings.wrSettings stg = new wrSettings.wrSettings();
            string SHN = Properties.Settings.Default.ShortName;
            txtINV.Text = stg.GetServiceInvoiceNo(DateTime.Now.Date, SHN);
        }

        private void Clear()
        {
            InvoiceNo();
            textEdit3.Text = "";
            txtAMT.EditValue = 0;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!dxValidationProvider1.Validate()) return;

            //wrCustomers.Server2Client scc = new wrCustomers.Server2Client();
            //wrCustomers.wsCustomers cus = new wrCustomers.wsCustomers();
            //scc = cus.CreateDefaultCustomer();
            //int CusID = scc.Count;

            //wrSales.Server2Client scs = new wrSales.Server2Client();
            //wrSales.wsSales sls = new wrSales.wsSales();
            //wrSales.Sale ss = new wrSales.Sale();

            ////wrSales.Sale s = new wrSales.Sale();

            //ss.InvoiceNo = txtINV.Text;
            //ss.SaleDate = dtpSDT.DateTime;
            //ss.CustomerID = CusID;
            //ss.Amount = Convert.ToDouble(txtAMT.EditValue);
            //ss.Discount =0;
            //ss.Payment = Convert.ToDouble(txtAMT.EditValue);
            //ss.Balance = 0;

            //sls = new wrSales.wsSales();
            //scs = sls.AddSale(ss);
            //if (scs.Message != null)
            //{
            //    XtraMessageBox.Show(scs.Message);
            //    return;
            //}

            s.InvoiceNo = txtINV.Text;
            s.ServiceDate = dtpSDT.DateTime;
            s.Description = textEdit3.Text;
            s.Amount = Convert.ToDouble(txtAMT.Text);

            wrSettings.Server2Client sc = new wrSettings.Server2Client();
            wrSettings.wrSettings stg = new wrSettings.wrSettings();
            sc = new wrSettings.Server2Client();
            stg = new wrSettings.wrSettings();

            sc = stg.AddServicing(s);

            if(sc.Message == null)
            {
                XtraMessageBox.Show("Success!");
                Clear();
            }
            else
            {
                XtraMessageBox.Show(sc.Message);
            }
        }
    }
}