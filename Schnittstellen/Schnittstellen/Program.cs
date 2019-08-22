using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klassische Instanziierung und anschließendes Hinzufügen
            // dynamischer -> unperformanter
            List<Form> formenInstanz = new List<Form>();
            formenInstanz.Add(new Kreis());
            formenInstanz.Add(new Rechteck());
            formenInstanz.Add(new Dreieck());

            Form formK = new Kreis();

            // GetType() (geerbt von Klasse "Object") 
            // Ermittelt den Typen der in der Variablen "formK" referenzierten Objekt-Instanz (= Kreis)
            Console.WriteLine($"{formK.GetType()}");
            // Möglichkeit für Kontrollstrukturen -> kontrollierter Funktionsablauf anhand des aktuellen Typen
            Console.WriteLine($"Typ von Kreis: {typeof(Kreis)}");
            Console.WriteLine($"Ist formK vom Typ Kreis?: {formK.GetType() == typeof(Kreis)}");
            Console.WriteLine($"Ist formK vom Typ Form?: {formK.GetType() == typeof(Form)}");

            // "is" ermittelt, ob eine Objekt-Instanz ein (evtl. vererbter Typ) einer Klasse ist ...
            Console.WriteLine($"Ist im Container formK ein Kreis?: {formK is Kreis}");
            Console.WriteLine($"Ist im Container formK eine Form?: {formK is Form}");


            // Listen-Initialisierung
            // statischer -> performanter
            List<Form> formen = new List<Form>
            {
                new Kreis(),
                new Dreieck(),
                new Rechteck()
            };

            //foreach(Form form in formen)
            //{
            //    form.Zeichnen();
            //}
            

            Console.WriteLine("---- ENDE ----");
            Console.ReadLine();
        }
    }
}
