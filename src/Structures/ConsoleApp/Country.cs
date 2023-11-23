using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Country
    {
        public string Name;
        public string CountryCode;
        public int Capacity;

        public Country(string name, string countryCode, int capacity)
        {
            Name = name;
            CountryCode = countryCode;
            Capacity = capacity;
        }
    }
}
