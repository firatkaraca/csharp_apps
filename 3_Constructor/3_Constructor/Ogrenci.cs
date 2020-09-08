using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Constructor
{
    class Ogrenci
    {
        public Ogrenci(string bilgi,string ad,string soyad,string yas ,string meslek)
        {
            Console.WriteLine("\n\n");

            Console.WriteLine("ADI: " + ad);
            Console.WriteLine("SOYADI: " + soyad);
            Console.WriteLine("DURUM: " + bilgi);
            Console.WriteLine("YAŞI: " + yas);
            Console.WriteLine("MESLEĞİ: " + meslek);
        }
    }
}
