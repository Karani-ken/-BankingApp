using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Banking_App
{
    public class BankAccount
    {
        public string Number { get; }
        public string Name { get; set; }
        public decimal Balance { get; }

        private static int accountNumberSeed = 1234567890;
        public BankAccount( string name, decimal initialBalance)
        {
            this.Name = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
        }
        public void makeDeposit()
        {

        }
        public void makeWithdraw(string amount)
        {

        }
    }
}
