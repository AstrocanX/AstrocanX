using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Veri atama byte short int ve long .
            byte birinci = 5;

            byte ikinci = 25;

            byte ucuncu = 255;
            //max ve min value kullanarak en çok ve az degerini bulmak için kullan.
            long maxdeger = long.MaxValue;
            byte mindeger = byte.MinValue;
            //Kısa yol için cw yaz tab tab yap c:
            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(ucuncu);
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();
        
        
        }

    }
}
