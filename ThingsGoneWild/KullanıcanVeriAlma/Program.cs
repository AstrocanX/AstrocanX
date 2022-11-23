using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanıcanVeriAlma
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen Adınızı Yazınız.");

            // ReadLine ile kullanıcıdan veri alabilirsin.
            string kullanici_ismi = Console.ReadLine();
            
            
            Console.WriteLine("Lütfen Cinsetinizi Yazınız");

            string kullanici_cinsiyeti = Console.ReadLine();
            
            if (kullanici_cinsiyeti == "Erkek") {

                Console.WriteLine("Hoşgeldiniz " + kullanici_ismi + " Bey");
                Console.ReadLine();

            }
            else if (kullanici_cinsiyeti == "Kadın")
            {

                Console.WriteLine("Hoşgeldiniz " + kullanici_ismi + " Hanım");
                Console.ReadLine();

            }
            /*
            else
            {
                
                Console.WriteLine("Lütfen Cinsiyetiniz düzgün bir şekilde tekrar yazınız");
                
                Console.ReadLine();



            }


            */



        }
    }
}
