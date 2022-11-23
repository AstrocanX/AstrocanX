using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 200;
            int number2 = 300;
            string result = number1 > number2 ? "Number1 is bigger" : "Number2 is bigger";
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
