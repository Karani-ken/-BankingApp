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
            var Account = new BankAccount("Kenneth",1000);
            Console.WriteLine($"An Account {Account.Number} has been created for " +
                $"{Account.Name} with initial balance of {Account.Balance}");
            Console.ReadLine();
        }
    }
}
                                                                        