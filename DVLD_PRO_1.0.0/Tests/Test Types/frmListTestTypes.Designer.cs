namespace DVLD_PRO_1._0._0.Tests.Test_Types
{
    partial class frmListTestsTypes
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
            dgvTestTypes = new DataGridView();
            TestTypeID = new DataGridViewTextBoxColumn();
            TestTypeTitle = new DataGridViewTextBoxColumn();
            TestTypeDescription = new DataGridViewTextBoxColumn();
            TestTypeFees = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EditApplicationTypesMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label3 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            panel1.Size = new Size(1006, 116);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(332, 35);
            label2.Name = "label2";
            label2.Size = new Size(342, 46);
            label2.TabIndex = 5;
            label2.Text = "Manage Test Types";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToResizeColumns = false;
            dgvTestTypes.AllowUserToResizeRows = false;
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTestTypes.BackgroundColor = Color.White;
            dgvTestTypes.BorderStyle = BorderStyle.None;
            dgvTestTypes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestTypes.ColumnHeadersHeight = 60;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTestTypes.Columns.AddRange(new DataGridViewColumn[] { TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees });
            dgvTestTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTestTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTestTypes.EnableHeadersVisualStyles = false;
            dgvTestTypes.GridColor = Color.White;
            dgvTestTypes.Location = new Point(1, 140);
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTestTypes.RowHeadersWidth = 30;
            dgvTestTypes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvTestTypes.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvTestTypes.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvTestTypes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvTestTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvTestTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvTestTypes.RowTemplate.DividerHeight = 1;
            dgvTestTypes.ShowCellErrors = false;
            dgvTestTypes.ShowRowErrors = false;
            dgvTestTypes.Size = new Size(1005, 423);
            dgvTestTypes.TabIndex = 7;
            // 
            // TestTypeID
            // 
            TestTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TestTypeID.DataPropertyName = "TestTypeID";
            TestTypeID.HeaderText = "ID";
            TestTypeID.MinimumWidth = 6;
            TestTypeID.Name = "TestTypeID";
            TestTypeID.ReadOnly = true;
            TestTypeID.Width = 130;
            // 
            // TestTypeTitle
            // 
            TestTypeTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TestTypeTitle.DataPropertyName = "TestTypeTitle";
            TestTypeTitle.HeaderText = "Title";
            TestTypeTitle.MinimumWidth = 6;
            TestTypeTitle.Name = "TestTypeTitle";
            TestTypeTitle.ReadOnly = true;
            TestTypeTitle.Width = 230;
            // 
            // TestTypeDescription
            // 
            TestTypeDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TestTypeDescription.DataPropertyName = "TestTypeDescription";
            TestTypeDescription.HeaderText = "Description";
            TestTypeDescription.MinimumWidth = 6;
            TestTypeDescription.Name = "TestTypeDescription";
            TestTypeDescription.ReadOnly = true;
            TestTypeDescription.Width = 460;
            // 
            // TestTypeFees
            // 
            TestTypeFees.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TestTypeFees.DataPropertyName = "TestTypeFees";
            TestTypeFees.HeaderText = "Fees";
            TestTypeFees.MinimumWidth = 6;
            TestTypeFees.Name = "TestTypeFees";
            TestTypeFees.ReadOnly = true;
            TestTypeFees.Width = 150;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditApplicationTypesMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(225, 40);
            // 
            // EditApplicationTypesMenuItem
            // 
            EditApplicationTypesMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            EditApplicationTypesMenuItem.Image = Properties.Resources.editApplicationTypes;
            EditApplicationTypesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditApplicationTypesMenuItem.Name = "EditApplicationTypesMenuItem";
            EditApplicationTypesMenuItem.Size = new Size(224, 36);
            EditApplicationTypesMenuItem.Text = "Edit TestType";
            EditApplicationTypesMenuItem.Click += EditApplicationTypesMenuItem_Click;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 566);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 38;
            lblRecordsCount.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(12, 566);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 37;
            label3.Text = "# Records";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(839, 572);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 39;
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
            // frmListTestsTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 641);
            Controls.Add(panel2);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvTestTypes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListTestsTypes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmListTestsTypes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dgvTestTypes;
        private Label lblRecordsCount;
        private Label label3;
        private Panel panel2;
        private Button btnClose;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditApplicationTypesMenuItem;
        private DataGridViewTextBoxColumn TestTypeID;
        private DataGridViewTextBoxColumn TestTypeTitle;
        private DataGridViewTextBoxColumn TestTypeDescription;
        private DataGridViewTextBoxColumn TestTypeFees;
    }
}