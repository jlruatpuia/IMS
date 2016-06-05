namespace Skynet.Controls
{
    partial class ucUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUsers));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bFind = new DevExpress.XtraBars.BarButtonItem();
            this.bPrint = new DevExpress.XtraBars.BarButtonItem();
            this.bExport = new DevExpress.XtraBars.BarSubItem();
            this.bPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.bPWD = new DevExpress.XtraBars.BarButtonItem();
            this.bUP = new DevExpress.XtraBars.BarButtonItem();
            this.bDown = new DevExpress.XtraBars.BarButtonItem();
            this.bDac = new DevExpress.XtraBars.BarButtonItem();
            this.pop = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.rpCategory = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPWD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bFind,
            this.bPrint,
            this.bExport,
            this.bPDF,
            this.bXLSX,
            this.bPWD,
            this.bUP,
            this.bDown,
            this.bDac,
            this.bDel});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 22;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCategory});
            this.ribbonControl.Size = new System.Drawing.Size(708, 141);
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
            // 
            // bFind
            // 
            this.bFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bFind.Caption = "Find";
            this.bFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bFind.Glyph")));
            this.bFind.Id = 8;
            this.bFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFind.LargeGlyph")));
            this.bFind.Name = "bFind";
            // 
            // bPrint
            // 
            this.bPrint.Caption = "Preview";
            this.bPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrint.Glyph")));
            this.bPrint.Id = 9;
            this.bPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrint.LargeGlyph")));
            this.bPrint.Name = "bPrint";
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
            // 
            // bXLSX
            // 
            this.bXLSX.Caption = "Microsoft Office Excel (XLSX)";
            this.bXLSX.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.Glyph")));
            this.bXLSX.Id = 12;
            this.bXLSX.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.LargeGlyph")));
            this.bXLSX.Name = "bXLSX";
            // 
            // bPWD
            // 
            this.bPWD.Caption = "Change Password";
            this.bPWD.Glyph = ((System.Drawing.Image)(resources.GetObject("bPWD.Glyph")));
            this.bPWD.Id = 13;
            this.bPWD.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPWD.LargeGlyph")));
            this.bPWD.Name = "bPWD";
            // 
            // bUP
            // 
            this.bUP.Caption = "Up";
            this.bUP.Glyph = ((System.Drawing.Image)(resources.GetObject("bUP.Glyph")));
            this.bUP.Id = 14;
            this.bUP.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bUP.LargeGlyph")));
            this.bUP.Name = "bUP";
            this.bUP.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bDown
            // 
            this.bDown.Caption = "Down";
            this.bDown.Glyph = ((System.Drawing.Image)(resources.GetObject("bDown.Glyph")));
            this.bDown.Id = 15;
            this.bDown.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDown.LargeGlyph")));
            this.bDown.Name = "bDown";
            this.bDown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
            // 
            // bDac
            // 
            this.bDac.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bDac.Caption = "Deactivate";
            this.bDac.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.bDac.DropDownControl = this.pop;
            this.bDac.Glyph = ((System.Drawing.Image)(resources.GetObject("bDac.Glyph")));
            this.bDac.Id = 20;
            this.bDac.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDac.LargeGlyph")));
            this.bDac.Name = "bDac";
            // 
            // pop
            // 
            this.pop.ItemLinks.Add(this.bDel);
            this.pop.Name = "pop";
            this.pop.Ribbon = this.ribbonControl;
            // 
            // bDel
            // 
            this.bDel.Caption = "Delete";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 21;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            // 
            // rpCategory
            // 
            this.rpCategory.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rpCategory.MergeOrder = 0;
            this.rpCategory.Name = "rpCategory";
            this.rpCategory.Text = "Users";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDac);
            this.ribbonPageGroup1.ItemLinks.Add(this.bPWD, true);
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
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(708, 444);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUID,
            this.colUNM,
            this.colPWD,
            this.colATP});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colUID
            // 
            this.colUID.Caption = "ID";
            this.colUID.FieldName = "ID";
            this.colUID.Name = "colUID";
            this.colUID.OptionsColumn.AllowEdit = false;
            this.colUID.OptionsColumn.AllowFocus = false;
            this.colUID.OptionsColumn.ReadOnly = true;
            // 
            // colUNM
            // 
            this.colUNM.Caption = "Username";
            this.colUNM.FieldName = "Username";
            this.colUNM.Name = "colUNM";
            this.colUNM.OptionsColumn.AllowEdit = false;
            this.colUNM.OptionsColumn.AllowFocus = false;
            this.colUNM.OptionsColumn.ReadOnly = true;
            this.colUNM.Visible = true;
            this.colUNM.VisibleIndex = 0;
            // 
            // colPWD
            // 
            this.colPWD.Caption = "Password";
            this.colPWD.FieldName = "Password";
            this.colPWD.Name = "colPWD";
            this.colPWD.OptionsColumn.AllowEdit = false;
            this.colPWD.OptionsColumn.AllowFocus = false;
            this.colPWD.OptionsColumn.ReadOnly = true;
            this.colPWD.Visible = true;
            this.colPWD.VisibleIndex = 1;
            // 
            // colATP
            // 
            this.colATP.Caption = "Account Type";
            this.colATP.FieldName = "AcType";
            this.colATP.Name = "colATP";
            this.colATP.OptionsColumn.AllowEdit = false;
            this.colATP.OptionsColumn.AllowFocus = false;
            this.colATP.OptionsColumn.ReadOnly = true;
            this.colATP.Visible = true;
            this.colATP.VisibleIndex = 2;
            // 
            // ucUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl);
            this.Name = "ucUsers";
            this.Size = new System.Drawing.Size(708, 585);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bFind;
        private DevExpress.XtraBars.BarButtonItem bPrint;
        private DevExpress.XtraBars.BarSubItem bExport;
        private DevExpress.XtraBars.BarButtonItem bPDF;
        private DevExpress.XtraBars.BarButtonItem bXLSX;
        private DevExpress.XtraBars.BarButtonItem bPWD;
        private DevExpress.XtraBars.BarButtonItem bUP;
        private DevExpress.XtraBars.BarButtonItem bDown;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colUID;
        private DevExpress.XtraGrid.Columns.GridColumn colUNM;
        private DevExpress.XtraGrid.Columns.GridColumn colPWD;
        private DevExpress.XtraGrid.Columns.GridColumn colATP;
        private DevExpress.XtraBars.BarButtonItem bDac;
        private DevExpress.XtraBars.PopupMenu pop;
        private DevExpress.XtraBars.BarButtonItem bDel;
    }
}
