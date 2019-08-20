using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWelt
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ausgabe von Strings
            //string Name = "Sebastian";
            //string NachName = "Herb";

            //Console.WriteLine("Hallo " + Name + " " + NachName);

            //Console.WriteLine("Hallo {0} {1}", Name, NachName);

            //Console.WriteLine($"Hallo {Name} {NachName}");
            #endregion

            #region Konvertierung
            //Console.WriteLine("Zahl eingeben: ");
            //string eingabe = Console.ReadLine();

            //int parsed;
            //bool parse = int.TryParse(eingabe, out parsed);

            //if (parse)
            //{
            //    Console.WriteLine($"Zahl wurde eingegeben: {parsed}");
            //}
            //else
            //{
            //    Console.WriteLine($"Keine Zahl! ... Wert: {parsed}");
            //}
            ////Convert.ToDouble();
            ////double.TryParse();
            ////double.Parse();
            //int a = 0;
            //Console.WriteLine(++a);

            //Console.WriteLine(a++);
            //Console.WriteLine(a++);

            //a++;
            //Console.WriteLine($"{a}");

            //double b = 4;

            //// a = b;
            //a = (int)b;
            //a = Convert.ToInt32(b);
            #endregion

            #region  ZahlenRateSpiel
            //Random generator = new Random();
            //int zufallszahl = generator.Next(1, 5);
            //Console.Write("Zahl eingeben: ");
            //int eingabe2 = int.Parse(Console.ReadLine());

            //if (eingabe2 < zufallszahl)
            //{
            //    Console.Write("Eingabe ist kleiner als Zufallszahl ({0}).", zufallszahl);
            //}
            //else if (eingabe2 > zufallszahl)
            //{
            //    Console.Write("Eingabe ist größer als Zufallszahl ({0}).", zufallszahl);
            //}
            //else
            //{
            //    Console.Write("Eingabe ist gleich der Zufallszahl ({0}).", zufallszahl);
            //}
            //Console.ReadLine();
            #endregion

            #region Arrays

            int zahlFünf = 5;
            int[] prüfArray = new int[] { 3, 4, 5 };
            Console.WriteLine($"Minus-Ausgabe: {prüfArray.First()}");

            object geklontesArray = prüfArray.Clone();

            Console.WriteLine("Geklontes Array: " + geklontesArray);

            int[] zahlenArray = new int[] { 2, 3, 4 }; // Array-Initializer = direkte Zuweisung von Werten bei der Instanziierung des Arrays

            // Mehrere Werte aus einem weiteren Array überprüfen
            foreach (int zahl in prüfArray)
            {
                if (zahlenArray.Contains(zahl))
                {

                }
            }

            // Enthält das Array einen Wert?
            if (zahlenArray.Contains(zahlFünf))
            {

            }

            string[] bezeichner = new string[] { "Hallo", "Welt" };

            int[,] multiDim = new int[2, 2]; // Multidimensionales Array

            // Zuweisung, "1". Dimension, "1". Index
            multiDim[0, 0] = 1;

            Console.WriteLine($"Item at the first index in first dimension {multiDim[0, 0]}");

            Console.WriteLine($"Array-Length is: {bezeichner.Length}");

            #endregion

            Random generator = new Random();

            int[] randomArray = new int[3];

            for (int i = 0; i < randomArray.Length; i++)
            {
                int currentZahl = generator.Next(1, 5);

                if(!randomArray.Contains(currentZahl))
                {
                    randomArray[i] = currentZahl;
                }
            }

            //int[] randomArray = new int[]
            //{
            //    generator.Next(1, 5),
            //    generator.Next(1, 5),
            //    generator.Next(1, 5)
            //};




            Console.WriteLine("--- ENDE PROGRAMM ---");
            Console.ReadLine();
        }
    }
}
