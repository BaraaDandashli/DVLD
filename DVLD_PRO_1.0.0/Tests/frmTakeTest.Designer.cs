namespace DVLD_PRO_1._0._0.Tests
{
    partial class frmTakeTest
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
            ctrlScheduledTest1 = new Controls.ctrlScheduledTest();
            lblUserMessage = new Label();
            label3 = new Label();
            rbPass = new RadioButton();
            rbFail = new RadioButton();
            label1 = new Label();
            txtNotes = new TextBox();
            panel3 = new Panel();
            btnSave = new Button();
            panel2 = new Panel();
            btnClose = new Button();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlScheduledTest1
            // 
            ctrlScheduledTest1.Location = new Point(12, -3);
            ctrlScheduledTest1.Name = "ctrlScheduledTest1";
            ctrlScheduledTest1.Size = new Size(556, 647);
            ctrlScheduledTest1.TabIndex = 0;
            ctrlScheduledTest1.TestTypeID = DVLD_BusinessLayer.clsTestType.enTestType.VisionTest;
            // 
            // lblUserMessage
            // 
            lblUserMessage.AutoSize = true;
            lblUserMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserMessage.ForeColor = Color.Red;
            lblUserMessage.Location = new Point(142, 695);
            lblUserMessage.Name = "lblUserMessage";
            lblUserMessage.Size = new Size(297, 28);
            lblUserMessage.TabIndex = 34;
            lblUserMessage.Text = "You cannot change the results";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 31, 56);
            label3.Location = new Point(170, 649);
            label3.Name = "label3";
            label3.Size = new Size(82, 28);
            label3.TabIndex = 33;
            label3.Text = "Result :";
            // 
            // rbPass
            // 
            rbPass.AutoSize = true;
            rbPass.Checked = true;
            rbPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            rbPass.ForeColor = Color.FromArgb(29, 31, 56);
            rbPass.Location = new Point(273, 650);
            rbPass.Name = "rbPass";
            rbPass.Size = new Size(64, 27);
            rbPass.TabIndex = 35;
            rbPass.TabStop = true;
            rbPass.Text = "Pass";
            rbPass.UseVisualStyleBackColor = true;
            // 
            // rbFail
            // 
            rbFail.AutoSize = true;
            rbFail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            rbFail.ForeColor = Color.FromArgb(29, 31, 56);
            rbFail.Location = new Point(349, 650);
            rbFail.Name = "rbFail";
            rbFail.Size = new Size(58, 27);
            rbFail.TabIndex = 36;
            rbFail.Text = "Fail";
            rbFail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 31, 56);
            label1.Location = new Point(56, 743);
            label1.Name = "label1";
            label1.Size = new Size(79, 28);
            label1.TabIndex = 37;
            label1.Text = "Notes :";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(142, 743);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(409, 87);
            txtNotes.TabIndex = 38;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSave);
            panel3.Location = new Point(296, 857);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 56);
            panel3.TabIndex = 40;
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
            panel2.Location = new Point(118, 857);
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
            // frmTakeTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 939);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(txtNotes);
            Controls.Add(label1);
            Controls.Add(rbFail);
            Controls.Add(rbPass);
            Controls.Add(lblUserMessage);
            Controls.Add(label3);
            Controls.Add(ctrlScheduledTest1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTakeTest";
            ShowIcon = false;
            Load += frmTakeTest_Load;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.ctrlScheduledTest ctrlScheduledTest1;
        private Label lblUserMessage;
        private Label label3;
        private RadioButton rbPass;
        private RadioButton rbFail;
        private Label label1;
        private TextBox txtNotes;
        private Panel panel3;
        private Button btnSave;
        private Panel panel2;
        private Button btnClose;
    }
}