using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayınızı giriniz");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2.sayınızı giriniz");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("hangi islemi yapacağınızı giriniz");
            char c = char.Parse(Console.ReadLine());

            if (c=='+')
            {
                Console.WriteLine(a+b);
            }
            else if (c=='-')
            {
                Console.WriteLine(a-b);
            }
            else if (c=='/')
            {
                Console.WriteLine(a/b);
            }
            else if (c=='*')
            {
                Console.WriteLine(a*b);
            }
            else
            {
                Console.WriteLine("yanlış bir işaret girdiniz tekrar deneyin");
            }

            Console.ReadLine();
        }
    }
}
