using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDNSLevel2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager() ;
            Product product1 = new Product() { ProductName = "Kolye", ProductPrice = 50, UnitInStock = 30 };

            productManager.add(product1);
        
        }
    }
}
