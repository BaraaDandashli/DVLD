namespace DVLD_PRO_1._0._0.User
{
    partial class frmChangePassword
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
            ctrlUserCard1 = new ctrlUserCard();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtCurrentPassword = new TextBox();
            txtNewPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlUserCard1
            // 
            ctrlUserCard1.Location = new Point(12, 12);
            ctrlUserCard1.Name = "ctrlUserCard1";
            ctrlUserCard1.Size = new Size(798, 557);
            ctrlUserCard1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(40, 597);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 40;
            label2.Text = "Current Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(40, 641);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 41;
            label1.Text = "New Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(40, 685);
            label3.Name = "label3";
            label3.Size = new Size(194, 28);
            label3.TabIndex = 42;
            label3.Text = "Confirm Password :";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.BackColor = Color.White;
            txtCurrentPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.ForeColor = Color.FromArgb(29, 31, 56);
            txtCurrentPassword.Location = new Point(254, 596);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(192, 30);
            txtCurrentPassword.TabIndex = 43;
            txtCurrentPassword.UseSystemPasswordChar = true;
            txtCurrentPassword.Validating += txtCurrentPassword_Validating;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BackColor = Color.White;
            txtNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.FromArgb(29, 31, 56);
            txtNewPassword.Location = new Point(254, 640);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(192, 30);
            txtNewPassword.TabIndex = 44;
            txtNewPassword.UseSystemPasswordChar = true;
            txtNewPassword.Validating += txtNewPassword_Validating;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.FromArgb(29, 31, 56);
            txtConfirmPassword.Location = new Point(254, 684);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(192, 30);
            txtConfirmPassword.TabIndex = 45;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(566, 587);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 47;
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
            panel2.Location = new Point(566, 661);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 46;
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
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 754);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(ctrlUserCard1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlUserCard ctrlUserCard1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private TextBox txtConfirmPassword;
        private Panel panel3;
        private Button btnSave;
        private Panel panel2;
        private Button btnClose;
        private ErrorProvider errorProvider1;
    }
}