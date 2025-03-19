namespace DVLD_PRO_1._0._0.Licenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            components = new System.ComponentModel.Container();
            ctrlDriverLicenseInfo1 = new ctrlDriverLicenseInfo();
            gbFilter = new GroupBox();
            panel1 = new Panel();
            btnFind = new Button();
            txtLicenseID = new TextBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Location = new Point(7, 113);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(926, 536);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(panel1);
            gbFilter.Controls.Add(txtLicenseID);
            gbFilter.Controls.Add(label4);
            gbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(29, 31, 56);
            gbFilter.Location = new Point(24, 13);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(452, 107);
            gbFilter.TabIndex = 2;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFind);
            panel1.Location = new Point(368, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(61, 56);
            panel1.TabIndex = 33;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(29, 31, 56);
            btnFind.BackgroundImageLayout = ImageLayout.Center;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Image = Properties.Resources.searchPerson;
            btnFind.Location = new Point(-7, -11);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 76);
            btnFind.TabIndex = 30;
            btnFind.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // txtLicenseID
            // 
            txtLicenseID.BackColor = Color.White;
            txtLicenseID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicenseID.ForeColor = Color.FromArgb(29, 31, 56);
            txtLicenseID.Location = new Point(156, 46);
            txtLicenseID.Name = "txtLicenseID";
            txtLicenseID.Size = new Size(192, 30);
            txtLicenseID.TabIndex = 30;
            txtLicenseID.KeyPress += txtLicenseID_KeyPress;
            txtLicenseID.Validating += txtLicenseID_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(28, 48);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 20;
            label4.Text = "License ID :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlDriverLicenseInfo1);
            Name = "ctrlDriverLicenseInfoWithFilter";
            Size = new Size(955, 660);
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private GroupBox gbFilter;
        private Panel panel1;
        private Button btnFind;
        private TextBox txtLicenseID;
        private Label label4;
        private ErrorProvider errorProvider1;
    }
}
