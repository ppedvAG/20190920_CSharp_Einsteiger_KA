using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        // Public Property mit Getter/Setter
        public string Name { get; set; }

        // propfull TAB TAB
        private int alter; // "Feld" -> für die interne Weiterverarbeitung 
        // "Property" / Eigenschaft .. für den Zugriff außerhalb der Klasse
        public int Alter {
            get { return alter; }
            set { alter = value; }
        }

        // Konstruktor
        public Person()
        {
            
        }
        public Person(int alter, string name)
        {
            this.alter = alter;
            this.Name = name;
        }       

        ~Person()
        {
            Console.WriteLine("Objekt wurde zerstört ...");
        }
    }
}
