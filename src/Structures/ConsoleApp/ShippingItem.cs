using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class ShippingItem
    {
        public string Number;
        public string Code;
        public string Recipient;

        public ShippingItem(string number, string code, string recipient)
        {
            Number = number;
            Code = code;
            Recipient = recipient;
        }
    }
}
