using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int abc = 0;
            while (abc < 1)
            {
                abc = 0;
                Random rnd = new Random();
                int num1 = rnd.Next(100);
                int num2 = rnd.Next(100);
                Console.WriteLine(num1 + " + " + num2 + " = ?");
                int a = num1 + num2;
                int b = Int32.Parse(Console.ReadLine());
                if (a == b)
                {
                    Console.WriteLine("işlemi doğru yaptınız");
                }
                else
                {
                    Console.WriteLine("işlemi yanlış yaptınız\nDoğru cevap = " + a);
                }
                Console.WriteLine("tekrar denemek ister misiniz?\nEvet veya hayır yazınız");
                string eh = Console.ReadLine();
                if (eh == "evet" | eh == "EVET" | eh == "Evet")
                {
                    Console.WriteLine("Yeni işleminiz");
                    abc = 0;
                }
                else if (eh == "hayır" | eh == "HAYIR" | eh == "Hayır")
                {
                    Console.WriteLine("görüşmek üzere");
                    abc = 1;
                }
                else
                {
                    Console.WriteLine("yanlış bir karakter girdiniz");
                    abc = 1;

                }

            }
            Console.ReadLine();
        }
    }
}
