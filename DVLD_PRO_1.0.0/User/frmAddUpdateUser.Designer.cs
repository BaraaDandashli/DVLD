namespace DVLD_PRO_1._0._0.User
{
    partial class frmAddUpdateUser
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
            tabControl1 = new TabControl();
            tpPersonInfo = new TabPage();
            panel1 = new Panel();
            btnNext = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.ctrlPersonCardWithFilter();
            tpLoginInfo = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            chkIsActive = new CheckBox();
            lblUserID = new Label();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            panel1.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonInfo);
            tabControl1.Controls.Add(tpLoginInfo);
            tabControl1.Location = new Point(12, 72);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(856, 718);
            tabControl1.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(panel1);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 29);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(848, 685);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "Person Info";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNext);
            panel1.Location = new Point(675, 610);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 50);
            panel1.TabIndex = 34;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Gray;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Image = Properties.Resources.next;
            btnNext.Location = new Point(-5, -7);
            btnNext.Name = "btnNext";
            btnNext.Padding = new Padding(5, 0, 10, 0);
            btnNext.Size = new Size(135, 61);
            btnNext.TabIndex = 30;
            btnNext.Text = "Next";
            btnNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(14, 21);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(820, 594);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.Controls.Add(panel4);
            tpLoginInfo.Location = new Point(4, 29);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(848, 685);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "Login Info";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 31, 56);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(6, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(836, 673);
            panel4.TabIndex = 55;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(chkIsActive);
            panel5.Controls.Add(lblUserID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtConfirmPassword);
            panel5.Controls.Add(txtPassword);
            panel5.Controls.Add(txtUserName);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(196, 210);
            panel5.Name = "panel5";
            panel5.Size = new Size(456, 265);
            panel5.TabIndex = 0;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            chkIsActive.ForeColor = Color.FromArgb(29, 31, 56);
            chkIsActive.Location = new Point(277, 208);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(115, 32);
            chkIsActive.TabIndex = 63;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(29, 31, 56);
            lblUserID.Location = new Point(240, 27);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 28);
            lblUserID.TabIndex = 62;
            lblUserID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(129, 27);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 61;
            label4.Text = "User ID :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.FromArgb(29, 31, 56);
            txtConfirmPassword.Location = new Point(238, 158);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(192, 30);
            txtConfirmPassword.TabIndex = 60;
            txtConfirmPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.Validating += txtConfirmPassword_Validating;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(29, 31, 56);
            txtPassword.Location = new Point(238, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 30);
            txtPassword.TabIndex = 59;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(29, 31, 56);
            txtUserName.Location = new Point(238, 70);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(192, 30);
            txtUserName.TabIndex = 58;
            txtUserName.UseSystemPasswordChar = true;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(27, 159);
            label3.Name = "label3";
            label3.Size = new Size(194, 28);
            label3.TabIndex = 57;
            label3.Text = "Confirm Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(109, 115);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 56;
            label1.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(100, 71);
            label2.Name = "label2";
            label2.Size = new Size(121, 28);
            label2.TabIndex = 55;
            label2.Text = "UserName :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(29, 31, 56);
            lblTitle.Location = new Point(250, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(345, 46);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Edit Application Type";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(440, 820);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 33;
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
            panel2.Location = new Point(262, 820);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 32;
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
            // frmAddUpdateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 913);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdateUser";
            Activated += frmAddUpdateUser_Activated;
            Load += frmAddUpdateUser_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpPersonInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private TabPage tpLoginInfo;
        private Label lblTitle;
        private Panel panel1;
        private Button btnNext;
        private Panel panel3;
        private Button btnSave;
        private Panel panel2;
        private Button btnClose;
        private Panel panel4;
        private Panel panel5;
        private CheckBox chkIsActive;
        private Label lblUserID;
        private Label label4;
        private TextBox txtConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label3;
        private Label label1;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}