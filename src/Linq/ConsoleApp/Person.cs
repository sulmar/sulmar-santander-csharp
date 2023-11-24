using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public int Age 
        {
            get
            {
                return new DateTime((DateTime.Today - Birthday).Ticks).Year;
            }
        }

        public DateTime Birthday;
        public byte Height;
        public byte Weight;

        public Person(string firstName, string lastName, DateTime birthday, byte height, byte weight)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
            Height = height;
            Weight = weight;
        }
    }
}
