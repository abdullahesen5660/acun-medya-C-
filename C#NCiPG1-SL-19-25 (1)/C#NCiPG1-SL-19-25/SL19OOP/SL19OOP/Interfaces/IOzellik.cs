using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL19OOP.Interfaces
{
    //1. interface çoklu kalıtıma (multiple inheritance) destek verir 
    //2. sözleşmeye benzetebiliriz. zorunlucu tanımlamalar yapabilirz.
    //3. Bu interface den türeyen tüm classlar bu interface içindeki ilgili metodların içini
    //doldurmak zorundadırl

    public interface IOzellik
    {
        public void oku(string adi);

    }
}
