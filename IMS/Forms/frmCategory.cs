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
    public partial class frmCategory : XtraForm
    {
        public bool IsEdit { get; set; }
        public int CID { get; set; }

        wrProducts.Server2Client sc = new wrProducts.Server2Client();
        wrProducts.wsProducts prd = new wrProducts.wsProducts();

        public frmCategory()
        {
            InitializeComponent();

            dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            LoadData();
        }

        private void LoadData()
        {
            sc = new wrProducts.Server2Client();

            prd = new wrProducts.wsProducts();

            sc = prd.GetProductCategories();

            grd.DataSource = sc.dataTable;

            if(grv.RowCount <= 0)
            {
                bEdit.Enabled = false;
                bDel.Enabled = false;
            }
            else
            {
                bEdit.Enabled = true;
                bDel.Enabled = true;
            }
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            IsEdit = false;

            txtCNM.Focus();
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CID = Convert.ToInt32(grv.GetFocusedRowCellValue(colCID));
            dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            IsEdit = true;

            wrProducts.Category c = new wrProducts.Category();
            wrProducts.wsProducts prd = new wrProducts.wsProducts();

            c = prd.GetCategory(CID);

            txtCNM.Text = c.CategoryName;

            txtCNM.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sc = new wrProducts.Server2Client();
            prd = new wrProducts.wsProducts();
            wrProducts.Category c = new wrProducts.Category();
            c.CategoryID = CID;
            c.CategoryName = txtCNM.Text.ToUpper();

            if (!IsEdit)
            {
                sc = prd.AddCategory(c);

                if (sc.Message == null)
                    XtraMessageBox.Show("New Category added successfully!");
                else
                    XtraMessageBox.Show(sc.Message);
                txtCNM.Text = "";
                txtCNM.Focus();
            }
            else
            {
                sc = prd.UpdateCategory(c);

                if (sc.Message == null)
                    XtraMessageBox.Show("Category updated successfully!");
                else
                    XtraMessageBox.Show(sc.Message);

                dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            }
            LoadData();
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CID = Convert.ToInt32(grv.GetFocusedRowCellValue(colCID));
            wrProducts.Category c = new wrProducts.Category();
            c.CategoryID = CID;
            c.CategoryName = txtCNM.Text.ToUpper();

            if (XtraMessageBox.Show("Are you sure you want to delete this Category? Deleting this category will also delete corresponding Products", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                sc = new wrProducts.Server2Client();
                prd = new wrProducts.wsProducts();
                sc = prd.DeleteCategory(c);

                if (sc.Message == null)
                    XtraMessageBox.Show("Category deleted successfully!");
                else
                    XtraMessageBox.Show(sc.Message);

                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCNM.Text = "";
            dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }
    }
}