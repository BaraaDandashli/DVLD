namespace DVLD_PRO_1._0._0.People.Controls
{
    partial class ctrlPersonCardWithFilter
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
            ctrlPersonCard1 = new ctrlPersonCard();
            gbFilter = new GroupBox();
            panel1 = new Panel();
            btnFind = new Button();
            panel3 = new Panel();
            btnAddPerson = new Button();
            txtFilterValue = new TextBox();
            cmbFilterBy = new ComboBox();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.Location = new Point(17, 153);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(805, 434);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(panel1);
            gbFilter.Controls.Add(panel3);
            gbFilter.Controls.Add(txtFilterValue);
            gbFilter.Controls.Add(cmbFilterBy);
            gbFilter.Controls.Add(label4);
            gbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            gbFilter.ForeColor = Color.FromArgb(29, 31, 56);
            gbFilter.Location = new Point(31, 28);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(752, 107);
            gbFilter.TabIndex = 1;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFind);
            panel1.Location = new Point(605, 33);
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
            // panel3
            // 
            panel3.Controls.Add(btnAddPerson);
            panel3.Location = new Point(672, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(61, 56);
            panel3.TabIndex = 32;
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.DarkGreen;
            btnAddPerson.BackgroundImageLayout = ImageLayout.Center;
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPerson.ForeColor = Color.White;
            btnAddPerson.Image = Properties.Resources.addPersonWhite;
            btnAddPerson.Location = new Point(-7, -11);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(75, 76);
            btnAddPerson.TabIndex = 30;
            btnAddPerson.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddPerson.UseVisualStyleBackColor = false;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BackColor = Color.White;
            txtFilterValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilterValue.ForeColor = Color.FromArgb(29, 31, 56);
            txtFilterValue.Location = new Point(367, 45);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(192, 30);
            txtFilterValue.TabIndex = 30;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            txtFilterValue.Validating += txtFilterValue_Validating;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Segoe UI", 10.2F);
            cmbFilterBy.ForeColor = Color.FromArgb(29, 31, 56);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cmbFilterBy.Location = new Point(159, 45);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(192, 31);
            cmbFilterBy.TabIndex = 29;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(29, 31, 56);
            label4.Location = new Point(28, 48);
            label4.Name = "label4";
            label4.Size = new Size(99, 28);
            label4.TabIndex = 20;
            label4.Text = "Find By  :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlPersonCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(825, 625);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private GroupBox gbFilter;
        private Label label4;
        private ComboBox cmbFilterBy;
        private TextBox txtFilterValue;
        private Panel panel3;
        private Button btnAddPerson;
        private Panel panel1;
        private Button btnFind;
        private ErrorProvider errorProvider1;
    }
}
