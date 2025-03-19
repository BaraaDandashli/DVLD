namespace DVLD_PRO_1._0._0.People
{
    partial class frmListPeople
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
            dgvPeopleList = new DataGridView();
            colPersonID = new DataGridViewTextBoxColumn();
            colNationalNo = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colSecondName = new DataGridViewTextBoxColumn();
            colThirdName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colDateOfBirth = new DataGridViewTextBoxColumn();
            colNationality = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            sendEmailToolStripMenuItem = new ToolStripMenuItem();
            phoneCallToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            cmbFilterBy = new ComboBox();
            txtFilterBy = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            label3 = new Label();
            lblRecordsCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPeopleList
            // 
            dgvPeopleList.AllowUserToAddRows = false;
            dgvPeopleList.AllowUserToDeleteRows = false;
            dgvPeopleList.AllowUserToResizeColumns = false;
            dgvPeopleList.AllowUserToResizeRows = false;
            dgvPeopleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPeopleList.BackgroundColor = Color.White;
            dgvPeopleList.BorderStyle = BorderStyle.None;
            dgvPeopleList.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvPeopleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeopleList.ColumnHeadersHeight = 60;
            dgvPeopleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPeopleList.Columns.AddRange(new DataGridViewColumn[] { colPersonID, colNationalNo, colFirstName, colSecondName, colThirdName, colLastName, colGender, colDateOfBirth, colNationality, colPhone, colEmail });
            dgvPeopleList.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPeopleList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeopleList.EnableHeadersVisualStyles = false;
            dgvPeopleList.GridColor = Color.White;
            dgvPeopleList.Location = new Point(12, 181);
            dgvPeopleList.MultiSelect = false;
            dgvPeopleList.Name = "dgvPeopleList";
            dgvPeopleList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPeopleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPeopleList.RowHeadersWidth = 30;
            dgvPeopleList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPeopleList.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvPeopleList.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvPeopleList.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvPeopleList.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvPeopleList.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvPeopleList.RowTemplate.DividerHeight = 1;
            dgvPeopleList.ShowCellErrors = false;
            dgvPeopleList.ShowRowErrors = false;
            dgvPeopleList.Size = new Size(1734, 559);
            dgvPeopleList.TabIndex = 1;
            dgvPeopleList.DoubleClick += dgvPeopleList_DoubleClick;
            // 
            // colPersonID
            // 
            colPersonID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPersonID.DataPropertyName = "PersonID";
            colPersonID.HeaderText = "Person ID";
            colPersonID.MinimumWidth = 6;
            colPersonID.Name = "colPersonID";
            colPersonID.ReadOnly = true;
            colPersonID.Width = 130;
            // 
            // colNationalNo
            // 
            colNationalNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNationalNo.DataPropertyName = "NationalNo";
            colNationalNo.HeaderText = "National No.";
            colNationalNo.MinimumWidth = 6;
            colNationalNo.Name = "colNationalNo";
            colNationalNo.ReadOnly = true;
            colNationalNo.Width = 170;
            // 
            // colFirstName
            // 
            colFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            colFirstName.Width = 160;
            // 
            // colSecondName
            // 
            colSecondName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colSecondName.DataPropertyName = "SecondName";
            colSecondName.HeaderText = "Second Name";
            colSecondName.MinimumWidth = 6;
            colSecondName.Name = "colSecondName";
            colSecondName.ReadOnly = true;
            colSecondName.Width = 180;
            // 
            // colThirdName
            // 
            colThirdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colThirdName.DataPropertyName = "ThirdName";
            colThirdName.HeaderText = "Third Name";
            colThirdName.MinimumWidth = 6;
            colThirdName.Name = "colThirdName";
            colThirdName.ReadOnly = true;
            colThirdName.Width = 160;
            // 
            // colLastName
            // 
            colLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            colLastName.Width = 160;
            // 
            // colGender
            // 
            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colGender.DataPropertyName = "GenderCaption";
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 160;
            // 
            // colDateOfBirth
            // 
            colDateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDateOfBirth.DataPropertyName = "DateOfBirth";
            colDateOfBirth.HeaderText = "Date Of Birth";
            colDateOfBirth.MinimumWidth = 6;
            colDateOfBirth.Name = "colDateOfBirth";
            colDateOfBirth.ReadOnly = true;
            colDateOfBirth.Width = 180;
            // 
            // colNationality
            // 
            colNationality.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colNationality.DataPropertyName = "NationalityCountryID";
            colNationality.HeaderText = "Nationality";
            colNationality.MinimumWidth = 6;
            colNationality.Name = "colNationality";
            colNationality.ReadOnly = true;
            colNationality.Width = 160;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 160;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 220;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator1, addNewToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem, toolStripSeparator2, sendEmailToolStripMenuItem, phoneCallToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(255, 232);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            showDetailsToolStripMenuItem.Image = Properties.Resources.showDetails;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(254, 36);
            showDetailsToolStripMenuItem.Text = "Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(251, 6);
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            addNewToolStripMenuItem.Image = Properties.Resources.addPerson0;
            addNewToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(254, 36);
            addNewToolStripMenuItem.Text = "Add New Person";
            addNewToolStripMenuItem.Click += addNewToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            editToolStripMenuItem.Image = Properties.Resources.editPerson;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(254, 36);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(254, 36);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.ForeColor = Color.FromArgb(29, 31, 56);
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(251, 6);
            // 
            // sendEmailToolStripMenuItem
            // 
            sendEmailToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            sendEmailToolStripMenuItem.Image = Properties.Resources.sendEmail;
            sendEmailToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            sendEmailToolStripMenuItem.Size = new Size(254, 36);
            sendEmailToolStripMenuItem.Text = "Send Email";
            sendEmailToolStripMenuItem.Click += sendEmailToolStripMenuItem_Click;
            // 
            // phoneCallToolStripMenuItem
            // 
            phoneCallToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            phoneCallToolStripMenuItem.Image = Properties.Resources.phoneCall;
            phoneCallToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            phoneCallToolStripMenuItem.Size = new Size(254, 36);
            phoneCallToolStripMenuItem.Text = "Phone Call";
            phoneCallToolStripMenuItem.Click += phoneCallToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 135);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 1;
            label1.Text = "Filter By :";
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cmbFilterBy.Location = new Point(150, 134);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(199, 31);
            cmbFilterBy.TabIndex = 2;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // txtFilterBy
            // 
            txtFilterBy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFilterBy.Location = new Point(364, 134);
            txtFilterBy.Name = "txtFilterBy";
            txtFilterBy.Size = new Size(199, 30);
            txtFilterBy.TabIndex = 3;
            txtFilterBy.TextChanged += txtFilterBy_TextChanged;
            txtFilterBy.KeyPress += txtFilterBy_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1758, 116);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(741, 36);
            label2.Name = "label2";
            label2.Size = new Size(277, 46);
            label2.TabIndex = 5;
            label2.Text = "Manage People";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(1559, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(187, 43);
            panel3.TabIndex = 32;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.addPerson;
            btnSave.Location = new Point(-7, -11);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(201, 63);
            btnSave.TabIndex = 30;
            btnSave.Text = "   Add Person";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(12, 746);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 33;
            label3.Text = "# Records";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 746);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 34;
            lblRecordsCount.Text = "???";
            // 
            // frmListPeople
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1758, 778);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(txtFilterBy);
            Controls.Add(cmbFilterBy);
            Controls.Add(label1);
            Controls.Add(dgvPeopleList);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmListPeople";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeopleList).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeopleList;
        private Label label1;
        private ComboBox cmbFilterBy;
        private TextBox txtFilterBy;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button btnSave;
        private Label label3;
        private Label lblRecordsCount;
        private DataGridViewTextBoxColumn colPersonID;
        private DataGridViewTextBoxColumn colNationalNo;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colSecondName;
        private DataGridViewTextBoxColumn colThirdName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colGender;
        private DataGridViewTextBoxColumn colDateOfBirth;
        private DataGridViewTextBoxColumn colNationality;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem sendEmailToolStripMenuItem;
        private ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}