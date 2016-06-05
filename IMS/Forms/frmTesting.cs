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
using Skynet.Classes;

namespace Skynet.Forms
{
    public partial class frmTesting : XtraForm
    {
        public frmTesting()
        {
            InitializeComponent();
        }
        
        private string ToFinancialYear(DateTime dt)
        {
            return "Financial Year " + (dt.Month >= 4 ? dt.Year + 1 : dt.Year);
        }

        private string ToFinancialYearShort(DateTime dt)
        {
            return "FY" + (dt.Month >= 4 ? dt.AddYears(1).ToString("yy") : dt.ToString("yy"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(ToFinancialYear(DateTime.Now.Date));
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(ToFinancialYearShort(DateTime.Now.Date));
        }

        

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Settings.GetFinancialYear(DateTime.Now.Date));
        }
    }
}