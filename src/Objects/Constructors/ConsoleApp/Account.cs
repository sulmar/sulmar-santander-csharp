

// Obiekt - instancja klasy

// Inicjalizacja obiektu z pomocą pól

// Inicjalizacja obiektu za pomocą inicjalizatorów



// 




class Account
{
    public string Number;
    public AccountType AccountType;
    public Banking.Person Owner;
    public decimal Balance;

    // Konstruktor (Constructor)
    // zastosowanie:
    // - wymagania do skonstruowania obiektu
    // - ustawienie wartości domyślnych
    public Account(string number, decimal balance = 0)
    {
        Number = number;
        Balance = balance;

        AccountType = AccountType.Banking;
    }
}





