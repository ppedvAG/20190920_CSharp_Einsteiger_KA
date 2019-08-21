using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region out
            // out parameter
            Console.WriteLine("-----");
            Console.WriteLine("Out-Parameter");
            Console.WriteLine("-----");
            int x;
            bool result = IrgeneinerFunktion(out x);
            Console.WriteLine($"Auswertung {result} - Wert von x: {x}");
            #endregion out

            #region params
            int[] zahlen = new int[] { 5, 5 };
            // Dynamischer Aufruf
            Console.WriteLine($"Summe: {SumUp(5, 5, 10, 3, 5, 3, 5, 3, 2, 4)}");

            // "Statischer" Aufruf
            Console.WriteLine($"Summe: {SumUpTwo(zahlen)}");
            #endregion

            #region default
            string[] strings = new string[] { "Hallo", "Welt", "Wie", "geht", "es" };
            Console.WriteLine($"{StringCombine(strings,' ')}");
            #endregion

            Console.ReadLine();
        }

        #region Methoden
        static bool IrgeneinerFunktion(out int variable)
        {
            variable = 20;
            return true;
        }

        static int SumUp(params int[] summanden)
        {
            int summe = 0;
            foreach(var summand in summanden)
            {
                // summe = summe + summand;
                summe += summand;
            }
            return summe;
        }

        static int SumUpTwo(int[] summanden)
        {
            int summe = 0;
            foreach (var summand in summanden)
            {
                // summe = summe + summand;
                summe += summand;
            }
            return summe;
        }

        static string StringCombine(string[] strings, char trenner = '/') // Mit Default-Parameter -> optionales Argument
        {
            string resultString = "";
            foreach(string item in strings)
            {
                resultString += (trenner + item);
            }
            return resultString;
        }
        #endregion
    }
}
