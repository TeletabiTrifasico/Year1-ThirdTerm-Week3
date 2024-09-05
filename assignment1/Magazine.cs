using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Magazine : BookStoreItem
    {
        public string Date;

        public Magazine(string Title, string Date, double Price, int Count)
        {
            this.Type = Type.Magazine;
            this.Title = Title;
            this.Date = Date;
            this.Price = Price;
            this.Count = Count;
        }
        public override void PrintBook()
        {
            Console.WriteLine($"[{this.Type}] {this.Title} - release day:{this.Date}, {this.Price:0.00} ({this.Count}x)");
        }
    }
}