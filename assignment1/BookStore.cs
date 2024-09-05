using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class BookStore
    {
        private List<BookStoreItem> books = new List<BookStoreItem>();
        public double totalPrice;

        public void AddBook(BookStoreItem book)
        {
            this.books.Add(book);
            this.totalPrice += book.TotalPrice;
        }
        public void PrintCompleteStock()
        {
            foreach (BookStoreItem book in this.books)
            {
                book.PrintBook();
            }
            Console.WriteLine($"\nTotal sales price: {this.totalPrice:0.00}");
        }
    }
}