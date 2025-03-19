namespace DVLD_PRO_1._0._0.Applications.Local_Driving_License
{
    partial class ctrlDrivingLicenseApplicationInfo
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
            ctrlApplicationBasicInfo1 = new Controls.ctrlApplicationBasicInfo();
            groupBox1 = new GroupBox();
            llShowLicenseInfo = new LinkLabel();
            lblPassedTests = new Label();
            label18 = new Label();
            lblAppliedForLicense = new Label();
            label16 = new Label();
            lblDLAppID = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlApplicationBasicInfo1
            // 
            ctrlApplicationBasicInfo1.Location = new Point(3, 167);
            ctrlApplicationBasicInfo1.Name = "ctrlApplicationBasicInfo1";
            ctrlApplicationBasicInfo1.Size = new Size(1080, 307);
            ctrlApplicationBasicInfo1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(llShowLicenseInfo);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblAppliedForLicense);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblDLAppID);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(15, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1048, 143);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driving License Application Info";
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.LinkColor = Color.FromArgb(192, 192, 255);
            llShowLicenseInfo.Location = new Point(858, 93);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(184, 28);
            llShowLicenseInfo.TabIndex = 41;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show License  Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassedTests.ForeColor = Color.FromArgb(29, 31, 56);
            lblPassedTests.Location = new Point(968, 46);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(48, 28);
            lblPassedTests.TabIndex = 40;
            lblPassedTests.Text = "????";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(29, 31, 56);
            label18.Location = new Point(822, 46);
            label18.Name = "label18";
            label18.Size = new Size(140, 28);
            label18.TabIndex = 39;
            label18.Text = "Passed Tests :";
            // 
            // lblAppliedForLicense
            // 
            lblAppliedForLicense.AutoSize = true;
            lblAppliedForLicense.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppliedForLicense.ForeColor = Color.FromArgb(29, 31, 56);
            lblAppliedForLicense.Location = new Point(506, 46);
            lblAppliedForLicense.Name = "lblAppliedForLicense";
            lblAppliedForLicense.Size = new Size(48, 28);
            lblAppliedForLicense.TabIndex = 36;
            lblAppliedForLicense.Text = "????";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(29, 31, 56);
            label16.Location = new Point(287, 46);
            label16.Name = "label16";
            label16.Size = new Size(213, 28);
            label16.TabIndex = 35;
            label16.Text = "Applied  For License :";
            // 
            // lblDLAppID
            // 
            lblDLAppID.AutoSize = true;
            lblDLAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDLAppID.ForeColor = Color.FromArgb(29, 31, 56);
            lblDLAppID.Location = new Point(150, 46);
            lblDLAppID.Name = "lblDLAppID";
            lblDLAppID.Size = new Size(48, 28);
            lblDLAppID.TabIndex = 28;
            lblDLAppID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(22, 46);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 19;
            label4.Text = "D.L.App ID :";
            // 
            // ctrlDrivingLicenseApplicationInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(ctrlApplicationBasicInfo1);
            Name = "ctrlDrivingLicenseApplicationInfo";
            Size = new Size(1082, 483);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlApplicationBasicInfo ctrlApplicationBasicInfo1;
        private GroupBox groupBox1;
        private LinkLabel llShowLicenseInfo;
        private Label lblPassedTests;
        private Label label18;
        private Label lblAppliedForLicense;
        private Label label16;
        private Label lblDLAppID;
        private Label label4;
    }
}
