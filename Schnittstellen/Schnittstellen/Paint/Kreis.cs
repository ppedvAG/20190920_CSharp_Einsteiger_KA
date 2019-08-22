using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    public class Kreis : Form
    {
        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Constructor
        #endregion

        #region Methods
        public override void Zeichnen()
        {
            // Zusätzliche Logik
            Console.WriteLine("Ein Kreis wird gezeichnet (Kind-Klasse >Kreis<)");
            base.Zeichnen();
        }
        #endregion
    }
}
