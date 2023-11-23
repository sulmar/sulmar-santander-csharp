namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string selectedCountry = "USA";

            decimal taxRatio;

            // Wybór wyrażenia na podstawie wartości przychodzącej

            switch(selectedCountry)
            {
                case "Poland": taxRatio = 0.23m; break;
                case "UK": taxRatio = 0.19m; break;
                case "France": taxRatio = 0.19m; break;
                case "Germany": taxRatio = 0.11m; break;

                default:
                    taxRatio = 0.22m; break;
            }

            int temperature = 89;

            switch(temperature)
            {
                case <= 0: Console.WriteLine("Stan stały"); break;
                case > 100: Console.WriteLine("Stan gazowy"); break;
                default: Console.WriteLine("Stan ciekły"); break;
            }


            switch (temperature)
            {
                case <= 0: 
                case > 100: 
                    Console.WriteLine("Woda nie jest w stanie ciekłym"); break;

                default: Console.WriteLine("Stan ciekły"); break;
            }
        }
    }
}
