namespace DVLD_PRO_1._0._0.Applications
{
    partial class frmReplaceLostOrDamagedLicenseApplication
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
            ctrlDriverLicenseInfoWithFilter1 = new Licenses.Controls.ctrlDriverLicenseInfoWithFilter();
            groupBox1 = new GroupBox();
            lblCreatedBy = new Label();
            label7 = new Label();
            lblApplicationFees = new Label();
            label9 = new Label();
            lblOldLicenseID = new Label();
            label2 = new Label();
            lblApplicationDate = new Label();
            label5 = new Label();
            lblPassedTests = new Label();
            lblRreplacedLicenseID = new Label();
            label16 = new Label();
            lblLRApplicationID = new Label();
            label4 = new Label();
            panel3 = new Panel();
            btnIssueReplacement = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            gbReplacementFor = new GroupBox();
            rbLostLicense = new RadioButton();
            rbDamagedLicense = new RadioButton();
            label14 = new Label();
            llShowLicenseInfo = new LinkLabel();
            llShowLicenseHistory = new LinkLabel();
            panel1 = new Panel();
            lblTitle = new Label();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            gbReplacementFor.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(8, 81);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(930, 655);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblApplicationFees);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblOldLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblApplicationDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(lblRreplacedLicenseID);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblLRApplicationID);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(33, 725);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 186);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info for License Replacement";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.FromArgb(29, 31, 56);
            lblCreatedBy.Location = new Point(610, 128);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(48, 28);
            lblCreatedBy.TabIndex = 52;
            lblCreatedBy.Text = "????";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(29, 31, 56);
            label7.Location = new Point(479, 128);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 51;
            label7.Text = "Created by :";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblApplicationFees.Location = new Point(214, 128);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(48, 28);
            lblApplicationFees.TabIndex = 50;
            lblApplicationFees.Text = "????";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(29, 31, 56);
            label9.Location = new Point(29, 128);
            label9.Name = "label9";
            label9.Size = new Size(179, 28);
            label9.TabIndex = 49;
            label9.Text = "Application Fees :";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOldLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblOldLicenseID.Location = new Point(610, 85);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(48, 28);
            lblOldLicenseID.TabIndex = 44;
            lblOldLicenseID.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(446, 85);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 43;
            label2.Text = "Old License ID :";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblApplicationDate.Location = new Point(214, 85);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(48, 28);
            lblApplicationDate.TabIndex = 42;
            lblApplicationDate.Text = "????";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(25, 85);
            label5.Name = "label5";
            label5.Size = new Size(183, 28);
            label5.TabIndex = 41;
            label5.Text = "Application Date :";
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
            // lblRreplacedLicenseID
            // 
            lblRreplacedLicenseID.AutoSize = true;
            lblRreplacedLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRreplacedLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblRreplacedLicenseID.Location = new Point(610, 46);
            lblRreplacedLicenseID.Name = "lblRreplacedLicenseID";
            lblRreplacedLicenseID.Size = new Size(48, 28);
            lblRreplacedLicenseID.TabIndex = 36;
            lblRreplacedLicenseID.Text = "????";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(29, 31, 56);
            label16.Location = new Point(393, 46);
            label16.Name = "label16";
            label16.Size = new Size(211, 28);
            label16.TabIndex = 35;
            label16.Text = "Replaced License ID :";
            // 
            // lblLRApplicationID
            // 
            lblLRApplicationID.AutoSize = true;
            lblLRApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLRApplicationID.ForeColor = Color.FromArgb(29, 31, 56);
            lblLRApplicationID.Location = new Point(214, 46);
            lblLRApplicationID.Name = "lblLRApplicationID";
            lblLRApplicationID.Size = new Size(48, 28);
            lblLRApplicationID.TabIndex = 28;
            lblLRApplicationID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(16, 46);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 19;
            label4.Text = "L.R.Application ID :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnIssueReplacement);
            panel3.Location = new Point(688, 920);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 56);
            panel3.TabIndex = 42;
            // 
            // btnIssueReplacement
            // 
            btnIssueReplacement.BackColor = Color.DarkGreen;
            btnIssueReplacement.FlatStyle = FlatStyle.Flat;
            btnIssueReplacement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueReplacement.ForeColor = Color.White;
            btnIssueReplacement.Image = Properties.Resources.save;
            btnIssueReplacement.Location = new Point(-7, -11);
            btnIssueReplacement.Name = "btnIssueReplacement";
            btnIssueReplacement.Padding = new Padding(10, 0, 0, 0);
            btnIssueReplacement.Size = new Size(266, 76);
            btnIssueReplacement.TabIndex = 30;
            btnIssueReplacement.Text = "   Issue Replacement";
            btnIssueReplacement.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssueReplacement.UseVisualStyleBackColor = false;
            btnIssueReplacement.Click += btnIssueReplacement_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(520, 920);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 41;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.close;
            btnClose.Location = new Point(-7, -11);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(10, 0, 0, 0);
            btnClose.Size = new Size(169, 76);
            btnClose.TabIndex = 30;
            btnClose.Text = "   Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // gbReplacementFor
            // 
            gbReplacementFor.Controls.Add(rbLostLicense);
            gbReplacementFor.Controls.Add(rbDamagedLicense);
            gbReplacementFor.Controls.Add(label14);
            gbReplacementFor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbReplacementFor.ForeColor = Color.FromArgb(29, 31, 56);
            gbReplacementFor.Location = new Point(498, 95);
            gbReplacementFor.Name = "gbReplacementFor";
            gbReplacementFor.Size = new Size(412, 105);
            gbReplacementFor.TabIndex = 53;
            gbReplacementFor.TabStop = false;
            gbReplacementFor.Text = "Replacement For";
            // 
            // rbLostLicense
            // 
            rbLostLicense.AutoSize = true;
            rbLostLicense.Location = new Point(30, 67);
            rbLostLicense.Name = "rbLostLicense";
            rbLostLicense.Size = new Size(144, 32);
            rbLostLicense.TabIndex = 42;
            rbLostLicense.TabStop = true;
            rbLostLicense.Text = "Lost License";
            rbLostLicense.UseVisualStyleBackColor = true;
            rbLostLicense.CheckedChanged += rbLostLicense_CheckedChanged;
            // 
            // rbDamagedLicense
            // 
            rbDamagedLicense.AutoSize = true;
            rbDamagedLicense.Location = new Point(30, 33);
            rbDamagedLicense.Name = "rbDamagedLicense";
            rbDamagedLicense.Size = new Size(193, 32);
            rbDamagedLicense.TabIndex = 41;
            rbDamagedLicense.TabStop = true;
            rbDamagedLicense.Text = "Damaged License";
            rbDamagedLicense.UseVisualStyleBackColor = true;
            rbDamagedLicense.CheckedChanged += rbDamagedLicense_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(29, 31, 56);
            label14.Location = new Point(968, 46);
            label14.Name = "label14";
            label14.Size = new Size(48, 28);
            label14.TabIndex = 40;
            label14.Text = "????";
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Font = new Font("Segoe UI", 12F);
            llShowLicenseInfo.Location = new Point(33, 933);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(218, 28);
            llShowLicenseInfo.TabIndex = 55;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Segoe UI", 12F);
            llShowLicenseHistory.Location = new Point(33, 902);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(203, 28);
            llShowLicenseHistory.TabIndex = 54;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(956, 85);
            panel1.TabIndex = 56;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(296, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 46);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "License Replacement";
            // 
            // frmReplaceLostOrDamagedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 983);
            Controls.Add(panel1);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(gbReplacementFor);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReplaceLostOrDamagedLicenseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Activated += frmReplaceLostOrDamagedLicenseApplication_Activated;
            Load += frmReplaceLostOrDamagedLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            gbReplacementFor.ResumeLayout(false);
            gbReplacementFor.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox groupBox1;
        private Label label7;
        private Label lblApplicationFees;
        private Label label9;
        private Label lblOldLicenseID;
        private Label label2;
        private Label lblApplicationDate;
        private Label label5;
        private Label lblPassedTests;
        private Label lblRreplacedLicenseID;
        private Label label16;
        private Label lblLRApplicationID;
        private Label label4;
        private Label lblCreatedBy;
        private Panel panel3;
        private Button btnIssueReplacement;
        private Panel panel2;
        private Button btnClose;
        private GroupBox gbReplacementFor;
        private RadioButton rbLostLicense;
        private RadioButton rbDamagedLicense;
        private Label label14;
        private LinkLabel llShowLicenseInfo;
        private LinkLabel llShowLicenseHistory;
        private Panel panel1;
        private Label lblTitle;
    }
}