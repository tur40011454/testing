namespace student_grades
{
    partial class frmStudent
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStuName = new System.Windows.Forms.Label();
            this.lblStuNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbEnterMarks = new System.Windows.Forms.GroupBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuNumb = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.grpStuMarks = new System.Windows.Forms.GroupBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.grbEnterMarks.SuspendLayout();
            this.grpStuMarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(229, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Grades";
            // 
            // lblStuName
            // 
            this.lblStuName.AutoSize = true;
            this.lblStuName.Location = new System.Drawing.Point(6, 27);
            this.lblStuName.Name = "lblStuName";
            this.lblStuName.Size = new System.Drawing.Size(76, 13);
            this.lblStuName.TabIndex = 1;
            this.lblStuName.Text = "Student Grade";
            // 
            // lblStuNumber
            // 
            this.lblStuNumber.AutoSize = true;
            this.lblStuNumber.Location = new System.Drawing.Point(6, 53);
            this.lblStuNumber.Name = "lblStuNumber";
            this.lblStuNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStuNumber.TabIndex = 2;
            this.lblStuNumber.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Group";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(6, 16);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 4;
            this.lblEnglish.Text = "English";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(6, 39);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 5;
            this.lblMaths.Text = "Maths";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(6, 62);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 6;
            this.lblScience.Text = "Science";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // grbEnterMarks
            // 
            this.grbEnterMarks.Controls.Add(this.cboGroup);
            this.grbEnterMarks.Controls.Add(this.txtStuNumb);
            this.grbEnterMarks.Controls.Add(this.txtStuName);
            this.grbEnterMarks.Controls.Add(this.lblStuName);
            this.grbEnterMarks.Controls.Add(this.lblStuNumber);
            this.grbEnterMarks.Controls.Add(this.label3);
            this.grbEnterMarks.Location = new System.Drawing.Point(12, 31);
            this.grbEnterMarks.Name = "grbEnterMarks";
            this.grbEnterMarks.Size = new System.Drawing.Size(522, 112);
            this.grbEnterMarks.TabIndex = 9;
            this.grbEnterMarks.TabStop = false;
            this.grbEnterMarks.Text = "Please enter the students marks";
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(96, 24);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(100, 20);
            this.txtStuName.TabIndex = 4;
            // 
            // txtStuNumb
            // 
            this.txtStuNumb.Location = new System.Drawing.Point(96, 50);
            this.txtStuNumb.Name = "txtStuNumb";
            this.txtStuNumb.Size = new System.Drawing.Size(100, 20);
            this.txtStuNumb.TabIndex = 5;
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(96, 77);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(100, 21);
            this.cboGroup.TabIndex = 6;
            // 
            // grpStuMarks
            // 
            this.grpStuMarks.Controls.Add(this.txtScience);
            this.grpStuMarks.Controls.Add(this.txtMaths);
            this.grpStuMarks.Controls.Add(this.txtEnglish);
            this.grpStuMarks.Controls.Add(this.lblEnglish);
            this.grpStuMarks.Controls.Add(this.lblMaths);
            this.grpStuMarks.Controls.Add(this.lblScience);
            this.grpStuMarks.Location = new System.Drawing.Point(12, 150);
            this.grpStuMarks.Name = "grpStuMarks";
            this.grpStuMarks.Size = new System.Drawing.Size(522, 108);
            this.grpStuMarks.TabIndex = 10;
            this.grpStuMarks.TabStop = false;
            this.grpStuMarks.Text = "Please enter the student marks";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(96, 16);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 7;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(96, 39);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 20);
            this.txtMaths.TabIndex = 8;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(96, 62);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 9;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 398);
            this.Controls.Add(this.grpStuMarks);
            this.Controls.Add(this.grbEnterMarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudent";
            this.Text = "Student Grades";
            this.grbEnterMarks.ResumeLayout(false);
            this.grbEnterMarks.PerformLayout();
            this.grpStuMarks.ResumeLayout(false);
            this.grpStuMarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStuName;
        private System.Windows.Forms.Label lblStuNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbEnterMarks;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStuNumb;
        private System.Windows.Forms.GroupBox grpStuMarks;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
    }
}

