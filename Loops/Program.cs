using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string kurs1 = "Yazilim Gelistirici Yetistirme Kampi";
            string kurs2 = "Programlamaya Baslangic Kursu";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazilim Gelistirici Yetistirme Kampi" , "Programlamaya Baslangic Kursu", "Java" ,"Python","C++" };

            //1.for yazımı
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine();

            //2.for yazımı
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
