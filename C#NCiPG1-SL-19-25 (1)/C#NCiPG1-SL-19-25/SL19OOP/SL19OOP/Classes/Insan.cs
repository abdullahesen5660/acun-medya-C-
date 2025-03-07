using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class Insan
    {  // başlangıç scope

        //properties değişkenleri 
        // access modifiers datatype değişken adı
        public string adi = "ibrahim123";
        public string soyadi = null;
        //tam sayısal verileri saklamamızı sağlar 2123232
        public int yas = 0;
        //kesirli küsuratlı sayıları saklamamızı sağlar. 
        public double maas = 3.14;
        //true yada false şeklinde değer saklamamızı sağlar 
        public bool cinsiyet;

        //metotlar 2 ye ayrılırlar 
        //access modifiers dönüştipi metodAdi()  {   }

        //dışarıdan parametre alacak hale getirdim
        public void uyu(string isim)
        {

            Console.WriteLine(isim +" uyuyor...");
        }

        public void ekranaYaz(string isim, string soyisim)
        {
            Console.WriteLine("Kişinin adı : " + isim + " Kişinin soyadı : " + soyisim);
        }

        public int yasHesapla(int dogumYili)
        {
            int sonuc = 0;
            sonuc = DateTime.Now.Year - dogumYili;
            return sonuc;
        }

        


    }  //bitiş scope
}
