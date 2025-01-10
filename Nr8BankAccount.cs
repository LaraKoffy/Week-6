using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr8
{
    public class BankAccount
    {

        private string _accountNumber;
        private double _balance;


        public BankAccount(string accountNumber, double initialBalance)
        {
            _accountNumber = accountNumber;
            _balance = initialBalance;
        }


        public string AccountNumber
        {
            get { return _accountNumber; }
        }

        public double Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }


        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited ${amount}. New balance is: ${_balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }


        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew ${amount}. New balance is: ${_balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }
    }
}
