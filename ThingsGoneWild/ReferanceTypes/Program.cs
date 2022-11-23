using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //int number1 = 10;
            //int number2 = 20;

            //number1 = number2;
            //number2 = 100;
            //Console.WriteLine(number1); 
            ////number1 equals 20 .





            ////KeyWordsForRemember=STACK,HEAP,REFERANCETYPES,VALUETYPES
            //int[] numbers1 = new int[] { 1, 2, 3 };
            //int[] numbers2 = new int[] { 10, 20, 30 };

            //numbers1 = numbers2;
            //numbers2[0] = 1000;
            //Console.WriteLine(numbers1[0]);
            ////numbers1[i] equals 1000.

            

            Person person = new Person();
            Turkish turkish = new Turkish();
            Syrian syrian = new Syrian();

            person.Name = "Alican";
            turkish.Name = "Olcay";
            turkish.id = 1231313123;
            syrian.Name = "eveveve";
            person = turkish;
            turkish.Name = "Can";
            //Console.WriteLine(person.Name);       
            // person id datasınıda tutar ama direk person olarak gösteremeyiz boxing(?) yaparız.
            Console.WriteLine(((Turkish)person).id);

            PersonManagment personManagment = new PersonManagment();
            personManagment.add(syrian);
        
        
        
        Console.ReadKey();
        
        }


        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int PhoneNumber  { get; set; }
        }
        class Turkish:Person
        {
            public int id { get; set; }
        }
        class Syrian:Person
        {
            public int refugeeİd { get; set; }
        }

        class PersonManagment
        {

        
        public void add(Person person)
            {


                Console.WriteLine(person.Name);
            
            
            }
        
        
        }
            
            
        
        
      }
    }

