using Console_App_Bank_Task.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Bank_Task.Models
{
    internal class Transaction
    {
        public int TransactionId { get; }
        static int count;
        private decimal _amount;
        public decimal Amount 
        {
            get 
            {  
                return _amount; 
            }
            set
            {
                if(value>0)
                {
                    _amount = value;
                }
                else
                {
                    throw new InvalidOperationException("Amount is not correct");
                }
            }
        }
        public DateTime TransactionDate { get; set; }
        public TransactionTypes TransactionType { get; set; }

        public Transaction(decimal amount, DateTime transactionDate, TransactionTypes transactionType)
        {
            Amount = amount;
            TransactionDate = transactionDate;
            TransactionType = transactionType;
            count++;
            TransactionId = count;
        }
    }
}
