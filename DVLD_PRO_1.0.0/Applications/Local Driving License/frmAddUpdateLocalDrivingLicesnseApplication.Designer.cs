namespace DVLD_PRO_1._0._0.Applications.Local_Driving_License
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            tabControl1 = new TabControl();
            tpPersonInfo = new TabPage();
            panel1 = new Panel();
            btnApplicationInfoNext = new Button();
            ctrlPersonCardWithFilter1 = new People.Controls.ctrlPersonCardWithFilter();
            tpApplicationInfo = new TabPage();
            panel4 = new Panel();
            panel5 = new Panel();
            cbLicesnseClass = new ComboBox();
            lblCreatedByUser = new Label();
            lblAppFees = new Label();
            lblAppDate = new Label();
            label5 = new Label();
            lblDLAppID = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            tabControl1.SuspendLayout();
            tpPersonInfo.SuspendLayout();
            panel1.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPersonInfo);
            tabControl1.Controls.Add(tpApplicationInfo);
            tabControl1.Location = new Point(12, 93);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(864, 700);
            tabControl1.TabIndex = 0;
            // 
            // tpPersonInfo
            // 
            tpPersonInfo.Controls.Add(panel1);
            tpPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonInfo.Location = new Point(4, 29);
            tpPersonInfo.Name = "tpPersonInfo";
            tpPersonInfo.Padding = new Padding(3);
            tpPersonInfo.Size = new Size(856, 667);
            tpPersonInfo.TabIndex = 0;
            tpPersonInfo.Text = "PersonInfo";
            tpPersonInfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnApplicationInfoNext);
            panel1.Location = new Point(637, 595);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 50);
            panel1.TabIndex = 35;
            // 
            // btnApplicationInfoNext
            // 
            btnApplicationInfoNext.BackColor = Color.Gray;
            btnApplicationInfoNext.FlatStyle = FlatStyle.Flat;
            btnApplicationInfoNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplicationInfoNext.ForeColor = Color.White;
            btnApplicationInfoNext.Image = Properties.Resources.next;
            btnApplicationInfoNext.Location = new Point(-5, -7);
            btnApplicationInfoNext.Name = "btnApplicationInfoNext";
            btnApplicationInfoNext.Padding = new Padding(5, 0, 10, 0);
            btnApplicationInfoNext.Size = new Size(135, 61);
            btnApplicationInfoNext.TabIndex = 30;
            btnApplicationInfoNext.Text = "Next";
            btnApplicationInfoNext.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnApplicationInfoNext.UseVisualStyleBackColor = false;
            btnApplicationInfoNext.Click += btnApplicationInfoNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(6, 6);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(837, 596);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.Controls.Add(panel4);
            tpApplicationInfo.Location = new Point(4, 29);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Padding = new Padding(3);
            tpApplicationInfo.Size = new Size(856, 667);
            tpApplicationInfo.TabIndex = 1;
            tpApplicationInfo.Text = "Application Info";
            tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(29, 31, 56);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(-4, -5);
            panel4.Name = "panel4";
            panel4.Size = new Size(865, 675);
            panel4.TabIndex = 56;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(cbLicesnseClass);
            panel5.Controls.Add(lblCreatedByUser);
            panel5.Controls.Add(lblAppFees);
            panel5.Controls.Add(lblAppDate);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(lblDLAppID);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(174, 210);
            panel5.Name = "panel5";
            panel5.Size = new Size(508, 265);
            panel5.TabIndex = 0;
            // 
            // cbLicesnseClass
            // 
            cbLicesnseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicesnseClass.Font = new Font("Segoe UI", 10.2F);
            cbLicesnseClass.ForeColor = Color.FromArgb(29, 31, 56);
            cbLicesnseClass.FormattingEnabled = true;
            cbLicesnseClass.Location = new Point(240, 110);
            cbLicesnseClass.Name = "cbLicesnseClass";
            cbLicesnseClass.Size = new Size(232, 31);
            cbLicesnseClass.TabIndex = 68;
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.ForeColor = Color.FromArgb(29, 31, 56);
            lblCreatedByUser.Location = new Point(240, 195);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(48, 28);
            lblCreatedByUser.TabIndex = 67;
            lblCreatedByUser.Text = "????";
            // 
            // lblAppFees
            // 
            lblAppFees.AutoSize = true;
            lblAppFees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppFees.ForeColor = Color.FromArgb(29, 31, 56);
            lblAppFees.Location = new Point(240, 153);
            lblAppFees.Name = "lblAppFees";
            lblAppFees.Size = new Size(48, 28);
            lblAppFees.TabIndex = 66;
            lblAppFees.Text = "$$$";
            // 
            // lblAppDate
            // 
            lblAppDate.AutoSize = true;
            lblAppDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppDate.ForeColor = Color.FromArgb(29, 31, 56);
            lblAppDate.Location = new Point(240, 69);
            lblAppDate.Name = "lblAppDate";
            lblAppDate.Size = new Size(102, 28);
            lblAppDate.TabIndex = 65;
            lblAppDate.Text = "??/??/????";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(95, 195);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 64;
            label5.Text = "Created By :";
            // 
            // lblDLAppID
            // 
            lblDLAppID.AutoSize = true;
            lblDLAppID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDLAppID.ForeColor = Color.FromArgb(29, 31, 56);
            lblDLAppID.Location = new Point(240, 27);
            lblDLAppID.Name = "lblDLAppID";
            lblDLAppID.Size = new Size(48, 28);
            lblDLAppID.TabIndex = 62;
            lblDLAppID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(28, 27);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 61;
            label4.Text = "D.L.Application ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(42, 153);
            label3.Name = "label3";
            label3.Size = new Size(179, 28);
            label3.TabIndex = 57;
            label3.Text = "Application Fees :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(76, 111);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 56;
            label1.Text = "License Class :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(38, 69);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 55;
            label2.Text = "Application Date :";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(29, 31, 56);
            lblTitle.Location = new Point(176, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(528, 46);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Local Driving License Application";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(440, 809);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 35;
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
            panel2.Location = new Point(262, 809);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 34;
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
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 885);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(lblTitle);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Activated += frmAddUpdateLocalDrivingLicesnseApplication_Activated;
            Load += frmAddUpdateLocalDrivingLicesnseApplication_Load;
            tabControl1.ResumeLayout(false);
            tpPersonInfo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpPersonInfo;
        private TabPage tpApplicationInfo;
        private People.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label lblTitle;
        private Panel panel1;
        private Button btnApplicationInfoNext;
        private Panel panel3;
        private Button btnSave;
        private Panel panel2;
        private Button btnClose;
        private Panel panel4;
        private Panel panel5;
        private Label lblDLAppID;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label lblCreatedByUser;
        private Label lblAppFees;
        private Label lblAppDate;
        private ComboBox cbLicesnseClass;
    }
}