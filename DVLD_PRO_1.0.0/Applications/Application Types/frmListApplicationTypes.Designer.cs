namespace DVLD_PRO_1._0._0.Applications.Application_Types
{
    partial class frmListApplicationTypes
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
            dgvApplicationTypes = new DataGridView();
            ApplicationTypeID = new DataGridViewTextBoxColumn();
            ApplicationTypeTitle = new DataGridViewTextBoxColumn();
            ApplicationFees = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            EditApplicationTypesMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lblRecordsCount = new Label();
            btnClose = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
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
            panel1.Size = new Size(823, 116);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(179, 35);
            label2.Name = "label2";
            label2.Size = new Size(464, 46);
            label2.TabIndex = 5;
            label2.Text = "Manage Application Types";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeColumns = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dgvApplicationTypes.BorderStyle = BorderStyle.None;
            dgvApplicationTypes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 53, 85);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvApplicationTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicationTypes.ColumnHeadersHeight = 60;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvApplicationTypes.Columns.AddRange(new DataGridViewColumn[] { ApplicationTypeID, ApplicationTypeTitle, ApplicationFees });
            dgvApplicationTypes.ContextMenuStrip = contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvApplicationTypes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvApplicationTypes.EnableHeadersVisualStyles = false;
            dgvApplicationTypes.GridColor = Color.White;
            dgvApplicationTypes.Location = new Point(0, 146);
            dgvApplicationTypes.MultiSelect = false;
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvApplicationTypes.RowHeadersWidth = 30;
            dgvApplicationTypes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvApplicationTypes.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvApplicationTypes.RowTemplate.DefaultCellStyle.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            dgvApplicationTypes.RowTemplate.DefaultCellStyle.ForeColor = Color.FromArgb(33, 53, 85);
            dgvApplicationTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dgvApplicationTypes.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.FromArgb(33, 53, 85);
            dgvApplicationTypes.RowTemplate.DividerHeight = 1;
            dgvApplicationTypes.ShowCellErrors = false;
            dgvApplicationTypes.ShowRowErrors = false;
            dgvApplicationTypes.Size = new Size(820, 387);
            dgvApplicationTypes.TabIndex = 6;
            // 
            // ApplicationTypeID
            // 
            ApplicationTypeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApplicationTypeID.DataPropertyName = "ApplicationTypeID";
            ApplicationTypeID.HeaderText = "ID";
            ApplicationTypeID.MinimumWidth = 6;
            ApplicationTypeID.Name = "ApplicationTypeID";
            ApplicationTypeID.ReadOnly = true;
            ApplicationTypeID.Width = 130;
            // 
            // ApplicationTypeTitle
            // 
            ApplicationTypeTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApplicationTypeTitle.DataPropertyName = "ApplicationTypeTitle";
            ApplicationTypeTitle.HeaderText = "Title";
            ApplicationTypeTitle.MinimumWidth = 6;
            ApplicationTypeTitle.Name = "ApplicationTypeTitle";
            ApplicationTypeTitle.ReadOnly = true;
            ApplicationTypeTitle.Width = 500;
            // 
            // ApplicationFees
            // 
            ApplicationFees.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ApplicationFees.DataPropertyName = "ApplicationFees";
            ApplicationFees.HeaderText = "Fees";
            ApplicationFees.MinimumWidth = 6;
            ApplicationFees.Name = "ApplicationFees";
            ApplicationFees.ReadOnly = true;
            ApplicationFees.Width = 160;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { EditApplicationTypesMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(302, 40);
            // 
            // EditApplicationTypesMenuItem
            // 
            EditApplicationTypesMenuItem.ForeColor = Color.FromArgb(29, 31, 56);
            EditApplicationTypesMenuItem.Image = Properties.Resources.editApplicationTypes;
            EditApplicationTypesMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            EditApplicationTypesMenuItem.Name = "EditApplicationTypesMenuItem";
            EditApplicationTypesMenuItem.Size = new Size(301, 36);
            EditApplicationTypesMenuItem.Text = "Edit Application Type";
            EditApplicationTypesMenuItem.Click += EditApplicationTypesMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(12, 547);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 35;
            label3.Text = "# Records";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.FromArgb(29, 31, 56);
            lblRecordsCount.Location = new Point(106, 547);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(31, 23);
            lblRecordsCount.TabIndex = 36;
            lblRecordsCount.Text = "???";
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
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(656, 554);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 37;
            // 
            // frmListApplicationTypes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 626);
            Controls.Add(panel2);
            Controls.Add(lblRecordsCount);
            Controls.Add(label3);
            Controls.Add(dgvApplicationTypes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmListApplicationTypes";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmListApplicationTypes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView dgvApplicationTypes;
        private DataGridViewTextBoxColumn ApplicationTypeID;
        private DataGridViewTextBoxColumn ApplicationTypeTitle;
        private DataGridViewTextBoxColumn ApplicationFees;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem EditApplicationTypesMenuItem;
        private Label label3;
        private Label lblRecordsCount;
        private Button btnClose;
        private Panel panel2;
    }
}