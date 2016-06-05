using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using IMS.Codes;

namespace IMS.Controls
{
    public partial class ucDashboard : XtraUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();

            LoadChart();
        }

        private void bRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadChart();
        }

        void LoadChart()
        {
            //Server2Client sc = new Server2Client();
            //Dashboard db = new Dashboard();

            //sc = db.SalesByCategory(DateTime.Now.Month);

            //chartSalesByCategory.DataSource = sc.dataTable;

            //sc = db.PaymentReceived(DateTime.Now.Month);

            //chartPaymentMonth.DataSource = sc.dataTable;

            //sc = db.SoldProducts(DateTime.Now.Month);

            //grd.DataSource = sc.dataTable;

            //sc = db.CreditBalance();

            //chartCredit.DataSource = sc.dataTable;
        }
    }
}
