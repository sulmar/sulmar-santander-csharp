using Banking;

// Obiekt - instancja klasy
Person person1 = new Person("Marcin", "Sulecki");
Person person2 = new Person("Marek", "Smith");

// Inicjalizacja obiektu z pomocą pól
Account account1 = new Account("555-000000-1111", 1000);
account1.AccountType = AccountType.Saving;
account1.Owner = person1;

// Inicjalizacja obiektu za pomocą inicjalizatorów
Account account2 = new Account("999-000000-2222", 5000)
{            
    Owner = person2
};

Account account3 = new Account("777-000000-2222") 
{     
    AccountType = AccountType.Mortage, 
    Owner = person2 
};

List<Account> accounts = new List<Account>();
accounts.Add(account1);
accounts.Add(account2);
accounts.Add(account3);

// 

Account fromAccount = accounts[0];
Account toAccount = accounts[2];

Transfer transfer1 = new Transfer();
transfer1.Title = "Nagroda";
transfer1.Amount = 100;
transfer1.From = fromAccount;
transfer1.To = toAccount;

transfer1.MakeTransfer();

Console.WriteLine(transfer1.From.Balance);
Console.WriteLine(transfer1.To.Balance);



