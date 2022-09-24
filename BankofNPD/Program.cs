using System;

namespace BankofNPD
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Nia", 1000000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

            account.MakeWithdrawal(2000, DateTime.Now, "Rent");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(1000, DateTime.Now, "Toys");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(1000, DateTime.Now, "Handloan");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
