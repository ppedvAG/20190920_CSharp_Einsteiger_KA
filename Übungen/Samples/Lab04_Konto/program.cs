using System;

namespace Konto
{
    class Program {
        static void Main() {
            Account k1 = new Account("Max Mustermann", 5000);
            k1.Describe();
            k1.Deposit(500);
            k1.Describe();
            k1.Withdraw(1000);
            k1.Describe();


            Console.ReadLine();
        }
    }
}