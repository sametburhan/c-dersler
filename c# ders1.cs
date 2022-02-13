using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string degisken = "yazı değerimiz"; //2*14byte
            int tamsayi = 32; //4byte
            float kesirlisayi = 3.4f; //4byte
            double buyukkesirlisayi = 5.8; //8byte
            char karakter = 'k'; //2byte
            bool anahtar = true; //1byte

            Console.Write(karakter+" "+anahtar+" "+degisken+" ");
            Console.WriteLine(tamsayi+" "+kesirlisayi+" "+buyukkesirlisayi+"\n"+(kesirlisayi+buyukkesirlisayi));

            Console.WriteLine("sayi = {0}, kelime = {1}", kesirlisayi, degisken);
            Console.WriteLine("sayi = "+ kesirlisayi+", kelime = "+degisken);
            */

            Console.WriteLine("bir kuruluş ismi giriniz");
            string kurulusIsmi;
            kurulusIsmi = Console.ReadLine();
            Console.WriteLine(kurulusIsmi);

            Console.Read();
            Console.ReadLine();
        }
    }
}
