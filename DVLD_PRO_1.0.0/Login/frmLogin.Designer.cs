namespace DVLD_PRO_1._0._0.Login
{
    partial class frmLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            txtUserName = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            pbVisiblePassword = new PictureBox();
            txtPassword = new TextBox();
            btnLOGIN = new Button();
            chkRememberME = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbVisiblePassword).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 19.8F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(67, 74);
            label1.Name = "label1";
            label1.Size = new Size(117, 58);
            label1.TabIndex = 0;
            label1.Text = "Hello!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(67, 173);
            label2.Name = "label2";
            label2.Size = new Size(104, 28);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(67, 283);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtUserName);
            panel1.Location = new Point(71, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 46);
            panel1.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(50, 7);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(278, 27);
            txtUserName.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(71, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(42, 46);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 31, 56);
            pictureBox1.Image = Properties.Resources.UserName;
            pictureBox1.Location = new Point(-4, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(71, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 46);
            panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(29, 31, 56);
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(-4, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pbVisiblePassword);
            panel4.Controls.Add(txtPassword);
            panel4.Location = new Point(71, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 46);
            panel4.TabIndex = 5;
            // 
            // pbVisiblePassword
            // 
            pbVisiblePassword.BackColor = Color.White;
            pbVisiblePassword.Cursor = Cursors.Hand;
            pbVisiblePassword.Image = Properties.Resources.visiblePassword;
            pbVisiblePassword.Location = new Point(286, 5);
            pbVisiblePassword.Name = "pbVisiblePassword";
            pbVisiblePassword.Size = new Size(41, 35);
            pbVisiblePassword.SizeMode = PictureBoxSizeMode.CenterImage;
            pbVisiblePassword.TabIndex = 1;
            pbVisiblePassword.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(50, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(233, 27);
            txtPassword.TabIndex = 0;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLOGIN
            // 
            btnLOGIN.BackColor = Color.FromArgb(29, 31, 56);
            btnLOGIN.Cursor = Cursors.Hand;
            btnLOGIN.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 0);
            btnLOGIN.FlatStyle = FlatStyle.Flat;
            btnLOGIN.Font = new Font("Segoe UI", 13.8F);
            btnLOGIN.ForeColor = Color.White;
            btnLOGIN.Location = new Point(71, 458);
            btnLOGIN.Name = "btnLOGIN";
            btnLOGIN.Size = new Size(331, 64);
            btnLOGIN.TabIndex = 1;
            btnLOGIN.Text = "LOGIN";
            btnLOGIN.UseVisualStyleBackColor = false;
            btnLOGIN.Click += btnLOGIN_Click;
            // 
            // chkRememberME
            // 
            chkRememberME.AutoSize = true;
            chkRememberME.Checked = true;
            chkRememberME.CheckState = CheckState.Checked;
            chkRememberME.Cursor = Cursors.Hand;
            chkRememberME.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            chkRememberME.Location = new Point(71, 371);
            chkRememberME.Name = "chkRememberME";
            chkRememberME.Size = new Size(168, 32);
            chkRememberME.TabIndex = 7;
            chkRememberME.Text = "Remember Me";
            chkRememberME.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 622);
            Controls.Add(chkRememberME);
            Controls.Add(btnLOGIN);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbVisiblePassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtUserName;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox txtPassword;
        private PictureBox pbVisiblePassword;
        private Button btnLOGIN;
        private CheckBox chkRememberME;
    }
}