using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class Matematik
    {

        //geriye int tipinde değer dönen ve 2 tane int tipinde parametre alan adı topla olan bir metod
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int carp(int sayi1,int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int bol(int sayi1,int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
}
