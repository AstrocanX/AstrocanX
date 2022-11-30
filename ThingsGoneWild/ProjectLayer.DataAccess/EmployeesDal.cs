
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







        public void AddEmpI(Employees employee)
        {


            employees.Add(employee);

        }

        public void Delete(Employees employees)
        {
            throw new NotImplementedException();
        }

        public List<Employees> getByEmpId()
        {
            throw new NotImplementedException();
        }

        public List<Employees> getEmpI()
        {
            return employees;
        }

        public void Update(Employees employees)
        {
            throw new NotImplementedException();
        }
    }

}
