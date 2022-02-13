using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 =18;
            int sayi2 = 14;
            string a = "adam";
            Console.WriteLine(sayi1+sayi2);
            Console.WriteLine(sayi1-sayi2);
            Console.WriteLine((double)sayi1/(double)sayi2); //birinin double olması yeterli
            Console.WriteLine(sayi1*sayi2);
            Console.WriteLine(sayi1%sayi2);

            Console.WriteLine(a+sayi1+sayi2); //kodun içinde 1 tane bile string varsa hepsi strin olur ve işlem yapılmaz

            double sayi3 = 4;
            Console.WriteLine(sayi3);
            sayi3 *= 10;
            Console.WriteLine(sayi3);
            sayi3 = sayi3 + 2;
            Console.WriteLine(sayi3);
            sayi3 /= 10;
            Console.WriteLine(sayi3);
            sayi3 = sayi3 - 2;
            Console.WriteLine(sayi3);
            sayi3 = sayi3 % sayi1;
            Console.WriteLine(sayi3);
            sayi3 %= sayi2;
            Console.WriteLine(sayi3);

            int x = 17;
            Console.WriteLine(x);
            x++; //postfix
            Console.WriteLine(x);
            --x; //prefix
            Console.WriteLine(x);

            x = 17;
            int sayi4 = 0;
            sayi4 = ++x; //burada önce sayiya 1 eklendi sonra eşitlendi (prefix)
            //bu kod hem sayi 4 ü hem de x etkiliyor
            Console.WriteLine(sayi4+" "+x);
            sayi4 = 0;
            x = 17;
            sayi4 = x++; //burada ise önce eşitlendi sonra sayıya 1 eklendi (postfix)
            //bu kod hem sayi 4 ü hem de x etkiliyor
            Console.WriteLine(sayi4 + " " + x);

            //dikdörtgen veya karenin çevresi ve alanını bulma
            double k,l,m;
            //k = kare kenarı
            //l = dikdörtgen kısa kenarı
            //m = dikdörtgen uzun kenarı
            Console.WriteLine("dökdörtgen alanı ve çevresini hesaplayacaksanız");
            Console.WriteLine("dikdörtgen kısa kenarını giriniz");
            l = double.Parse(Console.ReadLine());
            Console.WriteLine("dikdörtgen uzun kenarını giriniz");
            m = double.Parse(Console.ReadLine());
            double alan1 = l * m;
            double cevre1 = 2 * (l+m);
            Console.WriteLine("dikdörgeninizin alanı = "+alan1+"\ndikdörgeninizin çevresi = "+cevre1);
            Console.WriteLine("karenizin alanı ve çevresini hesaplayacaksanız");
            Console.WriteLine("karenizin bir kenarını girmeniz yeterlidir");
            k = double.Parse(Console.ReadLine());
            double alan2 = k*k;
            double cevre2 = 4 * k;
            Console.WriteLine("karenizin alanı = " + alan2 + "\nkarenizin çevresi = " + cevre2);
            Console.ReadLine();

        }
    }
}
