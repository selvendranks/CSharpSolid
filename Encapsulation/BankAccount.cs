using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be positive");
            }

            this._balance += amount;
        }

        public void Withdraw(decimal amount) 
            {

            if (amount <= 0) 
            {

                throw new ArgumentException("Withdraw amount needs to be positive");
            }

            if (amount > this._balance)
            {
                throw new InvalidOperationException("Amount must be less than balance");
            }

            this._balance -= amount;

            }


    }
}
