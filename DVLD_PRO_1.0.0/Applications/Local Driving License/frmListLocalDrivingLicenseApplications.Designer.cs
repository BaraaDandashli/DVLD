namespace DVLD_PRO_1._0._0.Applications.Local_Driving_License
{
    partial class frmListLocalDrivingLicenseApplications
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvLDLApp = new DataGridView();
            colLDLAppIID = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colNationalNo = new DataGridViewTextBoxColumn();
            colFullNameName = new DataGridViewTextBoxColumn();
            colApplicationDate = new DataGridViewTextBoxColumn();
            colPassedTests = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            EditAppToolStripMenuItem = new ToolStripMenuItem();
            DeleteAppToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            CancelAppToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            SechduleTestsToolStripMenuItem = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            IssueDLToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txtFilterBy = new TextBox();
            cmbFilterBy = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            btnNewLDLApp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLDLApp).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLDLApp
            // 
            dgvLDLApp.AllowUserToAddRows = false;
            dgvLDLApp.AllowUserToDeleteRows = false;
            dgvLDLApp.AllowUserToResizeColumns = false;
            dgvLDLApp.AllowUserToResizeRows = false;
            dgvLDLApp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLDLApp.BackgroundColor = Color.White;
            dgvLDLApp.BorderStyle = BorderStyle.None;
            dgvLDLApp.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLDLApp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLDLApp.ColumnHeadersHeight = 60;
            dgvLDLApp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLDLApp.Columns.AddRange(new DataGridViewColumn[] { colLDLAppIID, colClassName, colNationalNo, colFullNameName, colApplicationDate, colPassedTests, colStatus });
            dgvLDLApp.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLDLApp.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLDLApp.EnableHeadersVisualStyles = false;
            dgvLDLApp.GridColor = Color.White;
            dgvLDLApp.Location = new Point(6, 186);
            dgvLDLApp.MultiSelect = false;
            dgvLDLApp.Name = "dgvLDLApp";
            dgvLDLApp.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLDLApp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLDLApp.RowHeadersWidth = 30;
            dgvLDLApp.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLDLApp.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvLDLApp.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvLDLApp.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvLDLApp.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvLDLApp.RowTemplate.DividerHeight = 1;
            dgvLDLApp.ShowCellErrors = false;
            dgvLDLApp.ShowRowErrors = false;
            dgvLDLApp.Size = new Size(1609, 645);
            dgvLDLApp.TabIndex = 2;
            // 
            // colLDLAppIID
            // 
            colLDLAppIID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLDLAppIID.DataPropertyName = "LocalDrivingLicenseApplicationID";
            colLDLAppIID.HeaderText = "L.D.L.App ID";
            colLDLAppIID.MinimumWidth = 6;
            colLDLAppIID.Name = "colLDLAppIID";
            colLDLAppIID.ReadOnly = true;
            colLDLAppIID.Width = 170;
            // 
            // colClassName
            // 
            colClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "Driving Class";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            colClassName.Width = 350;
            // 
            // colNationalNo
            // 
            colNationalNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNationalNo.DataPropertyName = "NationalNo";
            colNationalNo.HeaderText = "National No.";
            colNationalNo.MinimumWidth = 6;
            colNationalNo.Name = "colNationalNo";
            colNationalNo.ReadOnly = true;
            colNationalNo.Width = 160;
            // 
            // colFullNameName
            // 
            colFullNameName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFullNameName.DataPropertyName = "FullName";
            colFullNameName.HeaderText = "Full Name";
            colFullNameName.MinimumWidth = 6;
            colFullNameName.Name = "colFullNameName";
            colFullNameName.ReadOnly = true;
            colFullNameName.Width = 350;
            // 
            // colApplicationDate
            // 
            colApplicationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colApplicationDate.DataPropertyName = "ApplicationDate";
            colApplicationDate.HeaderText = "Application Date";
            colApplicationDate.MinimumWidth = 6;
            colApplicationDate.Name = "colApplicationDate";
            colApplicationDate.ReadOnly = true;
            colApplicationDate.Width = 230;
            // 
            // colPassedTests
            // 
            colPassedTests.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPassedTests.DataPropertyName = "PassedTestCount";
            colPassedTests.HeaderText = "Passed Tests";
            colPassedTests.MinimumWidth = 6;
            colPassedTests.Name = "colPassedTests";
            colPassedTests.ReadOnly = true;
            colPassedTests.Width = 160;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 160;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, EditAppToolStripMenuItem, DeleteAppToolStripMenuItem, toolStripSeparator3, CancelAppToolStripMenuItem, toolStripSeparator2, SechduleTestsToolStripMenuItem, toolStripSeparator4, IssueDLToolStripMenuItem, toolStripSeparator5, showLicenseToolStripMenuItem, toolStripSeparator6, showPersonLicenseHistoryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(411, 328);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showDetailsToolStripMenuItem.Image = Properties.Resources.showDetails;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(410, 36);
            showDetailsToolStripMenuItem.Text = "Show Application Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(407, 6);
            // 
            // EditAppToolStripMenuItem
            // 
            EditAppToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            EditAppToolStripMenuItem.Image = Properties.Resources.addPerson0;
            EditAppToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditAppToolStripMenuItem.Name = "EditAppToolStripMenuItem";
            EditAppToolStripMenuItem.Size = new Size(410, 36);
            EditAppToolStripMenuItem.Text = "Edit Application";
            EditAppToolStripMenuItem.Click += EditAppToolStripMenuItem_Click;
            // 
            // DeleteAppToolStripMenuItem
            // 
            DeleteAppToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            DeleteAppToolStripMenuItem.Image = Properties.Resources.editPerson;
            DeleteAppToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            DeleteAppToolStripMenuItem.Name = "DeleteAppToolStripMenuItem";
            DeleteAppToolStripMenuItem.Size = new Size(410, 36);
            DeleteAppToolStripMenuItem.Text = "Delete Application";
            DeleteAppToolStripMenuItem.Click += DeleteAppToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(407, 6);
            // 
            // CancelAppToolStripMenuItem
            // 
            CancelAppToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            CancelAppToolStripMenuItem.Image = Properties.Resources.delete;
            CancelAppToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            CancelAppToolStripMenuItem.Name = "CancelAppToolStripMenuItem";
            CancelAppToolStripMenuItem.Size = new Size(410, 36);
            CancelAppToolStripMenuItem.Text = "Cancel Application";
            CancelAppToolStripMenuItem.Click += CancelAppToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(407, 6);
            // 
            // SechduleTestsToolStripMenuItem
            // 
            SechduleTestsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            SechduleTestsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            SechduleTestsToolStripMenuItem.Image = Properties.Resources.sendEmail;
            SechduleTestsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            SechduleTestsToolStripMenuItem.Name = "SechduleTestsToolStripMenuItem";
            SechduleTestsToolStripMenuItem.Size = new Size(410, 36);
            SechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(306, 32);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(306, 32);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(306, 32);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(407, 6);
            // 
            // IssueDLToolStripMenuItem
            // 
            IssueDLToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            IssueDLToolStripMenuItem.Image = Properties.Resources.phoneCall;
            IssueDLToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            IssueDLToolStripMenuItem.Name = "IssueDLToolStripMenuItem";
            IssueDLToolStripMenuItem.Size = new Size(410, 36);
            IssueDLToolStripMenuItem.Text = "Issue Driving License (First Time)";
            IssueDLToolStripMenuItem.Click += IssueDLToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(407, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(410, 36);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(407, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(410, 36);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 843);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 36;
            lblRecordsCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(12, 843);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 35;
            label3.Text = "# Records";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 116);
            panel1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(517, 35);
            label2.Name = "label2";
            label2.Size = new Size(586, 46);
            label2.TabIndex = 5;
            label2.Text = "Local Driving License Applications";
            // 
            // txtFilterBy
            // 
            txtFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilterBy.Location = new Point(364, 134);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(199, 30);
            txtFilterBy.TabIndex = 40;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "L.D.L.AppID", "National No.", "Full Name", "Status" });
            cmbFilterBy.Location = new Point(150, 134);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(199, 31);
            cmbFilterBy.TabIndex = 39;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 135);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 38;
            label1.Text = "Filter By :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNewLDLApp);
            panel3.Location = new Point(1456, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 43);
            panel3.TabIndex = 41;
            // 
            // btnNewLDLApp
            // 
            btnNewLDLApp.BackColor = Color.Green;
            btnNewLDLApp.FlatStyle = FlatStyle.Flat;
            btnNewLDLApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewLDLApp.ForeColor = Color.White;
            btnNewLDLApp.Image = Properties.Resources.license;
            btnNewLDLApp.Location = new Point(-19, -10);
            btnNewLDLApp.Name = "btnNewLDLApp";
            btnNewLDLApp.Padding = new Padding(10, 0, 0, 0);
            btnNewLDLApp.Size = new Size(201, 63);
            btnNewLDLApp.TabIndex = 30;
            btnNewLDLApp.Text = "   New";
            btnNewLDLApp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewLDLApp.UseVisualStyleBackColor = false;
            btnNewLDLApp.Click += btnNewLDLApp_Click;
            // 
            // frmListLocalDrivingLicenseApplications
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 876);
            Controls.Add(panel3);
            Controls.Add(txtFilterBy);
            Controls.Add(cmbFilterBy);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvLDLApp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListLocalDrivingLicenseApplications";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Local Driving License Applications";
            Load += frmListLocalDrivingLicenseApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLDLApp).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLDLApp;
        private Label lblRecordsCount;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private Panel panel3;
        private Button btnNewLDLApp;
        private DataGridViewTextBoxColumn colLDLAppIID;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colNationalNo;
        private DataGridViewTextBoxColumn colFullNameName;
        private DataGridViewTextBoxColumn colApplicationDate;
        private DataGridViewTextBoxColumn colPassedTests;
        private DataGridViewTextBoxColumn colStatus;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem EditAppToolStripMenuItem;
        private ToolStripMenuItem DeleteAppToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem CancelAppToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem SechduleTestsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem IssueDLToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}