namespace DVLD_PRO_1._0._0.Tests
{
    partial class frmListTestAppointments
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
            ctrlDrivingLicenseApplicationInfo1 = new Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo();
            panel1 = new Panel();
            lblTitle = new Label();
            dgvLicenseTestAppointments = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EditMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            panel3 = new Panel();
            btnAddAppointment = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            lblRecordsCount = new Label();
            label2 = new Label();
            AppointmentID = new DataGridViewTextBoxColumn();
            AppointmentDate = new DataGridViewTextBoxColumn();
            PaidFees = new DataGridViewTextBoxColumn();
            IsLocked = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(2, 139);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(1094, 472);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 0;
            ctrlDrivingLicenseApplicationInfo1.Load += ctrlDrivingLicenseApplicationInfo1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 140);
            panel1.TabIndex = 48;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(446, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(192, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Vision Test";
            // 
            // dgvLicenseTestAppointments
            // 
            dgvLicenseTestAppointments.AllowUserToAddRows = false;
            dgvLicenseTestAppointments.AllowUserToDeleteRows = false;
            dgvLicenseTestAppointments.AllowUserToResizeColumns = false;
            dgvLicenseTestAppointments.AllowUserToResizeRows = false;
            dgvLicenseTestAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvLicenseTestAppointments.BackgroundColor = Color.White;
            dgvLicenseTestAppointments.BorderStyle = BorderStyle.None;
            dgvLicenseTestAppointments.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLicenseTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLicenseTestAppointments.ColumnHeadersHeight = 60;
            dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLicenseTestAppointments.Columns.AddRange(new DataGridViewColumn[] { AppointmentID, AppointmentDate, PaidFees, IsLocked });
            dgvLicenseTestAppointments.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvLicenseTestAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            dgvLicenseTestAppointments.EnableHeadersVisualStyles = false;
            dgvLicenseTestAppointments.GridColor = Color.White;
            dgvLicenseTestAppointments.Location = new Point(51, 646);
            dgvLicenseTestAppointments.MultiSelect = false;
            dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            dgvLicenseTestAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvLicenseTestAppointments.RowHeadersWidth = 30;
            dgvLicenseTestAppointments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvLicenseTestAppointments.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvLicenseTestAppointments.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvLicenseTestAppointments.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvLicenseTestAppointments.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvLicenseTestAppointments.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvLicenseTestAppointments.RowTemplate.DividerHeight = 1;
            dgvLicenseTestAppointments.ShowCellErrors = false;
            dgvLicenseTestAppointments.ShowRowErrors = false;
            dgvLicenseTestAppointments.Size = new Size(992, 202);
            dgvLicenseTestAppointments.TabIndex = 49;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditMenuItem, takeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(186, 76);
            // 
            // EditMenuItem
            // 
            EditMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            EditMenuItem.Image = Properties.Resources.editApplicationTypes;
            EditMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditMenuItem.Name = "EditMenuItem";
            EditMenuItem.Size = new Size(185, 36);
            EditMenuItem.Text = "Edit";
            EditMenuItem.Click += EditMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(185, 36);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(51, 614);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 50;
            label3.Text = "Appointments :";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnAddAppointment);
            panel3.Location = new Point(887, 871);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 52;
            // 
            // btnAddAppointment
            // 
            btnAddAppointment.BackColor = Color.DarkGreen;
            btnAddAppointment.FlatStyle = FlatStyle.Flat;
            btnAddAppointment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAppointment.ForeColor = Color.White;
            btnAddAppointment.Image = Properties.Resources.next;
            btnAddAppointment.Location = new Point(-7, -11);
            btnAddAppointment.Name = "btnAddAppointment";
            btnAddAppointment.Padding = new Padding(10, 0, 0, 0);
            btnAddAppointment.Size = new Size(169, 76);
            btnAddAppointment.TabIndex = 30;
            btnAddAppointment.Text = "   ADD";
            btnAddAppointment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAppointment.UseVisualStyleBackColor = false;
            btnAddAppointment.Click += btnAddAppointment_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(719, 871);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 53;
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
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(145, 856);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 55;
            lblRecordsCount.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(51, 856);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 54;
            label2.Text = "# Records";
            // 
            // AppointmentID
            // 
            AppointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AppointmentID.DataPropertyName = "TestAppointmentID";
            AppointmentID.HeaderText = "Appointment ID";
            AppointmentID.MinimumWidth = 6;
            AppointmentID.Name = "AppointmentID";
            AppointmentID.ReadOnly = true;
            AppointmentID.Width = 250;
            // 
            // AppointmentDate
            // 
            AppointmentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            AppointmentDate.DataPropertyName = "AppointmentDate";
            AppointmentDate.HeaderText = "Appointment Date";
            AppointmentDate.MinimumWidth = 6;
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.ReadOnly = true;
            AppointmentDate.Width = 280;
            // 
            // PaidFees
            // 
            PaidFees.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PaidFees.DataPropertyName = "PaidFees";
            PaidFees.HeaderText = "Paid Fees";
            PaidFees.MinimumWidth = 6;
            PaidFees.Name = "PaidFees";
            PaidFees.ReadOnly = true;
            PaidFees.Width = 250;
            // 
            // IsLocked
            // 
            IsLocked.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IsLocked.DataPropertyName = "IsLocked";
            IsLocked.HeaderText = "Is Locked";
            IsLocked.MinimumWidth = 6;
            IsLocked.Name = "IsLocked";
            IsLocked.ReadOnly = true;
            IsLocked.Width = 180;
            // 
            // frmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 944);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(dgvLicenseTestAppointments);
            Controls.Add(panel1);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListTestAppointments";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmListTestAppointments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Applications.Local_Driving_License.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private Panel panel1;
        private Label lblTitle;
        private DataGridView dgvLicenseTestAppointments;
        private DataGridViewTextBoxColumn AppointmentID;
        private DataGridViewTextBoxColumn AppointmentDate;
        private DataGridViewTextBoxColumn PaidFees;
        private DataGridViewTextBoxColumn IsLocked;
        private Label label3;
        private Panel panel3;
        private Button btnAddAppointment;
        private Panel panel2;
        private Button btnClose;
        private Label lblRecordsCount;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}