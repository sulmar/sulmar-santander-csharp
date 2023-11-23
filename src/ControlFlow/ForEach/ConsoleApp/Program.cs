namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Lidia", "Klaudia", "Monika", "Marek", "Rafał", "Bartek" };

            // foreach(lokalna zmienna in zbiór)
            // {
            //    Ciało pętli
            // }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            List<string> countries = new List<string>() { "Poland", "USA", "France", "England" };            

            foreach (string country in countries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
