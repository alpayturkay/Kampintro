using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        { //Kendini tekrarlama-DNRY
           string kategoriEtiketi = " Kategoriler";
            int ogrencisayisi = 32000;
            double faizorani = 1.35;
            bool sistemegirisyapildimi = false;

            double dolarDun = 7.37;
            double dolarBugun = 7.48;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış göster");
            }
            else
            {
                Console.WriteLine("Değişmedi göster");
            }


            if (sistemegirisyapildimi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

           Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
