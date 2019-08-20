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
            Console.WriteLine("Zahl eingeben: ");
            string eingabe = Console.ReadLine();

            int parsed;
            bool parse = int.TryParse(eingabe, out parsed);

            if (parse)
            {
                Console.WriteLine($"Zahl wurde eingegeben: {parsed}");
            }
            else
            {
                Console.WriteLine($"Keine Zahl! ... Wert: {parsed}");
            }
            //Convert.ToDouble();
            //double.TryParse();
            //double.Parse();
            int a = 0;
            Console.WriteLine(++a);

            Console.WriteLine(a++);
            Console.WriteLine(a++);

            a++;
            Console.WriteLine($"{a}");

            double b = 4;

            // a = b;
            a = (int)b;
            a = Convert.ToInt32(b);





            #endregion

            Console.WriteLine("--- ENDE PROGRAMM ---");
            Console.ReadLine();
        }
    }
}
