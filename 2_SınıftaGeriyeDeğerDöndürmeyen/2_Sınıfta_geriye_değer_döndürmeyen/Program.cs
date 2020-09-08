using System;
using System.Security.Cryptography;

namespace _2_Sınıfta_geriye_değer_döndürmeyen
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgiler blg = new Bilgiler();
            Console.Write("İsim Girin: ");
            string ads = Console.ReadLine();

            Console.Write("Soyisim Girin: ");
            string syd = Console.ReadLine();

            Console.Write("Yaş Girin: ");
            string ys = Console.ReadLine();

            Console.Write("Meslek Girin: ");
            string mslk = Console.ReadLine();

            blg.bilgiyazdir(ads, syd, ys, mslk);
            Console.Read();

        }
    }
}
