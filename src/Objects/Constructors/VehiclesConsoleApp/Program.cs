using Santander.Vehicles.Model;
using Santander.Vehicles.Repositories;
using System.Net.WebSockets;

namespace Santander.Vehicles.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Marek", "Smith");
            Person person2 = new Person("Rafał", "Smith");

            MakeRepository makeRepository = new MakeRepository();

            List<Make> makes = makeRepository.GetAllMakes();

            Make selectedMark = makes[0];
            
            Vehicle vehicle = new Vehicle();
            vehicle.Make = selectedMark;
            vehicle.Model = "2";
            vehicle.VIN = "53843583757345734";
            vehicle.Mileage = 40_000;
            vehicle.ProductionYear = 2022;
            vehicle.Color = "Black";
            vehicle.Price = 100_000;
            vehicle.Owner = person1;

            Console.WriteLine(vehicle.Owner.FirstName);

            vehicle.Sell(person2);

            Console.WriteLine(vehicle.Owner.FirstName);
        }

    }
}