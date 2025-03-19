namespace DVLD_PRO_1._0._0.Licenses.Local_Licenses
{
    partial class frmIssueDriverLicenseFirstTime
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
            ctrlDrivingLicenseApplicationInfo1 = new Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo();
            panel1 = new Panel();
            lblTitle = new Label();
            panel3 = new Panel();
            btnIssueLicense = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            txtNotes = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(14, 153);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1078, 469);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1108, 133);
            panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(442, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(224, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Issue License";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnIssueLicense);
            panel3.Location = new Point(924, 744);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 33;
            // 
            // btnIssueLicense
            // 
            btnIssueLicense.BackColor = Color.DarkGreen;
            btnIssueLicense.FlatStyle = FlatStyle.Flat;
            btnIssueLicense.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIssueLicense.ForeColor = Color.White;
            btnIssueLicense.Image = Properties.Resources.save;
            btnIssueLicense.Location = new Point(-7, -11);
            btnIssueLicense.Name = "btnIssueLicense";
            btnIssueLicense.Padding = new Padding(10, 0, 0, 0);
            btnIssueLicense.Size = new Size(169, 76);
            btnIssueLicense.TabIndex = 30;
            btnIssueLicense.Text = "   Issue";
            btnIssueLicense.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIssueLicense.UseVisualStyleBackColor = false;
            btnIssueLicense.Click += btnIssueLicense_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(746, 744);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 32;
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
            // txtNotes
            // 
            txtNotes.Location = new Point(181, 628);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(898, 88);
            txtNotes.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(29, 31, 56);
            label7.Location = new Point(85, 625);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 35;
            label7.Text = "Notes :";
            // 
            // frmIssueDriverLicenseFirstTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 822);
            Controls.Add(label7);
            Controls.Add(txtNotes);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmIssueDriverLicenseFirstTime";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Issue Driver License First Time";
            Load += frmIssueDriverLicenseFirstTime_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Panel panel1;
        private Label lblTitle;
        private Panel panel3;
        private Button btnIssueLicense;
        private Panel panel2;
        private Button btnClose;
        private TextBox txtNotes;
        private Label label7;
    }
}