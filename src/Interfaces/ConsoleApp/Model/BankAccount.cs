using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Model
{
    internal class BankAccount
    {
        public int Id;
        public string Number;
        public decimal Balance;
        public DateTime OpenedDate;
        public DateTime? ClosedDate;

        // bankAccount = new BankAccount(); // Utworzenie instacji
        // bankAccount.Number = "1111";     // Przypisanie wartości

        // new BankAccount() { Number = "1111" }  // Wywołanie inicjalizatora

        public BankAccount()
        {
            
        }

        // new BankAccount(1, "1111")   // Wywołanie konstruktora
        public BankAccount(int id, string number, decimal balance = 0)
        {
            Id = id;
            Number = number;
            Balance = balance;

            OpenedDate = DateTime.Today;
        }

        public void Withdraw(decimal amount)
        {
            Balance += amount;
        }
    }
}
