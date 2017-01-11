using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyhodnia_bartuszak2
{
    //3.Dodaje klase potomna po Osoba
    class Lekarz : Osoba
    {
        //a) prywatne pola
        private string specjalnosc;

        //b) dodaje konstruktor parameteczynyc
        public Lekarz(string ImieNazwisko, string Specjalnosc) : base(ImieNazwisko)
        {
            //this.imieNazwisko = ImieNazwisko;
            this.specjalnosc = Specjalnosc;
        }

        //c)przeslaniem ToString()
        public override string ToString()
        {
            return "Lekarz, imię i nazwisko: " + this.imieNazwisko + ", specjalność: " + this.specjalnosc;
        }
    }
}
