namespace DVLD_PRO_1._0._0.Licenses.Controls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            gbFilter = new GroupBox();
            tabControl1 = new TabControl();
            tpLocal = new TabPage();
            lblLocalLicensesRecords = new Label();
            label6 = new Label();
            dgvLocalLicensesHistory = new DataGridView();
            colLicenseID = new DataGridViewTextBoxColumn();
            colApplicationID = new DataGridViewTextBoxColumn();
            colClassName = new DataGridViewTextBoxColumn();
            colIssueDate = new DataGridViewTextBoxColumn();
            colExpirationDate = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewTextBoxColumn();
            cmsLocal = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            label5 = new Label();
            tpInternational = new TabPage();
            lblInternationalLicensesRecords = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvInternationalLicensesHistory = new DataGridView();
            colInternationalLicenseID = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            cmsInternational = new ContextMenuStrip(components);
            InternationalLicenseHistorytoolStripMenuItem = new ToolStripMenuItem();
            gbFilter.SuspendLayout();
            tabControl1.SuspendLayout();
            tpLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).BeginInit();
            cmsLocal.SuspendLayout();
            tpInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).BeginInit();
            cmsInternational.SuspendLayout();
            SuspendLayout();
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(tabControl1);
            gbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(29, 31, 56);
            gbFilter.Location = new Point(17, 7);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(1042, 390);
            gbFilter.TabIndex = 3;
            gbFilter.TabStop = false;
            gbFilter.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpLocal);
            tabControl1.Controls.Add(tpInternational);
            tabControl1.Location = new Point(12, 38);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1019, 336);
            tabControl1.TabIndex = 4;
            // 
            // tpLocal
            // 
            tpLocal.Controls.Add(lblLocalLicensesRecords);
            tpLocal.Controls.Add(label6);
            tpLocal.Controls.Add(dgvLocalLicensesHistory);
            tpLocal.Controls.Add(label5);
            tpLocal.Location = new Point(4, 37);
            tpLocal.Name = "tpLocal";
            tpLocal.Padding = new Padding(3);
            tpLocal.Size = new Size(1011, 295);
            tpLocal.TabIndex = 0;
            tpLocal.Text = "Local";
            tpLocal.UseVisualStyleBackColor = true;
            // 
            // lblLocalLicensesRecords
            // 
            lblLocalLicensesRecords.AutoSize = true;
            lblLocalLicensesRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalLicensesRecords.ForeColor = Color.FromArgb(29, 31, 56);
            lblLocalLicensesRecords.Location = new Point(97, 268);
            lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            lblLocalLicensesRecords.Size = new Size(31, 23);
            lblLocalLicensesRecords.TabIndex = 38;
            lblLocalLicensesRecords.Text = "???";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(29, 31, 56);
            label6.Location = new Point(6, 9);
            label6.Name = "label6";
            label6.Size = new Size(194, 23);
            label6.TabIndex = 39;
            label6.Text = "Local Licenses History :";
            // 
            // dgvLocalLicensesHistory
            // 
            dgvLocalLicensesHistory.AllowUserToAddRows = false;
            dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            dgvLocalLicensesHistory.AllowUserToResizeColumns = false;
            dgvLocalLicensesHistory.AllowUserToResizeRows = false;
            dgvLocalLicensesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLocalLicensesHistory.BackgroundColor = Color.White;
            dgvLocalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvLocalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLocalLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalLicensesHistory.ColumnHeadersHeight = 60;
            dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLocalLicensesHistory.Columns.AddRange(new DataGridViewColumn[] { colLicenseID, colApplicationID, colClassName, colIssueDate, colExpirationDate, colIsActive });
            dgvLocalLicensesHistory.ContextMenuStrip = cmsLocal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(29, 31, 56);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLocalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLocalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvLocalLicensesHistory.GridColor = Color.White;
            dgvLocalLicensesHistory.Location = new Point(-1, 42);
            dgvLocalLicensesHistory.MultiSelect = false;
            dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            dgvLocalLicensesHistory.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLocalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLocalLicensesHistory.RowHeadersWidth = 30;
            dgvLocalLicensesHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLocalLicensesHistory.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvLocalLicensesHistory.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvLocalLicensesHistory.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvLocalLicensesHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvLocalLicensesHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvLocalLicensesHistory.RowTemplate.DividerHeight = 1;
            dgvLocalLicensesHistory.ShowCellErrors = false;
            dgvLocalLicensesHistory.ShowRowErrors = false;
            dgvLocalLicensesHistory.Size = new Size(1011, 223);
            dgvLocalLicensesHistory.TabIndex = 8;
            // 
            // colLicenseID
            // 
            colLicenseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLicenseID.DataPropertyName = "LicenseID";
            colLicenseID.HeaderText = "Lic.ID";
            colLicenseID.MinimumWidth = 6;
            colLicenseID.Name = "colLicenseID";
            colLicenseID.ReadOnly = true;
            colLicenseID.Width = 130;
            // 
            // colApplicationID
            // 
            colApplicationID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colApplicationID.DataPropertyName = "ApplicationID";
            colApplicationID.HeaderText = "App ID";
            colApplicationID.MinimumWidth = 6;
            colApplicationID.Name = "colApplicationID";
            colApplicationID.ReadOnly = true;
            colApplicationID.Width = 170;
            // 
            // colClassName
            // 
            colClassName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colClassName.DataPropertyName = "ClassName";
            colClassName.HeaderText = "Class Name";
            colClassName.MinimumWidth = 6;
            colClassName.Name = "colClassName";
            colClassName.ReadOnly = true;
            // 
            // colIssueDate
            // 
            colIssueDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIssueDate.DataPropertyName = "IssueDate";
            colIssueDate.HeaderText = "Issue Date";
            colIssueDate.MinimumWidth = 6;
            colIssueDate.Name = "colIssueDate";
            colIssueDate.ReadOnly = true;
            colIssueDate.Width = 180;
            // 
            // colExpirationDate
            // 
            colExpirationDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colExpirationDate.DataPropertyName = "ExpirationDate";
            colExpirationDate.HeaderText = "Expiration Date";
            colExpirationDate.MinimumWidth = 6;
            colExpirationDate.Name = "colExpirationDate";
            colExpirationDate.ReadOnly = true;
            colExpirationDate.Width = 160;
            // 
            // colIsActive
            // 
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "Is Active";
            colIsActive.MinimumWidth = 6;
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            colIsActive.Width = 117;
            // 
            // cmsLocal
            // 
            cmsLocal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmsLocal.ImageScalingSize = new Size(20, 20);
            cmsLocal.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmsLocal.Name = "contextMenuStrip1";
            cmsLocal.Size = new Size(269, 40);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showLicenseInfoToolStripMenuItem.Image = Properties.Resources.editApplicationTypes;
            showLicenseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(268, 36);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(3, 268);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 37;
            label5.Text = "# Records";
            // 
            // tpInternational
            // 
            tpInternational.Controls.Add(lblInternationalLicensesRecords);
            tpInternational.Controls.Add(label3);
            tpInternational.Controls.Add(label1);
            tpInternational.Controls.Add(dgvInternationalLicensesHistory);
            tpInternational.Location = new Point(4, 37);
            tpInternational.Name = "tpInternational";
            tpInternational.Padding = new Padding(3);
            tpInternational.Size = new Size(1011, 295);
            tpInternational.TabIndex = 1;
            tpInternational.Text = "International";
            tpInternational.UseVisualStyleBackColor = true;
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInternationalLicensesRecords.ForeColor = Color.FromArgb(29, 31, 56);
            lblInternationalLicensesRecords.Location = new Point(97, 268);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(31, 23);
            lblInternationalLicensesRecords.TabIndex = 43;
            lblInternationalLicensesRecords.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(3, 268);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 42;
            label3.Text = "# Records";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 23);
            label1.TabIndex = 41;
            label1.Text = "International Licenses History :";
            // 
            // dgvInternationalLicensesHistory
            // 
            dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            dgvInternationalLicensesHistory.AllowUserToResizeColumns = false;
            dgvInternationalLicensesHistory.AllowUserToResizeRows = false;
            dgvInternationalLicensesHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInternationalLicensesHistory.BackgroundColor = Color.White;
            dgvInternationalLicensesHistory.BorderStyle = BorderStyle.None;
            dgvInternationalLicensesHistory.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvInternationalLicensesHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInternationalLicensesHistory.ColumnHeadersHeight = 60;
            dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInternationalLicensesHistory.Columns.AddRange(new DataGridViewColumn[] { colInternationalLicenseID, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dgvInternationalLicensesHistory.ContextMenuStrip = cmsInternational;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(29, 31, 56);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInternationalLicensesHistory.DefaultCellStyle = dataGridViewCellStyle5;
            dgvInternationalLicensesHistory.EnableHeadersVisualStyles = false;
            dgvInternationalLicensesHistory.GridColor = Color.White;
            dgvInternationalLicensesHistory.Location = new Point(-1, 42);
            dgvInternationalLicensesHistory.MultiSelect = false;
            dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            dgvInternationalLicensesHistory.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvInternationalLicensesHistory.RowHeadersWidth = 30;
            dgvInternationalLicensesHistory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvInternationalLicensesHistory.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvInternationalLicensesHistory.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvInternationalLicensesHistory.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvInternationalLicensesHistory.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvInternationalLicensesHistory.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvInternationalLicensesHistory.RowTemplate.DividerHeight = 1;
            dgvInternationalLicensesHistory.ShowCellErrors = false;
            dgvInternationalLicensesHistory.ShowRowErrors = false;
            dgvInternationalLicensesHistory.Size = new Size(1011, 221);
            dgvInternationalLicensesHistory.TabIndex = 40;
            // 
            // colInternationalLicenseID
            // 
            colInternationalLicenseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colInternationalLicenseID.DataPropertyName = "InternationalLicenseID";
            colInternationalLicenseID.HeaderText = "Int.Lic ID";
            colInternationalLicenseID.MinimumWidth = 6;
            colInternationalLicenseID.Name = "colInternationalLicenseID";
            colInternationalLicenseID.ReadOnly = true;
            colInternationalLicenseID.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn2.DataPropertyName = "ApplicationID";
            dataGridViewTextBoxColumn2.HeaderText = "App ID";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "IssueUsingLocalLicenseID";
            dataGridViewTextBoxColumn3.HeaderText = "L.License ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn4.DataPropertyName = "IssueDate";
            dataGridViewTextBoxColumn4.HeaderText = "Issue Date";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 180;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewTextBoxColumn5.DataPropertyName = "ExpirationDate";
            dataGridViewTextBoxColumn5.HeaderText = "Expiration Date";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 160;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "IsActive";
            dataGridViewTextBoxColumn6.HeaderText = "Is Active";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 117;
            // 
            // cmsInternational
            // 
            cmsInternational.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmsInternational.ImageScalingSize = new Size(20, 20);
            cmsInternational.Items.AddRange(new ToolStripItem[] { InternationalLicenseHistorytoolStripMenuItem });
            cmsInternational.Name = "contextMenuStrip1";
            cmsInternational.Size = new Size(269, 40);
            // 
            // InternationalLicenseHistorytoolStripMenuItem
            // 
            InternationalLicenseHistorytoolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            InternationalLicenseHistorytoolStripMenuItem.Image = Properties.Resources.editApplicationTypes;
            InternationalLicenseHistorytoolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            InternationalLicenseHistorytoolStripMenuItem.Name = "InternationalLicenseHistorytoolStripMenuItem";
            InternationalLicenseHistorytoolStripMenuItem.Size = new Size(268, 36);
            InternationalLicenseHistorytoolStripMenuItem.Text = "Show License Info";
            InternationalLicenseHistorytoolStripMenuItem.Click += InternationalLicenseHistorytoolStripMenuItem_Click;
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Name = "ctrlDriverLicenses";
            Size = new Size(1077, 416);
            gbFilter.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tpLocal.ResumeLayout(false);
            tpLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).EndInit();
            cmsLocal.ResumeLayout(false);
            tpInternational.ResumeLayout(false);
            tpInternational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).EndInit();
            cmsInternational.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbFilter;
        private TabControl tabControl1;
        private TabPage tpLocal;
        private TabPage tpInternational;
        private Label lblLocalLicensesRecords;
        private Label label5;
        private DataGridView dgvLocalLicensesHistory;
        private Label label6;
        private DataGridViewTextBoxColumn colLicenseID;
        private DataGridViewTextBoxColumn colApplicationID;
        private DataGridViewTextBoxColumn colClassName;
        private DataGridViewTextBoxColumn colIssueDate;
        private DataGridViewTextBoxColumn colExpirationDate;
        private DataGridViewTextBoxColumn colIsActive;
        private Label label1;
        private DataGridView dgvInternationalLicensesHistory;
        private DataGridViewTextBoxColumn colInternationalLicenseID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblInternationalLicensesRecords;
        private Label label3;
        private ContextMenuStrip cmsLocal;
        private ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private ContextMenuStrip cmsInternational;
        private ToolStripMenuItem InternationalLicenseHistorytoolStripMenuItem;
    }
}
