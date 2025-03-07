using System;
using System.Collections.Generic;
using ConsoleApp3;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        // Farklı araç nesnelerini oluşturuyoruz
        List<Araba> arabalar = new List<Araba>
        {
            new BMW(),
            new Porsche(),
            new Mercedes(),
            new Togg(),
            new tofaş(),
            new Toyota()
        };

        // Her aracın bilgisini ekrana yazdırıyoruz
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba.Info);  // Info özelliğini doğrudan yazdırıyoruz
        }
    }
}
