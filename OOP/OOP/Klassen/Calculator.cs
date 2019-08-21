using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    static class Calculator
    {
        public static double Add(params double[] summanden)
        {
            double summe = 0;
            foreach(double number in summanden)
            {
                summe += number;
            }
            return summe;
        }
    }
}
