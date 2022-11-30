using System;
using System.Collections.Generic;
using System.Text;
using ProjectLayer.Entities;
namespace ProjectLayer.DataAccess
{
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



        public void AddEmpI(Employees employee)
        {

            employees.Add(employee);

        }

        public List<Employees> getByEmpId()
        {
            throw new NotImplementedException();
        }

        public void Update(Employees employees)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employees employees)
        {
            throw new NotImplementedException();
        }
    }


}
