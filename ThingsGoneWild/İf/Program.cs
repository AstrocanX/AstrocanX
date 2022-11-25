using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x den y ye kadarki Sayıları Toplama Sihirbazına Hoş Geldiniz");
            Console.WriteLine("Lütfen 1.Sayıyı Giriniz");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Sayıyı Giriniz");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                int numberofnumber = number1 - number2 + 1;
               int middlenumber = (number1 + number2) / 2;
                int totalequals = middlenumber * numberofnumber;
                Console.WriteLine(totalequals);

            }
            else if (number2 > number1)
            {
                int numberofnumber = number2 - number1 + 1 ;
                int middlenumber = (number1 + number2) / 2;
                int totalequals = middlenumber * numberofnumber;
                Console.WriteLine(totalequals);
            }
            else
            {
                Console.WriteLine("0");
                Console.ReadLine();
            }


            Console.ReadLine();
        }
        static int Number(int numbers)
        {
            return numbers;
        }


    }
}
