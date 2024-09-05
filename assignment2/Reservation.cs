using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Reservation
    {
        public Customer Customer { get; set; }
        public List<Ticket> Tickets = new List<Ticket>();

        public Reservation(Customer customer)
        {
            this.Customer = customer;
        }
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (Ticket ticket in Tickets)
                {
                    if (ticket.Discount)
                    {
                        //minus 5%
                        total += ticket.Price * 0.95;
                    }
                    else
                    {
                        total += ticket.Price;
                    }
                }
                if (Customer.Discount)
                {
                    // total minus 10%
                    total *= 0.9;
                }
                return total;
            }
        }
        public string ToString()
        {
            return $"creating tickets (for {Customer.Name})";
        }
    }
}