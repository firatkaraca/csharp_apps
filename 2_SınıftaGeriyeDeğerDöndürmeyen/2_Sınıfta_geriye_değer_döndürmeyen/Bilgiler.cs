using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Sınıfta_geriye_değer_döndürmeyen
{
    class Bilgiler
    {
        public void bilgiyazdir(string ad,string soyad,string yas,string meslek)
        {
            Console.WriteLine();
            Console.WriteLine("Bilgiler Aktarıldı :-)");
            Console.WriteLine("İsim: " + ad);
            Console.WriteLine("Soyisim: " + soyad);
            Console.WriteLine("Yaşı: " + yas);
            Console.WriteLine("Meslek: " + meslek);
        }
    }
}
