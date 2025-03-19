namespace DVLD_PRO_1._0._0.Applications.Rlease_Detained_License
{
    partial class frmListDetainedLicenses
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
            panel1 = new Panel();
            label2 = new Label();
            dgvListDetainedLicenses = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ShowPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ShowLicenseDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            ShowPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            ReleaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            txtFilterBy = new TextBox();
            cmbFilterBy = new ComboBox();
            label1 = new Label();
            lblRecordsCount = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnRelease = new Button();
            panel2 = new Panel();
            btnDetain = new Button();
            cbIsReleased = new ComboBox();
            colLDLAppIID = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colNationalNo = new DataGridViewTextBoxColumn();
            colIsReleased = new DataGridViewCheckBoxColumn();
            colFullNameName = new DataGridViewTextBoxColumn();
            colApplicationDate = new DataGridViewTextBoxColumn();
            colPassedTests = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colReleaseAppID = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListDetainedLicenses).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1829, 116);
            panel1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(723, 35);
            label2.Name = "label2";
            label2.Size = new Size(382, 46);
            label2.TabIndex = 5;
            label2.Text = "List Detained Licenses";
            // 
            // dgvListDetainedLicenses
            // 
            dgvListDetainedLicenses.AllowUserToAddRows = false;
            dgvListDetainedLicenses.AllowUserToDeleteRows = false;
            dgvListDetainedLicenses.AllowUserToResizeColumns = false;
            dgvListDetainedLicenses.AllowUserToResizeRows = false;
            dgvListDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvListDetainedLicenses.BackgroundColor = Color.White;
            dgvListDetainedLicenses.BorderStyle = BorderStyle.None;
            dgvListDetainedLicenses.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvListDetainedLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListDetainedLicenses.ColumnHeadersHeight = 60;
            dgvListDetainedLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListDetainedLicenses.Columns.AddRange(new DataGridViewColumn[] { colLDLAppIID, colClassName, colNationalNo, colIsReleased, colFullNameName, colApplicationDate, colPassedTests, colStatus, colReleaseAppID });
            dgvListDetainedLicenses.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListDetainedLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListDetainedLicenses.EnableHeadersVisualStyles = false;
            dgvListDetainedLicenses.GridColor = Color.White;
            dgvListDetainedLicenses.Location = new Point(1, 189);
            dgvListDetainedLicenses.MultiSelect = false;
            dgvListDetainedLicenses.Name = "dgvListDetainedLicenses";
            dgvListDetainedLicenses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListDetainedLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListDetainedLicenses.RowHeadersWidth = 30;
            dgvListDetainedLicenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvListDetainedLicenses.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvListDetainedLicenses.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvListDetainedLicenses.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvListDetainedLicenses.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvListDetainedLicenses.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvListDetainedLicenses.RowTemplate.DividerHeight = 1;
            dgvListDetainedLicenses.ShowCellErrors = false;
            dgvListDetainedLicenses.ShowRowErrors = false;
            dgvListDetainedLicenses.Size = new Size(1827, 495);
            dgvListDetainedLicenses.TabIndex = 39;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ShowPersonDetailsToolStripMenuItem, toolStripSeparator1, ShowLicenseDetailsToolStripMenuItem, toolStripSeparator3, ShowPersonLicenseHistoryToolStripMenuItem, toolStripSeparator4, ReleaseDetainedLicenseToolStripMenuItem, toolStripSeparator6 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(370, 172);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // ShowPersonDetailsToolStripMenuItem
            // 
            ShowPersonDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            ShowPersonDetailsToolStripMenuItem.Image = Properties.Resources.showDetails;
            ShowPersonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowPersonDetailsToolStripMenuItem.Name = "ShowPersonDetailsToolStripMenuItem";
            ShowPersonDetailsToolStripMenuItem.Size = new Size(369, 36);
            ShowPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            ShowPersonDetailsToolStripMenuItem.Click += ShowPersonDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(366, 6);
            // 
            // ShowLicenseDetailsToolStripMenuItem
            // 
            ShowLicenseDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            ShowLicenseDetailsToolStripMenuItem.Image = Properties.Resources.editPerson;
            ShowLicenseDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowLicenseDetailsToolStripMenuItem.Name = "ShowLicenseDetailsToolStripMenuItem";
            ShowLicenseDetailsToolStripMenuItem.Size = new Size(369, 36);
            ShowLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            ShowLicenseDetailsToolStripMenuItem.Click += ShowLicenseDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(366, 6);
            // 
            // ShowPersonLicenseHistoryToolStripMenuItem
            // 
            ShowPersonLicenseHistoryToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            ShowPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ShowPersonLicenseHistoryToolStripMenuItem.Name = "ShowPersonLicenseHistoryToolStripMenuItem";
            ShowPersonLicenseHistoryToolStripMenuItem.Size = new Size(369, 36);
            ShowPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            ShowPersonLicenseHistoryToolStripMenuItem.Click += ShowPersonLicenseHistoryToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(366, 6);
            // 
            // ReleaseDetainedLicenseToolStripMenuItem
            // 
            ReleaseDetainedLicenseToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            ReleaseDetainedLicenseToolStripMenuItem.Name = "ReleaseDetainedLicenseToolStripMenuItem";
            ReleaseDetainedLicenseToolStripMenuItem.Size = new Size(369, 36);
            ReleaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            ReleaseDetainedLicenseToolStripMenuItem.Click += ReleaseDetainedLicenseToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(366, 6);
            // 
            // txtFilterBy
            // 
            txtFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilterBy.Location = new Point(357, 137);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(199, 30);
            txtFilterBy.TabIndex = 43;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Detain ID", "Is Released", "National No.", "Full Name", "Release Application ID" });
            cmbFilterBy.Location = new Point(143, 137);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(199, 31);
            cmbFilterBy.TabIndex = 42;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 138);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 41;
            label1.Text = "Filter By :";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 689);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 45;
            lblRecordsCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(12, 689);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 44;
            label3.Text = "# Records";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRelease);
            panel3.Location = new Point(1664, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(153, 43);
            panel3.TabIndex = 46;
            // 
            // btnRelease
            // 
            btnRelease.BackColor = Color.Green;
            btnRelease.FlatStyle = FlatStyle.Flat;
            btnRelease.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelease.ForeColor = Color.White;
            btnRelease.Location = new Point(-19, -10);
            btnRelease.Name = "btnRelease";
            btnRelease.Padding = new Padding(10, 0, 0, 0);
            btnRelease.Size = new Size(201, 63);
            btnRelease.TabIndex = 30;
            btnRelease.Text = "Release";
            btnRelease.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRelease.UseVisualStyleBackColor = false;
            btnRelease.Click += btnRelease_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDetain);
            panel2.Location = new Point(1505, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 43);
            panel2.TabIndex = 47;
            // 
            // btnDetain
            // 
            btnDetain.BackColor = Color.Firebrick;
            btnDetain.FlatStyle = FlatStyle.Flat;
            btnDetain.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDetain.ForeColor = Color.White;
            btnDetain.Location = new Point(-19, -10);
            btnDetain.Name = "btnDetain";
            btnDetain.Padding = new Padding(10, 0, 0, 0);
            btnDetain.Size = new Size(201, 63);
            btnDetain.TabIndex = 30;
            btnDetain.Text = "Detain";
            btnDetain.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDetain.UseVisualStyleBackColor = false;
            btnDetain.Click += btnDetain_Click;
            // 
            // cbIsReleased
            // 
            cbIsReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsReleased.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(357, 137);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(92, 31);
            cbIsReleased.TabIndex = 48;
            cbIsReleased.SelectedIndexChanged += cbIsReleased_SelectedIndexChanged;
            // 
            // colLDLAppIID
            // 
            colLDLAppIID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLDLAppIID.DataPropertyName = "DetainedID";
            colLDLAppIID.HeaderText = "D.ID";
            colLDLAppIID.MinimumWidth = 6;
            colLDLAppIID.Name = "colLDLAppIID";
            colLDLAppIID.ReadOnly = true;
            colLDLAppIID.Width = 120;
            // 
            // colClassName
            // 
            colClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colClassName.DataPropertyName = "LicenseID";
            colClassName.HeaderText = "L.ID";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            colClassName.Width = 120;
            // 
            // colNationalNo
            // 
            colNationalNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNationalNo.DataPropertyName = "DetainedDate";
            colNationalNo.HeaderText = "D.Date";
            colNationalNo.MinimumWidth = 6;
            colNationalNo.Name = "colNationalNo";
            colNationalNo.ReadOnly = true;
            colNationalNo.Width = 200;
            // 
            // colIsReleased
            // 
            colIsReleased.DataPropertyName = "IsReleased";
            colIsReleased.HeaderText = "Is Released";
            colIsReleased.MinimumWidth = 6;
            colIsReleased.Name = "colIsReleased";
            colIsReleased.ReadOnly = true;
            colIsReleased.Resizable = DataGridViewTriState.True;
            colIsReleased.SortMode = DataGridViewColumnSortMode.Automatic;
            colIsReleased.Width = 159;
            // 
            // colFullNameName
            // 
            colFullNameName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFullNameName.DataPropertyName = "FineFees";
            colFullNameName.HeaderText = "Fine Fees";
            colFullNameName.MinimumWidth = 6;
            colFullNameName.Name = "colFullNameName";
            colFullNameName.ReadOnly = true;
            colFullNameName.Width = 200;
            // 
            // colApplicationDate
            // 
            colApplicationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colApplicationDate.DataPropertyName = "ReleasedDate";
            colApplicationDate.HeaderText = "Released Date";
            colApplicationDate.MinimumWidth = 6;
            colApplicationDate.Name = "colApplicationDate";
            colApplicationDate.ReadOnly = true;
            colApplicationDate.Width = 230;
            // 
            // colPassedTests
            // 
            colPassedTests.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPassedTests.DataPropertyName = "NationalNo";
            colPassedTests.HeaderText = "N.No.";
            colPassedTests.MinimumWidth = 6;
            colPassedTests.Name = "colPassedTests";
            colPassedTests.ReadOnly = true;
            colPassedTests.Width = 220;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatus.DataPropertyName = "FullName";
            colStatus.HeaderText = "Full Name";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 350;
            // 
            // colReleaseAppID
            // 
            colReleaseAppID.DataPropertyName = "ReleaseApplicationID";
            colReleaseAppID.HeaderText = "Release App ID";
            colReleaseAppID.MinimumWidth = 6;
            colReleaseAppID.Name = "colReleaseAppID";
            colReleaseAppID.ReadOnly = true;
            colReleaseAppID.Width = 202;
            // 
            // frmListDetainedLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1829, 721);
            Controls.Add(cbIsReleased);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(txtFilterBy);
            Controls.Add(cmbFilterBy);
            Controls.Add(label1);
            Controls.Add(dgvListDetainedLicenses);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListDetainedLicenses";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List Detained Licenses";
            Load += frmListDetainedLicenses_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListDetainedLicenses).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dgvListDetainedLicenses;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private Label lblRecordsCount;
        private Label label3;
        private Panel panel3;
        private Button btnRelease;
        private Panel panel2;
        private Button btnDetain;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ShowPersonDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ShowLicenseDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem ShowPersonLicenseHistoryToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem ReleaseDetainedLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ComboBox cbIsReleased;
        private DataGridViewTextBoxColumn colLDLAppIID;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colNationalNo;
        private DataGridViewCheckBoxColumn colIsReleased;
        private DataGridViewTextBoxColumn colFullNameName;
        private DataGridViewTextBoxColumn colApplicationDate;
        private DataGridViewTextBoxColumn colPassedTests;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colReleaseAppID;
    }
}