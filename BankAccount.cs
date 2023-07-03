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
        public decimal Balance { 
            
            get 
            {
                decimal balance = 0;
                    foreach (var item in Alltransactions) 
                    {
                             balance += item.Amount;
                    }
                    return balance;
            }
            
        }

        private static int accountNumberSeed = 1234567890;
        private List<Transactions> Alltransactions = new List<Transactions>();
        public BankAccount( string name, decimal initialBalance)
        {
            this.Name = name;
            makeDeposit(initialBalance, DateTime.Now, "initial balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            
        }
        public void makeDeposit(decimal amount, DateTime date, string notes)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Amount of deposit must be positive");
            }
            var depost = new Transactions(amount, date, notes);
            Alltransactions.Add(depost);

        }
        public void makeWithdraw(decimal amount, DateTime date, string notes)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must bge positive");
            }
            if(Balance-amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this operation");
            }
            var withdrawa = new Transactions(amount, date, notes);
            Alltransactions.Add(withdrawa);

        }
    }
}
