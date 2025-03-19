namespace DVLD_PRO_1._0._0.Applications.International_License
{
    partial class frmNewInternationalLicenseApplication
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
            panel3 = new Panel();
            btnIssue = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            lblLocalLicenseID = new Label();
            label18 = new Label();
            lblCreatedByUserID = new Label();
            label14 = new Label();
            lblInternationalLLicenseID = new Label();
            label16 = new Label();
            lblIssueDate = new Label();
            lblExpirationDate = new Label();
            lblFees = new Label();
            lblAppDate = new Label();
            lblInternationalLAppID = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            llShowLicensesInfo = new LinkLabel();
            llShowLicensesHistory = new LinkLabel();
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
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(921, 668);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(lblLocalLicenseID);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(lblCreatedByUserID);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lblInternationalLLicenseID);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(lblExpirationDate);
            groupBox1.Controls.Add(lblFees);
            groupBox1.Controls.Add(lblAppDate);
            groupBox1.Controls.Add(lblInternationalLAppID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(37, 663);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 228);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Application Info";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnIssue);
            panel3.Location = new Point(701, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 48;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.DarkGreen;
            btnIssue.FlatStyle = FlatStyle.Flat;
            btnIssue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssue.ForeColor = Color.White;
            btnIssue.Image = Properties.Resources.save;
            btnIssue.Location = new Point(-7, -11);
            btnIssue.Name = "btnIssue";
            btnIssue.Padding = new Padding(10, 0, 0, 0);
            btnIssue.Size = new Size(169, 76);
            btnIssue.TabIndex = 30;
            btnIssue.Text = "   Issue";
            btnIssue.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssue_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(701, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 47;
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
            // lblLocalLicenseID
            // 
            lblLocalLicenseID.AutoSize = true;
            lblLocalLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblLocalLicenseID.Location = new Point(598, 89);
            lblLocalLicenseID.Name = "lblLocalLicenseID";
            lblLocalLicenseID.Size = new Size(48, 28);
            lblLocalLicenseID.TabIndex = 40;
            lblLocalLicenseID.Text = "????";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(29, 31, 56);
            label18.Location = new Point(380, 89);
            label18.Name = "label18";
            label18.Size = new Size(174, 28);
            label18.TabIndex = 39;
            label18.Text = "Local License ID :";
            // 
            // lblCreatedByUserID
            // 
            lblCreatedByUserID.AutoSize = true;
            lblCreatedByUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUserID.ForeColor = Color.FromArgb(29, 31, 56);
            lblCreatedByUserID.Location = new Point(598, 174);
            lblCreatedByUserID.Name = "lblCreatedByUserID";
            lblCreatedByUserID.Size = new Size(48, 28);
            lblCreatedByUserID.TabIndex = 38;
            lblCreatedByUserID.Text = "????";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(29, 31, 56);
            label14.Location = new Point(429, 174);
            label14.Name = "label14";
            label14.Size = new Size(125, 28);
            label14.TabIndex = 37;
            label14.Text = "Created by :";
            // 
            // lblInternationalLLicenseID
            // 
            lblInternationalLLicenseID.AutoSize = true;
            lblInternationalLLicenseID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            lblInternationalLLicenseID.Location = new Point(598, 46);
            lblInternationalLLicenseID.Name = "lblInternationalLLicenseID";
            lblInternationalLLicenseID.Size = new Size(48, 28);
            lblInternationalLLicenseID.TabIndex = 36;
            lblInternationalLLicenseID.Text = "????";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(29, 31, 56);
            label16.Location = new Point(409, 46);
            label16.Name = "label16";
            label16.Size = new Size(145, 28);
            label16.TabIndex = 35;
            label16.Text = "I.L.License ID :";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblIssueDate.Location = new Point(144, 132);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(48, 28);
            lblIssueDate.TabIndex = 32;
            lblIssueDate.Text = "????";
            // 
            // lblExpirationDate
            // 
            lblExpirationDate.AutoSize = true;
            lblExpirationDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpirationDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblExpirationDate.Location = new Point(598, 132);
            lblExpirationDate.Name = "lblExpirationDate";
            lblExpirationDate.Size = new Size(48, 28);
            lblExpirationDate.TabIndex = 31;
            lblExpirationDate.Text = "????";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblFees.Location = new Point(143, 174);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(48, 28);
            lblFees.TabIndex = 30;
            lblFees.Text = "????";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblAppDate.Location = new Point(144, 89);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(48, 28);
            lblAppDate.TabIndex = 29;
            lblAppDate.Text = "????";
            // 
            // lblInternationalLAppID
            // 
            lblInternationalLAppID.AutoSize = true;
            lblInternationalLAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLAppID.ForeColor = Color.FromArgb(29, 31, 56);
            lblInternationalLAppID.Location = new Point(144, 46);
            lblInternationalLAppID.Name = "lblInternationalLAppID";
            lblInternationalLAppID.Size = new Size(48, 28);
            lblInternationalLAppID.TabIndex = 28;
            lblInternationalLAppID.Text = "????";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(17, 132);
            label3.Name = "label3";
            label3.Size = new Size(121, 28);
            label3.TabIndex = 27;
            label3.Text = "Issue Date :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(383, 132);
            label2.Name = "label2";
            label2.Size = new Size(171, 28);
            label2.TabIndex = 25;
            label2.Text = "Expiration Date :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(74, 174);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 23;
            label1.Text = "Fees :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(26, 89);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 20;
            label5.Text = "App Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(35, 46);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 19;
            label4.Text = "I.L.App ID";
            // 
            // llShowLicensesInfo
            // 
            llShowLicensesInfo.AutoSize = true;
            llShowLicensesInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llShowLicensesInfo.Location = new Point(702, 82);
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
            llShowLicensesHistory.Location = new Point(687, 54);
            llShowLicensesHistory.Name = "llShowLicensesHistory";
            llShowLicensesHistory.Size = new Size(216, 28);
            llShowLicensesHistory.TabIndex = 24;
            llShowLicensesHistory.TabStop = true;
            llShowLicensesHistory.Text = "Show Licenses History";
            llShowLicensesHistory.LinkClicked += llShowLicensesHistory_LinkClicked;
            // 
            // frmNewInternationalLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 904);
            Controls.Add(llShowLicensesInfo);
            Controls.Add(llShowLicensesHistory);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewInternationalLicenseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New International License Application";
            Load += frmNewInternationalLicenseApplication_Load;
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
        private Label lblLocalLicenseID;
        private Label label18;
        private Label lblCreatedByUserID;
        private Label label14;
        private Label lblInternationalLLicenseID;
        private Label label16;
        private Label lblIssueDate;
        private Label lblExpirationDate;
        private Label lblFees;
        private Label lblAppDate;
        private Label lblInternationalLAppID;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Button btnIssue;
        private Panel panel2;
        private Button btnClose;
        private LinkLabel llShowLicensesInfo;
        private LinkLabel llShowLicensesHistory;
    }
}