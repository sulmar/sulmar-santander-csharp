namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // while(warunek)
            // {
            //      Ciało pętli
            // }

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("Hello, World!");

                i++;
            }

            int number = 0;

            while (number != 10)
            {
                Console.WriteLine("Podaj liczbę z zakresu 0..10");
                number = int.Parse(Console.ReadLine());
            }

            while (true)
            {
                Console.Write(".");
            }

        }
    }
}
