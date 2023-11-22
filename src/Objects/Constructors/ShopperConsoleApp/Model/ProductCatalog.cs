using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperConsoleApp.Model
{
    // Klasa 
    internal class ProductCatalog
    {
        // Lista produktów
        private List<Product> products = new List<Product>();

        // Stała
        private const int BarCodeSize = 4;

        // Metoda do dodawania produktów
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void AddProducts(List<Product> products)
        {
            foreach (Product product in products)
            {
                AddProduct(product);
            }
        }

        // Metoda do wyszukiwania produktu na podstawie kodu kreskowego
        public Product GetByBarCode(string barCode)
        {
            // Walidacja #1
            // Sprawdzamy czy kod kreskowy jest pusty
            if (string.IsNullOrEmpty(barCode))
            {
                Console.WriteLine("Pusty kod kreskowy");
                return null;
            }

            // Walidacja #2
            // Sprawdzamy rozmiar kodu kreskowego
            if (barCode.Length != BarCodeSize)
            {
                Console.WriteLine("Nieprawidłowy kod kreskowy");
                return null;
            }

            // Odpowiednik SQL: SELECT * FROM dbo.Products ORDER BY popularity ASC
            products = products.OrderByDescending(product => product.Popularity).ToList();

            // R: x <- x + 2    <--->    C#: x => x + 2
            // Wyrażenie lambda (Lambda Expression) - zapis funkcyjny

            foreach (Product product in products)
            {
                // Warunek (Predykat - funkcja, która zwraca true/false)
                if (product.BarCode == barCode) return product;
            }

            // Zwracamy pusty produkt
            return null;
        }

        // Metoda do wyświetlenia katalogu produktów
        public void Show()
        {
            Console.WriteLine("Katalog produktów: ");

            // Przechodzimy w pętli po wszystkich produktach
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.Name} {product.BarCode} {product.Price:C2} {product.Popularity}");
            }
        }

       

    }
}
