
int size = 3;

// Tablice (Arrays)

// Deklaracja typu i rozmiaru tablicy
string[] selectedColors = new string[size];

// Przypisanie elementu na podstawie indeksu
selectedColors[0] = "red";
selectedColors[1] = "blue";
selectedColors[2] = "green";

// Pobranie elementu na podstawie indeksu
string selectedColor = selectedColors[1];

Console.WriteLine(selectedColor);

string[] dayOfWeeks = new string[] { "Pn", "Wt", "Sr", "Czw", "Pt", "So", "Nd" };

for (int index = 0; index < dayOfWeeks.Length; index = index + 1)
{
    Console.WriteLine($"{index} - {dayOfWeeks[index]}");
}

foreach (string dayOfWeek in dayOfWeeks.Skip(2))
{
    Console.WriteLine(dayOfWeek);
}

int[,,] board3D = new int[6, 8, 2];









