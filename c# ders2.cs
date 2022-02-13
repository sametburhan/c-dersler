using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            //girdi ve çıktı işlemleri:

            //string yazı atamak için kullanılır
            //string kullanabilmek için aşağıdaki kod kullanılır
            Console.WriteLine("bir kuruluş ismi giriniz");
            string kurulusIsmi = Console.ReadLine();
            Console.WriteLine("girdiğiniz kuruluş adı = "+kurulusIsmi);

            //karakter yazdırabilmek char kullanılır
            //char karakteri atayabilmek için aşağıdaki kod kullanılabilir
            char simge;
            Console.WriteLine("simgenizi giriniz");
            simge = Console.ReadKey().KeyChar;
            Console.WriteLine("\n"+"atadığınız simge budur = "+simge);

            //sayı için int kullanılır
            //sayı atamak için ise aşağıdaki kod kullanılır
            Console.WriteLine("bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayının karesi budur = "+(sayi*sayi));

            //virgüllü sayılarda işlem için aşağıdaki iki kod kullanılır
            //nokta binli sayılarda kullanılır
			//ancak kod yazarken sadece double koduna nokta konularak virgüllü sayı elde edilir
            //  1
            Console.WriteLine("lütfen virgüllü bir sayı giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayının karesi budur = "+(sayi1*sayi1));
            //  2
            Console.WriteLine("lütfen virgüllü bir sayı giriniz");
            float sayi2 = float.Parse(Console.ReadLine());
            Console.WriteLine("girdiğiniz sayının karesi budur = "+(sayi2*sayi2));



            //string = Console.ReadLine()
            //char = Console.ReadKey().KeyChar
            //int = Convert.ToInt32(Console.ReadLine()) - int.Parse(Console.ReadLine())
            //double = Convert.ToDouble(Console.ReadLine()); - double.Parse(Console.Readline())
            //float = float.Parse(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
