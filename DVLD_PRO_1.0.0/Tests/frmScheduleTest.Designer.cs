﻿namespace DVLD_PRO_1._0._0.Tests.Test_Types
{
    partial class frmScheduleTest
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
            ctrlSecheduleTest1 = new Controls.ctrlSecheduleTest();
            panel2 = new Panel();
            btnClose = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlSecheduleTest1
            // 
            ctrlSecheduleTest1.Location = new Point(12, 4);
            ctrlSecheduleTest1.Name = "ctrlSecheduleTest1";
            ctrlSecheduleTest1.Size = new Size(546, 818);
            ctrlSecheduleTest1.TabIndex = 0;
            ctrlSecheduleTest1.TestTypeID = DVLD_BusinessLayer.clsTestType.enTestType.StreetTest;
            ctrlSecheduleTest1.Load += ctrlSecheduleTest1_Load;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClose);
            panel2.Location = new Point(200, 845);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 56);
            panel2.TabIndex = 30;
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
            // frmScheduleTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 931);
            Controls.Add(panel2);
            Controls.Add(ctrlSecheduleTest1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmScheduleTest";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmScheduleTest_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlSecheduleTest ctrlSecheduleTest1;
        private Panel panel2;
        private Button btnClose;
    }
}