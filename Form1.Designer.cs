namespace EmployeeApplication1
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            lblSalary = new Label();
            button1 = new Button();
            textFname = new TextBox();
            textLname = new TextBox();
            textDept = new TextBox();
            textJTitle = new TextBox();
            textRatePerHour = new TextBox();
            textTotalhrsWorked = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 19);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(228, 81);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 193);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 293);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 6;
            label7.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 293);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 7;
            label8.Text = "<first name>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 332);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 8;
            label9.Text = "Last name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(97, 332);
            label10.Name = "label10";
            label10.Size = new Size(93, 20);
            label10.TabIndex = 9;
            label10.Text = "<last name>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 372);
            label11.Name = "label11";
            label11.Size = new Size(94, 20);
            label11.TabIndex = 10;
            label11.Text = "Basic Salary: ";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(117, 372);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(44, 20);
            lblSalary.TabIndex = 11;
            lblSalary.Text = "00.00";
            // 
            // button1
            // 
            button1.Location = new Point(155, 249);
            button1.Name = "button1";
            button1.Size = new Size(123, 35);
            button1.TabIndex = 12;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textFname
            // 
            textFname.Location = new Point(12, 42);
            textFname.Name = "textFname";
            textFname.Size = new Size(210, 27);
            textFname.TabIndex = 13;
            // 
            // textLname
            // 
            textLname.Location = new Point(228, 42);
            textLname.Name = "textLname";
            textLname.Size = new Size(231, 27);
            textLname.TabIndex = 14;
            // 
            // textDept
            // 
            textDept.Location = new Point(12, 104);
            textDept.Name = "textDept";
            textDept.Size = new Size(210, 27);
            textDept.TabIndex = 15;
            // 
            // textJTitle
            // 
            textJTitle.Location = new Point(228, 104);
            textJTitle.Name = "textJTitle";
            textJTitle.Size = new Size(231, 27);
            textJTitle.TabIndex = 16;
            // 
            // textRatePerHour
            // 
            textRatePerHour.Location = new Point(12, 216);
            textRatePerHour.Name = "textRatePerHour";
            textRatePerHour.Size = new Size(210, 27);
            textRatePerHour.TabIndex = 17;
            // 
            // textTotalhrsWorked
            // 
            textTotalhrsWorked.Location = new Point(228, 216);
            textTotalhrsWorked.Name = "textTotalhrsWorked";
            textTotalhrsWorked.Size = new Size(231, 27);
            textTotalhrsWorked.TabIndex = 18;
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 405);
            Controls.Add(textTotalhrsWorked);
            Controls.Add(textRatePerHour);
            Controls.Add(textJTitle);
            Controls.Add(textDept);
            Controls.Add(textLname);
            Controls.Add(textFname);
            Controls.Add(button1);
            Controls.Add(lblSalary);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label lblSalary;
        private Button button1;
        private TextBox textFname;
        private TextBox textLname;
        private TextBox textDept;
        private TextBox textJTitle;
        private TextBox textRatePerHour;
        private TextBox textTotalhrsWorked;
    }
}
