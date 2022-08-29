using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    internal class Account
    {
        public int AccountNo { get; set; }
        public string Description   { get; set; } = String.Empty;
        public decimal Balance { get; set; }

        public void Deposit(decimal Amount)
        {
            Balance += Amount;
        }
        public void Withdraw(decimal Amount)
        {   if(Amount <= Balance)
            {
                Balance -= Amount;
            } else
            {
                Console.WriteLine("Insufficient funds!");
            }
           
        }
        public void Transfer(decimal Amount, Account ToAccount)
        {
            Withdraw(Amount);
            ToAccount.Deposit(Amount);
        }

    }
}
