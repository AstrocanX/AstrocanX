using ProjectLayer.Business;
using System;
using ProjectLayer.Entities;


namespace ProjectLayer.ConsoleUI1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            EmployeeManager employeeManager = new EmployeeManager();

            
            foreach (Employees employees in employeeManager.getEmpB())
            {

                Console.WriteLine(employees.Name);

            }


        }
    }
}
