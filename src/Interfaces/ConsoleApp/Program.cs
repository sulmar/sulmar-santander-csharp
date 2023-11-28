using ConsoleApp.Model;
using System.Net.WebSockets;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankAccountService bankAccountService = new CsvFileBankAccountService();
            List<BankAccount> bankAccounts = bankAccountService.GetAllBankAccounts();

            foreach (BankAccount bankAccount in bankAccounts)
            {
                bankAccount.Withdraw(100);
            }


            IATM aTM = new FeeSantanderATM();
            aTM.Widthdraw(100);


        }
    }
}
