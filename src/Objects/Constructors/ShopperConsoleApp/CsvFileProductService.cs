using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopperConsoleApp.Model;

namespace ShopperConsoleApp
{
    internal class CsvFileProductService
    {
        public List<Product> GetProducts(string path, char separator)
        {
            List<Product> products = new List<Product>();

            // Pobieranie produktów z pliku tekstowego CSV

            // Odczytujemy zawartości całego pliku i przypisujemy do zmiennej tekstowej
            // string content = File.ReadAllText(filename);

            // Odczytujemy zawartość całego pliku i przypisujemy do tablicy tekstów jako osobne linie
            string[] lines = File.ReadAllLines(path);

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
                products.Add(product);

            }

            return products;
        }
    }
}
