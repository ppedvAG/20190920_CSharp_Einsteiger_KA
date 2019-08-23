using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaten
{
    public class Counter
    {
        #region Felder
        private int schwellwert;
        private int gesamt;
        #endregion Felder

        #region Delegat
        public event EventHandler SchwellwertErreicht;
        #endregion Delegat

        protected virtual void OnSchwellwertErreicht(EventArgs e)
        {
            // null?
            EventHandler handler = SchwellwertErreicht;
            if(handler != null)
            {
                handler.Invoke(this, e);
            }
            
        }

        #region Konstruktor
        public Counter(int übergebenerSchwellwert)
        {
            schwellwert = übergebenerSchwellwert;
        }
        #endregion Konstruktor
        public void Hinzufügen(int a)
        {
            gesamt += a;
            if(gesamt >= schwellwert)
           {
                OnSchwellwertErreicht(EventArgs.Empty);
            }
        }
    }
}
