using System.Drawing;

namespace ConsoleApp.Model
{
    // Klasa bazowa
    public abstract class Account
    {
        public string Number;      // pole publiczne (public)
        protected decimal Balance; // pole chronione (protected)
        public string Currency;

        public DateTime OpenedDate;

        private DateTime? ClosedDate; // pole prywatne (private)

        public void Close()           // Metoda publiczna
        {
            if (CanClose())
            {
                ClosedDate = DateTime.Today;
            }
        }

        // Metoda prywatna - możemy ją wywołać tylko z klasy, którą jest właścicielem tej metody
        // Nie można jest wywołać z obcej klasy lub klasy potomnej
        private bool CanClose()
        {
            return Balance == 0;            
        }

        // Metoda publiczna - można ją wywołać z obcej klasy lub klasy potomnej
        public void Print()
        {
            Console.WriteLine($"{Number} {Balance:N2} {OpenedDate} {Currency}");
        }

        // Metoda chroniona (protected) - można ją wywołać tylko z klasy potomnej, nie można jest wywołać z obcej klasy

        public abstract void Income(decimal amount);  // Metoda abstrakcyjna. Posiada tylko sygnaturę metody bez jej ciała.
        public abstract void Withdraw(decimal amount); // Metoda abstrakcyjna
    }

    // Klasa potomna
    class MortgageAccount : Account
    {      
        public override void Income(decimal amount) // Implementuje metodę abstrakcyjną dlatego override
        {
            this.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("Wypłata niemożliwa");
            throw new NotSupportedException();
        }
    }

    // Klasa potomna
    class BankingAcount : Account
    {
        public BankingAcount(string number, string currency = "PLN")
        {
            Number = number;            
            Currency = currency;

            Balance = 0;
            OpenedDate = DateTime.Today;

        }

        public override void Income(decimal amount) // override - tworzymy implementację metody abstrakcyjnej z klasy bazowej
        {
            this.Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new InvalidOperationException();
            }

            this.Balance -= amount;
        }
    }

    // Dziedziczenie (Inheritance)
    // Klasa potomna
    class CreditCardAccount : BankingAcount
    {
        public decimal FeeAfterPeriod;

        public CreditCardAccount(string creditCardNumber, decimal feeAfterPeriod, string currency = "PLN")
             : base(creditCardNumber, currency) // Wywołanie konstruktora klasy bazowej
        {
            FeeAfterPeriod = feeAfterPeriod;         
        }

        public new void Income(decimal amount)  // new - tworzymy nową implementację metody z klasy bazowej
        {
            this.Balance -= amount;
        }

        public new void Withdraw(decimal amount)
        {
            this.Balance += amount;
        }

        // Nowa implementacja metody Print z klasy bazowej
        public new void Print()
        {
            // Wywołanie metody Print klasy bazowej 
            base.Print();

            Console.WriteLine($"{FeeAfterPeriod}");
        }

        public decimal CalculateFee()
        {
            return this.Balance * this.FeeAfterPeriod;
        }

    }

    class ZeroCreditCardAccount : CreditCardAccount
    {
        public ZeroCreditCardAccount(string creditCardNumber, decimal feeAfterPeriod, string currency = "PLN") : base(creditCardNumber, feeAfterPeriod, currency)
        {
            
        }

        public void OdroczenieSplaty()
        {

        }        
    }
}
