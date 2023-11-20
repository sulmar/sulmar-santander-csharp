// Zmienne (Variables)




string firstName = "Marcin";

// Nazwy klas i metod (notacja Pascalowa)
Console.WriteLine(firstName);

// Nazwy zmiennych (notacja camel-case)
string lastName = "Sulecki";

bool isWoman = firstName.EndsWith('a');

string message1 = string.Format("Hello {0} {1}", firstName, lastName);

// Interpolacja
string message2 = $"Hello {firstName} {lastName}";

// Znak
char sign = 'A';

// Liczby całkowite 

// byte 0..255


byte age = 18;
Console.WriteLine($"byte {byte.MinValue} {byte.MaxValue}");

// sbyte
sbyte temp = -100;
Console.WriteLine($"sbyte {sbyte.MinValue} {sbyte.MaxValue}");

// short -32768..32767
short quantity = 1000;
Console.WriteLine($"short {short.MinValue} {short.MaxValue}");

// int 
int distance = 100000;
Console.WriteLine($"int {int.MinValue} {int.MaxValue}");

// Liczby rzeczywiste

float temperature = 21.50f;

double latitude = 21.665000001;

decimal price = 100.99m;

// Wartość logiczna (boolowska)
bool isHighPrice;


// Data i czas
DateTime currentDate = DateTime.UtcNow;

Console.WriteLine(currentDate);

DateTime logDate = DateTime.Parse("2023-11-20 09:00");

DateTime logginDate;

// +4 godz.
DateTime startDate = DateTime.Now.AddHours(4);

TimeSpan workingTime = logDate.Subtract(startDate);


// Odcinek czasu
TimeSpan duration = TimeSpan.FromHours(10);

// Data
DateOnly dueDate = DateOnly.Parse("2023-11-20");

// Czas
TimeOnly openingHour = TimeOnly.Parse("09:00");

// Nullable

byte? speed = null;

if (speed.HasValue) {
    Console.WriteLine(speed.Value);
}


DateTime? birthDay = null;

if (birthDay.HasValue)
{
    Console.WriteLine(birthDay.Value);
}

string secondName = "";
string thirdName = null;

// 2 + 0 = 2
// 2 + null = null
// null * null = null


// var

var x = 100;

var name = "John";

var capacity = 100.69;




















