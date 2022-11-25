using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_
{
    class Program
    {
        static void Main(string[] args)
        {

            Products Electronics = new Electronics();
            Products Books = new Books();
            ProductManagment productManagment = new ProductManagment();
            productManagment.AddProduct(Electronics);
            productManagment.AddProduct(Books);
            Console.ReadKey();
        }
    }
    //interfaces' can't new.
    interface Products
    {
        // unimplemented operation
        void Add();
        void Delete();
    }

    // implements interface ------- inherites class
    class Electronics : Products
    {
        public void Add()
        {
            Console.WriteLine("Electronic product added");
        }

        public void Delete()
        {
            Console.WriteLine("Electronic product deleted");
        }
    }
    class Books : Products
    {
        public void Add()
        {
            Console.WriteLine("Book product added");
        }

        public void Delete()
        {
            Console.WriteLine("Book product deleted");
        }
    }

    class ProductManagment
    {
        public void AddProduct(Products product)
        {

            product.Add();
        
        
        }
    
    
    
    }
}
