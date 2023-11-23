namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for(initiazacja; warunek; iterator)
            // {
            //    ciało pętli
            // }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello, World!");
            }

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{i} - Hello, World!");
            }

            for (int i = 1; i <= 10; i += 2) // i = i + 2 <-> i+=2
            {
                Console.WriteLine($"{i} - Hello, World!");
            }

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i} - Hello, World!");
            }
        }
    }
}
