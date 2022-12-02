using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPracatices
{

    class PersonDto // Data transformation object
    {
        public int jobId { get; set; }
        public int Age { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string CategoryName { get; set; }
    }
        class Person
        {
            public int jobId  { get; set; }
            public int Age { get; set; }
            public int NationaltyId { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
        class Job
        {
            public string CategoryName { get; set; }
            public int CategoryId { get; set; }



        }
    
    
    



}
