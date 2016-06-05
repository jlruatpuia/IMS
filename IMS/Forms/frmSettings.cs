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
    public partial class frmSettings : DevExpress.XtraEditors.XtraForm
    {
        public string ShopName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string ShortName { get; set; }

        public frmSettings()
        {
            InitializeComponent();

            ShopName = Properties.Settings.Default.ShopName;
            Address = Properties.Settings.Default.Address;
            PhoneNo = Properties.Settings.Default.Phone;
            Email = Properties.Settings.Default.Email;
            Website = Properties.Settings.Default.Website;
            ShortName = Properties.Settings.Default.ShortName;

            txtSNM.Text = ShopName;
            txtADR.Text = Address;
            txtPHN.Text = PhoneNo;
            txtEML.Text = Email;
            txtWEB.Text = Website;
            txtSHN.Text = ShortName;
        }

        private void wizardControl1_FinishClick(object sender, CancelEventArgs e)
        {
            ShopName = txtSNM.Text;
            Address = txtADR.Text;
            PhoneNo = txtPHN.Text;
            Email = txtEML.Text;
            Website = txtWEB.Text;
            ShortName = txtSHN.Text;
            DialogResult = DialogResult.OK;
        }

        private void txtWEB_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (txtWEB.Text == "") return;
            System.Diagnostics.Process.Start(txtWEB.Text);
        }
    }
}