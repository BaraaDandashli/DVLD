namespace DVLD_PRO_1._0._0.Applications.Application_Types
{
    partial class frmEditApplicationType
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
            panel1 = new Panel();
            label2 = new Label();
            lblApplicationTypeID = new Label();
            label4 = new Label();
            txtFees = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 116);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 35);
            label2.Name = "label2";
            label2.Size = new Size(343, 46);
            label2.TabIndex = 5;
            label2.Text = "Update Application";
            // 
            // lblApplicationTypeID
            // 
            lblApplicationTypeID.AutoSize = true;
            lblApplicationTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationTypeID.ForeColor = Color.FromArgb(29, 31, 56);
            lblApplicationTypeID.Location = new Point(122, 147);
            lblApplicationTypeID.Name = "lblApplicationTypeID";
            lblApplicationTypeID.Size = new Size(48, 28);
            lblApplicationTypeID.TabIndex = 30;
            lblApplicationTypeID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(56, 147);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 29;
            label4.Text = "ID :";
            // 
            // txtFees
            // 
            txtFees.BackColor = Color.White;
            txtFees.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.ForeColor = Color.FromArgb(29, 31, 56);
            txtFees.Location = new Point(122, 232);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(280, 30);
            txtFees.TabIndex = 31;
            txtFees.Validating += txtFees_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(34, 190);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 32;
            label1.Text = "Title :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(36, 233);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 33;
            label3.Text = "Fees :";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(29, 31, 56);
            txtTitle.Location = new Point(122, 189);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(280, 30);
            txtTitle.TabIndex = 34;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(231, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 36;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save;
            btnSave.Location = new Point(-7, -11);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(10, 0, 0, 0);
            btnSave.Size = new Size(169, 76);
            btnSave.TabIndex = 30;
            btnSave.Text = "   Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(53, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 35;
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmEditApplicationType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 425);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFees);
            Controls.Add(lblApplicationTypeID);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditApplicationType";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditApplicationType_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lblApplicationTypeID;
        private Label label4;
        private TextBox txtFees;
        private Label label1;
        private Label label3;
        private TextBox txtTitle;
        private Panel panel3;
        private Button btnSave;
        private Panel panel2;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}