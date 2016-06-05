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
    public partial class frmSelect : XtraForm
    {
        public int RetVal { get; set; }
        public DateTime DateOn { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string InvoiceNo { get; set; }

        public frmSelect()
        {
            InitializeComponent();
            Check();
        }

        public frmSelect(bool tt)
        {
            InitializeComponent();
            Check();
            rdoInv.Enabled = false;
            txtInv.Enabled = false;
        }

        public frmSelect(string ii)
        {
            InitializeComponent();
            Check();

        }

        void Check()
        {
            if (rdoDtOn.Checked)
            {
                dtpDtOn.Enabled = true;
                dtpDtFr.Enabled = false;
                dtpDtTo.Enabled = false;
                txtInv.Enabled = false;
            }
            else if (rdoDtBt.Checked)
            {
                dtpDtOn.Enabled = false;
                dtpDtFr.Enabled = true;
                dtpDtTo.Enabled = true;
                txtInv.Enabled = false;
            }
            else
            {
                dtpDtOn.Enabled = false;
                dtpDtFr.Enabled = false;
                dtpDtTo.Enabled = false;
                txtInv.Enabled = true;
            }
        }

        private void rdoDtOn_CheckedChanged(object sender, EventArgs e)
        {
            Check();   
        }

        private void rdoDtBt_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void rdoInv_CheckedChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdoDtOn.Checked)
            {
                DateOn = dtpDtOn.DateTime;
                RetVal = 0;
                if (dxVP1.Validate())
                    DialogResult = DialogResult.OK;
            }
            else if (rdoDtBt.Checked)
            {
                DateFrom = dtpDtFr.DateTime;
                DateTo = dtpDtTo.DateTime;
                RetVal = 1;
                if (dxVP2.Validate())
                    DialogResult = DialogResult.OK;
            }
            else
            {
                InvoiceNo = txtInv.Text;
                RetVal = 2;
                if (dxVP3.Validate())
                    DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}