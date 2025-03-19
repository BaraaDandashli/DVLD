namespace DVLD_PRO_1._0._0.User
{
    partial class ctrlUserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ctrlPersonCard1 = new People.ctrlPersonCard();
            gbFilter = new GroupBox();
            lblIsActive = new Label();
            label5 = new Label();
            lblUserName = new Label();
            label2 = new Label();
            lblUserID = new Label();
            label4 = new Label();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(5, 9);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(792, 431);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(lblIsActive);
            gbFilter.Controls.Add(label5);
            gbFilter.Controls.Add(lblUserName);
            gbFilter.Controls.Add(label2);
            gbFilter.Controls.Add(lblUserID);
            gbFilter.Controls.Add(label4);
            gbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(29, 31, 56);
            gbFilter.Location = new Point(22, 446);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(752, 98);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Login Information";
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsActive.ForeColor = Color.FromArgb(29, 31, 56);
            lblIsActive.Location = new Point(644, 40);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(48, 28);
            lblIsActive.TabIndex = 41;
            lblIsActive.Text = "????";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(29, 31, 56);
            label5.Location = new Point(534, 40);
            label5.Name = "label5";
            label5.Size = new Size(104, 28);
            label5.TabIndex = 40;
            label5.Text = "Is Active :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(29, 31, 56);
            lblUserName.Location = new Point(329, 40);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(48, 28);
            lblUserName.TabIndex = 39;
            lblUserName.Text = "????";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 31, 56);
            label2.Location = new Point(206, 40);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 38;
            label2.Text = "Username :";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.ForeColor = Color.FromArgb(29, 31, 56);
            lblUserID.Location = new Point(124, 40);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(48, 28);
            lblUserID.TabIndex = 37;
            lblUserID.Text = "????";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(26, 40);
            label4.Name = "label4";
            label4.Size = new Size(92, 28);
            label4.TabIndex = 20;
            label4.Text = "User ID :";
            // 
            // ctrlUserCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlUserCard";
            Size = new Size(795, 561);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private People.ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilter;
        private Label label4;
        private Label lblIsActive;
        private Label label5;
        private Label lblUserName;
        private Label label2;
        private Label lblUserID;
    }
}
