using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracatices
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Job> jobs = new List<Job>
            {
                new Job {CategoryId =1,CategoryName="Doktor "},
            new Job { CategoryId = 2, CategoryName = "Mühendis " },
            new Job { CategoryId = 3, CategoryName = "Cumhurbaşkanı " },



        };







            List<Person> people = new List<Person>
            {

            new Person{Name = "Ümeysa",Age = 18,Surname = "Okurlu",NationaltyId=1,jobId=2},
                new Person{Name = "Hasan",Age = 18,Surname = "Akın",NationaltyId=2,jobId=1},
                new Person { Name = "Gül", Age = 35, Surname = "Yardımcı", NationaltyId = 3,jobId=3 },
                new Person { Name = "Özer", Age = 19, Surname = "Keleş", NationaltyId = 4 ,jobId=3},
                new Person { Name = "Cyber", Age = 18, Surname = "Selin", NationaltyId = 5 ,jobId=2}


            };



            // Ekrana Sadece Mühendis Olanları yazam bide sadece mühendis olmayan 25 yaşından büyük olanları yazam.
            foreach (var person in people)
            {
                if (person.jobId == 2)
                {
                    Console.WriteLine(person.Name);
                }
            }

            //linq ile :
            var passedPeople = people.Where(p => p.jobId != 2 && p.Age > 25);
          
            
            foreach (var passedPerson in passedPeople.ToList())
            {

                Console.WriteLine(passedPerson.Name);
            
            
            
            
            }










        }
    }
}
