using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormListProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> students;
        List<string> studentsSchoolNumbers;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Alican Kandıran", "Temmuz Joe Oyur", "Haso Işık Akın" };
            studentsSchoolNumbers = new List<string>() { "12345678", "31313131", "87654321" };
            
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (tbxAddStudentName.Text.Length > 2 )
            {
                if (tbxAddStudentSurname.Text.Length > 1)
                {
                    if (tbxAddStudentSchoolNumber.Text.Length == 8 )
                    {
                        int magicalNumber = 0;
                        for (int i = 0; i < studentsSchoolNumbers.Count; i++)
                        {
                            if (tbxAddStudentSchoolNumber.Text == studentsSchoolNumbers[i])
                            {
                                magicalNumber = 1;
                            }
                        }
                        if (magicalNumber == 1)
                        {
                            MessageBox.Show("Başka bir öğrenci numarası deneyin bu numara zaten kullanımda!");
                        }
                        else
                        {
                            students.Add(tbxAddStudentName.Text + " " + tbxAddStudentSurname.Text);
                            studentsSchoolNumbers.Add(tbxAddStudentSchoolNumber.Text);
                            lbxStudentList.Items.Clear();
                            foreach (var student in students)
                            {
                                lbxStudentList.Items.Add(student);
                            }
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Your school number should has 8 characters long!");
                    }                
                }
                else
                {
                    MessageBox.Show("Your surname should has 1 or more characters long!");
                }
            }
            else
            {
                MessageBox.Show("Your name should has 2 or more characters long!");
            }


        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            int magicalNumber = 0;
            if (lbxStudentList.SelectedItem != null)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (lbxStudentList.SelectedItem == students[i])
                    {
                        magicalNumber = i;
                    }
                }
                studentsSchoolNumbers.Remove(studentsSchoolNumbers[magicalNumber]);
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            
            }
        }

        
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tbxAddStudentSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxAddStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxAddStudentSurname_Click(object sender, EventArgs e)
        {

        }

        private void tbxAddStudentSchoolNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSayTheStudentsNumber_Click(object sender, EventArgs e)
        {
            int magicalNumber = 0;
            if (lbxStudentList.SelectedItem != null)
            {
                for (int i = 0;i < students.Count; i++)
                {
                    if (lbxStudentList.SelectedItem.ToString() == students[i]) 
                    {
                        magicalNumber = i;
                    }
                }
                MessageBox.Show("This student's school number is "+studentsSchoolNumbers[magicalNumber]);
            
            }
           
        }
    }
}
