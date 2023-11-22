using ShopperConsoleApp.Model;

namespace ShopperConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Shopper!");

            // Tworzymy obiekt katalog produktowy
            ProductCatalog catalog = new ProductCatalog();

            // TODO: Pobierać produkty z pliku tekstowego CSV

            Product product1 = new Product("Product 1", "1111", 1.99m);
            Product product2 = new Product("Product 2", "2222", 20.99m);
            Product product3 = new Product("Product 3", "3333", 100.99m);

            catalog.AddProduct(product1);
            catalog.AddProduct(product2);
            catalog.AddProduct(product3);

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
