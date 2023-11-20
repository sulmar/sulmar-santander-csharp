const sbyte meltWaterTemperature = 0;

sbyte currentTempature = -9;

if (currentTempature < meltWaterTemperature)
{
    Console.WriteLine("Frozen");
}


const byte HighwaySpeedLimit = 140;

Console.Write("Podaj prędkość: ");
string currentSpeedString = Console.ReadLine();

// Zamiana tekstu na liczbę byte
byte currentSpeed = byte.Parse(currentSpeedString);
Console.WriteLine(currentSpeed);

if (currentSpeed > HighwaySpeedLimit) 
{
    Console.WriteLine("Overlimit!");
}

if (currentSpeed < HighwaySpeedLimit)
{

}


