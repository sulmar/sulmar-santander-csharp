using ConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // Interfejs to kontrakt/umowa 
    // Posiada tylko sygnatury metod
    // Nie zawiera żadnych implementacji
    interface IBankAccountService
    {
        List<BankAccount> GetAllBankAccounts();
        BankAccount GetBankAccount(string number);
        void AddBankAccount(BankAccount bankAccount);       
    }

    // Klasa implementuje interfejs (nie dziedziczy)
    class FakeBankAccountService : IBankAccountService
    {
        public List<BankAccount> GetAllBankAccounts()
        {
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(1, "1111", 1000),
                new BankAccount(2, "2222", 500),
                new BankAccount(3, "3333", 1500),
            };

            return bankAccounts;
        }

        public BankAccount GetBankAccount(string number)
        {
            return null;
        }

        public void AddBankAccount(BankAccount bankAccount)
        {

        }

        public void CloseBankAccount(string number)
        {

        }

    }


    class CsvFileBankAccountService : IBankAccountService
    {
        public List<BankAccount> GetAllBankAccounts()
        {
            var lines = File.ReadAllLines("bankaccounts.csv");
            var columns = lines.Select(row => row.Split(','));
            var bankAccounts = columns.Select(row => new BankAccount(int.Parse(row[0]), row[1], decimal.Parse(row[2])));

            return bankAccounts.ToList();
        }
        public BankAccount GetBankAccount(string number)
        {
            return null;
        }
        public void AddBankAccount(BankAccount bankAccount)
        {

        }
    }

    abstract class BankAccountService
    {
        public abstract List<BankAccount> GetBankAccounts();
                
    }
}
