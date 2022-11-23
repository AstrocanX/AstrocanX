using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇıkarmaZinciri
{
    class Program
    {


        static void Main(string[] args)
        {

            LotsOfFor temporaryNumber = new LotsOfFor();
            int magicalNumber = 0;
            List<LotsOfFor> numberXs = new List<LotsOfFor>();

            List<int> numberXsFirst = new List<int>();
            List<int> numberXsReal = new List<int>();       
            for (int i = 10; i < 100; i++)
            {

                numberXsFirst.Add(i);
                numberXsReal.Add(i);
              
            
            
            }
            for (int i = 0; i < numberXsFirst.Count; i++)
            {
                LotsOfFor numberX = new LotsOfFor();
                numberX.number1 = numberXsFirst[i];
                numberX.numberReal = numberXsReal[i];
                numberXs.Add(numberX);
            }





            List<LotsOfFor> secondThings = new List<LotsOfFor>();
            List<LotsOfFor> thirdThings = new List<LotsOfFor>();
            List<LotsOfFor> fourthThings = new List<LotsOfFor>();
            List<LotsOfFor> fifthThings = new List<LotsOfFor>();
            List<LotsOfFor> sixthThings = new List<LotsOfFor>();
            List<LotsOfFor> seventhThings = new List<LotsOfFor>();

            Program program = new Program();

            secondThings = numberXs;
            thirdThings = program.getPassedNumbers(secondThings);
            fourthThings = program.getPassedNumbers(thirdThings);
            fifthThings = program.getPassedNumbers(fourthThings);
            sixthThings = program.getPassedNumbers(fifthThings);
            seventhThings = program.getPassedNumbers(sixthThings);


            foreach (var sixth in sixthThings)
            {
                foreach (var seventh in seventhThings)
                {
                    if (sixth == seventh)
                    {
                        magicalNumber += 1;
                    }

                }
                if (magicalNumber != 1)
                {
                    Console.WriteLine(sixth.numberReal);
                }
            }

            Console.WriteLine("toplam " + sixthThings.Count);
            Console.Read();
        }





        public List<LotsOfFor> getPassedNumbers(List<LotsOfFor> numberX)
        {

            
            int magicalNumber = 0;
            List<int> newNumbers = new List<int>();
            List<int> passedNumbers = new List<int>();
            List<LotsOfFor> answer = new List<LotsOfFor>();
            foreach (var item in numberX)
            {
                newNumbers.Add(item.number1);
                passedNumbers.Add(item.numberReal);
            }

            for (int number1 = 0; number1 < newNumbers.Count; number1++)
            {



                int reversenumber1;
                int number1sFirstNumeral;
                int number1sSecondNumeral;






                number1sFirstNumeral = (newNumbers[number1] / 10);
                number1sSecondNumeral = (newNumbers[number1] % 10);

                reversenumber1 = number1sSecondNumeral * 10 + number1sFirstNumeral;

                int substractResult = newNumbers[number1] >= reversenumber1 ? newNumbers[number1] - reversenumber1 : reversenumber1 - newNumbers[number1];

                if (substractResult > 9)
                {
                   
                        LotsOfFor mainNumber = new LotsOfFor();
                        
                        mainNumber.number1 = substractResult;
                        mainNumber.numberReal = passedNumbers[number1];
                        answer.Add(mainNumber);


                }
            }

            return answer;
        }
    }
}
