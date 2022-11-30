
using ProjectLayer.DataAccess;
using ProjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLayer.Business
{
    public class EmployeeManager
    {
        IEmployeeDal employeeDal;
        public EmployeeManager(IEmployeeDal employeeDalSample)
        {
            employeeDal = employeeDalSample;









        }




        public List<Employees> getEmpB()
        {
            List<Employees> employees = new List<Employees>();






            employees = employeeDal.getEmpI();


            //Business Operation
            return employees;



        }

        public void AddEmpB(Employees newEmployee)
        {

            //Business Operation
            if (newEmployee.Name == "Tuncay")
            {
                throw new PersonException("Tuncay yok o yok kurtaramssın artık onu sal gitsin.");
            }
            
            employeeDal.AddEmpI(newEmployee);

        }


    }
}
