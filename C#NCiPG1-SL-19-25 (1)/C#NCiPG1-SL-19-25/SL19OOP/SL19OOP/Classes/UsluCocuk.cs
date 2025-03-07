using SL19OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class UsluCocuk : Cocuk, IAskereGit, IEhliyetAl
    {
        public void askereGit(string isim)
        {
            Console.WriteLine(isim + " askere gidiyor...");
        }

        public void ehliyetAl(string isim)
        {
            Console.WriteLine(isim + " ehliyet alıyor...");
        }
    }
}
