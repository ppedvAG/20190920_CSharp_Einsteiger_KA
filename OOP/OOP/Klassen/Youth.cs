using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Youth : Account
    {
        public Youth(string Owner) : base(Owner)
        {
            Console.WriteLine($"Constructor of Youth called ...");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Balance:{Balance}");
        }
        public Youth(string Owner, decimal Balance) : base(Owner, Balance)
        {
            Console.WriteLine($"Constructor of Youth called ...");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Balance:{Balance}");
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 50 && (!(amount > Balance)))
            {
                Console.WriteLine("Jugend-Konto: Abheben erfolgreich...");
                base.Withdraw(amount);
            }
            else if (amount > 50)
            {
                Console.WriteLine($"Maximum withdraw amount exceeded...");
            }
            else
            {
                Console.WriteLine($"Not enough deposit...");
            }

        }
    }
}
