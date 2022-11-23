using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadaşSayıProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Please enter the first number.");
            string number1string = Console.ReadLine();
            Console.WriteLine("Please enter the second number.");
            string number2string = Console.ReadLine();
            int number1 = Convert.ToInt32(number1string);
            int number2 = Convert.ToInt32(number2string);

            int compositeNumber = 0;
            int compositeNumber2 = 0;
            for (int i = 1; i < number1; i++)
            {
                if ((number1 % i) == 0)
                {
                    compositeNumber = compositeNumber + i;

                }
            }
            if (compositeNumber == number2)
            {
                for (int j = 1; j < number2; j++)
                {
                    if ((number2 % j) == 0)
                    {
                        compositeNumber2 = compositeNumber2 + j;

                    }
                }
                if (compositeNumber2 == number1)
                {
                    Console.WriteLine("Arkadaş Sayı");

                }
                else
                {
                    Console.WriteLine("Arkadaş Sayı Değil");
                }
            }
            else
            {
                Console.WriteLine("Arkadaş Sayı Değil");
            }
            Console.ReadLine();
        }
    }
}
