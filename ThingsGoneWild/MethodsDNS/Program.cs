using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDNS
{
    class Program
    {
        static void Main(string[] args)
        {
            EasyCalculator easyCalculator = new EasyCalculator();



            int result = easyCalculator.addition(90, 9, 99);
            int result2 = easyCalculator.addition(90);//2.Parametre opsiyonel girmessem 0 değerini alacak.
            int result3 = easyCalculator.addition(number2: 50, number1: 99);
            int result4 = easyCalculator.additionParams(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            int result5 = easyCalculator.additionParams(1, 2, 3, 4, 5, 6);//Params olmasaydı böyle yazamazdım.
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);

            Console.ReadLine();





        }
    }
    class EasyCalculator
    {
        //  EasyCalculator.addition methoduna 2 parametre girersem 1.si 3 parametre girersem 2.si çalışır bunada OVERLOADING denir.
        public int addition(int number1, int number2 = 0)
        {
            return number1 + number2;


        }
        public int addition(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;


        }
        public int additionParams(params int[] numbers)
        {
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }


    }
}
