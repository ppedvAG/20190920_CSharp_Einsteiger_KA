using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanziierung des Objektes anhand des Blueprints "Person"
            Person person1 = new Person(); // Aufruf des Konstruktors mit "= new ..."
            Person person2 = new Person(30, "Mustermann");

            person1.Alter = 20; // Setzen einer Eigenschaft

            Console.WriteLine($"Datentyp von p1: {person1.GetType()}");
            Console.WriteLine($"Name Person1: {person1.Name}");
            Console.WriteLine($"Name Person2: {person2.Name}");

            Console.WriteLine($"Summe: {Calculator.Add(5, 5, 5, 5, 5, 5)}");

            //Console.WriteLine($"Alter: {person1.Alter}");
            //IrgendeineFunktion();

            Console.ReadLine();
        }

        static void IrgendeineFunktion()
        {
            int x = 10;
            Console.WriteLine($"Wert: {x}");
        }
    }
}
