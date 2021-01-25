using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(17, 5);

            dortIslem.Topla(9, 27);

            dortIslem.Cıkar(17, 5);
            dortIslem.Carpma(6, 28);


            dortIslem.Bolme(897, 99);
        }
    }
}
