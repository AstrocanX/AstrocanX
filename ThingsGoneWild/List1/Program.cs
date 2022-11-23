using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = new string[] { "Kocaeli", "Diyarbakır", "Çanakkale", "Ankara", "İzmir" };

            Console.WriteLine(cities.Length);
            Console.WriteLine("-------------");
            foreach (var item in cities)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("-------------");
            List<string> cities_2 = new List<string>() { "Kocaeli", "Diyarbakır", "Çanakkale"};
            
            cities_2.Add("Ankara");
            cities_2.Add("İzmir");

            foreach (var item in cities_2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Console.WriteLine(cities_2.Count);

            Console.ReadLine();
        }
    }
}
