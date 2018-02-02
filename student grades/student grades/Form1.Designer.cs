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
            this.grbEnterMarks = new System.Windows.Forms.GroupBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.txtStuNumb = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.grpStuMarks = new System.Windows.Forms.GroupBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblStuDetails = new System.Windows.Forms.Label();
            this.lblAvgMark = new System.Windows.Forms.Label();
            this.lblStuGrade = new System.Windows.Forms.Label();
            this.txtStuDetails = new System.Windows.Forms.TextBox();
            this.txtAvgMark = new System.Windows.Forms.TextBox();
            this.txtStuGrade = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbEnterMarks.SuspendLayout();
            this.grpStuMarks.SuspendLayout();
            this.grpResults.SuspendLayout();
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
            this.grpStuMarks.Location = new System.Drawing.Point(12, 149);
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
            // grpResults
            // 
            this.grpResults.Controls.Add(this.btnExit);
            this.grpResults.Controls.Add(this.btnClear);
            this.grpResults.Controls.Add(this.btnCalculate);
            this.grpResults.Controls.Add(this.txtStuGrade);
            this.grpResults.Controls.Add(this.txtAvgMark);
            this.grpResults.Controls.Add(this.txtStuDetails);
            this.grpResults.Controls.Add(this.lblStuGrade);
            this.grpResults.Controls.Add(this.lblAvgMark);
            this.grpResults.Controls.Add(this.lblStuDetails);
            this.grpResults.Location = new System.Drawing.Point(12, 263);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(522, 121);
            this.grpResults.TabIndex = 11;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblStuDetails
            // 
            this.lblStuDetails.AutoSize = true;
            this.lblStuDetails.Location = new System.Drawing.Point(1, 20);
            this.lblStuDetails.Name = "lblStuDetails";
            this.lblStuDetails.Size = new System.Drawing.Size(79, 13);
            this.lblStuDetails.TabIndex = 0;
            this.lblStuDetails.Text = "Student Details";
            // 
            // lblAvgMark
            // 
            this.lblAvgMark.AutoSize = true;
            this.lblAvgMark.Location = new System.Drawing.Point(1, 44);
            this.lblAvgMark.Name = "lblAvgMark";
            this.lblAvgMark.Size = new System.Drawing.Size(74, 13);
            this.lblAvgMark.TabIndex = 1;
            this.lblAvgMark.Text = "Average Mark";
            // 
            // lblStuGrade
            // 
            this.lblStuGrade.AutoSize = true;
            this.lblStuGrade.Location = new System.Drawing.Point(1, 70);
            this.lblStuGrade.Name = "lblStuGrade";
            this.lblStuGrade.Size = new System.Drawing.Size(76, 13);
            this.lblStuGrade.TabIndex = 2;
            this.lblStuGrade.Text = "Student Grade";
            // 
            // txtStuDetails
            // 
            this.txtStuDetails.Location = new System.Drawing.Point(86, 20);
            this.txtStuDetails.Name = "txtStuDetails";
            this.txtStuDetails.Size = new System.Drawing.Size(212, 20);
            this.txtStuDetails.TabIndex = 3;
            // 
            // txtAvgMark
            // 
            this.txtAvgMark.Location = new System.Drawing.Point(86, 44);
            this.txtAvgMark.Name = "txtAvgMark";
            this.txtAvgMark.Size = new System.Drawing.Size(110, 20);
            this.txtAvgMark.TabIndex = 4;
            // 
            // txtStuGrade
            // 
            this.txtStuGrade.Location = new System.Drawing.Point(86, 70);
            this.txtStuGrade.Name = "txtStuGrade";
            this.txtStuGrade.Size = new System.Drawing.Size(212, 20);
            this.txtStuGrade.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(428, 20);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(428, 44);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(428, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 389);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpStuMarks);
            this.Controls.Add(this.grbEnterMarks);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmStudent";
            this.Text = "Student Grades";
            this.grbEnterMarks.ResumeLayout(false);
            this.grbEnterMarks.PerformLayout();
            this.grpStuMarks.ResumeLayout(false);
            this.grpStuMarks.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
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
        private System.Windows.Forms.GroupBox grbEnterMarks;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStuNumb;
        private System.Windows.Forms.GroupBox grpStuMarks;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtStuGrade;
        private System.Windows.Forms.TextBox txtAvgMark;
        private System.Windows.Forms.TextBox txtStuDetails;
        private System.Windows.Forms.Label lblStuGrade;
        private System.Windows.Forms.Label lblAvgMark;
        private System.Windows.Forms.Label lblStuDetails;
    }
}

