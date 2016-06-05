namespace IMS.Forms
{
    partial class frmSuppliers
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lbMSG = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtEML = new DevExpress.XtraEditors.TextEdit();
            this.txtPHN = new DevExpress.XtraEditors.TextEdit();
            this.txtADR = new DevExpress.XtraEditors.TextEdit();
            this.txtCNM = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxvp = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lbMSG);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnOK);
            this.layoutControl1.Controls.Add(this.txtEML);
            this.layoutControl1.Controls.Add(this.txtPHN);
            this.layoutControl1.Controls.Add(this.txtADR);
            this.layoutControl1.Controls.Add(this.txtCNM);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1065, 216, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(532, 152);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lbMSG
            // 
            this.lbMSG.Location = new System.Drawing.Point(12, 120);
            this.lbMSG.Name = "lbMSG";
            this.lbMSG.Size = new System.Drawing.Size(334, 20);
            this.lbMSG.TabIndex = 10;
            this.lbMSG.Text = "label1";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(442, 108);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(350, 108);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 32);
            this.btnOK.StyleController = this.layoutControl1;
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "&Save";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtEML
            // 
            this.txtEML.Location = new System.Drawing.Point(58, 84);
            this.txtEML.Name = "txtEML";
            this.txtEML.Size = new System.Drawing.Size(462, 20);
            this.txtEML.StyleController = this.layoutControl1;
            this.txtEML.TabIndex = 7;
            // 
            // txtPHN
            // 
            this.txtPHN.Location = new System.Drawing.Point(58, 60);
            this.txtPHN.Name = "txtPHN";
            this.txtPHN.Properties.Mask.EditMask = "d";
            this.txtPHN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtPHN.Size = new System.Drawing.Size(462, 20);
            this.txtPHN.StyleController = this.layoutControl1;
            this.txtPHN.TabIndex = 6;
            // 
            // txtADR
            // 
            this.txtADR.Location = new System.Drawing.Point(58, 36);
            this.txtADR.Name = "txtADR";
            this.txtADR.Size = new System.Drawing.Size(462, 20);
            this.txtADR.StyleController = this.layoutControl1;
            this.txtADR.TabIndex = 5;
            // 
            // txtCNM
            // 
            this.txtCNM.Location = new System.Drawing.Point(58, 12);
            this.txtCNM.Name = "txtCNM";
            this.txtCNM.Size = new System.Drawing.Size(462, 20);
            this.txtCNM.StyleController = this.layoutControl1;
            this.txtCNM.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Please enter Name";
            this.dxvp.SetValidationRule(this.txtCNM, conditionValidationRule1);
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
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(532, 152);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCNM;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(512, 24);
            this.layoutControlItem1.Text = "Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtADR;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(512, 24);
            this.layoutControlItem2.Text = "Address:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPHN;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(512, 24);
            this.layoutControlItem3.Text = "Phone:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtEML;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(512, 24);
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(43, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnOK;
            this.layoutControlItem5.Location = new System.Drawing.Point(338, 96);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(82, 36);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(82, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(82, 36);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnCancel;
            this.layoutControlItem6.Location = new System.Drawing.Point(430, 96);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(82, 36);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(82, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(82, 36);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(420, 96);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 36);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(338, 12);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lbMSG;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(338, 24);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // frmSuppliers
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 152);
            this.Controls.Add(this.layoutControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suppliers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSupCus_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCNM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.TextEdit txtEML;
        private DevExpress.XtraEditors.TextEdit txtPHN;
        private DevExpress.XtraEditors.TextEdit txtADR;
        private DevExpress.XtraEditors.TextEdit txtCNM;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp;
        private System.Windows.Forms.Label lbMSG;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}