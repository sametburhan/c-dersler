using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var anahtarı değiken atamak için kullanılır
            var x = 5;
            var kelime = 16;
            var kesir = 14.2;
            var y = "teker";
            var anahtar = kelime;
            var t = "tekrar";
            var karakter = "q";
            var abc = true;
            //var anahtarlarının üstüne geldiğimizde değişken türlerimizi görmek mümkün

            Console.WriteLine(x+" " + kelime+" " + kesir+" " + y + " "+anahtar+" " + t+" " + karakter+ " "+abc);

            //const anahtarı sabit değerler için kullanılır
            //işlemler boyunca değer değiştirilemez
            const double a = 1.2;
            const string b = "samet";
            const float c = 3.18f;
            const int d = 12;
            Console.WriteLine(a+" "+b+" "+c+" "+d);
            //bu kod sadece sabit atar ve bu sabit değiştirilemez

            Console.ReadLine();
        }
    }
}
