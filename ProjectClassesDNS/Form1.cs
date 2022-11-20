using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectClassesDNS
{
    public partial class form1 : Form
    {
        List<Student> students = new List<Student>();
        StudentManegment studentManegment = new StudentManegment();
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblStudentList_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {



            //var studentAgeString = tbxStudentAge.Text;
            //var studentMail = tbxStudentMail.Text;
            //var studentAge = Convert.ToInt32(tbxStudentAge.Text);
            //var studentName = tbxStudentName.Text;

            if (tbxAddStudentName.Text !="" && tbxAddStudentAge.Text != "" && tbxAddStudentMail.Text != "")
            {
                Student addedStudent = studentManegment.addStudent(tbxAddStudentName.Text, tbxAddStudentAge.Text, tbxAddStudentMail.Text, students);
                if (addedStudent == null)
                {
                    MessageBox.Show("Students names and E-mails can not be same");
                }
                else
                {
                    students.Add(addedStudent);
                }
            }
            else
            {
                MessageBox.Show("These text boxes can not be blank");
            }



            RefreshDataGrid();

        }


        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            Student studentIDCheck = new Student();
            studentIDCheck = studentManegment.getID(students, Convert.ToInt32(tbxGetSchoolID.Text));    
            if (studentIDCheck == null)
            {
                MessageBox.Show("There is no students have this ID");
            }
            else
            {
                students.Remove(studentIDCheck);

            }


            RefreshDataGrid();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First of all enter your student ID and change your informations . İf there is a information dont want to change don't write anything of its text box ");
        }

        private void tbxStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Student studentIDCheck = new Student();
            studentIDCheck = studentManegment.getID(students, Convert.ToInt32(tbxGetSchoolID.Text));
            if (studentIDCheck == null)
            {
                MessageBox.Show("There is no students have this ID");
            }
            else
            {
                studentManegment.changeStudentProperity(studentIDCheck, tbxUpdateStudentName.Text, tbxUpdateStudentAge.Text, tbxUpdateStudentMail.Text);

            }

            RefreshDataGrid();



        }

        private void lblRemoveStudent_Click(object sender, EventArgs e)
        {

        }

        private void tbxUpdateStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUpdateStudentMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUpdateStudentName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student studentIDCheck = new Student();
            studentIDCheck = studentManegment.getID(students, Convert.ToInt32(tbxGetSchoolID.Text));
            if (studentIDCheck == null)
            {
                MessageBox.Show("There is no students have this ID");
            }
            else
            {
                Student selectedStudent = studentIDCheck;
                lblShowStudentName.Text = selectedStudent.Name;
                lblShowStudentMail.Text = selectedStudent.Mail;
                lblShowStudentAge.Text = Convert.ToString(selectedStudent.Age);

            }
            RefreshDataGrid();
        }
    public void RefreshDataGrid()
        {
            dgrwStudentPropertyList.DataSource = null;
            dgrwStudentPropertyList.Columns.Clear();
            dgrwStudentPropertyList.Rows.Clear();
            dgrwStudentPropertyList.DataSource = students;
            dgrwStudentPropertyList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
        }
    }
}