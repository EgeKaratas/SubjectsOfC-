using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety-tip güvenliği
            //Do not repeat yourself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGirisi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artıs butonu");

            }
            else
            {
                Console.WriteLine("Değismedi butonu");
            }


            if (sistemGirisi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }



            Console.WriteLine(kategoriEtiketi);

        }
    }
}

