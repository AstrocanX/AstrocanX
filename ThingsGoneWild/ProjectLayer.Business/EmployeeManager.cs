
using ProjectLayer.DataAccess;
using ProjectLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLayer.Business
{
    public class EmployeeManager
    {
        public List<Employees> getEmpB()
        {


            IEmployeeDal employeeDal;
            int i = 1;

            if (i == 1)
            {
                employeeDal = new EmployeesDalAdoNet();
            }
            else
            {
                employeeDal= new EmployeesDalEntityFramework();
            }


           
            List<Employees> employees = new List<Employees>();

          
            employees = employeeDal.getEmpI();

            
            //Business Operation
            return employees;



        }




    }
}
