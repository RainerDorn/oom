using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Book
    {
        private string title;
        private decimal price;
        public Book(string newTitle, decimal newPrice)
        {

            public string GetTitle(string newTitle)
            {
            if (newTitle == null || newTitle.Length == 0)
                throw new ArgumentException("Kein Titel!");
            return title;
            }
        public decimal GetPrice()
            { return price; }
        public void SetTitle(decimal newPrice)
        {
            if (newPrice < 0)
                throw new ArgumentException("Negativer Preis!");
            price = newPrice;

        }

      
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Konstruktoroperationen heißen wie die Klasse selber
            Book a = new Book("Mein erstes Buch", 10);
            //Book b = a;
            //a.price = -10;
            //Console.WriteLine("Book.price: " + a.price);


            
        }
    }
}
