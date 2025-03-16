using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOOPrevision
{
    internal class BankAccount
    {
        private float balance { get; set; }


        public void MakeDeposit(float amount)
        {
            if (amount < 0)
            {
                throw new Exception("Must be positive number");

            }
            balance += amount;
        }

        public void MakeWithdrawal(float amount)
        {
            balance -= amount;

        }
    }
}
