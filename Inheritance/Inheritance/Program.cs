using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug a1 = new Auto();

            Console.WriteLine($"Datentyp a1: {a1.GetType()}");
            Console.WriteLine($"{a1.BeschreibeMich()}");

            Console.ReadLine();
        }
    }
}
