using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇıkarmaZinciri2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberXsFirstNumeral;
            int numberXsSecondNumeral;
            List<int> numberX = new List<int>();
            List<int> numberY = new List<int>();
            List<int> numberZ = new List<int>();

            for (int i = 10; i < 100; i++)
            {
                numberX.Add(i);
            }


            foreach (var item1 in numberX)
            {

                numberXsFirstNumeral = (item1 / 10) - ((item1 % 10) / 10);
                numberXsSecondNumeral = (item1 % 10);


                int result = numberXsFirstNumeral <= numberXsSecondNumeral ? numberXsSecondNumeral - numberXsFirstNumeral : numberXsFirstNumeral - numberXsSecondNumeral;

                if (result>1)
                {

                    numberY.Add(9 * result);
                    numberZ.Add(10 * numberXsFirstNumeral + numberXsSecondNumeral);
                
                
                }
            
            
            
            }
        





        
        
        
        }
    }
}
