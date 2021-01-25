using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("İşlemin Sonucu = "+ toplam);
        }


        public void Cıkar(int sayi1,int sayi2)
        {

            int cıktı = sayi1 - sayi2;
            Console.WriteLine("Çıkarma İşleminin Sonucu = "+cıktı);
        }

        public void Carpma(int sayi1,int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpma İşleminin Sonucu = "+ carpma);
             
        }


        public void Bolme(double sayi1,double sayi2)
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine("Bölme İşleminin Sonucu ="+ bolum);

        }
    }
}
