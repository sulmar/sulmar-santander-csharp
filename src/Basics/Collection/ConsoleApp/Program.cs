
List<object> items = new List<object>();
items.Add("Hello");
items.Add(100);

int number = (int) items[1];


List<string> members = new List<string>();
members.Add("Lidia");
members.Add("Monika");
members.Add("Klaudia");
members.Add("Marek");
members.Add("Bartek");
members.Add("Rafał");
members.Add("Marcin");

//members[6] = "John";

//members.Remove("John");

if (members.Contains("Marcin"))
{
    Console.WriteLine("Jest Marcin na sali");
}
else
{
    Console.WriteLine("Nie ma Marcina na sali");
}

foreach (string member in members)
{
    Console.WriteLine(member);
}


string selectedMember = members[3];

Console.WriteLine(selectedMember);