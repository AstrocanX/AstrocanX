using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beden_Kitle_EndeksiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beden Kitle Endeksi Uygulamasına HoşGeldiniz!");

            Console.WriteLine("Lütfen Kilonuzu Kg Cinsinden Giriniz");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen Boyunuzu Cm Cinsiden Giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());
            boy = boy / 100;
            double bedenkitle_endeksi1 = kilo / (boy * boy);
            int bedenkitle_endeksi = Convert.ToInt32(bedenkitle_endeksi1);
            if (bedenkitle_endeksi <= 18 && bedenkitle_endeksi > 0) 
            {
                Console.WriteLine("Şişmanlık Ölçütünüz : Zayıf");
                Console.WriteLine("Beden Kitle Endeksi Değeriniz : " + bedenkitle_endeksi);
                Console.ReadLine();
            }
            else if (bedenkitle_endeksi > 18 && bedenkitle_endeksi <= 25) 
            {
                Console.WriteLine("Şişmanlık Ölçütünüz : Normal");
                Console.WriteLine("Beden Kitle Endeksi Değeriniz : " + bedenkitle_endeksi);
                Console.ReadLine();
            }
             else if (bedenkitle_endeksi > 25 && bedenkitle_endeksi <= 30) 
            {
                Console.WriteLine("Şişmanlık Ölçütünüz : Fazla Kilolu!");
                Console.WriteLine("Beden Kitle Endeksi Değeriniz : " + bedenkitle_endeksi);
                Console.ReadLine();
            }
            else if (bedenkitle_endeksi > 30)
            {
                Console.WriteLine("Şişmanlık Ölçütünüz : Obezite!");
                Console.WriteLine("Beden Kitle Endeksi Değeriniz : " + bedenkitle_endeksi);
                Console.ReadLine();
            }
            
            else
            {
                Console.WriteLine("Lütfen Kilonuzu Ve Boyunuzu Doğru girdiğinizden emin olunuz");
                Console.ReadLine();
            }






        }
    }
}
