using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public abstract class Account
    {

        #region Felder
        private string owner;
        private decimal balance;
        #endregion Felder

        #region Eigenschaften
        public virtual string Owner {
            get {
                return owner;
            }
            set {
                owner = value;
            }
        }
        public virtual decimal Balance {
            get {
                return balance;
            }
            protected set {
                balance = value;
            }
        }
        #endregion Eigenschaften

        #region Konstruktor
        public Account(string Owner)
        {
            owner = Owner;
            Console.WriteLine($"Constructor of Account called ...");
            Console.WriteLine($"Account-Owner: {owner}");
            MessageBox.Show($"Konto erstellt für {owner}");
        }
        public Account(string Owner, decimal Balance)
        {
            owner = Owner;
            balance = Balance;
            Console.WriteLine($"Constructor of Account called ...");
            Console.WriteLine($"Account-Owner: {owner}");
            Console.WriteLine($"Account-Balance:{balance}");
        }
        #endregion Konstruktor

        #region Methoden
        public void Deposit(decimal amount)
        {
            balance += amount;
            System.Console.WriteLine($"Amount of {amount} deposit. New balance {balance}.");
        }

        public virtual void Withdraw(decimal amount)
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

