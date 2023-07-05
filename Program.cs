using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Account = new BankAccount("Kenneth",10000);
            Console.WriteLine($"An Account {Account.Number} has been created for " +
                $"{Account.Name} with initial balance of {Account.Balance}");
            Account.makeDeposit(1500, DateTime.Now, "savings");
            Account.makeWithdraw(700, DateTime.Now, "Pizza");
            Account.makeWithdraw(2000, DateTime.Now, "Rent");
            Console.WriteLine("\t\tAccount History");
            Console.WriteLine(Account.getAccountHistory());
            Console.ReadLine();
        }
    }
}
                                                                        