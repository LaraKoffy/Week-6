using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr6
{
    class Account
    {
       
        private string _accountHolder;
        private double _amount;

    
        public Account(string accountHolder)
        {
            _accountHolder = accountHolder;
            _amount = 0; 
        }

       
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _amount += amount;
                LogTransaction($"Deposited ${amount}. Current balance: ${_amount}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        
        private void LogTransaction(string message)
        {
           
            Console.WriteLine($"Transaction Log: {message}");
        }

       
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {_accountHolder}");
            Console.WriteLine($"Balance: ${_amount}");
        }
    }
