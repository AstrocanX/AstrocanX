using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOrtalamasıProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Matematik Notunuzu Giriniz");

            int MatNotuInt = Convert.ToInt32(Console.ReadLine());

            if (MatNotuInt > 100)
            {
                Console.WriteLine("Yanlış Değer Girdiniz Lütfen Tekrar Deneyiniz");
                Console.ReadLine();
            }
            else
            {


                Console.WriteLine("Lütfen Türkçe Notunuzu Giriniz");

                int TrNotuInt = Convert.ToInt32(Console.ReadLine());
                if (TrNotuInt > 100)

                {
                    Console.WriteLine("Yanlış Değer Girdiniz Lütfen Tekrar Deneyiniz");
                    Console.ReadLine();

                }
                else
                {

                    Console.WriteLine("Lütfen Fen Notunuzu Giriniz");

                    int FenNotuInt = Convert.ToInt32(Console.ReadLine());



                    if (FenNotuInt > 100)
                    {

                        Console.WriteLine("Yanlış Değer Girdiniz Lütfen Tekrar Deneyiniz");
                        Console.ReadLine();
                    }
                    else
                    {

                        int not_ortalaması = (FenNotuInt + TrNotuInt + MatNotuInt) / 3;

                        if (not_ortalaması <= 100 && not_ortalaması >= 80)
                        {

                            Console.WriteLine("Tebrikler!! Not Dereceniz : A");
                            Console.WriteLine("Not Ortalamanız : " + not_ortalaması);
                            Console.ReadLine();
                        }
                        else if (not_ortalaması <= 79 && not_ortalaması >= 60)
                        {

                            Console.WriteLine("Tebrikler!Not Dereceniz : B ");
                            Console.WriteLine("Not Ortalamanız : " + not_ortalaması);
                            Console.ReadLine();

                        }
                        else if (not_ortalaması <= 59 && not_ortalaması >= 40)
                        {

                            Console.WriteLine("Not Dereceniz : C");
                            Console.WriteLine("Not Ortalamanız : " + not_ortalaması);
                            Console.ReadLine();
                        }

                        else if (not_ortalaması <= 39 && not_ortalaması >= 20)
                        {
                            Console.WriteLine("Not Dereceniz : D");
                            Console.WriteLine("Not Ortalamanız : " + not_ortalaması);
                            Console.ReadLine();

                        }
                        else if (not_ortalaması <= 19 && not_ortalaması >= 0)
                        {

                            Console.WriteLine("Not Dereceniz : E");
                            Console.WriteLine("Not Ortalamanız : " + not_ortalaması);
                            Console.ReadLine();

                        }



                    }



                }

            }

        }
    }
}
