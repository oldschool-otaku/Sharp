using System;

namespace Classes.Book
{
    internal class Book : Classes.Publisher.Publisher
    {
        public Book(string pubName, string name, string author, bool interesting, string genre, int amount) 
            : base(pubName)
        {
            this.Name = name;
            this.Author = author;
            this.Interesting = interesting;
            this.Genre = genre;
            this.Amount = amount;
        }

        private string Name { get; set; }

        private string Author { get; set; }

        private bool Interesting { get; set; }

        private string Genre { get; set; }

        private int Amount { get; set; }

        public void Print()
        {
            Console.WriteLine("name: {0}", Name);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine(Interesting ? "Interesting: Yes" : "Interesting: No");
            Console.WriteLine("Genre: {0}", Genre);
            Console.WriteLine("Amount of Pages: {0}", Amount);
        }
    }
}