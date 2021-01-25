using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya Başlangıç:Temel Kurs";
            string kurs3 = "Java";

            //Array-Dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı" ,
                "Programlamaya Başlangıç:Temel Kurs" , "Java" ,"C++","Python", "React","SQL","C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

                Console.WriteLine("****For döngüsü bitti****");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

                Console.WriteLine("****Foreach bitti****");


        }
    }
}
