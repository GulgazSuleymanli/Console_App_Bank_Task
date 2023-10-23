using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Bank_Task.Interfacies
{
    internal interface IAccount
    {
        public int AccountId { get; }
        public static decimal Balance { get; set; }

        public void Deposit(decimal amount);
        public void Withdraw(decimal amount);
    }
}
