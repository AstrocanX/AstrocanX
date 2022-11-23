using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int işlem_değeri = 0;
            do
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi sol tarafındaki rakamı yazarak seçiniz");
                Console.WriteLine("1-Hesabınızdan Para Çekme");
                Console.WriteLine("2-Hesabınıza Para Yatırma");
                Console.WriteLine("3-Hesap Bakiyenizi Görme");
                işlem_değeri = Convert.ToInt32(Console.ReadLine());
                int para_bakiyesi = 1000;



                if (işlem_değeri == 1)
                {
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
                        Console.WriteLine("Kalan Bakiyeniz:" + kalan_bakiye);
                        Console.ReadLine();
                    }

                }
                else if (işlem_değeri == 2)
                {
                    Console.WriteLine("Lütfen Hesabınıza Yatırlıcak Para Miktarını Giriniz");
                    int artı_para = Convert.ToInt32(Console.ReadLine());
                    int kalan_bakiye = para_bakiyesi + artı_para;
                    Console.WriteLine("Para Yatırma İşleminiz Başarıyla Tamamlanmıştır İyi Günler Dileriz");
                    Console.WriteLine("Yeni Bakiyeniz:" + kalan_bakiye + " TL");
                    Console.ReadLine();

                }
                else if (işlem_değeri == 3)
                {

                    Console.WriteLine("Para Bakiyeniz :" + para_bakiyesi);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Geçersiz Bir Değer Girdiniz");


                    Console.WriteLine("Sistemi yeniden başlatma işlemi için hazırlanılıyor...");
                    Console.WriteLine("Lütfen Sistemi Yeniden başlatmak için ENTER tuşuna basınız.");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (işlem_değeri > 3 || işlem_değeri < 1);




        }
    }




}
