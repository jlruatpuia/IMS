namespace IMS.Controls
{
    partial class ucSuppliers
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSuppliers));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.grvD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.bFind = new DevExpress.XtraBars.BarButtonItem();
            this.bPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bExport = new DevExpress.XtraBars.BarSubItem();
            this.bPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.bPay = new DevExpress.XtraBars.BarButtonItem();
            this.bUP = new DevExpress.XtraBars.BarButtonItem();
            this.bDown = new DevExpress.XtraBars.BarButtonItem();
            this.rpSupplier = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repDetails = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grvD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grvD
            // 
            this.grvD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.grvD.GridControl = this.grd;
            this.grvD.IndicatorWidth = 35;
            this.grvD.Name = "grvD";
            this.grvD.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "SupplierID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Date";
            this.gridColumn3.FieldName = "TransDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 112;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Description";
            this.gridColumn4.FieldName = "Description";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 186;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Debit";
            this.gridColumn5.DisplayFormat.FormatString = "{0:c}";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Debit";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 105;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Credit";
            this.gridColumn6.DisplayFormat.FormatString = "{0:c}";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Credit";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 93;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Balance";
            this.gridColumn7.DisplayFormat.FormatString = "{0:c}";
            this.gridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn7.FieldName = "Balance";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 4;
            this.gridColumn7.Width = 106;
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.grvD;
            gridLevelNode1.RelationName = "pk_fk";
            this.grd.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl;
            this.grd.Name = "grd";
            this.grd.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repDetails});
            this.grd.Size = new System.Drawing.Size(1087, 558);
            this.grd.TabIndex = 4;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv,
            this.grvD});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colEmail});
            this.grv.GridControl = this.grd;
            this.grv.IndicatorWidth = 30;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Caption = "Supplier Name";
            this.colName.FieldName = "SupplierName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone No";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email ID";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDel,
            this.bFind,
            this.bPrint,
            this.bExport,
            this.bPDF,
            this.bXLSX,
            this.bPay,
            this.bUP,
            this.bDown});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 16;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpSupplier});
            this.ribbonControl.Size = new System.Drawing.Size(1087, 141);
            // 
            // bNew
            // 
            this.bNew.Caption = "New";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 1;
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 2;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDel
            // 
            this.bDel.Caption = "Delete";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 3;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            this.bDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDel_ItemClick);
            // 
            // bFind
            // 
            this.bFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bFind.Caption = "Find";
            this.bFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bFind.Glyph")));
            this.bFind.Id = 8;
            this.bFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFind.LargeGlyph")));
            this.bFind.Name = "bFind";
            this.bFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bFind_ItemClick);
            // 
            // bPrint
            // 
            this.bPrint.Caption = "Preview";
            this.bPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrint.Glyph")));
            this.bPrint.Id = 9;
            this.bPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrint.LargeGlyph")));
            this.bPrint.Name = "bPrint";
            this.bPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPrint_ItemClick);
            // 
            // bExport
            // 
            this.bExport.Caption = "Export";
            this.bExport.Glyph = ((System.Drawing.Image)(resources.GetObject("bExport.Glyph")));
            this.bExport.Id = 10;
            this.bExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bExport.LargeGlyph")));
            this.bExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bPDF, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLSX)});
            this.bExport.Name = "bExport";
            // 
            // bPDF
            // 
            this.bPDF.Caption = "Portable Document Format (PDF)";
            this.bPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("bPDF.Glyph")));
            this.bPDF.Id = 11;
            this.bPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPDF.LargeGlyph")));
            this.bPDF.Name = "bPDF";
            this.bPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPDF_ItemClick);
            // 
            // bXLSX
            // 
            this.bXLSX.Caption = "Microsoft Office Excel (XLSX)";
            this.bXLSX.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.Glyph")));
            this.bXLSX.Id = 12;
            this.bXLSX.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.LargeGlyph")));
            this.bXLSX.Name = "bXLSX";
            this.bXLSX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bXLSX_ItemClick);
            // 
            // bPay
            // 
            this.bPay.Caption = "Debit Payment";
            this.bPay.Glyph = ((System.Drawing.Image)(resources.GetObject("bPay.Glyph")));
            this.bPay.Id = 13;
            this.bPay.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPay.LargeGlyph")));
            this.bPay.Name = "bPay";
            this.bPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPay_ItemClick);
            // 
            // bUP
            // 
            this.bUP.Caption = "Up";
            this.bUP.Glyph = ((System.Drawing.Image)(resources.GetObject("bUP.Glyph")));
            this.bUP.Id = 14;
            this.bUP.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bUP.LargeGlyph")));
            this.bUP.Name = "bUP";
            this.bUP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bUP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bUP_ItemClick);
            // 
            // bDown
            // 
            this.bDown.Caption = "Down";
            this.bDown.Glyph = ((System.Drawing.Image)(resources.GetObject("bDown.Glyph")));
            this.bDown.Id = 15;
            this.bDown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDown.LargeGlyph")));
            this.bDown.Name = "bDown";
            this.bDown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.bDown.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDown_ItemClick);
            // 
            // rpSupplier
            // 
            this.rpSupplier.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rpSupplier.MergeOrder = 0;
            this.rpSupplier.Name = "rpSupplier";
            this.rpSupplier.Text = "Suppliers";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDel);
            this.ribbonPageGroup1.ItemLinks.Add(this.bPay, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Manage";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bUP);
            this.ribbonPageGroup2.ItemLinks.Add(this.bDown);
            this.ribbonPageGroup2.ItemLinks.Add(this.bFind, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Navigation";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bPrint);
            this.ribbonPageGroup3.ItemLinks.Add(this.bExport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Print && Export";
            // 
            // repDetails
            // 
            this.repDetails.AutoHeight = false;
            this.repDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repDetails.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "View Details", null, null, true)});
            this.repDetails.Name = "repDetails";
            this.repDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ucSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucSuppliers";
            this.Size = new System.Drawing.Size(1087, 699);
            ((System.ComponentModel.ISupportInitialize)(this.grvD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        private DevExpress.XtraBars.BarButtonItem bFind;
        private DevExpress.XtraBars.BarButtonItem bPrint;
        private DevExpress.XtraBars.BarSubItem bExport;
        private DevExpress.XtraBars.BarButtonItem bPDF;
        private DevExpress.XtraBars.BarButtonItem bXLSX;
        private DevExpress.XtraBars.BarButtonItem bPay;
        private DevExpress.XtraBars.BarButtonItem bUP;
        private DevExpress.XtraBars.BarButtonItem bDown;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSupplier;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grvD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repDetails;
    }
}
