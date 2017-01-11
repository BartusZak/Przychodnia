using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyhodnia_bartuszak2
{
    //1.Tworze klasę abstrakcyjnaosoba
    abstract class Osoba
    {
        //a)dodaje pole
        protected string imieNazwisko;

        //b)dodaje konstruktor
        public Osoba(string ImieNazwisko)
        {
            this.imieNazwisko = ImieNazwisko;
        }

    }
}
