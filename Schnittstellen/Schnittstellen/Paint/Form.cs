using Schnittstellen.Paint.Schnittstellen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    // Base-Class (Mutterklasse)
    public class Form : IZeichenbar
    {
        #region Fields

        #endregion

        #region Properties
        // Start-/End-Koordinaten
        public int X { get; set; }
        public int Y { get; set; }

        // Form-Eigenschaften
        public int Höhe { get; set; }
        public int Breite { get; set; }
        #endregion

        #region Constructor

        #endregion

        #region Methods
        /// <summary>
        /// Die Methode zeichnet unsere Form
        /// </summary>
        public virtual void Zeichnen()
        {
            Console.WriteLine("Eine Form (aus der Mutterklasse) wird gezeichnet ...");
        }
        #endregion


    }
}
