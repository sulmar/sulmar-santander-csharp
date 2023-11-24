using System.Collections;
using System.Collections.ObjectModel;

namespace ConsoleApp
{
    // https://learn.microsoft.com/pl-pl/dotnet/csharp/linq/
    internal class Program
    {
        static void Main(string[] args)
        {
            // FilterItems();

            // FilterItemsByLinq();

            // FilterStringsByLinq();

            // FilterCustomersByLinq();

            // ProjectionByLinq();

            // ProjectionsByLinq2();

            // AggregateByLinq();

            // IntersectionByLinq();

            // DifferenceByLinq();

            var bankTranfers = new List<BankTransfer>
            {
                new BankTransfer(100, "GB"),
                new BankTransfer(200, "PLN"),
                new BankTransfer(600, "USD"),
                new BankTransfer(100, "GB"),
                new BankTransfer(100, "USD"),
                new BankTransfer(500, "USD"),
            };

`            // SQL:
            // SELECT Currency, SUM(Amount) as TotalAmount
            // FROM bankTranfers
            // GROUP BY Currency
            var query = bankTranfers
                .GroupBy(bankTranfer => bankTranfer.Currency)
                .Select(g => new { Currency = g.Key, TotalAmount = g.Sum(bt => bt.Amount) })
                .ToList();

            var query2 = from bankTranfer in bankTranfers
                         group bankTranfer by bankTranfer.Currency into g
                         select new { Currency = g.Key, TotalAmount = g.Sum(bt=>bt.Amount) };


            // GB 200
            // PLN 200
            // USD 1200

                         // SQL: SELECT * FROM bankTranfers ORDER BY Amount 
            var results1 = bankTranfers.OrderBy(bt => bt.Amount);

            var results2 = from bt in bankTranfers
                           orderby bt.Amount
                           select bt;

            // SQL: SELECT * FROM bankTranfers ORDER BY Amount desc
            var results3 = bankTranfers.OrderByDescending(bt => bt.Amount);

            var results4 = from bt in bankTranfers
                           orderby bt.Amount descending
                           select bt;

            //  SQL: SELECT * FROM bankTranfers ORDER BY Amount, Currency
            var results5 = bankTranfers.OrderBy(bt => new { bt.Amount, bt.Currency });

            var results6 = from bt in bankTranfers
                           orderby bt.Amount, bt.Currency
                           select bt;

            // Typ anonimowy
            var vehicle = new { Id = 1, Model = "Audi A6", ProductionYear = 2023 };

            var items = new List<string> { "100", "200", "20", "150" };

            var sortedItems = items
                .Select(i => int.Parse(i))
                .OrderBy(i => i);


            var names = new List<string>
            {
                "ą",
                "a",
                "ć",
                "c",
                "ó",
                "o"
            };


            var q = names.Order();

            //var checks = new List<string>
            //{
            //    "GB",
            //    "USD"
            //};

            // var checkBankTranfers = bankTranfers.Select(bt=>bt.Currency).Intersect(checks);


        }

        private static void DifferenceByLinq()
        {
            var myNumbers = new List<int> { 1, 5, 6, 7, 8, 10, 11 };
            var happyNumbers = new List<int> { 1, 6, 7, 12, 11, 9 };

            // Różnica zbiorów
            var results = myNumbers.Except(happyNumbers);
        }

        private static void IntersectionByLinq()
        {
            var myNumbers = new List<int> { 1, 5, 6, 7, 8, 10, 11 };
            var happyNumbers = new List<int> { 1, 6, 7, 12, 11, 9 };

            // Część wspólna (iloczyn zbiorów)
            var results = myNumbers.Intersect(happyNumbers);

            var count = myNumbers.Intersect(happyNumbers).Count();

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static void AggregateByLinq()
        {
            var items = new List<int> { 1, 5, 6, 7, 8, 10, 11 };

            var total = items.Sum();

            Console.WriteLine(total);

            var people = new List<Person>()
            {
                new Person("John", "Smith",  DateTime.Parse("2001-01-01"), 176, 80),
                new Person("Bob",  "Smith",  DateTime.Parse("2011-04-01"), 156, 40),
                new Person("Kate", "Smith",  DateTime.Parse("2005-05-01"), 166, 50),
                new Person("John", "Spider", DateTime.Parse("1990-12-01"), 186, 90),
                new Person("Bob", "Spider",  DateTime.Parse("1991-11-01"), 180, 60),
            };

            // SQL: SELECT sum(Weight) FROM people WHERE Age > 30
            var totalWeight = people
                .Where(person => person.Age > 30)
                .Sum(person => person.Weight);

            // SQL: SELECT AVG(Age) FROM people
            var avgAge = people.Average(person => person.Age);

            Console.WriteLine(totalWeight);
            Console.WriteLine(avgAge);
        }

        private static void ProjectionsByLinq2()
        {
            var items = new List<int> { 1, 5, 6, 7, 8, 10, 11 };

            var results = items.Select(item => item * item);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }

        private static void ProjectionByLinq()
        {
            var people = new List<Person>()
            {
                new Person("John", "Smith",  DateTime.Parse("2001-01-01"), 176, 80),
                new Person("Bob",  "Smith",  DateTime.Parse("2011-04-01"), 156, 40),
                new Person("Kate", "Smith",  DateTime.Parse("2005-05-01"), 166, 50),
                new Person("John", "Spider", DateTime.Parse("1990-12-01"), 186, 90),
                new Person("Bob", "Spider",  DateTime.Parse("1991-11-01"), 180, 60),
            };

            // Projekcja
            // SQL: SELECT firstname, lastname FROM people
            var results = people
                .Where(person => person.Weight > 50)
                .Select(person => new { person.FirstName, person.LastName }); // Powstaje Tuple, Typ anonimowy

            foreach (var person in results)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        private static void FilterCustomersByLinq()
        {
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
