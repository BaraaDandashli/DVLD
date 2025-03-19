namespace DVLD_PRO_1._0._0.Applications.Renew_Local_License
{
    partial class frmRenewLocalDrivingLicenseApplication
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
            txtNotes = new TextBox();
            label18 = new Label();
            lblTotalFees = new Label();
            label20 = new Label();
            lblLicenseFees = new Label();
            label22 = new Label();
            lblCreatedBy = new Label();
            label7 = new Label();
            lblApplicationFees = new Label();
            label9 = new Label();
            lblExpirationDate = new Label();
            label11 = new Label();
            lblIssueDate = new Label();
            label13 = new Label();
            lblOldLicenseID = new Label();
            label2 = new Label();
            lblApplicationDate = new Label();
            label5 = new Label();
            lblPassedTests = new Label();
            lblRenewedLicenseID = new Label();
            label16 = new Label();
            lblRLApplicationID = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label14 = new Label();
            panel3 = new Panel();
            btnRenew = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            llShowLicenseHistory = new LinkLabel();
            llShowLicenseInfo = new LinkLabel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(10, 82);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(937, 678);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNotes);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblTotalFees);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(lblLicenseFees);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblApplicationFees);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(lblOldLicenseID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblApplicationDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lblPassedTests);
            groupBox1.Controls.Add(lblRenewedLicenseID);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblRLApplicationID);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(34, 727);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 304);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application New License Info";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.White;
            txtNotes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.FromArgb(29, 31, 56);
            txtNotes.Location = new Point(214, 240);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(540, 38);
            txtNotes.TabIndex = 31;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(29, 31, 56);
            label18.Location = new Point(129, 241);
            label18.Name = "label18";
            label18.Size = new Size(79, 28);
            label18.TabIndex = 57;
            label18.Text = "Notes :";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblTotalFees.Location = new Point(610, 202);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(48, 28);
            lblTotalFees.TabIndex = 56;
            lblTotalFees.Text = "????";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(29, 31, 56);
            label20.Location = new Point(487, 202);
            label20.Name = "label20";
            label20.Size = new Size(117, 28);
            label20.TabIndex = 55;
            label20.Text = "Total Fees :";
            // 
            // lblLicenseFees
            // 
            lblLicenseFees.AutoSize = true;
            lblLicenseFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblLicenseFees.Location = new Point(214, 202);
            lblLicenseFees.Name = "lblLicenseFees";
            lblLicenseFees.Size = new Size(48, 28);
            lblLicenseFees.TabIndex = 54;
            lblLicenseFees.Text = "????";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(29, 31, 56);
            label22.Location = new Point(69, 202);
            label22.Name = "label22";
            label22.Size = new Size(139, 28);
            label22.TabIndex = 53;
            label22.Text = "License Fees :";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.FromArgb(29, 31, 56);
            lblCreatedBy.Location = new Point(610, 163);
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
            label7.Location = new Point(479, 163);
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
            lblApplicationFees.Location = new Point(214, 163);
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
            label9.Location = new Point(29, 163);
            label9.Name = "label9";
            label9.Size = new Size(179, 28);
            label9.TabIndex = 49;
            label9.Text = "Application Fees :";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpirationDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblExpirationDate.Location = new Point(610, 124);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(48, 28);
            lblExpirationDate.TabIndex = 48;
            lblExpirationDate.Text = "????";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(29, 31, 56);
            label11.Location = new Point(433, 124);
            label11.Name = "label11";
            label11.Size = new Size(171, 28);
            label11.TabIndex = 47;
            label11.Text = "Expiration Date :";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblIssueDate.Location = new Point(214, 124);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(48, 28);
            lblIssueDate.TabIndex = 46;
            lblIssueDate.Text = "????";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(29, 31, 56);
            label13.Location = new Point(87, 124);
            label13.Name = "label13";
            label13.Size = new Size(121, 28);
            label13.TabIndex = 45;
            label13.Text = "Issue Date :";
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
            // lblRenewedLicenseID
            // 
            lblRenewedLicenseID.AutoSize = true;
            lblRenewedLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRenewedLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblRenewedLicenseID.Location = new Point(610, 46);
            lblRenewedLicenseID.Name = "lblRenewedLicenseID";
            lblRenewedLicenseID.Size = new Size(48, 28);
            lblRenewedLicenseID.TabIndex = 36;
            lblRenewedLicenseID.Text = "????";
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
            label16.Text = "Renewed License ID :";
            // 
            // lblRLApplicationID
            // 
            lblRLApplicationID.AutoSize = true;
            lblRLApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRLApplicationID.ForeColor = Color.FromArgb(29, 31, 56);
            lblRLApplicationID.Location = new Point(214, 46);
            lblRLApplicationID.Name = "lblRLApplicationID";
            lblRLApplicationID.Size = new Size(48, 28);
            lblRLApplicationID.TabIndex = 28;
            lblRLApplicationID.Text = "????";
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
            label4.Text = "R.L.Application ID :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label14);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(988, 85);
            panel1.TabIndex = 38;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(236, 19);
            label14.Name = "label14";
            label14.Size = new Size(478, 46);
            label14.TabIndex = 5;
            label14.Text = "Renew License Applications";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRenew);
            panel3.Location = new Point(818, 813);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 40;
            // 
            // btnRenew
            // 
            btnRenew.BackColor = Color.DarkGreen;
            btnRenew.FlatStyle = FlatStyle.Flat;
            btnRenew.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRenew.ForeColor = Color.White;
            btnRenew.Image = Properties.Resources.save;
            btnRenew.Location = new Point(-7, -11);
            btnRenew.Name = "btnRenew";
            btnRenew.Padding = new Padding(10, 0, 0, 0);
            btnRenew.Size = new Size(169, 76);
            btnRenew.TabIndex = 30;
            btnRenew.Text = "   Renew";
            btnRenew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRenew.UseVisualStyleBackColor = false;
            btnRenew.Click += btnRenew_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(818, 882);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 39;
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
            // llShowLicenseHistory
            // 
            llShowLicenseHistory.AutoSize = true;
            llShowLicenseHistory.Font = new Font("Segoe UI", 12F);
            llShowLicenseHistory.Location = new Point(693, 141);
            llShowLicenseHistory.Name = "llShowLicenseHistory";
            llShowLicenseHistory.Size = new Size(203, 28);
            llShowLicenseHistory.TabIndex = 43;
            llShowLicenseHistory.TabStop = true;
            llShowLicenseHistory.Text = "Show Licenses History";
            llShowLicenseHistory.LinkClicked += llShowLicenseHistory_LinkClicked;
            // 
            // llShowLicenseInfo
            // 
            llShowLicenseInfo.AutoSize = true;
            llShowLicenseInfo.Font = new Font("Segoe UI", 12F);
            llShowLicenseInfo.Location = new Point(685, 172);
            llShowLicenseInfo.Name = "llShowLicenseInfo";
            llShowLicenseInfo.Size = new Size(218, 28);
            llShowLicenseInfo.TabIndex = 44;
            llShowLicenseInfo.TabStop = true;
            llShowLicenseInfo.Text = "Show New Licenses Info";
            llShowLicenseInfo.LinkClicked += llShowLicenseInfo_LinkClicked;
            // 
            // frmRenewLocalDrivingLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 1043);
            Controls.Add(llShowLicenseInfo);
            Controls.Add(llShowLicenseHistory);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRenewLocalDrivingLicenseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renew Local Driving License";
            Activated += frnRenewLocalDrivingLicenseApplication_Activated;
            Load += frnRenewLocalDrivingLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox groupBox1;
        private Label lblPassedTests;
        private Label lblRenewedLicenseID;
        private Label label16;
        private Label lblRLApplicationID;
        private Label label4;
        private Label label18;
        private Label lblTotalFees;
        private Label label20;
        private Label lblLicenseFees;
        private Label label22;
        private Label lblCreatedBy;
        private Label label7;
        private Label lblApplicationFees;
        private Label label9;
        private Label lblExpirationDate;
        private Label label11;
        private Label lblIssueDate;
        private Label label13;
        private Label lblOldLicenseID;
        private Label label2;
        private Label lblApplicationDate;
        private Label label5;
        private TextBox txtNotes;
        private Panel panel1;
        private Label label14;
        private Panel panel3;
        private Button btnRenew;
        private Panel panel2;
        private Button btnClose;
        private LinkLabel llShowLicenseHistory;
        private LinkLabel llShowLicenseInfo;
    }
}