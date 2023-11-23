namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int temperature = 20;

            string message1;

            if (temperature > 20 )
            {
                message1 = "Ciepło";
            }
            else
            {
                message1 = "Zimno";
            }

            // warunek ? wykonaj jeśli prawda : wykonaj jeśli fałsz
            string message = temperature > 20 ? "Ciepło" : "Zimno";

            Console.WriteLine(message);


            int age = 19;

            if (age > 18)
            {
                Console.WriteLine("For Adult only");
            }
            else
            {
                Console.WriteLine("For Childs");
            }

            int waterTemperature;

            while (true)
            {
                Console.WriteLine("Podaj temperaturę: ");
                waterTemperature = int.Parse(Console.ReadLine());

                if (waterTemperature <= 0)
                {
                    Console.WriteLine("Stan stały");
                }
                else if (waterTemperature > 100)
                {
                    Console.WriteLine("Stan gazowy");
                }
                else
                {
                    Console.WriteLine("Stan ciekły");
                }
            }


        }
    }
}
