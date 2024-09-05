using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Book : BookStoreItem
    {
        public string Author { get; private set; }
        public Book(string title, string author, double price, int count)
        {
            Title = title;
            Author = author;
            Price = price;
            Type = Type.Book;
            Author = author;
            Count = count;
        }
        public override void PrintBook()
        {
            Console.WriteLine($"[{this.Type}] '{this.Title}' by {this.Author}, {this.Price:0.00} ({this.Count}x)");
        }
    }
}
