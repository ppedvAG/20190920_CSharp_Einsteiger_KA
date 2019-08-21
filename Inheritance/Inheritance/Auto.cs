using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Auto : Fahrzeug
    {
        // überschreibt die BeschreibeMich-Methode aus der Mutterklasse "Fahrzeug"
        // Schlüsselwort: override
        public override string BeschreibeMich()
        {
            //throw new NotImplementedException();
            return base.BeschreibeMich() + "und ich bin ein Auto";
        }
    }
}
