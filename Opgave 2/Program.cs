using System;

namespace Opgave_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Velkommen til ConCalc");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Træk fra");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Dividere");
                Console.WriteLine("5. Nettoløn");
                Console.WriteLine("6. Kørselsfradrag");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");
                string funktion = Console.ReadLine();
                Console.Write("Tal 1: ");
                string tal1 = Console.ReadLine();
                Console.Write("Tal 2: ");
                string tal2 = Console.ReadLine();
                double resultat = 0;
                if (funktion == "1") //hvorfor ikke bare bruge switch case?
                {
                    resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
                }
                else if (funktion == "2")
                {
                    resultat = Convert.ToDouble(tal1) - Convert.ToDouble(tal2); 
                }
                else if (funktion == "3")
                {
                    resultat = Convert.ToDouble(tal1) * Convert.ToDouble(tal2);
                }
                else if (funktion == "4")
                {
                    resultat = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);
                }
                else if (funktion == "5")
                {
                    Console.Write("Tal 3: ");
                    string tal3 = Console.ReadLine();
                    resultat = (Convert.ToDouble(tal1) - Convert.ToDouble(tal2)) * ((100 - Convert.ToDouble(tal3)) / 100);
                }
                else if (funktion == "6")
                {
                    double fradrag;
                    if (Convert.ToDouble(tal2) < 24)
                    {
                        fradrag = 0;
                    }
                    else if (Convert.ToDouble(tal2) < 120)
                    {
                        fradrag = 1.98 * Convert.ToDouble(tal2);
                    }
                    else
                    {
                        fradrag = 0.99 * Convert.ToDouble(tal2);
                    }

                    resultat = Convert.ToDouble(tal1) * fradrag;
                }

                Console.WriteLine("---------------------");
                Console.Write("Resultat: ");
                Console.WriteLine(resultat);
                Console.WriteLine("---------------------");
                Console.WriteLine("Skriv 'ESC' for at afslutte");
                string tast = Console.ReadLine();
                if (tast == "ESC")
                {
                    break;
                }
            }
        }
    }
}
