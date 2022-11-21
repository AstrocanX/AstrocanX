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
            students = studentManegment.writeStaticData();
            RefreshDataGrid();
            RefreshEverything();

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

            if (tbxAddStudentName.Text != "" && tbxAddStudentAge.Text != "" && tbxAddStudentMail.Text != "")
            {
                Student student = new Student();
                student.Name = tbxAddStudentName.Text;
                student.Age = tbxAddStudentAge.Text;
                student.Mail = tbxAddStudentMail.Text;
                students = studentManegment.setStudentList(student);
                MessageBox.Show(studentManegment.giveMessageOutsideStudentPriorityConflictCheck());



            }
            else
            {
                MessageBox.Show("These text boxes can not be blank");
            }



            RefreshDataGrid();

        }


        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            studentManegment.removeStudent(Convert.ToInt32(tbxGetSchoolID.Text));
            MessageBox.Show(studentManegment.giveMessageOutsideIDCheck());

            RefreshEverything();
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
            Student changedStudent = new Student();
            Student studentIDCheck = new Student();
            studentIDCheck = studentManegment.getID(Convert.ToInt32(tbxGetSchoolID.Text));
            changedStudent.Name = tbxUpdateStudentName.Text  ;
            changedStudent.Age = tbxUpdateStudentAge.Text  ;
            changedStudent.Mail = tbxUpdateStudentMail.Text  ;
            studentManegment.changeStudentProperity(studentIDCheck, changedStudent);

            RefreshEverything();
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
            Student selectedStudent = new Student();

            selectedStudent = studentManegment.getID(Convert.ToInt32(tbxGetSchoolID.Text));
            string smth = studentManegment.giveMessageOutsideIDCheck() == "Changes done !" ? "Student Finded" : studentManegment.giveMessageOutsideIDCheck();
            MessageBox.Show(smth);
            lblShowStudentName.Text = selectedStudent.Name;
            lblShowStudentMail.Text = selectedStudent.Mail;
            lblShowStudentAge.Text = selectedStudent.Age;


            btnRemoveStudent.Enabled = true;
            btnUpdateSelected.Enabled = true;
            RefreshDataGrid();
        }
        public void RefreshEverything()
        {
            btnRemoveStudent.Enabled = false;
            btnUpdateSelected.Enabled = false;
            tbxGetSchoolID.Text = "";
            tbxUpdateStudentName.Text = "";
            tbxUpdateStudentAge.Text = "";
            tbxUpdateStudentMail.Text = "";
            lblShowStudentName.Text = "";
            lblShowStudentAge.Text = "";
            lblShowStudentMail.Text = "";

             

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