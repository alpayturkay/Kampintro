using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string UrunAdi = "Armut";
            double fiyati = 20;
            string aciklama = "Lezizzzz";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Armut";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Lezizzzz";


            Urun urun2 = new Urun();
            urun2.Adi = "Şeftali";
            urun2.Fiyati = 17;
            urun2.Aciklama = "Bursa Şeftalisi";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("**************");

            }
            Console.WriteLine("*******Metotlar*******");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
