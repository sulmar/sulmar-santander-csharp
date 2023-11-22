using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperConsoleApp.Model
{
    // Klasa reprezentująca koszyk zakupowy
    internal class ShoppingCart
    {
        private List<Product> products = new List<Product>();

        // Metoda do dodawania produktów do koszyka zakupowego
        public void AddProduct(Product product)
        {
            products.Add(product);
            product.IncrementPopularity();
        }

        public void Show()
        {
            Console.WriteLine("Twój koszyk:");

            foreach (Product product in  products)
            {
                Console.WriteLine($"{product.Name} {product.Price:C2}");
            }
        }
    }
}
