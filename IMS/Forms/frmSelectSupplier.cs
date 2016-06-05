using DevExpress.XtraEditors;
using IMS.Codes;
using System;
using System.Windows.Forms;

namespace IMS
{
    public partial class frmSelectSupplier : XtraForm
    {
        public int SupplierID { get; set; }
        public bool DateSelected { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public frmSelectSupplier()
        {
            InitializeComponent();

            wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();

            wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSuppliers();
            lueSNM.Properties.DataSource = sc.dataTable;
            lueSNM.Properties.DisplayMember = "SupplierName";
            lueSNM.Properties.ValueMember = "ID";

            chkSEL_CheckedChanged(null, null);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (dxValidationProvider1.Validate())
            {
                SupplierID = Convert.ToInt32(lueSNM.EditValue);
                if (DateSelected)
                {
                    DateFrom = dtpFR.DateTime;
                    DateTo = dtpTO.DateTime;
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void chkSEL_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSEL.Checked)
            {
                dtpFR.Enabled = true;
                dtpTO.Enabled = true;
                DateSelected = true;
            }
            else
            {
                dtpFR.Enabled = false;
                dtpTO.Enabled = false;
                DateSelected = false;
            }
        }
    }
}