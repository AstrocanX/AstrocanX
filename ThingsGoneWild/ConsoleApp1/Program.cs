using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int yanlış_giriş_sayisi = 0;
            do
            {

            
            string kullanıcı_adı = "AlicanTR17";
            string şifre = "ali9311+";
            
            Console.WriteLine("Lütfen Kullanıcı Adınızı Giriniz");
            string kullanıcı_girişi = Console.ReadLine();
            Console.WriteLine("Lütfen Şifrenizi Giriniz");
            string şifre_girişi = Console.ReadLine();
            if (kullanıcı_adı== kullanıcı_girişi && şifre == şifre_girişi)

            {
                Console.WriteLine("Hesabınıza Başarıyla Giriş Yapılmıştır!");
                Console.ReadLine();

            }
            else
            {
                    Console.Clear();
                    Console.WriteLine("Yanlış Kullanıcı Adı Veya Şifre Lütfen Tekrar Deneyin");
                yanlış_giriş_sayisi++;
                    Console.WriteLine("Kalan Giriş Hakkınız :"+(3-yanlış_giriş_sayisi));
            }
                if (yanlış_giriş_sayisi==3)
                {
                    Console.WriteLine("Tüm Giriş Haklarınızı Kullandınız Lütfen Daha Sonra Tekrar Deneyiniz");
                    Console.ReadLine();
                }
            } while (yanlış_giriş_sayisi<=2 && yanlış_giriş_sayisi >0);

            

        }
    }
}
