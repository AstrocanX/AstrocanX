using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectLayer.Entities
{
    public class Employees:EntitySign
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public int Age { get; set; }

        public int EmpId { get; set; }



    }
}
