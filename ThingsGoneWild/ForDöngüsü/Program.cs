using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
               
            }
            ....................................
            for (int i = 1;i<=10;i+=2)
            {
                for (int j = 1; j<= i; j+=2)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine("");
            }
            */


            int a = 0;
            for (int i = 1; i <= 10; i++)
            {
               
                for (int  j =1 ;  j <=i; j++)
                {
                    
                    Console.Write(j+a);
                    
                }
                a += i;
                Console.WriteLine("");
            
            }





            Console.ReadLine();
        }

       
        
    }
}
