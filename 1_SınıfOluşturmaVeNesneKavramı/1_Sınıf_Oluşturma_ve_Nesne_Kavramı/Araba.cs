using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Sınıf_Oluşturma_ve_Nesne_Kavramı
{
    class Araba: ArabaDetay
    {
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string Marka;

        public int YIL
        {
            get { return yil; }
            set { yil = Math.Abs(value); }
        }
        public string MARKASI
        {
            get { return Marka; }
            set { Marka = value.ToUpper(); }
        }
    }
}
