namespace IMS.Controls
{
    partial class ucProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProducts));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.bAddExt = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDelete = new DevExpress.XtraBars.BarButtonItem();
            this.beiView = new DevExpress.XtraBars.BarEditItem();
            this.rdoView = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bFind = new DevExpress.XtraBars.BarCheckItem();
            this.bPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bExport = new DevExpress.XtraBars.BarSubItem();
            this.bPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bXLS = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bExpand = new DevExpress.XtraBars.BarCheckItem();
            this.rpProducts = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgView = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgPrint = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTBV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgCollSmall = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bAddNew,
            this.bAddExt,
            this.bEdit,
            this.bDelete,
            this.beiView,
            this.barButtonItem1,
            this.bFind,
            this.bPrint,
            this.bExport,
            this.bPDF,
            this.bXLS,
            this.barButtonItem2,
            this.barButtonItem3,
            this.bExpand});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 15;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpProducts});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rdoView});
            this.ribbonControl.Size = new System.Drawing.Size(768, 141);
            // 
            // bAddNew
            // 
            this.bAddNew.Caption = "Add New";
            this.bAddNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bAddNew.Glyph")));
            this.bAddNew.Id = 1;
            this.bAddNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bAddNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bAddNew.LargeGlyph")));
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bAddNew_ItemClick);
            // 
            // bAddExt
            // 
            this.bAddExt.Caption = "Add Existing";
            this.bAddExt.Glyph = ((System.Drawing.Image)(resources.GetObject("bAddExt.Glyph")));
            this.bAddExt.Id = 2;
            this.bAddExt.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.N));
            this.bAddExt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bAddExt.LargeGlyph")));
            this.bAddExt.Name = "bAddExt";
            this.bAddExt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bAddExt_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 3;
            this.bEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // bDelete
            // 
            this.bDelete.Caption = "Delete";
            this.bDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelete.Glyph")));
            this.bDelete.Id = 4;
            this.bDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete));
            this.bDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelete.LargeGlyph")));
            this.bDelete.Name = "bDelete";
            this.bDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDelete_ItemClick);
            // 
            // beiView
            // 
            this.beiView.Caption = "View By:";
            this.beiView.Edit = this.rdoView;
            this.beiView.EditHeight = 60;
            this.beiView.Id = 5;
            this.beiView.Name = "beiView";
            this.beiView.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            this.beiView.Width = 100;
            // 
            // rdoView
            // 
            this.rdoView.AllowFocused = false;
            this.rdoView.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.rdoView.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.rdoView.AppearanceDisabled.Options.UseBackColor = true;
            this.rdoView.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.rdoView.AppearanceFocused.Options.UseBackColor = true;
            this.rdoView.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.rdoView.AppearanceReadOnly.Options.UseBackColor = true;
            this.rdoView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdoView.Columns = 1;
            this.rdoView.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Categorized"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Uncategorized")});
            this.rdoView.Name = "rdoView";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bFind
            // 
            this.bFind.Caption = "Find";
            this.bFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bFind.Glyph")));
            this.bFind.Id = 7;
            this.bFind.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.bFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFind.LargeGlyph")));
            this.bFind.Name = "bFind";
            this.bFind.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bFind_CheckedChanged);
            // 
            // bPrint
            // 
            this.bPrint.Caption = "Print";
            this.bPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrint.Glyph")));
            this.bPrint.Id = 8;
            this.bPrint.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P));
            this.bPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrint.LargeGlyph")));
            this.bPrint.Name = "bPrint";
            this.bPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPrint_ItemClick);
            // 
            // bExport
            // 
            this.bExport.Caption = "Export";
            this.bExport.Glyph = ((System.Drawing.Image)(resources.GetObject("bExport.Glyph")));
            this.bExport.Id = 9;
            this.bExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bExport.LargeGlyph")));
            this.bExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLS)});
            this.bExport.Name = "bExport";
            // 
            // bPDF
            // 
            this.bPDF.Caption = "PDF";
            this.bPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("bPDF.Glyph")));
            this.bPDF.Id = 10;
            this.bPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPDF.LargeGlyph")));
            this.bPDF.Name = "bPDF";
            this.bPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPDF_ItemClick);
            // 
            // bXLS
            // 
            this.bXLS.Caption = "XLS";
            this.bXLS.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLS.Glyph")));
            this.bXLS.Id = 11;
            this.bXLS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLS.LargeGlyph")));
            this.bXLS.Name = "bXLS";
            this.bXLS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bXLS_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Expand";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 12;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bExpand
            // 
            this.bExpand.Caption = "Expand";
            this.bExpand.Glyph = ((System.Drawing.Image)(resources.GetObject("bExpand.Glyph")));
            this.bExpand.Id = 14;
            this.bExpand.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bExpand.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bExpand.LargeGlyph")));
            this.bExpand.Name = "bExpand";
            this.bExpand.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bExpand_CheckedChanged);
            // 
            // rpProducts
            // 
            this.rpProducts.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgProducts,
            this.rpgView,
            this.rpgPrint});
            this.rpProducts.MergeOrder = 0;
            this.rpProducts.Name = "rpProducts";
            this.rpProducts.Text = "Products";
            // 
            // rpgProducts
            // 
            this.rpgProducts.ItemLinks.Add(this.bAddNew);
            this.rpgProducts.ItemLinks.Add(this.bAddExt);
            this.rpgProducts.ItemLinks.Add(this.bEdit);
            this.rpgProducts.ItemLinks.Add(this.bDelete);
            this.rpgProducts.Name = "rpgProducts";
            this.rpgProducts.ShowCaptionButton = false;
            this.rpgProducts.Text = "Products";
            // 
            // rpgView
            // 
            this.rpgView.ItemLinks.Add(this.bFind);
            this.rpgView.ItemLinks.Add(this.bExpand);
            this.rpgView.Name = "rpgView";
            this.rpgView.ShowCaptionButton = false;
            this.rpgView.Text = "View";
            // 
            // rpgPrint
            // 
            this.rpgPrint.ItemLinks.Add(this.bPrint);
            this.rpgPrint.ItemLinks.Add(this.bExport);
            this.rpgPrint.Name = "rpgPrint";
            this.rpgPrint.ShowCaptionButton = false;
            this.rpgPrint.Text = "Print && Export";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(768, 362);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCAT,
            this.colPNM,
            this.colBVL,
            this.colSVL,
            this.colQTY,
            this.colTBV,
            this.colTSV});
            this.grv.GridControl = this.grd;
            this.grv.GroupCount = 1;
            this.grv.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBuyingValue", this.colTBV, "{0:C2}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSellingValue", this.colTSV, "{0:C2}")});
            this.grv.IndicatorWidth = 40;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowFooter = true;
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCAT, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grv_CustomDrawRowIndicator);
            // 
            // colCAT
            // 
            this.colCAT.Caption = "Category";
            this.colCAT.FieldName = "CategoryName";
            this.colCAT.Name = "colCAT";
            this.colCAT.OptionsColumn.AllowEdit = false;
            this.colCAT.OptionsColumn.AllowFocus = false;
            this.colCAT.OptionsColumn.ReadOnly = true;
            this.colCAT.Visible = true;
            this.colCAT.VisibleIndex = 0;
            // 
            // colPNM
            // 
            this.colPNM.Caption = "Product Name";
            this.colPNM.FieldName = "ProductName";
            this.colPNM.Name = "colPNM";
            this.colPNM.OptionsColumn.AllowEdit = false;
            this.colPNM.OptionsColumn.AllowFocus = false;
            this.colPNM.OptionsColumn.ReadOnly = true;
            this.colPNM.Visible = true;
            this.colPNM.VisibleIndex = 0;
            // 
            // colBVL
            // 
            this.colBVL.Caption = "Buying Value";
            this.colBVL.DisplayFormat.FormatString = "{0:C2}";
            this.colBVL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBVL.FieldName = "BuyingValue";
            this.colBVL.Name = "colBVL";
            this.colBVL.OptionsColumn.AllowEdit = false;
            this.colBVL.OptionsColumn.AllowFocus = false;
            this.colBVL.OptionsColumn.ReadOnly = true;
            this.colBVL.Visible = true;
            this.colBVL.VisibleIndex = 1;
            // 
            // colSVL
            // 
            this.colSVL.Caption = "Selling Value";
            this.colSVL.DisplayFormat.FormatString = "{0:C2}";
            this.colSVL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSVL.FieldName = "SellingValue";
            this.colSVL.Name = "colSVL";
            this.colSVL.OptionsColumn.AllowEdit = false;
            this.colSVL.OptionsColumn.AllowFocus = false;
            this.colSVL.OptionsColumn.ReadOnly = true;
            this.colSVL.Visible = true;
            this.colSVL.VisibleIndex = 2;
            // 
            // colQTY
            // 
            this.colQTY.Caption = "Total Quantity";
            this.colQTY.FieldName = "TotalQuantity";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.AllowFocus = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 3;
            // 
            // colTBV
            // 
            this.colTBV.Caption = "Total Buying Value";
            this.colTBV.DisplayFormat.FormatString = "{0:C2}";
            this.colTBV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTBV.FieldName = "TotalBuyingValue";
            this.colTBV.Name = "colTBV";
            this.colTBV.OptionsColumn.AllowEdit = false;
            this.colTBV.OptionsColumn.AllowFocus = false;
            this.colTBV.OptionsColumn.ReadOnly = true;
            this.colTBV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalBuyingValue", "{0:C2}")});
            this.colTBV.Visible = true;
            this.colTBV.VisibleIndex = 4;
            // 
            // colTSV
            // 
            this.colTSV.Caption = "Total Selling Value";
            this.colTSV.DisplayFormat.FormatString = "{0:C2}";
            this.colTSV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTSV.FieldName = "TotalSellingValue";
            this.colTSV.Name = "colTSV";
            this.colTSV.OptionsColumn.AllowEdit = false;
            this.colTSV.OptionsColumn.AllowFocus = false;
            this.colTSV.OptionsColumn.ReadOnly = true;
            this.colTSV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalSellingValue", "{0:C2}")});
            this.colTSV.Visible = true;
            this.colTSV.VisibleIndex = 5;
            // 
            // imgCollSmall
            // 
            this.imgCollSmall.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollSmall.ImageStream")));
            this.imgCollSmall.InsertGalleryImage("squeeze_16x16.png", "office2013/actions/squeeze_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/squeeze_16x16.png"), 0);
            this.imgCollSmall.Images.SetKeyName(0, "squeeze_16x16.png");
            this.imgCollSmall.InsertGalleryImage("stretch_16x16.png", "office2013/actions/stretch_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/stretch_16x16.png"), 1);
            this.imgCollSmall.Images.SetKeyName(1, "stretch_16x16.png");
            this.imgCollSmall.InsertGalleryImage("squeeze_32x32.png", "office2013/actions/squeeze_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/squeeze_32x32.png"), 2);
            this.imgCollSmall.Images.SetKeyName(2, "squeeze_32x32.png");
            this.imgCollSmall.InsertGalleryImage("stretch_32x32.png", "office2013/actions/stretch_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/stretch_32x32.png"), 3);
            this.imgCollSmall.Images.SetKeyName(3, "stretch_32x32.png");
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(768, 503);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgProducts;
        private DevExpress.XtraBars.BarButtonItem bAddNew;
        private DevExpress.XtraBars.BarButtonItem bAddExt;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDelete;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        public DevExpress.XtraBars.Ribbon.RibbonPage rpProducts;
        private DevExpress.XtraBars.BarEditItem beiView;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup rdoView;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgView;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colCAT;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colBVL;
        private DevExpress.XtraGrid.Columns.GridColumn colSVL;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colTBV;
        private DevExpress.XtraGrid.Columns.GridColumn colTSV;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem bFind;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgPrint;
        private DevExpress.XtraBars.BarButtonItem bPrint;
        private DevExpress.XtraBars.BarSubItem bExport;
        private DevExpress.XtraBars.BarButtonItem bPDF;
        private DevExpress.XtraBars.BarButtonItem bXLS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarCheckItem bExpand;
        private DevExpress.Utils.ImageCollection imgCollSmall;
    }
}
