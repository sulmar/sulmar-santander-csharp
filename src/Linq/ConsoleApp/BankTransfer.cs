using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BankTransfer
    {
        public decimal Amount;
        public string Currency;

        public BankTransfer(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }


}
