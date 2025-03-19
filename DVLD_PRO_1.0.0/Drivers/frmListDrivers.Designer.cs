namespace DVLD_PRO_1._0._0.Drivers
{
    partial class frmListDrivers
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
            txtFilterBy = new TextBox();
            cmbFilterBy = new ComboBox();
            label1 = new Label();
            dgvDrivers = new DataGridView();
            colDriverID = new DataGridViewTextBoxColumn();
            colPersonID = new DataGridViewTextBoxColumn();
            colNationalNo = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colActivateLicenses = new DataGridViewTextBoxColumn();
            lblRecordsCount = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 116);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(532, 35);
            label2.Name = "label2";
            label2.Size = new Size(284, 46);
            label2.TabIndex = 5;
            label2.Text = "Manage Drivers";
            // 
            // txtFilterBy
            // 
            txtFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilterBy.Location = new Point(361, 131);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(199, 30);
            txtFilterBy.TabIndex = 8;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cmbFilterBy.Location = new Point(147, 131);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(199, 31);
            cmbFilterBy.TabIndex = 7;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 6;
            label1.Text = "Filter By :";
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToResizeColumns = false;
            dgvDrivers.AllowUserToResizeRows = false;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.BorderStyle = BorderStyle.None;
            dgvDrivers.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDrivers.ColumnHeadersHeight = 60;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDrivers.Columns.AddRange(new DataGridViewColumn[] { colDriverID, colPersonID, colNationalNo, colFullName, colDate, colActivateLicenses });
            dgvDrivers.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDrivers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDrivers.EnableHeadersVisualStyles = false;
            dgvDrivers.GridColor = Color.White;
            dgvDrivers.Location = new Point(12, 177);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDrivers.RowHeadersWidth = 30;
            dgvDrivers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvDrivers.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvDrivers.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvDrivers.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvDrivers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvDrivers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvDrivers.RowTemplate.DividerHeight = 1;
            dgvDrivers.ShowCellErrors = false;
            dgvDrivers.ShowRowErrors = false;
            dgvDrivers.Size = new Size(1322, 513);
            dgvDrivers.TabIndex = 9;
            // 
            // colDriverID
            // 
            colDriverID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDriverID.DataPropertyName = "DriverID";
            colDriverID.HeaderText = "Driver ID";
            colDriverID.MinimumWidth = 6;
            colDriverID.Name = "colDriverID";
            colDriverID.ReadOnly = true;
            colDriverID.Width = 130;
            // 
            // colPersonID
            // 
            colPersonID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPersonID.DataPropertyName = "PersonID";
            colPersonID.HeaderText = "Person ID";
            colPersonID.MinimumWidth = 6;
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 170;
            // 
            // colNationalNo
            // 
            colNationalNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNationalNo.DataPropertyName = "NationalNo";
            colNationalNo.HeaderText = "National No.";
            colNationalNo.MinimumWidth = 6;
            colNationalNo.Name = "colNationalNo";
            colNationalNo.ReadOnly = true;
            colNationalNo.Width = 200;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 300;
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDate.DataPropertyName = "CreatedDate";
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 250;
            // 
            // colActivateLicenses
            // 
            colActivateLicenses.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colActivateLicenses.DataPropertyName = "NumberOfActiveLicenses";
            colActivateLicenses.HeaderText = "Activate Licenses";
            colActivateLicenses.MinimumWidth = 6;
            colActivateLicenses.Name = "colActivateLicenses";
            colActivateLicenses.ReadOnly = true;
            colActivateLicenses.Width = 240;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 706);
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
            label3.Location = new Point(12, 706);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 35;
            label3.Text = "# Records";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(1179, 715);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 40;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, toolStripSeparator3, editToolStripMenuItem, toolStripSeparator2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(370, 94);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showDetailsToolStripMenuItem.Image = Properties.Resources.showDetails;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(369, 36);
            showDetailsToolStripMenuItem.Text = "Show Person Info";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(366, 6);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(366, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            editToolStripMenuItem.Image = Properties.Resources.editPerson;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(369, 36);
            editToolStripMenuItem.Text = "Show Person License History";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(366, 6);
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 783);
            Controls.Add(panel2);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvDrivers);
            Controls.Add(txtFilterBy);
            Controls.Add(cmbFilterBy);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListDrivers";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListDrivers";
            Load += frmListDrivers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            panel2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private DataGridView dgvDrivers;
        private Label lblRecordsCount;
        private Label label3;
        private Panel panel2;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridViewTextBoxColumn colDriverID;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colNationalNo;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colActivateLicenses;
    }
}