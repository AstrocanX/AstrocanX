using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtamaVeEşittirOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            // = Opertörü  bir sayıyı diğerine eşitler. 
            int sayi1 = 20;
            int sayi2 = 20;
            // == Opertörü 2 sayının birbirine eşit olup olmadığını kontrol eder != Operatörü tam tersidir.
            bool kontrolcu = (sayi2 == sayi1);
            bool kontrolcu2 = (sayi2 != sayi1);
            
            Console.WriteLine(kontrolcu);
            Console.WriteLine(kontrolcu2);
            Console.ReadLine();
        
        
        
        }
    }
}
