using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = new int[3];
            numbers[0] = 3;
            numbers[1] = 10;
            numbers[2] = 99;
            Console.WriteLine(numbers.Min());


            Console.ReadLine();





            /*
            
            if (numbers[0] > numbers[1] && numbers[0] > numbers[2])
            {
                if (numbers[1] > numbers[2])
                {
                    Console.WriteLine(numbers[0] + ">" + numbers[1] + ">" + numbers[2]);

                }
                else
                {
                    Console.WriteLine(numbers[0] + ">" + numbers[2] + ">" + numbers[1]);
                }

            }
            else if (numbers[1] > numbers[2])
            {
                if (numbers[0] > numbers[2])
                {
                    Console.WriteLine(numbers[1] + ">" + numbers[0] + ">" + numbers[2]);
                }
                else
                {
                    Console.WriteLine(numbers[1] + ">" + numbers[2] + ">" + numbers[0]);
                }
            }
            else
            {
                if (numbers[0] > numbers[1])
                {
                    Console.WriteLine(numbers[2] + ">" + numbers[0] + ">" + numbers[1]);
                }
                else
                {
                    Console.WriteLine(numbers[2] + ">" + numbers[1] + ">" + numbers[0]);
                }
            }
            Console.ReadLine();
        */
        }

    }
}
