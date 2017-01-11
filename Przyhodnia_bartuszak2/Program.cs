using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przyhodnia_bartuszak2
{
    class Program
    {
        static public ConsoleKey key;
        static void Main(string[] args)
        {
            Przychodnia przychodnia1 = new Przychodnia();

            while(key != ConsoleKey.E)
            {
                //Console.Clear();

                Console.WriteLine(@"Przychonia!
Co chcesz zrobić?
L - Dodaj lekarza,
W - Dodaj pacjenta
I - Sprawdz, czy przyjmuje lekarz
Z - Pokaz kolejke
P - Wykonaj porade
B - Wykonaj badanie
S - Generuj raport
E - Wyjscie");
                key = Console.ReadKey().Key;

                switch(key)
                {
                    case ConsoleKey.L:
                        {
                            Console.WriteLine("Dodaje Lekarza...");
                            Console.WriteLine("Podaj jego imie i nazwisko:");
                            
                                string imieNazwisko = Console.ReadLine();
                            

                            Console.WriteLine("Podaj jego specjalnosc:");
                            string specjalnosc = Console.ReadLine();

                            przychodnia1.UstawLekarza(imieNazwisko, specjalnosc);
                            
                            break;
                        }
                    case ConsoleKey.W:
                        {
                            Console.WriteLine("Dodaje Pacjenta...");
                            Console.WriteLine("Podaj jego imie i nazwisko:");
                            string imieNazwisko = Console.ReadLine();

                            Console.WriteLine("Podaj jego wiek:");
                            
                            int wiek = 0;
                            try
                            {
                                wiek = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj jego chorobe:");
                                string choroba = Console.ReadLine();

                                przychodnia1.DodajDoKolejki(imieNazwisko, wiek, choroba);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("To nie jest liczba!");
                                Console.ReadLine();
                            }
                                                  
                            break;
                        }
                    case ConsoleKey.Z:
                        {
                            Console.WriteLine(przychodnia1.ToString());
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.S:
                        {
                            przychodnia1.GenerujRaport();

                            Console.WriteLine("Raport wygenerowany!");
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.P:
                        {
                            Console.WriteLine(przychodnia1.WykonajPorade());
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.WriteLine(przychodnia1.WykonajBadanie());
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.I:
                        {
                            if (przychodnia1.CzyLekarz())
                            {
                                Console.WriteLine("Lekarz przyjmuje!");
                            }
                            else
                            {
                                Console.WriteLine("Dodaj lekarza!");
                            }
                            Console.ReadLine();

                            break;
                        }
                }
            }
        }
    }
}
