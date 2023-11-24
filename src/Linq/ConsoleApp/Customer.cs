using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Customer
    {
        public int Id;
        public string Name;
        public string City;
        public decimal Balance;

        public Customer(int id, string name, string city, decimal balance)
        {
            Id = id;
            Name = name;
            City = city;
            Balance = balance;
        }
    }
}
