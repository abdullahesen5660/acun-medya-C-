using SL19OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Classes
{
    public class Baba : Insan,IOzellik
    {

       

        public void oku(string adi)
        {
            Console.WriteLine(adi + " okuyor..");
        }
    }
}
