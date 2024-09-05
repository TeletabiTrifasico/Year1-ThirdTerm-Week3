using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class BookStoreItem
    {
        public Type Type { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get { return Price * Count; } }
        public virtual void PrintBook()
        {
            Console.WriteLine();
        }
    }
}