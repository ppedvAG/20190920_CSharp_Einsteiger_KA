using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Zahl eingeben!: ");
            //try
            //{
            //    int input = int.Parse(Console.ReadLine());
            //}
            //catch (Exception exceptionObject)
            //{
            //    Console.WriteLine($"Fehlernachricht: {exceptionObject.Message}");
            //    Console.WriteLine($"Fehler-Trace: {exceptionObject.StackTrace}");

            //    Console.WriteLine(Environment.NewLine);
            //}
            //finally
            //{
            //    Console.WriteLine("Danke...");
            //}


            try
            {
                Console.WriteLine("Hallo Exception");
                // Werfen des Fehlers
                throw new CustomException("Fehlermeldung");
            // Auffangen
            } catch (CustomException ex)
            {
                // Behandlung
                MessageBox.Show(ex.Message);
            }

            




            Console.WriteLine("---- ENDE PROGRAMM -----");
            Console.ReadKey();
        }
    }
}
