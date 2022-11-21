using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayıProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.Sayıyı Griniz");
            long Sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sayıyı Griniz");
            long Sayi2 = Convert.ToInt32(Console.ReadLine());

            
            for (long i = Sayi1; i < Sayi2; i++)
            {
                long bölüm = 0;
                double maxsayi = Math.Sqrt(i);
                for (double bolen = 2; bolen <= maxsayi ; bolen++)
                {
                    if ((i % bolen) == 0)
                    {
                        bölüm++;
                        bolen = maxsayi + 1;
                    }
                
                
                }
                if (bölüm == 0) Console.WriteLine(i);

                


            
            }

            Console.ReadKey();
        
        
        }
    }
}
