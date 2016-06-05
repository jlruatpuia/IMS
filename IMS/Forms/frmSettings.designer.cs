namespace IMS.Forms
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtSHN = new DevExpress.XtraEditors.TextEdit();
            this.txtEML = new DevExpress.XtraEditors.TextEdit();
            this.txtPHN = new DevExpress.XtraEditors.TextEdit();
            this.txtADR = new DevExpress.XtraEditors.TextEdit();
            this.txtSNM = new DevExpress.XtraEditors.TextEdit();
            this.txtWEB = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSHN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEML.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWEB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(548, 331);
            this.wizardControl1.Text = "Setup";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(488, 169);
            this.welcomeWizardPage1.Text = "Welcome to the settings wizard";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.layoutControl1);
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(488, 169);
            this.wizardPage1.Text = "Enter Shop details";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtSHN);
            this.layoutControl1.Controls.Add(this.txtEML);
            this.layoutControl1.Controls.Add(this.txtPHN);
            this.layoutControl1.Controls.Add(this.txtADR);
            this.layoutControl1.Controls.Add(this.txtSNM);
            this.layoutControl1.Controls.Add(this.txtWEB);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(837, 63, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(488, 169);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtSHN
            // 
            this.txtSHN.Location = new System.Drawing.Point(171, 134);
            this.txtSHN.Name = "txtSHN";
            this.txtSHN.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtSHN.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSHN.Size = new System.Drawing.Size(116, 20);
            this.txtSHN.StyleController = this.layoutControl1;
            this.txtSHN.TabIndex = 9;
            // 
            // txtEML
            // 
            this.txtEML.Location = new System.Drawing.Point(171, 84);
            this.txtEML.Name = "txtEML";
            this.txtEML.Properties.Mask.EditMask = "(\\w|[\\.\\-])+@(\\w|[\\-]+\\.)*(\\w|[\\-]){2,63}\\.[a-zA-Z]{2,4}";
            this.txtEML.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEML.Size = new System.Drawing.Size(305, 20);
            this.txtEML.StyleController = this.layoutControl1;
            this.txtEML.TabIndex = 7;
            // 
            // txtPHN
            // 
            this.txtPHN.Location = new System.Drawing.Point(171, 60);
            this.txtPHN.Name = "txtPHN";
            this.txtPHN.Size = new System.Drawing.Size(305, 20);
            this.txtPHN.StyleController = this.layoutControl1;
            this.txtPHN.TabIndex = 6;
            // 
            // txtADR
            // 
            this.txtADR.Location = new System.Drawing.Point(171, 36);
            this.txtADR.Name = "txtADR";
            this.txtADR.Size = new System.Drawing.Size(305, 20);
            this.txtADR.StyleController = this.layoutControl1;
            this.txtADR.TabIndex = 5;
            // 
            // txtSNM
            // 
            this.txtSNM.Location = new System.Drawing.Point(171, 12);
            this.txtSNM.Name = "txtSNM";
            this.txtSNM.Size = new System.Drawing.Size(305, 20);
            this.txtSNM.StyleController = this.layoutControl1;
            this.txtSNM.TabIndex = 4;
            // 
            // txtWEB
            // 
            this.txtWEB.Location = new System.Drawing.Point(171, 108);
            this.txtWEB.Name = "txtWEB";
            this.txtWEB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("txtWEB.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtWEB.Size = new System.Drawing.Size(305, 22);
            this.txtWEB.StyleController = this.layoutControl1;
            this.txtWEB.TabIndex = 8;
            this.txtWEB.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtWEB_ButtonClick);
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
            this.simpleLabelItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(488, 169);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSNM;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(468, 24);
            this.layoutControlItem1.Text = "Shop Name:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(156, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtADR;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(468, 24);
            this.layoutControlItem2.Text = "Address:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(156, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPHN;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(468, 24);
            this.layoutControlItem3.Text = "Phone No:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(156, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtEML;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(468, 24);
            this.layoutControlItem4.Text = "Email:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(156, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtWEB;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(468, 26);
            this.layoutControlItem5.Text = "Website:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(156, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtSHN;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(279, 27);
            this.layoutControlItem6.Text = "Shop Shortname:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(156, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(279, 122);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(189, 27);
            this.simpleLabelItem1.Text = "This will be used on your Receipt";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(156, 13);
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(488, 169);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 331);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSHN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEML.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtADR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSNM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWEB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtEML;
        private DevExpress.XtraEditors.TextEdit txtPHN;
        private DevExpress.XtraEditors.TextEdit txtADR;
        private DevExpress.XtraEditors.TextEdit txtSNM;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.TextEdit txtSHN;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraEditors.ButtonEdit txtWEB;
    }
}