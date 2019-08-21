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
            // Instanziierung Jugend-Konto 
            //Youth jugendKonto = new Youth("Max Mustermann");
            Giro giroKonto = new Giro("Hans Wurst");

            //Console.Write("Initial Deposit?: ");
            //decimal uInputDeposit = Convert.ToDecimal(Console.ReadLine());
            //jugendKonto.Deposit(uInputDeposit);

            Console.Write("Initial Deposit?: ");
            decimal uInputDepositGiro = Convert.ToDecimal(Console.ReadLine());
            giroKonto.Deposit(uInputDepositGiro);

            //Console.Write("Withdraw amount?: ");
            //decimal uInputWithdraw = Convert.ToDecimal(Console.ReadLine());
            //jugendKonto.Withdraw(uInputWithdraw);

            Console.Write("Withdraw amount?: ");
            decimal uInputWithdrawGiro = Convert.ToDecimal(Console.ReadLine());
            giroKonto.Withdraw(uInputWithdrawGiro);

            Console.ReadLine();
        }
    }
}
