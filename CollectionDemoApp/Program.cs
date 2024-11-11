using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemoApp
{
    //Content class 
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

    }
    public class Library
    {
        private List<Book> books = null;
        private string location;
        public Library(string location) 
        {
            books = new List<Book>();
            books.Add(new Book {Id=1,Title = "Inside c#",Description ="best seller",Author="Steve jobs" });
            books.Add(new Book { Id = 1, Title = "Inside c++", Description = "best seller", Author = "Steve jobs" });
            books.Add(new Book { Id = 1, Title = "Inside c--", Description = "best seller", Author = "Steve jobs" });
            this.location = location;
        }

        //property
        public string Location 
        {
            get { return this.location; }
            set { this.location = value; }
        }

        //Indexer
        public Book this[int index] 
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Library pccoeLib = new Library("Akurdi");
            Console.WriteLine(pccoeLib.Location);

            Book thebook = pccoeLib[2];

            Console.WriteLine(thebook.Id + " "+ thebook.Title + " " + thebook.Description + " " + thebook.Author);

            pccoeLib[2] = new Book { Id = 1, Title = "Inside c++", Description = "best seller", Author = "Steve jobs" } ;
            thebook = pccoeLib[2];

            Console.WriteLine(thebook.Id + " " + thebook.Title + " " + thebook.Description + " " + thebook.Author);

            Console.ReadLine();
        }
    }
}
