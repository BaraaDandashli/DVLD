namespace DVLD_PRO.Pepole
{
    partial class frmAddUpdatePerson
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
            lblTitle = new Label();
            panel1 = new Panel();
            panPersonInfo = new Panel();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            cbCountry = new ComboBox();
            lblRemove = new LinkLabel();
            lblSetImage = new LinkLabel();
            pbPersonImage = new PictureBox();
            label11 = new Label();
            txtPhone = new TextBox();
            label10 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            txtNationalNo = new TextBox();
            txtLastName = new TextBox();
            txtThirdName = new TextBox();
            txtSecondName = new TextBox();
            txtFirstName = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            lblPersonID = new Label();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panPersonInfo.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(376, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Person";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 31, 56);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 100);
            panel1.TabIndex = 1;
            // 
            // panPersonInfo
            // 
            panPersonInfo.Controls.Add(panel3);
            panPersonInfo.Controls.Add(panel2);
            panPersonInfo.Controls.Add(cbCountry);
            panPersonInfo.Controls.Add(lblRemove);
            panPersonInfo.Controls.Add(lblSetImage);
            panPersonInfo.Controls.Add(pbPersonImage);
            panPersonInfo.Controls.Add(label11);
            panPersonInfo.Controls.Add(txtPhone);
            panPersonInfo.Controls.Add(label10);
            panPersonInfo.Controls.Add(txtAddress);
            panPersonInfo.Controls.Add(txtEmail);
            panPersonInfo.Controls.Add(rbFemale);
            panPersonInfo.Controls.Add(rbMale);
            panPersonInfo.Controls.Add(dateTimePicker1);
            panPersonInfo.Controls.Add(label9);
            panPersonInfo.Controls.Add(txtNationalNo);
            panPersonInfo.Controls.Add(txtLastName);
            panPersonInfo.Controls.Add(txtThirdName);
            panPersonInfo.Controls.Add(txtSecondName);
            panPersonInfo.Controls.Add(txtFirstName);
            panPersonInfo.Controls.Add(label7);
            panPersonInfo.Controls.Add(label8);
            panPersonInfo.Controls.Add(label6);
            panPersonInfo.Controls.Add(label5);
            panPersonInfo.Controls.Add(label4);
            panPersonInfo.Dock = DockStyle.Bottom;
            panPersonInfo.Location = new Point(0, 173);
            panPersonInfo.Name = "panPersonInfo";
            panPersonInfo.Size = new Size(1033, 428);
            panPersonInfo.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(520, 354);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 31;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Image = DVLD_PRO_1._0._0.Properties.Resources.save;
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
            panel2.Location = new Point(342, 354);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 29;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.DarkRed;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Image = DVLD_PRO_1._0._0.Properties.Resources.close;
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
            // cbCountry
            // 
            cbCountry.Font = new Font("Segoe UI", 10.2F);
            cbCountry.ForeColor = Color.FromArgb(29, 31, 56);
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(617, 165);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(192, 31);
            cbCountry.TabIndex = 28;
            // 
            // lblRemove
            // 
            lblRemove.AutoSize = true;
            lblRemove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRemove.Location = new Point(877, 305);
            lblRemove.Name = "lblRemove";
            lblRemove.Size = new Size(85, 28);
            lblRemove.TabIndex = 27;
            lblRemove.TabStop = true;
            lblRemove.Text = "Remove";
            lblRemove.LinkClicked += lblRemove_LinkClicked;
            // 
            // lblSetImage
            // 
            lblSetImage.AutoSize = true;
            lblSetImage.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetImage.Location = new Point(867, 277);
            lblSetImage.Name = "lblSetImage";
            lblSetImage.Size = new Size(104, 28);
            lblSetImage.TabIndex = 26;
            lblSetImage.TabStop = true;
            lblSetImage.Text = "Set Image";
            lblSetImage.LinkClicked += lblSetImage_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.Image = DVLD_PRO_1._0._0.Properties.Resources.Male;
            pbPersonImage.Location = new Point(823, 67);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(192, 187);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 25;
            pbPersonImage.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(29, 31, 56);
            label11.Location = new Point(494, 166);
            label11.Name = "label11";
            label11.Size = new Size(99, 28);
            label11.TabIndex = 23;
            label11.Text = "Country :";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.FromArgb(29, 31, 56);
            txtPhone.Location = new Point(617, 120);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(192, 30);
            txtPhone.TabIndex = 22;
            txtPhone.Validating += ValidateEmptyTextBox;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(29, 31, 56);
            label10.Location = new Point(511, 118);
            label10.Name = "label10";
            label10.Size = new Size(82, 28);
            label10.TabIndex = 21;
            label10.Text = "Phone :";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.FromArgb(29, 31, 56);
            txtAddress.Location = new Point(214, 215);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(595, 119);
            txtAddress.TabIndex = 20;
            txtAddress.Validating += ValidateEmptyTextBox;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(29, 31, 56);
            txtEmail.Location = new Point(214, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 30);
            txtEmail.TabIndex = 19;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbFemale.ForeColor = Color.FromArgb(29, 31, 56);
            rbFemale.Location = new Point(295, 121);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(88, 27);
            rbFemale.TabIndex = 18;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.Click += rbFemale_Click;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbMale.ForeColor = Color.FromArgb(29, 31, 56);
            rbMale.Location = new Point(219, 121);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(70, 27);
            rbMale.TabIndex = 17;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.Click += rbMale_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.FromArgb(29, 31, 56);
            dateTimePicker1.CalendarMonthBackground = SystemColors.Control;
            dateTimePicker1.CalendarTitleForeColor = Color.FromArgb(29, 31, 56);
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(617, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(192, 34);
            dateTimePicker1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(29, 31, 56);
            label9.Location = new Point(442, 70);
            label9.Name = "label9";
            label9.Size = new Size(151, 28);
            label9.TabIndex = 15;
            label9.Text = "Date Of Birth :";
            // 
            // txtNationalNo
            // 
            txtNationalNo.BackColor = Color.White;
            txtNationalNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNationalNo.ForeColor = Color.FromArgb(29, 31, 56);
            txtNationalNo.Location = new Point(214, 71);
            txtNationalNo.Name = "txtNationalNo";
            txtNationalNo.Size = new Size(192, 30);
            txtNationalNo.TabIndex = 14;
            txtNationalNo.Validating += txtNationalNo_Validating;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = Color.FromArgb(29, 31, 56);
            txtLastName.Location = new Point(823, 22);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(192, 30);
            txtLastName.TabIndex = 13;
            txtLastName.Validating += ValidateEmptyTextBox;
            // 
            // txtThirdName
            // 
            txtThirdName.BackColor = Color.White;
            txtThirdName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtThirdName.ForeColor = Color.FromArgb(29, 31, 56);
            txtThirdName.Location = new Point(620, 23);
            txtThirdName.Name = "txtThirdName";
            txtThirdName.PlaceholderText = "Third Name";
            txtThirdName.Size = new Size(192, 30);
            txtThirdName.TabIndex = 12;
            // 
            // txtSecondName
            // 
            txtSecondName.BackColor = Color.White;
            txtSecondName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecondName.ForeColor = Color.FromArgb(29, 31, 56);
            txtSecondName.Location = new Point(417, 23);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.PlaceholderText = "Second Name";
            txtSecondName.Size = new Size(192, 30);
            txtSecondName.TabIndex = 11;
            txtSecondName.Validating += ValidateEmptyTextBox;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = Color.FromArgb(29, 31, 56);
            txtFirstName.Location = new Point(214, 23);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(192, 30);
            txtFirstName.TabIndex = 10;
            txtFirstName.Validating += ValidateEmptyTextBox;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(29, 31, 56);
            label7.Location = new Point(39, 216);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 9;
            label7.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(29, 31, 56);
            label8.Location = new Point(39, 168);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 8;
            label8.Text = "Email :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(29, 31, 56);
            label6.Location = new Point(39, 120);
            label6.Name = "label6";
            label6.Size = new Size(91, 28);
            label6.TabIndex = 7;
            label6.Text = "Gender :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(39, 72);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 6;
            label5.Text = "National No :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(39, 24);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 5;
            label4.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(39, 123);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 3;
            label2.Text = "Person ID :";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.ForeColor = Color.FromArgb(29, 31, 56);
            lblPersonID.Location = new Point(232, 123);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(51, 28);
            lblPersonID.TabIndex = 4;
            lblPersonID.Text = "N/A";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdatePerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 601);
            Controls.Add(lblPersonID);
            Controls.Add(label2);
            Controls.Add(panPersonInfo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdatePerson";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add / Edit Person Info";
            Load += frmAddUpdatePerson_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panPersonInfo.ResumeLayout(false);
            panPersonInfo.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Panel panPersonInfo;
        private Label label2;
        private Label lblPersonID;
        private TextBox txtLastName;
        private TextBox txtThirdName;
        private TextBox txtSecondName;
        private TextBox txtFirstName;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox txtNationalNo;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private PictureBox pbPersonImage;
        private Label label11;
        private TextBox txtPhone;
        private Label label10;
        private LinkLabel lblRemove;
        private LinkLabel lblSetImage;
        private ComboBox cbCountry;
        private Panel panel2;
        private Button btnClose;
        private Panel panel3;
        private Button btnSave;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}