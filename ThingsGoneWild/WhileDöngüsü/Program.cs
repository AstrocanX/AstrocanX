using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("En Büyük Sayı Bulma Sihirbazına Hoşgeldiniz");
            Console.WriteLine("1.Sayıyı Giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("2.Sayıyı Giriniz");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("3.Sayıyı Giriniz");
            double sayi3 = Convert.ToDouble(Console.ReadLine());





            if (sayi1 > sayi2 && sayi1 > sayi3)
            {

                Console.WriteLine("En Büyük Sayınız :"+ sayi1);
                
            }
            else if (sayi2 > sayi3)
            {


                Console.WriteLine("En Büyük Sayınız :" + sayi2);

               
            }
            else
            {
                Console.WriteLine("En Büyük Sayınız :" + sayi3);

            }
            Console.Read();
        }
    }
}
