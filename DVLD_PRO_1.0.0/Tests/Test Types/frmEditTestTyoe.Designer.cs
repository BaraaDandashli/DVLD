namespace DVLD_PRO_1._0._0.Tests.Test_Types
{
    partial class frmEditTestTyoe
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
            panel3 = new Panel();
            btnSave = new Button();
            txtTitle = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtFees = new TextBox();
            lblTestTypeID = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            txtDescription = new TextBox();
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
            panel1.Size = new Size(473, 116);
            panel1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(80, 35);
            label2.Name = "label2";
            label2.Size = new Size(313, 46);
            label2.TabIndex = 5;
            label2.Text = "Update Test Type";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(250, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 45;
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
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.FromArgb(29, 31, 56);
            txtTitle.Location = new Point(171, 190);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(280, 30);
            txtTitle.TabIndex = 43;
            txtTitle.Validating += txtTitle_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(80, 234);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 42;
            label3.Text = "Fees :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(78, 191);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 41;
            label1.Text = "Title :";
            // 
            // txtFees
            // 
            txtFees.BackColor = Color.White;
            txtFees.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.ForeColor = Color.FromArgb(29, 31, 56);
            txtFees.Location = new Point(171, 233);
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(280, 30);
            txtFees.TabIndex = 40;
            txtFees.Validating += txtFees_Validating;
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypeID.ForeColor = Color.FromArgb(29, 31, 56);
            lblTestTypeID.Location = new Point(171, 148);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(48, 28);
            lblTestTypeID.TabIndex = 39;
            lblTestTypeID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(100, 148);
            label4.Name = "label4";
            label4.Size = new Size(44, 28);
            label4.TabIndex = 38;
            label4.Text = "ID :";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(72, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 44;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 47;
            label5.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.FromArgb(29, 31, 56);
            txtDescription.Location = new Point(171, 279);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 108);
            txtDescription.TabIndex = 46;
            txtDescription.Validating += txtDescription_Validating;
            // 
            // frmEditTestTyoe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 532);
            Controls.Add(label5);
            Controls.Add(txtDescription);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtFees);
            Controls.Add(lblTestTypeID);
            Controls.Add(label4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmEditTestTyoe";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmEditTestTyoe_Load;
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
        private Panel panel3;
        private Button btnSave;
        private TextBox txtTitle;
        private Label label3;
        private Label label1;
        private TextBox txtFees;
        private Label lblTestTypeID;
        private Label label4;
        private Panel panel2;
        private Button btnClose;
        private ErrorProvider errorProvider1;
        private Label label5;
        private TextBox txtDescription;
    }
}