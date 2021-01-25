using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ad = "Alpay";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C Programlama";
            kurs1.KursEgitmeni = "Alpay";
            kurs1.TamamlanmaOrani = 82;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C#";
            kurs2.KursEgitmeni = "Engin Demirog";
            kurs2.TamamlanmaOrani = 87;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.KursEgitmeni = "Berkay B.";
            kurs3.TamamlanmaOrani = 74;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursEgitmeni);

                Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
                foreach (var kurs in kurslar)
               {
                    Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
                }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int TamamlanmaOrani { get; set; }
    }
}
