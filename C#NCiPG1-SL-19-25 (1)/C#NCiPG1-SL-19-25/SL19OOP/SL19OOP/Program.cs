// See https://aka.ms/new-console-template for more information
using SL19OOP.Abstracts;
using SL19OOP.Classes;
using System.Collections;

Console.WriteLine("Hello, World!");


//bir class ten nesne oluşturma
//ClassIsmi nesneAdi = new ClassIsmi();

Insan i = new Insan();
i.adi = "Hakan";
i.soyadi = "Yılmaz";
i.yas = 46;
i.maas = 3.14;
i.cinsiyet = true;
//bir metodu çağırmış olduk.
i.uyu("metin");
i.uyu(i.adi);
//1. yöntem 
int gelenYas = i.yasHesapla(2000);
Console.WriteLine("Yaşınız : " + gelenYas);


Araba a = new Araba();
a.marka = "Bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.git("Mercedes");
a.git(a.marka);


Matematik m = new Matematik();
//1. yöntem 
int gelenDeger = m.topla(5, 5);
Console.WriteLine("Toplam : " + gelenDeger);

//2. yöntem
Console.WriteLine("Toplam 2. yöntem : " + m.topla(10, 10));

Console.WriteLine("Çıkan sonuç : " + m.cikar(10, 10));

Console.WriteLine("Çarpım Sonucu : " + m.carp(10, 10));

Console.WriteLine("Bölüm Sonucu : " + m.bol(10, 10));

Anne an = new Anne();
an.adi = "fahriye";
an.soyadi = "gökyar";
an.yas = 70;
an.cinsiyet = true;
an.ekranaYaz(an.adi, an.soyadi);
an.oku(an.adi);
an.dinle(an.adi);
an.yaz(an.adi);

Baba b = new Baba();
b.ekranaYaz("Kasım", "Gökyar");
b.oku("Kasım");

Cocuk c = new Cocuk();
c.ekranaYaz("ibrahim", "gökyar");


Bmw bm = new Bmw();

bm.markaModelYaz("Bmw", "X5");

Mercedes me = new Mercedes();
me.marka = "Mercedes";
me.model = "XL";
me.markaModelYaz(me.marka, me.model);

Porche p = new Porche();
p.markaModelYaz("Porche", "Carrera");


AkilliCocuk ak = new AkilliCocuk();
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.sifat = "Akıllıdır";
ak.AdSoyadSifatYaz(ak.adi, ak.soyadi, ak.sifat);
ak.askereGit(ak.adi);
ak.ehliyetAl(ak.adi);
ak.klubeGit(ak.adi);


UsluCocuk us = new UsluCocuk();
us.AdSoyadSifatYaz("Mehmet", "Yıldız", "Usludur");
us.askereGit("Mehmet");
us.ehliyetAl("Mehmet");


HiperAktifCocuk hp = new HiperAktifCocuk();
hp.ehliyetAl("Hüseyin");

//Abstract class ların nesnesi oluşturulamaz
//Calisan ca = new Calisan();


GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += mu.maasinizNedir();
toplamMaas += pr.maasinizNedir();
toplamMaas += s.maasinizNedir();

Console.WriteLine("Toplam : " + toplamMaas + " TL maaş alyorlar...");



ArrayList arr = new ArrayList();


//aynı türden değişkenleri objeleri bir isim altında tutmamızı sağlar.
//1. yöntem
//7 elemanlı bir dizi tanımladım.
//hangitip[] diziadi = new string[kaç elemanlı];
//dizideki ilk eleman 0 dan başlar 
string[] gunler = new string[7];
string[] gunler = { "pazartesi", "salı", "çarşamba", "perşembe", "cuma", "cumartesi", "pazar" };
gunler[0] = "pazartesi";
gunler[1] = "salı";
gunler[2] = "çarşamba";
gunler[3] = "perşembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";

//dizinin kaç elemanı olduğunu söyler
//gunler.Length;

//döngü for döngüsü 
//for(koşul) {     }

//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");
//Console.WriteLine("Merhaba Dünya");

for(int j=0;j<10; j++)
{
    //yapmam gereken iş ne ise onu burada yazıcam
    Console.WriteLine("Merhaba Dünya : - "+ j);
}


for (int k=0; k<gunler.Length; k++)
{
    Console.WriteLine(gunler[k]);
}


//n elemanlı bir diziyi tanımlayacağız.
//2. yöntem
int[] sayilar = { 3,5,7,9,11,24,27,34,41,44,88,99 };


int sayiToplam = 0;

for(int z=0; z<sayilar.Length; z++)
{
    Console.WriteLine("Sayı : " + sayilar[z]);
    //sayiToplam = sayiToplam + sayilar[z];
    sayiToplam += sayilar[z];
}

Console.WriteLine("Sayıların Toplamı : " + sayiToplam);


