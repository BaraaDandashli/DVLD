namespace DVLD_PRO_1._0._0.Applications.Rlease_Detained_License
{
    partial class frmReleaseDetainedLicenseApplication
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
            lblFineFees = new Label();
            label3 = new Label();
            lblTotalFees = new Label();
            label10 = new Label();
            lblApplicationFees = new Label();
            label6 = new Label();
            panel3 = new Panel();
            btnRelease = new Button();
            lblApplicationID = new Label();
            label9 = new Label();
            lblDetainID = new Label();
            label7 = new Label();
            lblCreatedBy = new Label();
            lblLicenseID = new Label();
            lblDetainDate = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            llShowLicensesInfo = new LinkLabel();
            llShowLicensesHistory = new LinkLabel();
            btnClose = new Button();
            panel2 = new Panel();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 12);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(931, 652);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblFineFees);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTotalFees);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lblApplicationFees);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(lblApplicationID);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblDetainID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(lblLicenseID);
            groupBox1.Controls.Add(lblDetainDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(36, 655);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 218);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detain Info";
            // 
            // lblFineFees
            // 
            lblFineFees.AutoSize = true;
            lblFineFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFineFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblFineFees.Location = new Point(538, 121);
            lblFineFees.Name = "lblFineFees";
            lblFineFees.Size = new Size(48, 28);
            lblFineFees.TabIndex = 53;
            lblFineFees.Text = "????";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(423, 121);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 52;
            label3.Text = "Fine Fees :";
            // 
            // lblTotalFees
            // 
            lblTotalFees.AutoSize = true;
            lblTotalFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblTotalFees.Location = new Point(192, 163);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(48, 28);
            lblTotalFees.TabIndex = 51;
            lblTotalFees.Text = "????";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(29, 31, 56);
            label10.Location = new Point(65, 163);
            label10.Name = "label10";
            label10.Size = new Size(117, 28);
            label10.TabIndex = 50;
            label10.Text = "Total Fees :";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblApplicationFees.Location = new Point(192, 121);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(48, 28);
            lblApplicationFees.TabIndex = 49;
            lblApplicationFees.Text = "????";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(29, 31, 56);
            label6.Location = new Point(3, 121);
            label6.Name = "label6";
            label6.Size = new Size(179, 28);
            label6.TabIndex = 48;
            label6.Text = "Application Fees :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRelease);
            panel3.Location = new Point(698, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 46;
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.DarkGreen;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.ForeColor = Color.White;
            btnRelease.Image = Properties.Resources.save;
            btnRelease.Location = new Point(-7, -11);
            btnRelease.Name = "btnRelease";
            btnRelease.Padding = new Padding(10, 0, 0, 0);
            btnRelease.Size = new Size(169, 76);
            btnRelease.TabIndex = 30;
            btnRelease.Text = "   Release";
            btnRelease.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationID.ForeColor = Color.FromArgb(29, 31, 56);
            lblApplicationID.Location = new Point(538, 163);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(48, 28);
            lblApplicationID.TabIndex = 44;
            lblApplicationID.Text = "????";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(29, 31, 56);
            label9.Location = new Point(373, 163);
            label9.Name = "label9";
            label9.Size = new Size(159, 28);
            label9.TabIndex = 43;
            label9.Text = "Application ID :";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainID.ForeColor = Color.FromArgb(29, 31, 56);
            lblDetainID.Location = new Point(192, 39);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(48, 28);
            lblDetainID.TabIndex = 42;
            lblDetainID.Text = "????";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(29, 31, 56);
            label7.Location = new Point(69, 39);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 41;
            label7.Text = "Detain ID :";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.FromArgb(29, 31, 56);
            lblCreatedBy.Location = new Point(538, 80);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(48, 28);
            lblCreatedBy.TabIndex = 30;
            lblCreatedBy.Text = "????";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblLicenseID.Location = new Point(538, 39);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(48, 28);
            lblLicenseID.TabIndex = 29;
            lblLicenseID.Text = "????";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetainDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblDetainDate.Location = new Point(192, 80);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(48, 28);
            lblDetainDate.TabIndex = 28;
            lblDetainDate.Text = "????";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(407, 80);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 23;
            label1.Text = "Created by :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(413, 39);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 20;
            label5.Text = "License ID :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(45, 80);
            label4.Name = "label4";
            label4.Size = new Size(137, 28);
            label4.TabIndex = 19;
            label4.Text = "Detain Date :";
            // 
            // llShowLicensesInfo
            // 
            llShowLicensesInfo.AutoSize = true;
            llShowLicensesInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llShowLicensesInfo.Location = new Point(702, 79);
            llShowLicensesInfo.Name = "llShowLicensesInfo";
            llShowLicensesInfo.Size = new Size(187, 28);
            llShowLicensesInfo.TabIndex = 25;
            llShowLicensesInfo.TabStop = true;
            llShowLicensesInfo.Text = "Show Licenses Info";
            llShowLicensesInfo.LinkClicked += llShowLicensesInfo_LinkClicked;
            // 
            // llShowLicensesHistory
            // 
            llShowLicensesHistory.AutoSize = true;
            llShowLicensesHistory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llShowLicensesHistory.Location = new Point(687, 51);
            llShowLicensesHistory.Name = "llShowLicensesHistory";
            llShowLicensesHistory.Size = new Size(216, 28);
            llShowLicensesHistory.TabIndex = 24;
            llShowLicensesHistory.TabStop = true;
            llShowLicensesHistory.Text = "Show Licenses History";
            llShowLicensesHistory.LinkClicked += llShowLicensesHistory_LinkClicked;
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
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(698, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 45;
            // 
            // frmReleaseDetainedLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 895);
            Controls.Add(llShowLicensesInfo);
            Controls.Add(llShowLicensesHistory);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReleaseDetainedLicenseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Release Detained License Application";
            Activated += frmReleaseDetainedLicenseApplication_Activated;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Licenses.Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox groupBox1;
        private Label lblTotalFees;
        private Label label10;
        private Label lblApplicationFees;
        private Label label6;
        private Panel panel3;
        private Button btnRelease;
        private Label lblApplicationID;
        private Label label9;
        private Label lblDetainID;
        private Label label7;
        private Label lblCreatedBy;
        private Label lblLicenseID;
        private Label lblDetainDate;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label lblFineFees;
        private Label label3;
        private LinkLabel llShowLicensesInfo;
        private LinkLabel llShowLicensesHistory;
        private Panel panel2;
        private Button btnClose;
    }
}