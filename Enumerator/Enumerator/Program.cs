using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    enum Wochentag { Mo = 1, Di, Mi, Do, Fr, Sa, So };
    class Program
    {
        static int alter; // = 0
        static void Main(string[] args)
        {
            #region Enumerator
            //Dictionary<int, string> wochentage = new Dictionary<int, string>();
            //wochentage.Add(1, "Mo");
            //wochentage.Add(2, "Di");
            //wochentage.Add(3, "Mi");
            //wochentage.Add(4, "Do");
            //wochentage.Add(5, "Fr");
            //wochentage.Add(6, "Sa");
            //wochentage.Add(7, "So");

            //Console.WriteLine("Zahl zwischen 1 und 7 eingeben");
            //Console.WriteLine($"{wochentage[Convert.ToInt32(Console.ReadLine())]}");

            //Wochentag wochentag = Wochentag.Mi;

            //switch(wochentag)
            //{
            //    case Wochentag.Mo:
            //        Console.WriteLine("Der Tag ist Montag");
            //        break;
            //    case Wochentag.Di:
            //        Console.WriteLine("Es ist Dienstag");
            //        break;
            //}

            //Console.WriteLine("Hier mach ich weiter");

            //Console.WriteLine("Zahl zwischen 1 und 7 eingeben");

            //Wochentag eingabe = (Wochentag)Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(eingabe);
            #endregion

            #region Funktionen

            //Console.WriteLine($"Zahl eins eingeben: ");
            //int eingabe1 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Zahl zwei eingeben: ");
            //int eingabe2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Summe ist: {addieren(eingabe1, eingabe2)}"); 

            //Console.WriteLine();
            #endregion

            #region Out/Ref

            Console.WriteLine(alter);

            int wert = 0;
            Console.WriteLine(wert);

            changeAlter(out wert);

            Console.WriteLine(wert);

            Console.WriteLine(alter);

            #endregion

            Console.ReadLine();
        }

        /// <summary>
        /// Addiert zwei Integer-Zahlen
        /// </summary>
        /// <param name="a">Datentyp int</param>
        /// <param name="b">Datentyp int</param>
        /// <returns>int</returns>
        //public static int addieren(int a, int b)
        //{
        //    // Operationen
        //    return a + b;
        //}

        public static void changeAlter(out int wert)
        {
            wert = 20;
        }
    }
}
