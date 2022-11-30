using ProjectLayer.Business;
using System;
using ProjectLayer.Entities;
using ProjectLayer.DataAccess;

namespace ProjectLayer.ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int i = 0;
            
            IEmployeeDal employeeDal;
            if (i == 1)
            {
               employeeDal = new EmployeesDalAdoNet();
                
            }
            else
            {
               employeeDal= new EmployeesDalEntityFramework();
                
            
            }
            EmployeeManager employeeManager = new EmployeeManager(employeeDal);

       

            try
            {
                employeeManager.AddEmpB(new Employees { Name = "Tuncay", Surname = "Yalçınkaya", Age = 39, EmpId = 11 });
            }
            catch (PersonException exception)
            {

                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {
                throw exception;
            }

            foreach (Employees employees in employeeManager.getEmpB())
            {

                Console.WriteLine(employees.Name);

            }






        }
    }
}
