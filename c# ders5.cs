using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //daire alan ve çevresini hesaplama
            const double pI = 3.14;
            Console.WriteLine("daire alanı ve çevresi hesaplanacaktır lütfen dairenin yarı çapını giriniz");
            double r = double.Parse(Console.ReadLine());
            double alan = pI * r * r;
            double cevre = 2 * pI * r;
            Console.WriteLine("dairenizin alanı = "+alan+"\ndairenizin çevresi = "+cevre);
            */

            //fonksiyon
            //f(x)=ax^2+bx+c
            int x, a, b, c;
            Console.WriteLine("lütfen a değişkenini giriniz");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen b değişkenini giriniz");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("lütfen c değişkenini giriniz");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("f(x)"+a+"x^2+"+b+"x+"+c);
            //delta=b^2-4ac
            Console.WriteLine("delta="+bxb+"-4"+axc);



            Console.ReadLine();
        }
    }
}
