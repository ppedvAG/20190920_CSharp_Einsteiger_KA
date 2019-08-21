using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Account
    {

        #region Felder
        private string owner;
        private decimal balance;
        #endregion Felder

        #region Eigenschaften
        public string Owner {
            get {
                return owner;
            }
            set {
                owner = value;
            }
        }
        public decimal Balance {
            get {
                return balance;
            }
            private set {
                balance = value;
            }
        }
        #endregion Eigenschaften

        #region Konstruktor
        public Account(string Owner, decimal Balance)
        {
            owner = Owner;
            balance = Balance;
        }
        #endregion Konstruktor

        #region Methoden
        public void Deposit(decimal amount)
        {
            balance += amount;
            System.Console.WriteLine($"Amount of {amount} deposit. New balance {balance}.");
        }

        public void Withdraw(decimal amount)
        {
            balance -= amount;
            System.Console.WriteLine($"Amount of {amount} withdraw. New balance {balance}.");
        }

        public void Describe()
        {
            System.Console.WriteLine($"Current balance: {balance}");
            System.Console.WriteLine($"Account owner: {owner}");
        }

        #endregion Methoden
    }
}

