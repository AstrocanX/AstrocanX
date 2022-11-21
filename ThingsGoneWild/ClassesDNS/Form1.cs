using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesDNS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Alican";
            student1.Age = 10;
            student1.Email = "ackandiran@outlook.com";

            Student student2 = new Student();
            student2.FirstName = "Joe";
            student2.Age = 31;
            student2.Email = "oçkandiran@outlook.com";

            Student student3 = new Student();
            student3.FirstName = "Yasin";
            student3.Age = 19;
            student3.Email = "yasinkargin@outlook.com";

            List<Student> students = new List<Student>() { student1, student2, student3 };
            foreach (var student in students)
            {
                //MessageBox.Show(student.FirstName+" "+student.Age+" "+student.Email);

                
            }

            dgrwStudents.DataSource = students;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
