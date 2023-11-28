using CarConsoleApp.Model;

namespace CarConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Car electricCar1 = new ElectricCar();
            // electricCar1.Start();

            List<Car> cars = new List<Car>
            {
                 new ElectricCar(),
                 new PetrolCar(),
                 new PetrolCar(),
                 new ElectricCar(),
                 new ElectricCar(),
            };

            foreach (Car car in cars)
            {
                car.Start();

            }



        }
    }
}
