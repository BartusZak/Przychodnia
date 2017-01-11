using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyhodnia_bartuszak2
{
    //2.Tworze klasę Pacjent dziedzicaca po Osoba
    class Pacjent : Osoba
    {
        //a)dodaje pola prywatne
        private int wiek;
        private string choroba;

        //b)dodaje konstruktor parametryczny  //Sprawdz czy działa z base!
        public Pacjent(string ImieNazwisko, int Wiek, string Choroba) : base (ImieNazwisko)
        {
            //this.imieNazwisko = ImieNazwisko;
            this.wiek = Wiek;
            this.choroba = Choroba;
        }
        //c)przeslaniam ToString()
        public override string ToString()
        {
            return "Pacjent, imię nazwisko: " + this.imieNazwisko + ", wiek: " + this.wiek + ", choroba: " + this.choroba;
        }
    }
}
