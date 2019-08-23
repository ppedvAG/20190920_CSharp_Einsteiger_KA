using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten
{
    public class Program
    {
        // Delegat-Beispiel
        // Delegat-Signatur
        public delegate int MeinDelegatenTyp(int a, string b);
        static void Main(string[] args)
        {
            Counter zähler = new Counter(1);

            zähler.SchwellwertErreicht += c_SchwellwertErreicht;

            Console.WriteLine("drücke a um den wert zu erhöhen");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("wert wird um 1 erhöht");
                zähler.Hinzufügen(1);
            }
            



                // Delegaten instanziieren
            MeinDelegatenTyp delegatVariable = new MeinDelegatenTyp(BeispielMethode);
            // Anhängen einer weiteren Methode an den Delegaten
            delegatVariable += IrgendeineandereMethode;


            //Console.WriteLine(delegatVariable.Method);

            foreach(var delegat in delegatVariable.GetInvocationList())
            {
                Console.WriteLine(delegat.Method);
            }

            Console.WriteLine($"{delegatVariable.Invoke(10, "Delegataufruf")}"); // Rückgabewert 2

            Console.ReadLine();
        }

        public static int BeispielMethode(int x, string y)
        {
            Console.WriteLine("Erste Methode wurde invoked...");
            return 2;
        }

        public static int IrgendeineandereMethode(int g, string b)
        {
            return 815;
        }

        // Handler-Methode für das Ereignis "Schwellwert erreicht"
        static void c_SchwellwertErreicht(object sender, EventArgs e)
        {
            Console.WriteLine("Schwellwert wurde erreicht");
        }

    }
}
