using System;

namespace Classes.Magazine
{
    internal class Magazine : Book.Book
    {
        public Magazine(string pubName, string name, string author, bool interesting, string genre, int amount, string theme)
            : base(pubName, name, author, interesting, genre, amount)
        {
            this.Theme = theme;
        }
        
        private string Theme { get; set; }

        public void Print()
        {
            Console.WriteLine("Theme {0}", Theme);
        }
    }
}