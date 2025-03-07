using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class Cocuk : Insan
    {
        public string sifat;

        public void AdSoyadSifatYaz(string isim,string soyisim,string sifati)
        {
            Console.WriteLine(isim + " " + soyisim + " " + sifati);
        }
    }
}
