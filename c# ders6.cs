using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double sayi1 = 4;
            Console.WriteLine(Math.Pow(sayi1,3));
            Console.WriteLine(Math.Sqrt(sayi1));
            

            int sayi2;
            Console.WriteLine("lütfen 6 basakmaklı bir sayı giriniz");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayiniz = "+sayi2);
            int birler = sayi2 % 10;
            int onlar = (sayi2 % 100) / 10;
            int yuzler = (sayi2 % 1000) / 100;
            int binler = (sayi2 % 10000) / 1000;
            int onbinler = (sayi2 % 100000) / 10000;
            int yuzbinler = sayi2 / 100000;
            Console.WriteLine("sayınızın tersi bu mu?");
            Console.WriteLine(birler+""+onlar+""+yuzler+""+binler+""+onbinler+""+yuzbinler);
            */

            //sayi değiştirme
            int a, b;
            Console.WriteLine("1. sayı");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayı");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı 1 = {0} sayı 2 = {1}",a,b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("sayı 1 = {0} sayı 2 = {1}",a,b);
            Console.ReadKey();
        }
    }
}
