using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmSwichCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi sol tarafındaki rakamı yazarak seçiniz");
            Console.WriteLine("1-Hesabınızdan Para Çekme");
            Console.WriteLine("2-Hesabınıza Para Yatırma");
            Console.WriteLine("3-Hesap Bakiyenizi Görme");

            int para_bakiyesi = 1000;
            switch (Console.ReadLine())
            {
                case "1":

                    Console.WriteLine("Lütfen Hesabınızdan Çekiliecek Para Miktarını Giriniz");
                    int eksi_para = Convert.ToInt32(Console.ReadLine());
                    if (eksi_para > para_bakiyesi)
                    {
                        Console.WriteLine("Yetersiz Bakiye Hesabınızdaki Para Miktarı : " + para_bakiyesi + " TL");
                        Console.ReadLine();
                    }
                    else
                    {
                        int kalan_bakiye = para_bakiyesi - eksi_para;
                        Console.WriteLine("Para Çekme İşleminiz Başarıyla Tamamlanmıştır İyi Günler Dileriz");
                        Console.WriteLine("Kalan Bakiyeniz: {0}", kalan_bakiye);
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    Console.WriteLine("Lütfen Hesabınıza Yatırlıcak Para Miktarını Giriniz");
                    int artı_para = Convert.ToInt32(Console.ReadLine());
                    int kalan_bakiye1 = para_bakiyesi + artı_para;
                    Console.WriteLine("Lütfen Yatırmak İstediğiniz Parayı Açılan Atm Bölmesine Yerleştiriniz");
                    Console.WriteLine("Para Yatırma İşleminiz Başarıyla Tamamlanmıştır İyi Günler Dileriz");
                    Console.WriteLine("Yeni Bakiyeniz:" + kalan_bakiye1 + " TL");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Para Bakiyeniz :" + para_bakiyesi);
                    Console.ReadLine();
                    break;


                default:
                    Console.WriteLine("Lütfen Belirtilen Rakamlardan Birini Giriniz");
                    Console.ReadLine();

                    break;




            }


        }
    }
}
