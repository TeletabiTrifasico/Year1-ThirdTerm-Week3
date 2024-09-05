using System.Globalization;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            BookStore store = new BookStore();

            Book book1 = new Book("Dracula", "Bram Stoker", 15.00, 5);
            Book book2 = new Book("Joe speedboot", "Tommy Wieringa", 12.50, 5);
            Magazine magazine1 = new Magazine("Time", "Friday", 3.90, 10);
            Magazine magazine2 = new Magazine("Donald Duck", "Thursday", 2.50, 8);
            Book book3 = new Book("The hobbit", "J.R.R. Tolkien", 12.50, 4);

            store.AddBook(book1);
            store.AddBook(book2);
            store.AddBook(magazine1);
            store.AddBook(magazine2);
            store.AddBook(book3);

            store.PrintCompleteStock();
        }
    }
}