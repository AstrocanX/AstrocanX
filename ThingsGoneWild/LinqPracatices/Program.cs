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
            //foreach (var person in people)
            //{
            //    if (person.jobId == 2)
            //    {
            //        Console.WriteLine(person.Name);
            //    }
            //}

            //linq ile :
            //IEnumerable<Person> passedPeople = NewLinq(people);
            //FindLinq(people);
            //SmthToOrder(people);
            //AnyLinq(people);
            //ClassicLinq(people);

            var result = from p in people
                         join c in jobs
                         on p.jobId equals c.CategoryId
                         where p.Age > 18
                         orderby p.Name 
                         
                         select new PersonDto { Name = p.Name, CategoryName = c.CategoryName, Age = p.Age, jobId = p.jobId, Surname = p.Surname };


            foreach (var item in result)
            {
                Console.WriteLine("{0} ---- {1} ---- {2}",item.Name,item.Age,item.CategoryName);
            }
        
        
        
        
        }

        
        
        
        
        
        
        
        private static void ClassicLinq(List<Person> people)
        {
            var People = from p in people
                         where p.Age >= 18
                         orderby p.Age descending
                         select p;

            foreach (var item in People)
            {
                // Console.WriteLine(item.Name);
            }
        }

        private static void AnyLinq(List<Person> people)
        {
            var result = people.Any(p => p.jobId == 2);//True veya False Döner.
        }

        private static void SmthToOrder(List<Person> people)
        {
            var smth = people.FindAll(p => p.Age > 18).OrderBy(p => p.Name);// OrderByDescending yazarsam tam tersi şekilde sıralar

            foreach (var item in smth)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void FindLinq(List<Person> people)
        {
            var passedPeople = people.Find(p => p.Age == 35);
            Console.WriteLine(passedPeople.Name);
        }

        private static IEnumerable<Person> NewLinq(List<Person> people)
        {

            return people.Where(p => p.jobId != 2 && p.Age > 25);


        }
    }
}
