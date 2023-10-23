using Console_App_Bank_Task.enums;
using Console_App_Bank_Task.Exceptions;
using Console_App_Bank_Task.Interfacies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Bank_Task.Models
{
    internal class Account : IAccount
    {
        static int _id=1101 ;
        public int AccountId { get; }
        public static decimal Balance { get; set; }
        public Account()
        {
            _id++;
            AccountId = _id;
        }
        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                DateTime dateTime = DateTime.Now;
                Transaction transaction = new Transaction(amount, dateTime, TransactionTypes.Deposit);
                Balance += amount;
                Array.Resize(ref _transactions, _transactions.Length + 1);
                _transactions[^1] = transaction;
            }
        }

        public void Withdraw(decimal amount)
        {
            if(amount > 0)
            {
                if (amount <= Balance)
                {
                    DateTime dateTime = DateTime.Now;
                    Transaction transaction = new Transaction(amount, dateTime, TransactionTypes.Deposit);
                    Balance -= amount;
                    Array.Resize(ref _transactions, _transactions.Length + 1);
                    _transactions[^1] = transaction;
                }
                else
                {
                    throw new InsufficientFundsException("No insufficient amount in the balance");
                }
            }
        }

        private Transaction[] _transactions=new Transaction[0];
    }
}
