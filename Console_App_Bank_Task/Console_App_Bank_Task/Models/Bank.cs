using Console_App_Bank_Task.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Bank_Task.Models
{
    internal class Bank
    {
        private Account[] _accounts = new Account[0];

        public void CreateAccount()
        {
            Account account = new Account();
            Array.Resize(ref _accounts, _accounts.Length+1);
            _accounts[^1]=account;
        }

        public void DepositMoney(int accountId, decimal amount)
        {
            if(_accounts!=null)
            {
                try
                {
                    for (int i = 0; i < _accounts.Length; i++)
                    {
                        if (_accounts[i].AccountId == accountId)
                        {
                            try
                            {
                                _accounts[i].Deposit(amount);
                            }
                            catch (InvalidAmountException)
                            {
                                Console.WriteLine("Amount is not correct");
                            }
                        }
                    }
                }
                catch (AccountNotFoundException)
                {

                    throw new AccountNotFoundException("Not found this account");
                }
            }
            else
            {
                Console.WriteLine("No bank account");
            }
        }

        public void WithdrawMoney(int accountId, decimal amount)
        {
            if (_accounts != null)
            {
                try
                {
                    for (int i = 0; i < _accounts.Length; i++)
                    {
                        if (_accounts[i].AccountId == accountId)
                        {
                            try
                            {
                                _accounts[i].Withdraw(amount);
                            }
                            catch (InvalidAmountException)
                            {
                                Console.WriteLine("Amount is not correct");
                            }
                        }
                    }
                }
                catch (AccountNotFoundException)
                {
                    throw new AccountNotFoundException("Not found this account");
                }
            }
            else
            {
                Console.WriteLine("No bank account");
            }
        }

        public void TransferMoney(int fromAccountId,  int toAccountId, decimal amount)
        {
            if(_accounts != null)
            {
                try
                {
                    for (int i = 0; i < _accounts.Length; i++)
                    {
                        if (_accounts[i].AccountId == fromAccountId)
                        {
                            try
                            {
                                _accounts[i].Withdraw(amount);
                            }
                            catch (InvalidAmountException)
                            {
                                Console.WriteLine("Amount is not correct");
                            }

                            try
                            {
                                for (int j = 0; j < _accounts.Length; j++)
                                {
                                    if (_accounts[i].AccountId == toAccountId)
                                    {
                                        try
                                        {
                                            _accounts[i].Deposit(amount);
                                        }
                                        catch (InvalidAmountException)
                                        {
                                            Console.WriteLine("Amount is not correct");
                                        }
                                    }
                                }
                            }
                            catch (AccountNotFoundException)
                            {
                                throw new AccountNotFoundException("Not found this account");
                            }
                        }
                    }
                }
                catch (AccountNotFoundException)
                {
                    throw new AccountNotFoundException("Not found this account");
                }
            }
        }

        public void GetAllAccount()
        {
            if ( _accounts != null )
            {
                foreach ( Account account in _accounts )
                {
                    Console.WriteLine($"Account id: {account.AccountId}");
                }
            }
            else
            {
                Console.WriteLine("Account list is null");
            }
        }
    }
}
