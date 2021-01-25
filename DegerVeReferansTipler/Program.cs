using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 15;
            int sayi2 = 45;
            sayi1 = sayi2;
            sayi2 = 77;

            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 15, 25, 35 };
            int[] sayilar2 = new int[] { 100, 2255, 336 };
            sayilar1 = sayilar2;
            sayilar2[0] = 546454;

            Console.WriteLine(sayilar1[0]);

            Console.WriteLine("-------------------");

            Console.WriteLine("Hello World!");
        }
    }
}
