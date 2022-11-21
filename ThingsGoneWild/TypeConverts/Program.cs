using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConverts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               // Tür Dönüşümleri Bir Değişken türündeki değeri başka bir değişkene çevirmeye yarar Ör :İnt tipinde bir veriyi byte a çevirmek.
            // Tür dönüşümü yapmak için birden çok method var.
               1. Yol (Vereceğimiz Değeri paranteze alarak)(Her Veri Tipinde Çalışmayabilir.)
               int a = 5;
               

               byte b = (byte)a;
               // Eğer değeri byte veri tipinin alabileceğinden fazla verirsek "Değer Kaybı" yaşanır.

               Console.WriteLine(b.GetType());
               Console.WriteLine(b);
               Console.ReadLine();
            */
            string sayi1 = "456";
            string sayi2 = "213";
            // Bir değeri int a çevirmek için 2 yol var 1. int.Parse ile
            
            int sayi1Int = int.Parse(sayi1);
            //2. si ise Convert.ToInt32 ile çevirebiliriz. ( Convert metodu ile her veri tipininin dönüşümünü yapabiliriz.)
            int sayi2Int = Convert.ToInt32(sayi2);
            Console.WriteLine(sayi2Int.GetType());
            Console.WriteLine(sayi2Int);
            Console.WriteLine(sayi1Int.GetType());
            Console.WriteLine(sayi1Int);
            Console.WriteLine(sayi1 + sayi2);
            Console.WriteLine(sayi1Int+sayi2Int);
            
           
          //Bir değeri stringe çevirmik için yine convert i kullanabiliriz. convert.ToString ile yapabiliriz.
            long tckimlik_numarasi = 10058185678;
            string tckimliknoString = Convert.ToString(tckimlik_numarasi);

            Console.WriteLine(tckimliknoString.GetType());
            Console.WriteLine(tckimliknoString);

            Console.ReadLine();

        }
    }
}
