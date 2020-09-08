using System;

namespace _3_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alttaki iki kullanımda doğrudur
            Console.Write("Adınızı Giriniz: ");
            string adı = Console.ReadLine();
    
            Console.Write("Soyadınızı Giriniz: ");
            string soyadı= Console.ReadLine();

            string blg;
            Console.Write("Cinsiyet - Kulüp bilgilerinizi giriniz: ");
            blg = Console.ReadLine();

            string yas;
            Console.Write("Yasınızı giriniz: ");
            yas = Console.ReadLine();

            string meslek;
            Console.Write("Mesleğinizi giriniz: ");
            meslek = Console.ReadLine();

            Ogrenci ogr = new Ogrenci(blg,adı,soyadı,yas,meslek);
            Console.Read();
        }
    }
}
