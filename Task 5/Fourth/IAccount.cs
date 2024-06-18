using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal interface IAccount
    {
        public double Balance { get; set; }
        public void Deposit(double amount);
        public void Withdraw(double amount);
    }
}
