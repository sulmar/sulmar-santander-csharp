using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FilterItems();

            // FilterItemsByLinq();

            // FilterStringsByLinq();

            var customers = new List<Customer>
            {
                new(1, "A", "Warszawa", 0),
                new(2, "B", "Poznań", 1000),
                new(3, "C", "Warszawa", -2000),
                new(4, "D", "Kraków", -1000),
                new(5, "E", "Poznań", -5000),
                new(6, "F", "Kraków", -3000),
                new(5, "G", "Poznań", -1000),
            };

            var results = customers
                .Where(customer => (customer.City == "Poznań" || customer.City == "Warszawa") && customer.Balance < 0)
                .Select(customer => customer);

            var results2 = from customer in customers
                           where (customer.City == "Poznań" || customer.City == "Warszawa") && customer.Balance < 0
                           select customer;

            //var results = customers
            //    .Where(customer => customer.City == "Poznań")
            //    .Where(customer => customer.Balance < 0);

            foreach (var customer in results)
            {
                Console.WriteLine($"{customer.Name} {customer.City} {customer.Balance}");
            }


        }

        private static void FilterStringsByLinq()
        {
            IEnumerable<string> fruits = ["apple", "banana", "cherry", "kiwi", "mango"];

            var newlist = fruits
                .Where(x => x.Contains("a"))
                .Select(x => x);

            // SQL: select x from fruits where x like '%a%'
            var newLists2 = from x in fruits
                            where x.Contains("a")
                            select x;

            foreach (string fruit in newlist)
            {
                Console.WriteLine(fruit);
            }
        }

        private static void FilterItemsByLinq()
        {
            IEnumerable<int> items = new List<int> { 1, 5, 6, 7, 8, 10, 11 };

            // LINQ (odpowiednik Lists Comprehension w Pythonie)
            // https://www.w3schools.com/python/python_lists_comprehension.asp

            // Filtrowanie
            IEnumerable<int> results = items.Where(item => item < 10);

            // Wyrażenie lambda
            // item => item < 10

            // R
            // test <- item < 10

            // Wyświetla rezultaty
            foreach (int item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static void FilterItems()
        {
            IEnumerable<int> items = new List<int> { 1, 5, 6, 7, 8, 10, 11 };

            // Inicjalizacja 
            List<int> results = new List<int>();

            // Wyszukujemy elementy
            foreach (int item in items)
            {
                if (item < 10)  // Warunek (Predykat)
                {
                    results.Add(item);
                }
            }

            // Wyświetla rezultaty
            foreach (int item in results)
            {
                Console.WriteLine(item);
            }
        }
    }

}
