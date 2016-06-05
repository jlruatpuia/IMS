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
using IMS.Codes;

namespace IMS.Forms
{
    public partial class frmDeleteProduct : DevExpress.XtraEditors.XtraForm
    {
        wrProducts.Server2Client sc = new wrProducts.Server2Client();
        wrProducts.wsProducts prd = new wrProducts.wsProducts();

        public frmDeleteProduct()
        {
            InitializeComponent();

            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();

            sc = prd.GetCategories();
            lueCAT.Properties.DataSource = sc.dataTable;
            lueCAT.Properties.DisplayMember = "CategoryName";
            lueCAT.Properties.ValueMember = "ID";
        }

        private void lueCAT_EditValueChanged(object sender, EventArgs e)
        {
            int CID = Convert.ToInt32(lueCAT.EditValue);

            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();

            sc = prd.GetProductByCategory(CID);
            grd.DataSource = sc.dataTable;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grv.RowCount > 0)
            {
                for (int i = 0; i < grv.SelectedRowsCount; i++)
                {
                    if (grv.GetSelectedRows()[i] >= 0)
                    {
                        int x = Convert.ToInt32(grv.GetSelectedRows()[i]);
                        int id = Convert.ToInt32(grv.GetRowCellValue(x, colPID));
                        sc = new wrProducts.Server2Client();
                        prd = new wrProducts.wsProducts();

                        sc = prd.deleteProduct(id);
                        if (sc.Message != null)
                            XtraMessageBox.Show(sc.Message);
                    }
                }
                lueCAT_EditValueChanged(null, null);
            }
            else
            {
                XtraMessageBox.Show("Nothing to delete");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}