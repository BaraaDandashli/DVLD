namespace DVLD_PRO
{
    partial class frmMainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1 = new MenuStrip();
            appsToolStripMenuItem = new ToolStripMenuItem();
            drivingLicenseServicesToolStripMenuItem = new ToolStripMenuItem();
            newDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localDrivToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            replacementForLostOrDamagedLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem = new ToolStripMenuItem();
            appsToolStripMenuItem1 = new ToolStripMenuItem();
            localDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseAppkucationsToolStripMenuItem = new ToolStripMenuItem();
            detainLicensesToolStripMenuItem = new ToolStripMenuItem();
            manageDetainedLicensesToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
            pepoleToolStripMenuItem = new ToolStripMenuItem();
            diversToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 118);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.1525421F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.84746F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 187F));
            tableLayoutPanel1.Size = new Size(1383, 667);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImage = DVLD_PRO_1._0._0.Properties.Resources.ProLogo;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(464, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 358);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(menuStrip1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1383, 107);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { appsToolStripMenuItem, pepoleToolStripMenuItem, diversToolStripMenuItem, usersToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10);
            menuStrip1.Size = new Size(600, 102);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // appsToolStripMenuItem
            // 
            appsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicenseServicesToolStripMenuItem, appsToolStripMenuItem1, detainLicensesToolStripMenuItem, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            appsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            appsToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.APPS;
            appsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            appsToolStripMenuItem.Size = new Size(73, 82);
            appsToolStripMenuItem.Text = "Apps";
            appsToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem, replacementForLostOrDamagedLicenseToolStripMenuItem, releaseDetainedDrivingLicenseToolStripMenuItem, retakeTestToolStripMenuItem });
            drivingLicenseServicesToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.license;
            drivingLicenseServicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            drivingLicenseServicesToolStripMenuItem.Size = new Size(379, 56);
            drivingLicenseServicesToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localDrivToolStripMenuItem, internationalLicenseToolStripMenuItem });
            newDrivingLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.AddNEWDL;
            newDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            newDrivingLicenseToolStripMenuItem.Size = new Size(527, 56);
            newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localDrivToolStripMenuItem
            // 
            localDrivToolStripMenuItem.Name = "localDrivToolStripMenuItem";
            localDrivToolStripMenuItem.Size = new Size(296, 32);
            localDrivToolStripMenuItem.Text = "Local License";
            localDrivToolStripMenuItem.Click += localDrivToolStripMenuItem_Click;
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(296, 32);
            internationalLicenseToolStripMenuItem.Text = "International License";
            internationalLicenseToolStripMenuItem.Click += internationalLicenseToolStripMenuItem_Click;
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.RenewDL;
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(527, 56);
            renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            renewDrivingLicenseToolStripMenuItem.Click += renewDrivingLicenseToolStripMenuItem_Click;
            // 
            // replacementForLostOrDamagedLicenseToolStripMenuItem
            // 
            replacementForLostOrDamagedLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.ReplacementDL;
            replacementForLostOrDamagedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            replacementForLostOrDamagedLicenseToolStripMenuItem.Name = "replacementForLostOrDamagedLicenseToolStripMenuItem";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Size = new Size(527, 56);
            replacementForLostOrDamagedLicenseToolStripMenuItem.Text = "Replacement for Lost or Damaged License";
            replacementForLostOrDamagedLicenseToolStripMenuItem.Click += replacementForLostOrDamagedLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.releasedDL;
            releaseDetainedDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(527, 56);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            retakeTestToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.retakeTest;
            retakeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            retakeTestToolStripMenuItem.Size = new Size(527, 56);
            retakeTestToolStripMenuItem.Text = "Retake Test";
            retakeTestToolStripMenuItem.Click += retakeTestToolStripMenuItem_Click;
            // 
            // appsToolStripMenuItem1
            // 
            appsToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { localDrivingLicenseApplicationsToolStripMenuItem, internationalLicenseAppkucationsToolStripMenuItem });
            appsToolStripMenuItem1.Image = DVLD_PRO_1._0._0.Properties.Resources.manage_apps;
            appsToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            appsToolStripMenuItem1.Name = "appsToolStripMenuItem1";
            appsToolStripMenuItem1.Size = new Size(379, 56);
            appsToolStripMenuItem1.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            localDrivingLicenseApplicationsToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.LDLID;
            localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            localDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(452, 56);
            localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            localDrivingLicenseApplicationsToolStripMenuItem.Click += localDrivingLicenseApplicationsToolStripMenuItem_Click;
            // 
            // internationalLicenseAppkucationsToolStripMenuItem
            // 
            internationalLicenseAppkucationsToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.IDLID;
            internationalLicenseAppkucationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            internationalLicenseAppkucationsToolStripMenuItem.Name = "internationalLicenseAppkucationsToolStripMenuItem";
            internationalLicenseAppkucationsToolStripMenuItem.Size = new Size(452, 56);
            internationalLicenseAppkucationsToolStripMenuItem.Text = "International License Applications";
            // 
            // detainLicensesToolStripMenuItem
            // 
            detainLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageDetainedLicensesToolStripMenuItem, detainLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            detainLicensesToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.detain;
            detainLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            detainLicensesToolStripMenuItem.Size = new Size(379, 56);
            detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            manageDetainedLicensesToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.ManageLDLID;
            manageDetainedLicensesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            manageDetainedLicensesToolStripMenuItem.Size = new Size(380, 56);
            manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            manageDetainedLicensesToolStripMenuItem.Click += manageDetainedLicensesToolStripMenuItem_Click;
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.detainedDLID;
            detainLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(380, 56);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            detainLicenseToolStripMenuItem.Click += detainLicenseToolStripMenuItem_Click;
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.releaseDLID;
            releaseDetainedLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(380, 56);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            releaseDetainedLicenseToolStripMenuItem.Click += releaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.manageappstypes;
            manageApplicationTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(379, 56);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.testTypes;
            manageTestTypesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(379, 56);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
            // 
            // pepoleToolStripMenuItem
            // 
            pepoleToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            pepoleToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.Pepole;
            pepoleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            pepoleToolStripMenuItem.Name = "pepoleToolStripMenuItem";
            pepoleToolStripMenuItem.Size = new Size(89, 82);
            pepoleToolStripMenuItem.Text = "Pepole";
            pepoleToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            pepoleToolStripMenuItem.Click += pepoleToolStripMenuItem_Click;
            // 
            // diversToolStripMenuItem
            // 
            diversToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            diversToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.drivers;
            diversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            diversToolStripMenuItem.Name = "diversToolStripMenuItem";
            diversToolStripMenuItem.Size = new Size(86, 82);
            diversToolStripMenuItem.Text = "Divers";
            diversToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            diversToolStripMenuItem.Click += diversToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            usersToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.users;
            usersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(77, 82);
            usersToolStripMenuItem.Text = "Users";
            usersToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            usersToolStripMenuItem.Click += usersToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, signOutToolStripMenuItem });
            settingsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            settingsToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.settings;
            settingsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(103, 82);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.userInfo;
            currentUserInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(293, 56);
            currentUserInfoToolStripMenuItem.Text = "Current User Info";
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.changePassord;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(293, 56);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = DVLD_PRO_1._0._0.Properties.Resources.signOut;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(293, 56);
            signOutToolStripMenuItem.Text = "Sign Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 31, 56);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 107);
            panel2.Name = "panel2";
            panel2.Size = new Size(1383, 11);
            panel2.TabIndex = 1;
            // 
            // frmMainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1383, 785);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(823, 832);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pro DVLD System";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem appsToolStripMenuItem;
        private ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private ToolStripMenuItem appsToolStripMenuItem1;
        private ToolStripMenuItem pepoleToolStripMenuItem;
        private ToolStripMenuItem diversToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem replacementForLostOrDamagedLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem;
        private ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseAppkucationsToolStripMenuItem;
        private ToolStripMenuItem detainLicensesToolStripMenuItem;
        private ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private ToolStripMenuItem changePasswordToolStripMenuItem;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem localDrivToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
    }
}
