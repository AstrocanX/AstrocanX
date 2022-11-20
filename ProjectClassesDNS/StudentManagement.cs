using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassesDNS
{
    class StudentManegment

    {
        int newStudentID = 9999999;
        int newStudentSchoolNumberAdd = 0;
        public Student addStudent(string studentName, string studentAge, string studentMail, List<Student> students)
        {
            Student newStudent = new Student();

            if (students.Count == 0)
            {
                newStudent = addStudentCore(studentName, studentAge, studentMail, students);
                return newStudent;
            }

            else
            {
                newStudent = addStudentCore(studentName, studentAge, studentMail, students);
                bool checksResult = studentPriorityConflictCheck(newStudent, students);
                if (checksResult)
                {
                    newStudentID -= 1;
                    return null;
                }
                else
                {
                    return newStudent;
                }
            }




        }
        public Student addStudentCore(string studentName, string studentAge, string studentMail, List<Student> students)
        {
            int studentID = identifyStudentID();
            int studentSchoolNumber = identifyStudentSchoolNumber(students);
            Student newStudent = new Student();
            newStudent.Name = studentName;
            newStudent.Age = studentAge;
            newStudent.Mail = studentMail;
            newStudent.ID = studentID;
            newStudent.SchoolNumber = studentSchoolNumber;

            return newStudent;
        }
        public bool studentPriorityConflictCheck(Student coreStudent, List<Student> students)
        {
            Student newStudent = new Student();
            newStudent = coreStudent;
            int magicalNumber = 0;
            bool checkResult = true;
            if (students.Count != 0)
            {
                foreach (var student in students)
                {
                    if (newStudent.Name == student.Name || newStudent.Mail == student.Mail)
                    {
                        magicalNumber += 1;
                    }
                }
                if (magicalNumber == 1)
                {
                    checkResult = true;
                }
                else
                {
                    checkResult = false;
                }
            }




            return checkResult;
        }
        public int identifyStudentID()
        {


            newStudentID += 1;
            return newStudentID;

        }
        public int identifyStudentSchoolNumber(List<Student> students)
        {
            if (students.Count == 0)
            {
                newStudentSchoolNumberAdd = 0;
            }
            else
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].SchoolNumber == newStudentSchoolNumberAdd + 100)
                    {
                        newStudentSchoolNumberAdd += 1;
                    }

                }

            }




            return 100 + newStudentSchoolNumberAdd;
        }



        public Student getID(List<Student> students, int studentID)
        {

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == studentID)
                {
                    return students[i];
                }

            }



            return null;
        }
        public Student changeStudentProperity(Student student , string studentName,string studentAge,string studentMail)
        {
            student.Name = studentName == "" ? student.Name : studentName;
            student.Age = studentAge == "" ? student.Age : studentAge;
            student.Mail = studentMail == "" ? student.Mail : studentMail;
            return student;
        }

    }
}
