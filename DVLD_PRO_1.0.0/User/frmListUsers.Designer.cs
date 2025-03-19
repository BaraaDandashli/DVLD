namespace DVLD_PRO_1._0._0.User
{
    partial class frmListUsers
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
            lblTitle = new Label();
            txtFilterBy = new TextBox();
            cmbFilterBy = new ComboBox();
            label1 = new Label();
            dgvUsersList = new DataGridView();
            colUserID = new DataGridViewTextBoxColumn();
            colPersonID = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colIsActive = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnAddUser = new Button();
            cmbIsActive = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1179, 100);
            panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(467, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(245, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Users";
            // 
            // txtFilterBy
            // 
            txtFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilterBy.ForeColor = Color.FromArgb(29, 31, 56);
            txtFilterBy.Location = new Point(365, 119);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(199, 30);
            txtFilterBy.TabIndex = 6;
            txtFilterBy.TextChanged += txtFilterValue_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilterBy.ForeColor = Color.FromArgb(29, 31, 56);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "User ID", "UserName", "Person ID", "Full Name", "Is Active" });
            cmbFilterBy.Location = new Point(156, 119);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(199, 31);
            cmbFilterBy.TabIndex = 5;
            cmbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(21, 120);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 4;
            label1.Text = "Filter By :";
            // 
            // dgvUsersList
            // 
            dgvUsersList.AllowUserToAddRows = false;
            dgvUsersList.AllowUserToDeleteRows = false;
            dgvUsersList.AllowUserToResizeColumns = false;
            dgvUsersList.AllowUserToResizeRows = false;
            dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUsersList.BackgroundColor = Color.White;
            dgvUsersList.BorderStyle = BorderStyle.None;
            dgvUsersList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsersList.ColumnHeadersHeight = 60;
            dgvUsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsersList.Columns.AddRange(new DataGridViewColumn[] { colUserID, colPersonID, colFullName, colUserName, colIsActive });
            dgvUsersList.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsersList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsersList.EnableHeadersVisualStyles = false;
            dgvUsersList.GridColor = Color.White;
            dgvUsersList.Location = new Point(12, 171);
            dgvUsersList.MultiSelect = false;
            dgvUsersList.Name = "dgvUsersList";
            dgvUsersList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsersList.RowHeadersWidth = 30;
            dgvUsersList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvUsersList.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvUsersList.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvUsersList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvUsersList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvUsersList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvUsersList.RowTemplate.DividerHeight = 1;
            dgvUsersList.ShowCellErrors = false;
            dgvUsersList.ShowRowErrors = false;
            dgvUsersList.Size = new Size(1155, 421);
            dgvUsersList.TabIndex = 7;
            dgvUsersList.DoubleClick += dgvUsersList_DoubleClick;
            // 
            // colUserID
            // 
            colUserID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUserID.DataPropertyName = "UserID";
            colUserID.HeaderText = "User ID";
            colUserID.MinimumWidth = 6;
            colUserID.Name = "colUserID";
            colUserID.ReadOnly = true;
            colUserID.Width = 130;
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
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colUserName
            // 
            colUserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUserName.DataPropertyName = "UserName";
            colUserName.HeaderText = "User Name";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            colUserName.Width = 180;
            // 
            // colIsActive
            // 
            colIsActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colIsActive.DataPropertyName = "IsActive";
            colIsActive.HeaderText = "Is Active";
            colIsActive.MinimumWidth = 6;
            colIsActive.Name = "colIsActive";
            colIsActive.ReadOnly = true;
            colIsActive.Width = 160;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripMenuItem1, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(264, 268);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showDetailsToolStripMenuItem.Image = Properties.Resources.showDetails;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(263, 36);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(260, 6);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            addNewToolStripMenuItem.Image = Properties.Resources.addPerson0;
            addNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(263, 36);
            addNewToolStripMenuItem.Text = "Add New User";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            editToolStripMenuItem.Image = Properties.Resources.editPerson;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(263, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(263, 36);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.changePassord;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(263, 36);
            toolStripMenuItem1.Text = "Change Password";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(260, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            sendEmailToolStripMenuItem.Image = Properties.Resources.sendEmail;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(263, 36);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            phoneCallToolStripMenuItem.Image = Properties.Resources.phoneCall;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(263, 36);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 610);
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
            label3.Location = new Point(12, 610);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 35;
            label3.Text = "# Records";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddUser);
            panel3.Location = new Point(978, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 43);
            panel3.TabIndex = 37;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Green;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Image = Properties.Resources.addPerson;
            btnAddUser.Location = new Point(-7, -11);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Padding = new Padding(10, 0, 0, 0);
            btnAddUser.Size = new Size(201, 63);
            btnAddUser.TabIndex = 30;
            btnAddUser.Text = "   Add User";
            btnAddUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // cmbIsActive
            // 
            cmbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIsActive.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbIsActive.ForeColor = Color.FromArgb(29, 31, 56);
            cmbIsActive.FormattingEnabled = true;
            cmbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cmbIsActive.Location = new Point(365, 119);
            cmbIsActive.Name = "cmbIsActive";
            cmbIsActive.Size = new Size(105, 31);
            cmbIsActive.TabIndex = 38;
            cmbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // frmListUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 642);
            Controls.Add(cmbIsActive);
            Controls.Add(panel3);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvUsersList);
            Controls.Add(txtFilterBy);
            Controls.Add(cmbFilterBy);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListUsers";
            Load += frmListUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private TextBox txtFilterBy;
        private ComboBox cmbFilterBy;
        private Label label1;
        private DataGridView dgvUsersList;
        private DataGridViewTextBoxColumn colUserID;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colIsActive;
        private Label lblRecordsCount;
        private Label label3;
        private Panel panel3;
        private Button btnAddUser;
        private ComboBox cmbIsActive;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}