using System;

namespace Mini_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Integer-Zahl ein: ");
            int intZahl = int.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine Double-Zahl ein: ");
            double doubleZahl = double.Parse(Console.ReadLine());
            Console.WriteLine($"{intZahl} + {doubleZahl}  als Integer = {intZahl + (int)doubleZahl}");
            Console.WriteLine($"{intZahl} + {doubleZahl} als Double = {intZahl + doubleZahl}");

            double minZahl = Math.Min(intZahl, doubleZahl);
            double maxZahl = Math.Max(intZahl, doubleZahl);

            Console.WriteLine($"{maxZahl} / {minZahl} = {maxZahl / minZahl}");

            Console.ReadKey();
        }
    }
}
