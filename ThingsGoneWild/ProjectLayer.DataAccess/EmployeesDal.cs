
using ProjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace ProjectLayer.DataAccess
{
    public class EmployeesDalAdoNet : IEmployeeDal
    {

        List<Employees> employees;
        public EmployeesDalAdoNet()
        {
            employees = new List<Employees>()
            {




                new Employees{Name = "Alican",Age = 18,Surname = "Kandıran",EmpId=1},
                new Employees{Name = "Olcay",Age = 40,Surname = "Kandıran",EmpId=2},
                new Employees{Name = "Ayça",Age = 19,Surname = "Gülü",EmpId=3},
                new Employees{Name = "Joe",Age = 18,Surname = "Oyur",EmpId=4},
                new Employees{Name = "Mehmet",Age = 19,Surname = "Şenol",EmpId=5}







            };




        }













        public List<Employees> getEmpI()
        {
            return employees;
        }

        
    }

public class EmployeesDalEntityFramework : IEmployeeDal
    {

        List<Employees> employees;

        public EmployeesDalEntityFramework()
        {
            employees = new List<Employees>()
            {




                new Employees{Name = "Ümeysa",Age = 18,Surname = "Okurlu",EmpId=1},
                new Employees{Name = "Hasan",Age = 18,Surname = "Akın",EmpId=2},
                new Employees { Name = "Gül", Age = 35, Surname = "Yardımcı", EmpId = 3 },
                new Employees { Name = "Özer", Age = 19, Surname = "Keleş", EmpId = 4 },
                new Employees { Name = "Cyber", Age = 18, Surname = "Selin", EmpId = 5 }







            };
        }


       
    
    
    
    public List<Employees> getEmpI()
        {


            return employees;
        }
    
    
    
    }

}
