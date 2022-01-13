using System;
using Classes.Publisher;
using Classes.Book;
using Classes.Magazine;
using Classes.Textbook;

namespace CSharp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var pb = new Publisher("John");
            pb.Print();
            
            var ct = new Book("Petr", "1984", "George Orwell", true, "Anti-utopia",
                512);
            Console.WriteLine("------------------------");
            ct.Print();
            
            var tx = new Textbook("Zelenskiy Pechataet", "Mathematics", "Zelesnskiy",
                false, "Textbook", 737,
                "mathematics",  9);
            Console.WriteLine("------------------");
            tx.Print();
            
            var mg = new Magazine("Zelenskiy Pechataet", "How to be not Ugly", "Zelesnskiy", 
                false, "Magazine", 1,
            "Beatify");
            Console.WriteLine("------------------");
            mg.Print();
        }
    }
}