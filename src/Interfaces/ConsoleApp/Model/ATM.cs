namespace ConsoleApp.Model
{
    interface IATM
    {
        void Income(decimal amount);
        void Widthdraw(decimal amount);
    }

    abstract class SantanderATM : IATM
    {
        protected decimal balance;

        public void Income(decimal amount)
        {
            balance += amount;
        }

        public void Widthdraw(decimal amount)
        {
            balance -= amount;
        }
    }

    class FreeSantanderATM : SantanderATM, IATM
    {
               
    }

    class FeeSantanderATM : SantanderATM, IATM
    {        
        private decimal fee = 0.2m;        

        public new void Widthdraw(decimal amount)
        {
            base.Widthdraw(amount);

            balance += fee;
        }
    }

    class PKOATM : IATM
    {
        private decimal saldo;
        private decimal prowizja = 0.1m;

        public void Income(decimal amount)
        {
            saldo = saldo + amount - prowizja;
        }

        public void Widthdraw(decimal amount)
        {
            saldo = saldo - amount - prowizja;
        }
    }
}
