
namespace FormListProject
{
    partial class Form1
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
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lblAddStudentName = new System.Windows.Forms.Label();
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lbxAddStudentSurname = new System.Windows.Forms.Label();
            this.lbxAddStudentSchoolNumber = new System.Windows.Forms.Label();
            this.tbxAddStudentSurname = new System.Windows.Forms.TextBox();
            this.tbxAddStudentSchoolNumber = new System.Windows.Forms.TextBox();
            this.btnSayTheStudentsNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(67, 69);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(63, 13);
            this.lblStudentList.TabIndex = 0;
            this.lblStudentList.Text = "Student List";
            this.lblStudentList.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAddStudentName
            // 
            this.lblAddStudentName.AutoSize = true;
            this.lblAddStudentName.Location = new System.Drawing.Point(386, 120);
            this.lblAddStudentName.Name = "lblAddStudentName";
            this.lblAddStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblAddStudentName.TabIndex = 1;
            this.lblAddStudentName.Text = "Student Name";
            this.lblAddStudentName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.Location = new System.Drawing.Point(28, 100);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(149, 212);
            this.lbxStudentList.TabIndex = 2;
            // 
            // tbxAddStudentName
            // 
            this.tbxAddStudentName.Location = new System.Drawing.Point(488, 117);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(264, 20);
            this.tbxAddStudentName.TabIndex = 3;
            this.tbxAddStudentName.TextChanged += new System.EventHandler(this.tbxAddStudentName_TextChanged);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(626, 324);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(126, 34);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(28, 318);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(149, 46);
            this.btnRemoveStudent.TabIndex = 5;
            this.btnRemoveStudent.Text = "Remove Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // lbxAddStudentSurname
            // 
            this.lbxAddStudentSurname.AutoSize = true;
            this.lbxAddStudentSurname.Location = new System.Drawing.Point(372, 185);
            this.lbxAddStudentSurname.Name = "lbxAddStudentSurname";
            this.lbxAddStudentSurname.Size = new System.Drawing.Size(89, 13);
            this.lbxAddStudentSurname.TabIndex = 6;
            this.lbxAddStudentSurname.Text = "Student Surname";
            this.lbxAddStudentSurname.Click += new System.EventHandler(this.lbxAddStudentSurname_Click);
            // 
            // lbxAddStudentSchoolNumber
            // 
            this.lbxAddStudentSchoolNumber.AutoSize = true;
            this.lbxAddStudentSchoolNumber.Location = new System.Drawing.Point(362, 249);
            this.lbxAddStudentSchoolNumber.Name = "lbxAddStudentSchoolNumber";
            this.lbxAddStudentSchoolNumber.Size = new System.Drawing.Size(120, 13);
            this.lbxAddStudentSchoolNumber.TabIndex = 7;
            this.lbxAddStudentSchoolNumber.Text = "Student School Number";
            this.lbxAddStudentSchoolNumber.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tbxAddStudentSurname
            // 
            this.tbxAddStudentSurname.Location = new System.Drawing.Point(488, 182);
            this.tbxAddStudentSurname.Name = "tbxAddStudentSurname";
            this.tbxAddStudentSurname.Size = new System.Drawing.Size(264, 20);
            this.tbxAddStudentSurname.TabIndex = 8;
            this.tbxAddStudentSurname.TextChanged += new System.EventHandler(this.tbxAddStudentSurname_TextChanged);
            // 
            // tbxAddStudentSchoolNumber
            // 
            this.tbxAddStudentSchoolNumber.Location = new System.Drawing.Point(488, 246);
            this.tbxAddStudentSchoolNumber.Name = "tbxAddStudentSchoolNumber";
            this.tbxAddStudentSchoolNumber.Size = new System.Drawing.Size(264, 20);
            this.tbxAddStudentSchoolNumber.TabIndex = 9;
            this.tbxAddStudentSchoolNumber.TextChanged += new System.EventHandler(this.tbxAddStudentSchoolNumber_TextChanged);
            // 
            // btnSayTheStudentsNumber
            // 
            this.btnSayTheStudentsNumber.Location = new System.Drawing.Point(183, 100);
            this.btnSayTheStudentsNumber.Name = "btnSayTheStudentsNumber";
            this.btnSayTheStudentsNumber.Size = new System.Drawing.Size(69, 212);
            this.btnSayTheStudentsNumber.TabIndex = 10;
            this.btnSayTheStudentsNumber.Text = "Question the chosen student school number";
            this.btnSayTheStudentsNumber.UseVisualStyleBackColor = true;
            this.btnSayTheStudentsNumber.Click += new System.EventHandler(this.btnSayTheStudentsNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSayTheStudentsNumber);
            this.Controls.Add(this.tbxAddStudentSchoolNumber);
            this.Controls.Add(this.tbxAddStudentSurname);
            this.Controls.Add(this.lbxAddStudentSchoolNumber);
            this.Controls.Add(this.lbxAddStudentSurname);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxAddStudentName);
            this.Controls.Add(this.lbxStudentList);
            this.Controls.Add(this.lblAddStudentName);
            this.Controls.Add(this.lblStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblAddStudentName;
        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.TextBox tbxAddStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Label lbxAddStudentSurname;
        private System.Windows.Forms.Label lbxAddStudentSchoolNumber;
        private System.Windows.Forms.TextBox tbxAddStudentSurname;
        private System.Windows.Forms.TextBox tbxAddStudentSchoolNumber;
        private System.Windows.Forms.Button btnSayTheStudentsNumber;
    }
}

