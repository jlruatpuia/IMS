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
    public partial class ucUsers : XtraUserControl
    {
        Server2Client sc;
        Users u;
        public ucUsers()
        {
            InitializeComponent();

            InitUsers();
        }

        void InitUsers()
        {
            sc = new Server2Client();
            u = new Users();
            sc = u.GetUsers();

            grd.DataSource = sc.dataTable;
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsers frm = new frmUsers();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                sc = new Server2Client();
                u = new Users();
                User uu = new User();
                uu.Username = frm.Username;
                uu.Password = frm.Password;
                uu.AccountType = frm.AccountType;
                uu.Active = frm.Active;
                sc = u.AddUser(uu);

                if (sc.Message == null)
                {
                    XtraMessageBox.Show("New user successfully created!");
                    InitUsers();
                }
                else
                    XtraMessageBox.Show(sc.Message);
            }
        }
    }
}
