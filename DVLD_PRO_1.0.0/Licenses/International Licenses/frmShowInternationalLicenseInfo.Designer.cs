namespace DVLD_PRO_1._0._0.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            ctrlDriverInternationalLicenseInfo11 = new Controls.ctrlDriverInternationalLicenseInfo1();
            panel1 = new Panel();
            lblTitle = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDriverInternationalLicenseInfo11
            // 
            ctrlDriverInternationalLicenseInfo11.Location = new Point(10, 131);
            ctrlDriverInternationalLicenseInfo11.Name = "ctrlDriverInternationalLicenseInfo11";
            ctrlDriverInternationalLicenseInfo11.Size = new Size(1165, 351);
            ctrlDriverInternationalLicenseInfo11.TabIndex = 0;
            ctrlDriverInternationalLicenseInfo11.Load += ctrlDriverInternationalLicenseInfo11_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1197, 100);
            panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(430, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(337, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Driver International";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(968, 469);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 46;
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
            // frmShowInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(ctrlDriverInternationalLicenseInfo11);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmShowInternationalLicenseInfo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show International License Info";
            Load += frmShowInternationalLicenseInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlDriverInternationalLicenseInfo1 ctrlDriverInternationalLicenseInfo11;
        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Button btnClose;
    }
}