using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClassesDNS
{
    class StudentManegment

    {
        public StudentManegment()
        {
            students = new List<Student>()
            {
                new Student{Name="Alican",Age="18",Mail="alican@",ID=10000000,SchoolNumber=100}

            };
        }
        int newStudentID = 9999999;
        int newStudentSchoolNumberAdd = 0;
        int globalMagicalNumberAdd = 0;
        int globalMagicalNumberIDCheck = 0;
        List<Student> students;
        public List<Student> writeStaticData()
        {
            return students;
        }
        public List<Student> setStudentList(Student student)
        {
            if (studentPriorityConflictCheck(student) == false)
            {
                students.Add(addStudent(student));
            }
            else
            {
                globalMagicalNumberAdd += 1;

            }

            return students;
        }
        public Student addStudent(Student student)
        {
            Student newStudent = new Student();
            newStudent = student;



            if (students.Count == 0)
            {
                newStudent = addStudentCore(student);
                return newStudent;
            }

            else
            {
                newStudent = addStudentCore(student);
                bool checksResult = studentPriorityConflictCheck(student);
                if (checksResult)
                {
                    newStudentID -= 1;
                    return newStudent;
                }
                else
                {
                    return newStudent;
                }
            }




        }
        public Student addStudentCore(Student student)
        {

            int studentID = identifyStudentID();
            int studentSchoolNumber = identifyStudentSchoolNumber();
            Student newStudent = new Student();
            newStudent.Name = student.Name;
            newStudent.Age = student.Age;
            newStudent.Mail = student.Mail;
            newStudent.ID = studentID;
            newStudent.SchoolNumber = studentSchoolNumber;

            return newStudent;
        }
        public bool studentPriorityConflictCheck(Student coreStudent)
        {
            Student newStudent = new Student();
            newStudent = coreStudent;
            int magicalNumber = 0;
            bool checkResult = false;
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


            newStudentID = newStudentID + 1 + students.Count;
            return newStudentID;

        }
        public int identifyStudentSchoolNumber()
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



        public Student getID(int studentID)
        {

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == studentID)
                {
                    return students[i];
                }

            }


            globalMagicalNumberIDCheck += 1;
            return null;
        }
        public void changeStudentProperity(Student student, Student changedStudent)
        {
            students.Remove(student);
            student.Name = changedStudent.Name == "" ? student.Name : changedStudent.Name;
            student.Age = changedStudent.Age == "" ? student.Age : changedStudent.Age;
            student.Mail = changedStudent.Mail == "" ? student.Mail : changedStudent.Mail;

            students.Add(student);

        }

        public string giveMessageOutsideStudentPriorityConflictCheck()
        {

            if (globalMagicalNumberAdd == 1)
            {
                globalMagicalNumberAdd -= 1;
                return "Student names and e-Mails can not be same with other students";

            }
            else
            {
                return "Student Added Successfully";
            }

        }
        public string giveMessageOutsideIDCheck()
        {

            if (globalMagicalNumberIDCheck == 1)
            {
                globalMagicalNumberIDCheck -= 1;
                return "There is no students have this ID";

            }
            else
            {
                return "Changes done !";
            }

        }
        public void removeStudent(int studentID)
        {
            Student student = new Student();
            student = getID(studentID);
            if (student == null)
            {
                globalMagicalNumberIDCheck += 1;
            }
            else
            {
                students.Remove(student);
            }
        }
    }
}
