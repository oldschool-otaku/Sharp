using System;

namespace Classes.Textbook
{
    internal class Textbook : Book.Book
    {
        public Textbook(string pubName, string name, string author, bool interesting, string genre, int amount, string subject, int grade)
            : base(pubName, name, author, interesting, genre, amount)
        {
            this.Subject = subject;
            this.Grade = grade;
        } 
        private string Subject { get; set; }

        private int Grade { get; set; }

        public void Print()
        {
            Console.WriteLine("Grade: {0}", Grade);
            Console.WriteLine("Subject: {0}", Subject);
        }
    }
}