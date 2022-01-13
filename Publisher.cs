using System;

namespace Classes.Publisher
{
    public class Publisher
    {
        public Publisher(string pubName)
        {
            this.PublisherName = pubName;
        }
        
        private string PublisherName { get; set; }

        public void Print()
        {
            Console.WriteLine("Publisher: {0}", PublisherName);
        }
    }
}