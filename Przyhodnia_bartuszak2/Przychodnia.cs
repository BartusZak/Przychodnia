using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyhodnia_bartuszak2
{
    //5.Tworze klase Przychodnia
    class Przychodnia : IPrzychodnia
    {
        //a)dodaje pola prywante
        private Lekarz lekarz;
        
        //b)dodaje prywatne pole
        private Queue<Pacjent> pacjenci = new Queue<Pacjent>();

        //c)Podpinam Interfejs ^^

        //d)Dodaje metody??????????????????
        public void UstawLekarza(string imieN, string specjalnosc)
        {
            this.lekarz = new Lekarz(imieN, specjalnosc);
        }
        public void DodajDoKolejki(string imieN,  int wiek, string choroba)
        {
            pacjenci.Enqueue(new Pacjent(imieN, wiek, choroba));
        }
        public string WykonajPorade()
        {
            //pacjenci.Peek();            
            try
            {
                if (pacjenci.Count == 0)
                {
                    throw new System.InvalidOperationException("Brak pacjetnow!");
                }
                return "Wykonano poradę! " + pacjenci.Dequeue();
            }
            catch(Exception ex)
            {
               
                return ex.Message;
            }
            
        }
        public string WykonajBadanie()
        {
            try
            {
                if (pacjenci.Count == 0)
                {
                    throw new System.InvalidOperationException("Brak pacjetnow!");
                }
                return "Wykonano badanie! " + pacjenci.Peek();
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }
        public int CzasOczekiwania()
        {
            return (int)(Math.Round(pacjenci.Count / 4.00));
        }
        public override string ToString()
        {
            string info = "";

            try
            {
                if (lekarz.ToString() == null)
                {
                  
                    throw new ArgumentNullException();                   
                }

                info += lekarz.ToString();
                info += Environment.NewLine + Environment.NewLine + "Pacjenci w kolejce:";

                foreach (var e in pacjenci)
                {
                    info += Environment.NewLine + " " + e;
                }

                info += Environment.NewLine + Environment.NewLine + "Czas oczekiwania: " + CzasOczekiwania();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Najpierw dodaj Lekarza!");
                Console.WriteLine(ex.Message);
                
            }
                
            
          
            return info;
        }
        public void GenerujRaport()
        {
            string Do_pliku = ToString();

            File.CreateText(("Raport") + DateTime.Now.ToString("HHmmddMMyyyy") + (".txt")).Close();
            File.WriteAllText(("Raport") + DateTime.Now.ToString("HHmmddMMyyyy") + (".txt"), ToString());

        }
        public bool CzyLekarz()
        {
            if(lekarz != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
