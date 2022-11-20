
namespace ProjectClassesDNS
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.dgrwStudentPropertyList = new System.Windows.Forms.DataGridView();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lblAddStudent = new System.Windows.Forms.Label();
            this.tbxAddStudentName = new System.Windows.Forms.TextBox();
            this.tbxAddStudentMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStudentAge = new System.Windows.Forms.Label();
            this.lblStudentMail = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lblUpdateStudent = new System.Windows.Forms.Label();
            this.lblRemoveStudent = new System.Windows.Forms.Label();
            this.tbxUpdateStudentName = new System.Windows.Forms.TextBox();
            this.tbxUpdateStudentAge = new System.Windows.Forms.TextBox();
            this.tbxUpdateStudentMail = new System.Windows.Forms.TextBox();
            this.lblUpdateStudentName = new System.Windows.Forms.Label();
            this.lblUpdateStudentAge = new System.Windows.Forms.Label();
            this.lblUpdateStudentMail = new System.Windows.Forms.Label();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnUpdateInformation = new System.Windows.Forms.Button();
            this.tbxAddStudentAge = new System.Windows.Forms.TextBox();
            this.tbxGetSchoolID = new System.Windows.Forms.TextBox();
            this.lblRemoveBySchoolID = new System.Windows.Forms.Label();
            this.lblStudentMail1 = new System.Windows.Forms.Label();
            this.lblStudentAge1 = new System.Windows.Forms.Label();
            this.lblStudentName1 = new System.Windows.Forms.Label();
            this.lblShowStudentName = new System.Windows.Forms.Label();
            this.lblShowStudentAge = new System.Windows.Forms.Label();
            this.lblShowStudentMail = new System.Windows.Forms.Label();
            this.btnChooseStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudentPropertyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrwStudentPropertyList
            // 
            this.dgrwStudentPropertyList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgrwStudentPropertyList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrwStudentPropertyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrwStudentPropertyList.GridColor = System.Drawing.Color.DarkGreen;
            this.dgrwStudentPropertyList.Location = new System.Drawing.Point(12, 34);
            this.dgrwStudentPropertyList.Name = "dgrwStudentPropertyList";
            this.dgrwStudentPropertyList.Size = new System.Drawing.Size(502, 169);
            this.dgrwStudentPropertyList.TabIndex = 0;
            this.dgrwStudentPropertyList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentList.Location = new System.Drawing.Point(236, 9);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(63, 13);
            this.lblStudentList.TabIndex = 1;
            this.lblStudentList.Text = "Student List";
            this.lblStudentList.Click += new System.EventHandler(this.lblStudentList_Click);
            // 
            // lblAddStudent
            // 
            this.lblAddStudent.AutoSize = true;
            this.lblAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAddStudent.ForeColor = System.Drawing.Color.Maroon;
            this.lblAddStudent.Location = new System.Drawing.Point(114, 220);
            this.lblAddStudent.Name = "lblAddStudent";
            this.lblAddStudent.Size = new System.Drawing.Size(66, 13);
            this.lblAddStudent.TabIndex = 2;
            this.lblAddStudent.Text = "Add Student";
            this.lblAddStudent.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxAddStudentName
            // 
            this.tbxAddStudentName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAddStudentName.ForeColor = System.Drawing.Color.White;
            this.tbxAddStudentName.Location = new System.Drawing.Point(83, 265);
            this.tbxAddStudentName.Name = "tbxAddStudentName";
            this.tbxAddStudentName.Size = new System.Drawing.Size(125, 20);
            this.tbxAddStudentName.TabIndex = 3;
            this.tbxAddStudentName.TextChanged += new System.EventHandler(this.tbxStudentName_TextChanged);
            // 
            // tbxAddStudentMail
            // 
            this.tbxAddStudentMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAddStudentMail.ForeColor = System.Drawing.Color.White;
            this.tbxAddStudentMail.Location = new System.Drawing.Point(83, 350);
            this.tbxAddStudentMail.Name = "tbxAddStudentMail";
            this.tbxAddStudentMail.Size = new System.Drawing.Size(125, 20);
            this.tbxAddStudentMail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(2, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student Name";
            // 
            // lblStudentAge
            // 
            this.lblStudentAge.AutoSize = true;
            this.lblStudentAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentAge.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStudentAge.Location = new System.Drawing.Point(2, 309);
            this.lblStudentAge.Name = "lblStudentAge";
            this.lblStudentAge.Size = new System.Drawing.Size(66, 13);
            this.lblStudentAge.TabIndex = 7;
            this.lblStudentAge.Text = "Student Age";
            // 
            // lblStudentMail
            // 
            this.lblStudentMail.AutoSize = true;
            this.lblStudentMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentMail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStudentMail.Location = new System.Drawing.Point(2, 357);
            this.lblStudentMail.Name = "lblStudentMail";
            this.lblStudentMail.Size = new System.Drawing.Size(75, 13);
            this.lblStudentMail.TabIndex = 8;
            this.lblStudentMail.Text = "Student e-Mail";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(83, 387);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(125, 41);
            this.btnAddStudent.TabIndex = 9;
            this.btnAddStudent.Text = "Add Student !";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveStudent.Location = new System.Drawing.Point(584, 385);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(123, 43);
            this.btnRemoveStudent.TabIndex = 10;
            this.btnRemoveStudent.Text = "Remove Selected Student !";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // lblUpdateStudent
            // 
            this.lblUpdateStudent.AutoSize = true;
            this.lblUpdateStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateStudent.ForeColor = System.Drawing.Color.Maroon;
            this.lblUpdateStudent.Location = new System.Drawing.Point(420, 220);
            this.lblUpdateStudent.Name = "lblUpdateStudent";
            this.lblUpdateStudent.Size = new System.Drawing.Size(182, 13);
            this.lblUpdateStudent.TabIndex = 11;
            this.lblUpdateStudent.Text = "Update or Remove Choosen Student\r\n";
            this.lblUpdateStudent.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblRemoveStudent
            // 
            this.lblRemoveStudent.AutoSize = true;
            this.lblRemoveStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemoveStudent.ForeColor = System.Drawing.Color.Maroon;
            this.lblRemoveStudent.Location = new System.Drawing.Point(615, 34);
            this.lblRemoveStudent.Name = "lblRemoveStudent";
            this.lblRemoveStudent.Size = new System.Drawing.Size(92, 13);
            this.lblRemoveStudent.TabIndex = 12;
            this.lblRemoveStudent.Text = "Choose a Student";
            this.lblRemoveStudent.Click += new System.EventHandler(this.lblRemoveStudent_Click);
            // 
            // tbxUpdateStudentName
            // 
            this.tbxUpdateStudentName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxUpdateStudentName.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateStudentName.Location = new System.Drawing.Point(324, 350);
            this.tbxUpdateStudentName.Name = "tbxUpdateStudentName";
            this.tbxUpdateStudentName.Size = new System.Drawing.Size(125, 20);
            this.tbxUpdateStudentName.TabIndex = 13;
            this.tbxUpdateStudentName.TextChanged += new System.EventHandler(this.tbxUpdateStudentName_TextChanged);
            // 
            // tbxUpdateStudentAge
            // 
            this.tbxUpdateStudentAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxUpdateStudentAge.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateStudentAge.Location = new System.Drawing.Point(455, 350);
            this.tbxUpdateStudentAge.Name = "tbxUpdateStudentAge";
            this.tbxUpdateStudentAge.Size = new System.Drawing.Size(125, 20);
            this.tbxUpdateStudentAge.TabIndex = 14;
            this.tbxUpdateStudentAge.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxUpdateStudentMail
            // 
            this.tbxUpdateStudentMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxUpdateStudentMail.ForeColor = System.Drawing.Color.White;
            this.tbxUpdateStudentMail.Location = new System.Drawing.Point(582, 350);
            this.tbxUpdateStudentMail.Name = "tbxUpdateStudentMail";
            this.tbxUpdateStudentMail.Size = new System.Drawing.Size(125, 20);
            this.tbxUpdateStudentMail.TabIndex = 15;
            this.tbxUpdateStudentMail.TextChanged += new System.EventHandler(this.tbxUpdateStudentMail_TextChanged);
            // 
            // lblUpdateStudentName
            // 
            this.lblUpdateStudentName.AutoSize = true;
            this.lblUpdateStudentName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateStudentName.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdateStudentName.Location = new System.Drawing.Point(349, 334);
            this.lblUpdateStudentName.Name = "lblUpdateStudentName";
            this.lblUpdateStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateStudentName.TabIndex = 16;
            this.lblUpdateStudentName.Text = "Student Name";
            this.lblUpdateStudentName.Click += new System.EventHandler(this.lblUpdateStudentName_Click);
            // 
            // lblUpdateStudentAge
            // 
            this.lblUpdateStudentAge.AutoSize = true;
            this.lblUpdateStudentAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateStudentAge.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdateStudentAge.Location = new System.Drawing.Point(483, 334);
            this.lblUpdateStudentAge.Name = "lblUpdateStudentAge";
            this.lblUpdateStudentAge.Size = new System.Drawing.Size(66, 13);
            this.lblUpdateStudentAge.TabIndex = 17;
            this.lblUpdateStudentAge.Text = "Student Age";
            // 
            // lblUpdateStudentMail
            // 
            this.lblUpdateStudentMail.AutoSize = true;
            this.lblUpdateStudentMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUpdateStudentMail.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUpdateStudentMail.Location = new System.Drawing.Point(602, 334);
            this.lblUpdateStudentMail.Name = "lblUpdateStudentMail";
            this.lblUpdateStudentMail.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateStudentMail.TabIndex = 18;
            this.lblUpdateStudentMail.Text = "Student e-Mail";
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateSelected.Location = new System.Drawing.Point(324, 387);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(125, 41);
            this.btnUpdateSelected.TabIndex = 19;
            this.btnUpdateSelected.Text = "Update Selected Student !";
            this.btnUpdateSelected.UseVisualStyleBackColor = false;
            this.btnUpdateSelected.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateInformation
            // 
            this.btnUpdateInformation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateInformation.Location = new System.Drawing.Point(713, 29);
            this.btnUpdateInformation.Name = "btnUpdateInformation";
            this.btnUpdateInformation.Size = new System.Drawing.Size(23, 23);
            this.btnUpdateInformation.TabIndex = 20;
            this.btnUpdateInformation.Text = "!";
            this.btnUpdateInformation.UseVisualStyleBackColor = false;
            this.btnUpdateInformation.Click += new System.EventHandler(this.btnUpdateInformation_Click);
            // 
            // tbxAddStudentAge
            // 
            this.tbxAddStudentAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxAddStudentAge.ForeColor = System.Drawing.Color.White;
            this.tbxAddStudentAge.Location = new System.Drawing.Point(83, 309);
            this.tbxAddStudentAge.Name = "tbxAddStudentAge";
            this.tbxAddStudentAge.Size = new System.Drawing.Size(125, 20);
            this.tbxAddStudentAge.TabIndex = 21;
            // 
            // tbxGetSchoolID
            // 
            this.tbxGetSchoolID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbxGetSchoolID.ForeColor = System.Drawing.Color.White;
            this.tbxGetSchoolID.Location = new System.Drawing.Point(605, 70);
            this.tbxGetSchoolID.Name = "tbxGetSchoolID";
            this.tbxGetSchoolID.Size = new System.Drawing.Size(125, 20);
            this.tbxGetSchoolID.TabIndex = 22;
            // 
            // lblRemoveBySchoolID
            // 
            this.lblRemoveBySchoolID.AutoSize = true;
            this.lblRemoveBySchoolID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemoveBySchoolID.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblRemoveBySchoolID.Location = new System.Drawing.Point(520, 73);
            this.lblRemoveBySchoolID.Name = "lblRemoveBySchoolID";
            this.lblRemoveBySchoolID.Size = new System.Drawing.Size(58, 13);
            this.lblRemoveBySchoolID.TabIndex = 23;
            this.lblRemoveBySchoolID.Text = "Student ID";
            // 
            // lblStudentMail1
            // 
            this.lblStudentMail1.AutoSize = true;
            this.lblStudentMail1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentMail1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStudentMail1.Location = new System.Drawing.Point(602, 237);
            this.lblStudentMail1.Name = "lblStudentMail1";
            this.lblStudentMail1.Size = new System.Drawing.Size(75, 13);
            this.lblStudentMail1.TabIndex = 24;
            this.lblStudentMail1.Text = "Student e-Mail";
            // 
            // lblStudentAge1
            // 
            this.lblStudentAge1.AutoSize = true;
            this.lblStudentAge1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentAge1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStudentAge1.Location = new System.Drawing.Point(349, 237);
            this.lblStudentAge1.Name = "lblStudentAge1";
            this.lblStudentAge1.Size = new System.Drawing.Size(75, 13);
            this.lblStudentAge1.TabIndex = 25;
            this.lblStudentAge1.Text = "Student Name";
            // 
            // lblStudentName1
            // 
            this.lblStudentName1.AutoSize = true;
            this.lblStudentName1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudentName1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblStudentName1.Location = new System.Drawing.Point(483, 237);
            this.lblStudentName1.Name = "lblStudentName1";
            this.lblStudentName1.Size = new System.Drawing.Size(66, 13);
            this.lblStudentName1.TabIndex = 26;
            this.lblStudentName1.Text = "Student Age";
            // 
            // lblShowStudentName
            // 
            this.lblShowStudentName.AutoSize = true;
            this.lblShowStudentName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowStudentName.Location = new System.Drawing.Point(349, 272);
            this.lblShowStudentName.Name = "lblShowStudentName";
            this.lblShowStudentName.Size = new System.Drawing.Size(0, 13);
            this.lblShowStudentName.TabIndex = 27;
            // 
            // lblShowStudentAge
            // 
            this.lblShowStudentAge.AutoSize = true;
            this.lblShowStudentAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowStudentAge.Location = new System.Drawing.Point(474, 272);
            this.lblShowStudentAge.Name = "lblShowStudentAge";
            this.lblShowStudentAge.Size = new System.Drawing.Size(0, 13);
            this.lblShowStudentAge.TabIndex = 28;
            // 
            // lblShowStudentMail
            // 
            this.lblShowStudentMail.AutoSize = true;
            this.lblShowStudentMail.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowStudentMail.Location = new System.Drawing.Point(602, 272);
            this.lblShowStudentMail.Name = "lblShowStudentMail";
            this.lblShowStudentMail.Size = new System.Drawing.Size(0, 13);
            this.lblShowStudentMail.TabIndex = 29;
            // 
            // btnChooseStudent
            // 
            this.btnChooseStudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChooseStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChooseStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseStudent.Location = new System.Drawing.Point(605, 132);
            this.btnChooseStudent.Name = "btnChooseStudent";
            this.btnChooseStudent.Size = new System.Drawing.Size(125, 23);
            this.btnChooseStudent.TabIndex = 30;
            this.btnChooseStudent.Text = "Choose Student";
            this.btnChooseStudent.UseVisualStyleBackColor = false;
            this.btnChooseStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.btnChooseStudent);
            this.Controls.Add(this.lblShowStudentMail);
            this.Controls.Add(this.lblShowStudentAge);
            this.Controls.Add(this.lblShowStudentName);
            this.Controls.Add(this.lblStudentName1);
            this.Controls.Add(this.lblStudentAge1);
            this.Controls.Add(this.lblStudentMail1);
            this.Controls.Add(this.lblRemoveBySchoolID);
            this.Controls.Add(this.tbxGetSchoolID);
            this.Controls.Add(this.tbxAddStudentAge);
            this.Controls.Add(this.btnUpdateInformation);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.lblUpdateStudentMail);
            this.Controls.Add(this.lblUpdateStudentAge);
            this.Controls.Add(this.lblUpdateStudentName);
            this.Controls.Add(this.tbxUpdateStudentMail);
            this.Controls.Add(this.tbxUpdateStudentAge);
            this.Controls.Add(this.tbxUpdateStudentName);
            this.Controls.Add(this.lblRemoveStudent);
            this.Controls.Add(this.lblUpdateStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblStudentMail);
            this.Controls.Add(this.lblStudentAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAddStudentMail);
            this.Controls.Add(this.tbxAddStudentName);
            this.Controls.Add(this.lblAddStudent);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.dgrwStudentPropertyList);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "form1";
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrwStudentPropertyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrwStudentPropertyList;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Label lblAddStudent;
        private System.Windows.Forms.TextBox tbxAddStudentName;
        private System.Windows.Forms.TextBox tbxAddStudentMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStudentAge;
        private System.Windows.Forms.Label lblStudentMail;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Label lblUpdateStudent;
        private System.Windows.Forms.Label lblRemoveStudent;
        private System.Windows.Forms.TextBox tbxUpdateStudentName;
        private System.Windows.Forms.TextBox tbxUpdateStudentAge;
        private System.Windows.Forms.TextBox tbxUpdateStudentMail;
        private System.Windows.Forms.Label lblUpdateStudentName;
        private System.Windows.Forms.Label lblUpdateStudentAge;
        private System.Windows.Forms.Label lblUpdateStudentMail;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnUpdateInformation;
        private System.Windows.Forms.TextBox tbxAddStudentAge;
        private System.Windows.Forms.TextBox tbxGetSchoolID;
        private System.Windows.Forms.Label lblRemoveBySchoolID;
        private System.Windows.Forms.Label lblStudentMail1;
        private System.Windows.Forms.Label lblStudentAge1;
        private System.Windows.Forms.Label lblStudentName1;
        private System.Windows.Forms.Label lblShowStudentName;
        private System.Windows.Forms.Label lblShowStudentAge;
        private System.Windows.Forms.Label lblShowStudentMail;
        private System.Windows.Forms.Button btnChooseStudent;
    }
}

