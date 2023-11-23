using System.Collections.Concurrent;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = 10;

            // do
            // while
            // { 
            //   wyrażenie
            // } (warunek)

            do
            {
                Console.WriteLine("Podaj liczbę z zakresu 0..10");
                number = int.Parse(Console.ReadLine());

            }
            while (number != 10);


            string selectedProtocol;
            string[] protocols = new string[] { "TCP", "UDP", "HTTP" };

            do
            {
                Console.WriteLine("Podaj protokół");
                Console.WriteLine(string.Join(",", protocols));
                selectedProtocol = Console.ReadLine();

            } while (!protocols.Contains(selectedProtocol));


            bool isConnected = false;

            Random random = new Random();

            int probe = 1;

            do
            {
                double value = random.NextDouble();                

                Console.WriteLine($"Connecting... probe #{probe} {value}");

                isConnected = value > 0.9;

                Thread.Sleep(1000);

                probe++;

            } while (!isConnected);

            Console.WriteLine("Connected.");

        }
    }
}
