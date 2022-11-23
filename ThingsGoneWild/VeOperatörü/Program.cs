using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi1 = 12;
            int sayi2 = 12;
            int sayi3 = 98;
            // && işareti VE anlamına gelir eğer karşılaştırmaların hepsi doğruysa true herhangi biri yanlış ise false değeri döner. 
            bool kontrolet1 = sayi1 == sayi2 && sayi3 == sayi2;
            
            // || işareti VEYA anlamına gelir eğer karşılaştırmaların herhangi biri doğruysa true değeri hepsi yanlışsa false değeri döner.
            bool kontrolet2 = sayi1 == sayi2 || sayi3 == sayi2;
            
            Console.WriteLine(kontrolet1);
            Console.WriteLine(kontrolet2);
            Console.ReadLine(); 
        }
    }
}
