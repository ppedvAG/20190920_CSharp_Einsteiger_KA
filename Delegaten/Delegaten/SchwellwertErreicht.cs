using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten
{
    public class SchwellwertErreicht : EventArgs
    {
        public int Schwellwert { get; set; }
        public DateTime Zeitpunkt { get; set; }
    }
}
