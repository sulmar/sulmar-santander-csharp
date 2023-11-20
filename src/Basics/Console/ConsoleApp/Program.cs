
Console.Write("Podaj imię: ");

string firstName = Console.ReadLine();
string lastName = Console.ReadLine();

// Console.WriteLine("Witaj " + firstName + "!");

string message = $"Witaj {firstName} {lastName}!";

Console.WriteLine(message);