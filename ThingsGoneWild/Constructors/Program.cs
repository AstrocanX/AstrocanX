using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        public Program()
        {

        }
        static void Main(string[] args)
        {

            Product product1 = new Product { Name = "Bardak", Stock = 10, ID = 100, Price = 50 };
            Product product2 = new Product("Akıllı Çay Bardağı", 5, 101, 1000);
            Console.WriteLine(product2.Name);
            Console.ReadLine();

        }

    }


    class Product
    {

        public Product()
        {

        }
        public Product(string name , int stock , int IDp , int price)
        {
            Name = name;
            Stock = stock;
            ID = IDp;
            Price = price;


        }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }

    }


}
