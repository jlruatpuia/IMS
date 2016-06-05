namespace IMS.Forms
{
    partial class frmDeleteProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQTY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueCAT = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCatID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCAT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.grd);
            this.layoutControl1.Controls.Add(this.lueCAT);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1318, 398, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(873, 492);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(791, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 22);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(691, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 22);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grd
            // 
            this.grd.Location = new System.Drawing.Point(12, 36);
            this.grd.MainView = this.grv;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(849, 418);
            this.grd.TabIndex = 5;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPID,
            this.colPNM,
            this.colBVL,
            this.colSVL,
            this.colQTY,
            this.colBCD});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsSelection.MultiSelect = true;
            this.grv.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grv.OptionsView.ShowGroupPanel = false;
            // 
            // colPID
            // 
            this.colPID.Caption = "gridColumn1";
            this.colPID.FieldName = "ID";
            this.colPID.Name = "colPID";
            this.colPID.OptionsColumn.AllowEdit = false;
            this.colPID.OptionsColumn.AllowFocus = false;
            this.colPID.OptionsColumn.ReadOnly = true;
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
            this.colPNM.VisibleIndex = 1;
            this.colPNM.Width = 158;
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
            this.colBVL.VisibleIndex = 2;
            this.colBVL.Width = 158;
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
            this.colSVL.VisibleIndex = 3;
            this.colSVL.Width = 158;
            // 
            // colQTY
            // 
            this.colQTY.Caption = "Quantity";
            this.colQTY.FieldName = "Quantity";
            this.colQTY.Name = "colQTY";
            this.colQTY.OptionsColumn.AllowEdit = false;
            this.colQTY.OptionsColumn.AllowFocus = false;
            this.colQTY.OptionsColumn.ReadOnly = true;
            this.colQTY.Visible = true;
            this.colQTY.VisibleIndex = 4;
            this.colQTY.Width = 158;
            // 
            // colBCD
            // 
            this.colBCD.Caption = "Bar Code";
            this.colBCD.FieldName = "BarCode";
            this.colBCD.Name = "colBCD";
            this.colBCD.OptionsColumn.AllowEdit = false;
            this.colBCD.OptionsColumn.AllowFocus = false;
            this.colBCD.OptionsColumn.ReadOnly = true;
            this.colBCD.Visible = true;
            this.colBCD.VisibleIndex = 5;
            this.colBCD.Width = 166;
            // 
            // lueCAT
            // 
            this.lueCAT.Location = new System.Drawing.Point(96, 12);
            this.lueCAT.Name = "lueCAT";
            this.lueCAT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCAT.Properties.NullText = "[Select Category]";
            this.lueCAT.Properties.View = this.searchLookUpEdit1View;
            this.lueCAT.Size = new System.Drawing.Size(765, 20);
            this.lueCAT.StyleController = this.layoutControl1;
            this.lueCAT.TabIndex = 4;
            this.lueCAT.EditValueChanged += new System.EventHandler(this.lueCAT_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCatID,
            this.colCatName});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCatID
            // 
            this.colCatID.Caption = "gridColumn1";
            this.colCatID.FieldName = "ID";
            this.colCatID.Name = "colCatID";
            // 
            // colCatName
            // 
            this.colCatName.Caption = "Category";
            this.colCatName.FieldName = "CategoryName";
            this.colCatName.Name = "colCatName";
            this.colCatName.Visible = true;
            this.colCatName.VisibleIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 492);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lueCAT;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(853, 24);
            this.layoutControlItem1.Text = "Select Category:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grd;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 422);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDelete;
            this.layoutControlItem3.Location = new System.Drawing.Point(679, 446);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(779, 446);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(74, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 446);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(679, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(769, 446);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 26);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmDeleteProduct
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 492);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteProduct";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Product";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCAT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SearchLookUpEdit lueCAT;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colCatID;
        private DevExpress.XtraGrid.Columns.GridColumn colCatName;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colPID;
        private DevExpress.XtraGrid.Columns.GridColumn colPNM;
        private DevExpress.XtraGrid.Columns.GridColumn colBVL;
        private DevExpress.XtraGrid.Columns.GridColumn colSVL;
        private DevExpress.XtraGrid.Columns.GridColumn colQTY;
        private DevExpress.XtraGrid.Columns.GridColumn colBCD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}