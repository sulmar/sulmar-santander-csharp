
GreetHelloWorld();
GreetHelloWorld();
GreetHelloWorld();

Greet("Marcin");
Greet("John");

Greet("Klaudia");

int result = Square(4);

Console.WriteLine(result);


int area = CalculateArea(100, 50);

Console.WriteLine(area);

void GreetHelloWorld()
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Hello, World!");
}

void Greet(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

string GetFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}

int Square(int number)
{
    return number * number;
}

int CalculateArea(int width, int height)
{
    return width * height;
}