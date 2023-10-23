using Console_App_Bank_Task.Models;

namespace Console_App_Bank_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Bank bank = new Bank();

            Console.WriteLine("______ Welcome to hell ______");

            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("====== Operation Menyu ======");
                Console.WriteLine("~1~ Create new account");
                Console.WriteLine("~2~ Deposit money");
                Console.WriteLine("~3~ Withdraw money");
                Console.WriteLine("~4~ Show all account id");
                Console.WriteLine("~5~ Transfer money");
                Console.WriteLine("~0~ Exit program");
                Console.WriteLine(" ");

                string input = Console.ReadLine();
                Console.WriteLine("...........");

                switch (input)
                {
                    case "1":
                        bank.CreateAccount();
                        Console.WriteLine("Account created");
                        break;

                    case "2":
                        int depositAccountid;
                        decimal depositAmount;

                        do
                        {
                            Console.WriteLine("Insert account id to deposit money");
                            depositAccountid = int.Parse(Console.ReadLine());
                        }
                        while (depositAccountid.ToString().Length<4);

                        Console.WriteLine("Insert deposit amount");
                        depositAmount = decimal.Parse(Console.ReadLine());

                        bank.DepositMoney(depositAccountid, depositAmount);
                        Console.WriteLine("Money deposited successfull");
                        break;

                    case "3":
                        int withdrawAccountid;
                        decimal withdrAwamount;

                        do
                        {
                        Console.WriteLine("Insert account id to withdraw money");
                        withdrawAccountid = int.Parse(Console.ReadLine());
                        }
                        while (withdrawAccountid.ToString().Length < 8);

                        Console.WriteLine("Insert withdraw amount");
                        withdrAwamount = decimal.Parse(Console.ReadLine());

                        bank.DepositMoney(withdrawAccountid, withdrAwamount);
                        Console.WriteLine("Money withdrawed successfull");
                        break;

                    case "4":
                        bank.GetAllAccount();
                        break;

                    case "5":
                        int fromAccountid;
                        int toAccountid;
                        decimal transferAmount;

                        do
                        {
                        Console.WriteLine("Insert account id to withdraw money");
                        fromAccountid= int.Parse(Console.ReadLine());
                        }
                        while (fromAccountid.ToString().Length < 8);

                        do
                        {
                        Console.WriteLine("Insert account id to deposit money");
                        toAccountid= int.Parse(Console.ReadLine());
                        }
                        while (toAccountid.ToString().Length < 8);

                        Console.WriteLine("Insert transferd amount");
                        transferAmount= decimal.Parse(Console.ReadLine());

                        bank.TransferMoney(fromAccountid, toAccountid, transferAmount);
                        Console.WriteLine("Money transfered successfully");
                        break;

                    case "0":
                        check = false;
                        break;
                }
            }
            while (check);
        }
    }
}