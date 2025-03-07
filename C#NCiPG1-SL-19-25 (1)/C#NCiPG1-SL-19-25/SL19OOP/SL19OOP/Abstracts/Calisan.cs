using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Abstracts
{
    //1. abstract class ların nesnesi oluşturulamaz
    //2. abstract classların içinde abstract keyword ile beraber bir metod yazılırsa
    //o abstract classtan türeyen tüm classlar ilgili metodun içini doldurmak zorundadır.
    public abstract class Calisan
    {

        public abstract double maasinizNedir();

        public void mesaiyeBasla(string isim)
        {
            Console.WriteLine(isim + " mesaiye başladı ");
        }
    }
}
