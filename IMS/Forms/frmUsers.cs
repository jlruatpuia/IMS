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

namespace Skynet.Forms
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AccountType { get; set; }
        public bool Active { get; set; }
        public frmUsers()
        {
            InitializeComponent();
            rdoATP.SelectedIndex = 1;
        }

        public frmUsers(int UID)
        {
            InitializeComponent();
            //txtUNM.Text = Username;
            //txtPWD
        }

        public frmUsers(int UID, string ABC)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!dxVP.Validate()) return;

            Username = txtUNM.Text;
            Password = Utils.Encrypt(txtPWD2.Text);
            AccountType = rdoATP.SelectedIndex;
            Active = true;

            DialogResult = DialogResult.OK;
        }
    }
}