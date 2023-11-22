using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopperConsoleApp.Model
{
    // TODO: dodaj nazwę, opis, kod kreskowy, kolor, cenę i ocenę w skali 1..5
    internal class Product
    {
        public string Name;
        public string Description;
        public string BarCode;
        public Color? Color;
        public Size? Size;
        public decimal Price;
        private List<byte> ratings;

        public int Popularity;
        

        // Konstruktor
        public Product(string name, string barcode, decimal price)
        {
            this.Name = name;
            this.BarCode = barcode;
            this.Price = price;
        }

        // Metoda do podnoszenia popularności
        public void IncrementPopularity()
        {
            Popularity++; // popularity = popularity + 1;
        }

        // Ocena w skali 1..5
        public void Rate(byte rating)
        {   
            // Walidacja (sprawdzenie poprawności przychodzących danych)
            if (rating < 1 || rating > 5)
            {
                Console.WriteLine($"Ocena {rating} jest spoza zakresu 1..5");
                return;
            }                   

            // Logika
            ratings.Add(rating);
        }

        // TODO: dodaj metodę do obliczania średniej oceny
    }

    // Typ wyliczeniowy
    public enum Color
    {
        Red,
        Green,
        Blue,
        Purple,
        Black
    }

    // Typ wyliczeniowy
    public enum Size
    {
        S,
        M,
        L,
        XL
    }

   
    
}
