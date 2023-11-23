namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List
            List<int> list = [1, 3, 5, 5, 2, 5, 4, 5];

            list[2] = 6;

            list.Remove(3);

            foreach (int number in list)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Count: {list.Count}");

            // HashSet
            HashSet<int> hashset = [1, 3, 5, 5, 2, 5, 4, 5];

            foreach (int number in hashset)
            {
                Console.WriteLine(number);
            }

            // Dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "k1", 1 },
                { "k3", 5 }
            };

            dictionary["k2"] = 6;
            dictionary["k4"] = 5;


            Dictionary<char, bool> accountTypes = new()
            { 
                { 'A', true }, 
                { 'B', false },
                { 'C', false }
            };

            accountTypes['C'] = true;

            Dictionary<string, Country> countries = new Dictionary<string, Country>
            {
                { "PL", new Country("Poland", "PL", 40_000_000) },
                { "UK", new Country("United Kingdom", "UK", 140_000_000) },
                { "FR", new Country("France", "FR", 120_000_000) },
            };

            Country selectedCountry = countries["UK"];

            List<string> countryKeys = countries.Keys.ToList();
            List<Country> countryList = countries.Values.ToList();

            // LINQ
            var sortedCountries = countries.Values.OrderBy(c=>c.Capacity).ToList();

            // dictionary.Add("k2", 6); // exception

            // Queue

            Queue<char> queue = new Queue<char>();

            queue.Enqueue('a');
            queue.Enqueue('b');
            queue.Enqueue('c');

            while( queue.Count > 0 )
            {
                char item = queue.Dequeue();

                Console.WriteLine(item);
            }

            Queue<ShippingItem> toSent = new Queue<ShippingItem>();
            toSent.Enqueue(new ShippingItem("1", "P1", "Marek"));
            toSent.Enqueue(new ShippingItem("2", "P2", "Lidia"));
            toSent.Enqueue(new ShippingItem("3", "P3", "Rafał"));
            toSent.Enqueue(new ShippingItem("4", "P4", "Klaudia"));

            while(toSent.Count> 0 )
            {
                // Pobiera pierwszy element z kolejki ale go nie usuwa
                ShippingItem previewShippingItem = toSent.Peek();

                // Pobiera pierwszy element z kolejki i go usuwa z kolejki
                ShippingItem shippingItem = toSent.Dequeue();

                Console.WriteLine($"Send {shippingItem.Number} {shippingItem.Code} to {shippingItem.Recipient}");
            }

            // Stack (Stos)
            Stack<char> stack = new Stack<char>();
            stack.Push('a');
            stack.Push('b');
            stack.Push('c');

            while( stack.Count > 0 )
            {
                // Pobiera element ze stosu i go usuwa
                char item = stack.Pop();

                Console.WriteLine(item);
            }


        }
    }
}
