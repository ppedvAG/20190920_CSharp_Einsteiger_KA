using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // abstract markiert die Klasse als "Template" / Vorgabe für erbende Klassen ("Derivate")
    public abstract class Fahrzeug
    {
        // virtual markiert die Methode "BeschreibeMich" dafür, dass sie überschrieben werden kann 
        // durch "override" in einer Kindklasse (Derivat)
        public virtual string BeschreibeMich()
        {
            return "Ich bin ein Fahrzeug.";
        }
    }
}
