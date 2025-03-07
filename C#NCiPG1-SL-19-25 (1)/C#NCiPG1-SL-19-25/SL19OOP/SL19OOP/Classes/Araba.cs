using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class Araba
    {
        //değişkenler properties
        public string marka = null;
        public string model = null;
        public int kapiSayisi = 0;
        public int pencereSayisi = 0;


        //metodlar
        public void git(string markasi)
        {
            Console.WriteLine(markasi + " gidiyor...");
        }

        public void markaModelYaz(string markasi, string modeli)
        {
            Console.WriteLine("Arabanın markası : " + markasi + " modeli : " + modeli);
        }
    }
}
