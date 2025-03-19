namespace DVLD_PRO_1._0._0.Licenses.Detain_Licenses
{
    partial class frmDetainLicenseApplication
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
            components = new System.ComponentModel.Container();
            ctrlDriverLicenseInfoWithFilter1 = new Controls.ctrlDriverLicenseInfoWithFilter();
            groupBox1 = new GroupBox();
            txtFineFees = new TextBox();
            panel3 = new Panel();
            btnDetainLicense = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            lblIssueDate = new Label();
            label9 = new Label();
            lblDetainID = new Label();
            label7 = new Label();
            lblCreatedBy = new Label();
            lblLicenseID = new Label();
            lblDetainDate = new Label();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            llShowLicensesHistory = new LinkLabel();
            llShowLicensesInfo = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfoWithFilter1
            // 
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = true;
            ctrlDriverLicenseInfoWithFilter1.Location = new Point(12, 0);
            ctrlDriverLicenseInfoWithFilter1.Name = "ctrlDriverLicenseInfoWithFilter1";
            ctrlDriverLicenseInfoWithFilter1.Size = new Size(934, 654);
            ctrlDriverLicenseInfoWithFilter1.TabIndex = 0;
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += ctrlDriverLicenseInfoWithFilter1_OnLicenseSelected;
            ctrlDriverLicenseInfoWithFilter1.Load += ctrlDriverLicenseInfoWithFilter1_Load;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFineFees);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(lblIssueDate);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblDetainID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(lblCreatedBy);
            groupBox1.Controls.Add(lblLicenseID);
            groupBox1.Controls.Add(lblDetainDate);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(29, 31, 56);
            groupBox1.Location = new Point(34, 646);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 172);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            txtFineFees.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            txtFineFees.Location = new Point(188, 119);
            txtFineFees.Name = "txtFineFees";
            txtFineFees.Size = new Size(92, 30);
            txtFineFees.TabIndex = 47;
            txtFineFees.Validating += txtFineFees_Validating;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDetainLicense);
            panel3.Location = new Point(712, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 46;
            // 
            // btnDetainLicense
            // 
            btnDetainLicense.BackColor = Color.DarkGreen;
            btnDetainLicense.FlatStyle = FlatStyle.Flat;
            btnDetainLicense.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetainLicense.ForeColor = Color.White;
            btnDetainLicense.Image = Properties.Resources.save;
            btnDetainLicense.Location = new Point(-7, -11);
            btnDetainLicense.Name = "btnDetainLicense";
            btnDetainLicense.Padding = new Padding(10, 0, 0, 0);
            btnDetainLicense.Size = new Size(169, 76);
            btnDetainLicense.TabIndex = 30;
            btnDetainLicense.Text = "   Detain";
            btnDetainLicense.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetainLicense.UseVisualStyleBackColor = false;
            btnDetainLicense.Click += btnDetainLicense_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(712, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 45;
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
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblIssueDate.Location = new Point(538, 121);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.Size = new Size(48, 28);
            lblIssueDate.TabIndex = 44;
            lblIssueDate.Text = "????";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(29, 31, 56);
            label9.Location = new Point(411, 121);
            label9.Name = "label9";
            label9.Size = new Size(121, 28);
            label9.TabIndex = 43;
            label9.Text = "Issue Date :";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(73, 121);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 27;
            label3.Text = "Fine Fees :";
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
            // llShowLicensesHistory
            // 
            llShowLicensesHistory.AutoSize = true;
            llShowLicensesHistory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llShowLicensesHistory.Location = new Point(687, 44);
            llShowLicensesHistory.Name = "llShowLicensesHistory";
            llShowLicensesHistory.Size = new Size(216, 28);
            llShowLicensesHistory.TabIndex = 0;
            llShowLicensesHistory.TabStop = true;
            llShowLicensesHistory.Text = "Show Licenses History";
            llShowLicensesHistory.LinkClicked += llShowLicensesHistory_LinkClicked;
            // 
            // llShowLicensesInfo
            // 
            llShowLicensesInfo.AutoSize = true;
            llShowLicensesInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            llShowLicensesInfo.Location = new Point(702, 72);
            llShowLicensesInfo.Name = "llShowLicensesInfo";
            llShowLicensesInfo.Size = new Size(187, 28);
            llShowLicensesInfo.TabIndex = 23;
            llShowLicensesInfo.TabStop = true;
            llShowLicensesInfo.Text = "Show Licenses Info";
            llShowLicensesInfo.LinkClicked += llShowLicensesInfo_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDetainLicenseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 837);
            Controls.Add(llShowLicensesInfo);
            Controls.Add(llShowLicensesHistory);
            Controls.Add(groupBox1);
            Controls.Add(ctrlDriverLicenseInfoWithFilter1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDetainLicenseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detain License Application";
            Activated += frmDetainLicenseApplication_Activated;
            Load += frmDetainLicenseApplication_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlDriverLicenseInfoWithFilter ctrlDriverLicenseInfoWithFilter1;
        private GroupBox groupBox1;
        private Label lblIssueDate;
        private Label label9;
        private Label lblDetainID;
        private Label label7;
        private Label lblCreatedBy;
        private Label lblLicenseID;
        private Label lblDetainDate;
        private Label label3;
        private Label label1;
        private Label label5;
        private Label label4;
        private LinkLabel llShowLicensesHistory;
        private LinkLabel llShowLicensesInfo;
        private Panel panel3;
        private Button btnDetainLicense;
        private Panel panel2;
        private Button btnClose;
        private TextBox txtFineFees;
        private ErrorProvider errorProvider1;
    }
}