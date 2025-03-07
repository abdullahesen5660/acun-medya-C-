
using SL19OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    //Anne classı Insan class ından türemiştir
    //Anne class ı Insan classındaki public olan tüm değişken ve metodlara erişebilir
    //Anne class ını hem Insan classından hemde IOzellik interface inden türetiyoruz
    public class Anne : Insan,IOzellik,IOzellik2
    {
        public void dinle(string isim)
        {
            Console.WriteLine(isim + " dinliyor...");
        }

        public void oku(string adi)
        {
            Console.WriteLine(adi + " okuyor...");
        }

        public void yaz(string isim)
        {
            Console.WriteLine(isim + " yazıyor...");
        }
    }
}
