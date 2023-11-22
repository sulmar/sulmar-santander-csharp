using ShopperConsoleApp.Model;
using System.Globalization;

namespace ShopperConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Shopper!");

            string filename = "Products.csv";
            char separator = ';';


            // Tworzymy obiekt katalog produktowy
            ProductCatalog catalog = new ProductCatalog();

            // Pobieranie produktów z pliku tekstowego CSV

            // Odczytujemy zawartości całego pliku i przypisujemy do zmiennej tekstowej
            // string content = File.ReadAllText(filename);

            // Odczytujemy zawartość całego pliku i przypisujemy do tablicy tekstów jako osobne linie
            string[] lines = File.ReadAllLines(filename);

            // Przechodzimy po wierszach 
            foreach (string line in lines.Skip(1)) // Skip(1) - pomija pierwszą linię
            {
                Console.WriteLine(line);

                // Tniemy tekst na osobne kolumny
                string[] columns = line.Split(separator);

                // Pobieramy wartości poszczególnych kolumn i przypisujemy do zmiennych
                string name = columns[0];
                string barcode = columns[1];
                decimal price = decimal.Parse(columns[2], CultureInfo.InvariantCulture);

                // Tworzymy obiekt typu Product z użyciem konstruktora na podstawie zmiennych
                Product product = new Product(name, barcode, price);

                // Dodajemy utworzony obiekt produktu do katalogu 
                catalog.AddProduct(product);

            }

            

            //Product product1 = new Product("Product 1", "1111", 1.99m);
            //Product product2 = new Product("Product 2", "2222", 20.99m);
            //Product product3 = new Product("Product 3", "3333", 100.99m);

            //catalog.AddProduct(product1);
            //catalog.AddProduct(product2);
            //catalog.AddProduct(product3);

            // Wyświetlenie zawartości katalogu
            catalog.Show();

            // Tworzymy obiekt (instancję klasy) koszyka zakupowego 
            ShoppingCart cart = new ShoppingCart();

            // Pętla nieskończona
            while (true)
            {
                Console.Write("Podaj kod kreskowy: ");

                // Przypisujemy do zmiennej barcode typu string wynik działania metody Console.ReadLine()
                string barcode = Console.ReadLine();

                // Przypisujemy do zmiennej selectedProduct typu Product wynik działania metody GetByBarCode()
                Product selectedProduct = catalog.GetByBarCode(barcode);

                // Sprawdzamy czy wybrany produkt nie jest pustym obiektem
                if (selectedProduct != null)
                {
                    // Wywołujemy metodę i przekazujemy wybrany produkt
                    cart.AddProduct(selectedProduct);

                    cart.Show();

                    catalog.Show();
                }
                else
                {
                    Console.WriteLine($"Produkt z kodem kreskowym '{barcode}' nie istnieje.");
                }
            }
        }
    }
}
