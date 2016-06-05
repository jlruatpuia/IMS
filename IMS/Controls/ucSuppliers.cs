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
using DevExpress.Utils;
using IMS.Forms;
using DevExpress.XtraReports.UI;

namespace IMS.Controls
{
    public partial class ucSuppliers : DevExpress.XtraEditors.XtraUserControl
    {
        wrSuppliers.Server2Client sc = new wrSuppliers.Server2Client();
        wrSuppliers.wsSuppliers sup = new wrSuppliers.wsSuppliers();
        public ucSuppliers()
        {
            InitializeComponent();

            fillGrid();
            FillGridControl();
        }

        void ButtonDisableEnable(int count)
        {
            if (count < 1)
            {
                bEdit.Enabled = false;
                bDel.Enabled = false;
                bPay.Enabled = false;
            }
            else
            {
                bEdit.Enabled = true;
                bDel.Enabled = true;
                bPay.Enabled = true;
            }
        }

        private void FillGridControl()
        {
            sc = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            sc = sup.Supplier_Account();

            grd.DataSource = sc.dataSet.Tables[0];
            grd.ForceInitialize();
            grd.LevelTree.Nodes.Add(sc.Message, grvD);
            grvD.PopulateColumns(sc.dataSet.Tables[1]);
            grvD.ViewCaption = "Summary";
            grvD.OptionsView.ShowGroupPanel = false;
            grvD.Columns["ID"].VisibleIndex = -1;
            grvD.Columns["SupplierID"].VisibleIndex = -1;
            grvD.Columns["TransDate"].OptionsColumn.AllowEdit = false;
            grvD.Columns["TransDate"].OptionsColumn.AllowFocus = false;
            grvD.Columns["TransDate"].OptionsColumn.ReadOnly = true;
            grvD.Columns["Description"].OptionsColumn.AllowEdit = false;
            grvD.Columns["Description"].OptionsColumn.AllowFocus = false;
            grvD.Columns["Description"].OptionsColumn.ReadOnly = true;
            grvD.Columns["Debit"].OptionsColumn.AllowEdit = false;
            grvD.Columns["Debit"].OptionsColumn.AllowFocus = false;
            grvD.Columns["Debit"].OptionsColumn.ReadOnly = true;
            grvD.Columns["Debit"].DisplayFormat.FormatType = FormatType.Numeric;
            grvD.Columns["Debit"].DisplayFormat.FormatString = "{0:c}";
            grvD.Columns["Credit"].OptionsColumn.AllowEdit = false;
            grvD.Columns["Credit"].OptionsColumn.AllowFocus = false;
            grvD.Columns["Credit"].OptionsColumn.ReadOnly = true;
            grvD.Columns["Credit"].DisplayFormat.FormatType = FormatType.Numeric;
            grvD.Columns["Credit"].DisplayFormat.FormatString = "{0:c}";
            grvD.Columns["Balance"].OptionsColumn.AllowEdit = false;
            grvD.Columns["Balance"].OptionsColumn.AllowFocus = false;
            grvD.Columns["Balance"].OptionsColumn.ReadOnly = true;
            grvD.Columns["Balance"].DisplayFormat.FormatType = FormatType.Numeric;
            grvD.Columns["Balance"].DisplayFormat.FormatString = "{0:c}";

            ButtonDisableEnable(sc.Count);
        }

        private void fillGrid()
        {
            sup = new wrSuppliers.wsSuppliers();
            sc = new wrSuppliers.Server2Client();

            sc = sup.getSuppliers();

            grd.DataSource = sc.dataTable;

            ButtonDisableEnable(sc.Count);
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSuppliers frm = new frmSuppliers();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                fillGrid();
                FillGridControl();
            }
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            frmSuppliers frm = new frmSuppliers(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                fillGrid();
                FillGridControl();
            }
        }

        private void bDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Are you sure you want to delete this Supplier?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
                sc = new wrSuppliers.Server2Client();
                sup = new wrSuppliers.wsSuppliers();
                sc = sup.deleteSupplier(id);
                if (sc.Message == null)
                    XtraMessageBox.Show("Supplier deleted successfully!");
                else
                    XtraMessageBox.Show(sc.Message);

                fillGrid();
                FillGridControl();
            }
        }

        private void bPay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(grv.GetFocusedRowCellValue(colID));
            frmDebitPayment frm = new frmDebitPayment(id);
            frm.ShowDialog();
        }

        private void bUP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MovePrev();
        }

        private void bDown_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveNext();
        }

        private void bFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Down)
                grv.OptionsFind.AlwaysVisible = true;
            else
                grv.OptionsFind.AlwaysVisible = false;
        }

        private XtraReport rpt()
        {
            sc = new wrSuppliers.Server2Client();
            sup = new wrSuppliers.wsSuppliers();
            sc = sup.getSuppliersFull();
            Utils u = new Utils();

            rptCustomers rpt = new rptCustomers() { DataSource = sc.dataTable };

            XRSummary tbal = new XRSummary();

            rpt.lbCNM.DataBindings.Add("Text", null, "SupplierName");
            rpt.lbADR.DataBindings.Add("Text", null, "Address");
            rpt.lbPHN.DataBindings.Add("Text", null, "Phone");
            rpt.lbEML.DataBindings.Add("Text", null, "Email");
            rpt.lbBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");
            rpt.lbTBAL.DataBindings.Add("Text", null, "Balance", "{0:C2}");

            tbal.FormatString = "{0:C2}";
            tbal.Running = SummaryRunning.Report;
            rpt.lbTBAL.Summary = tbal;
            return rpt;
        }

        private void bPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpt().ShowPreviewDialog();
        }

        private void bPDF_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Portable Document Format (*.PDF)|*.pdf|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt().ExportToPdf(sfd.FileName);
            }
        }

        private void bXLSX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Microsoft Office Excel (*.XLSX)|*.xlsx|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rpt().ExportToXlsx(sfd.FileName);
            }
        }
    }
}
