using System;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        public void Start()
        {
            // Create customers
            Customer lionelMessi = new Customer("Lionel Messi", new DateTime(1987, 6, 24));
            Customer pietPaulusma = new Customer("Piet Paulusma", new DateTime(1956, 12, 15));

            // Print customers
            PrintCustomer(lionelMessi);
            Console.WriteLine();
            PrintCustomer(pietPaulusma);
            Console.WriteLine();

            // Set the time the movies are starting
            DateTime bohemianRapsodyTime = new DateTime(2021, 02, 13, 21, 30, 00);
            DateTime theProdigyTime = new DateTime(2021, 02, 13, 22, 00, 00);
            DateTime greenBookTime = new DateTime(2021, 02, 15, 19, 00, 00);

            // Create the tickets for three movies
            Ticket bohemianRapsody = new Ticket("Bohemian Rapsody", 10.50, 1, bohemianRapsodyTime, 6);
            Ticket theProdigy = new Ticket("The Prodigy", 10.50, 4, theProdigyTime, 16);
            Ticket greenBook = new Ticket("Green Book", 10.50, 5, greenBookTime, 12);

            // Create reservation1 for first customer
            Reservation reservationOne = new Reservation(lionelMessi);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(reservationOne.ToString());
            Console.ResetColor();

            // Add the movies to his reservation
            reservationOne.Tickets.Add(bohemianRapsody);
            reservationOne.Tickets.Add(theProdigy);
            reservationOne.Tickets.Add(greenBook);

            // Print total price of reservation
            Console.WriteLine($"total price of reservation: {reservationOne.TotalPrice:0.00}");

            // Create reservation2 for second customer
            Reservation reservationTwo = new Reservation(pietPaulusma);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(reservationTwo.ToString());
            Console.ResetColor();

            // Add the movies to his reservation
            reservationTwo.Tickets.Add(bohemianRapsody);
            reservationTwo.Tickets.Add(theProdigy);
            reservationTwo.Tickets.Add(greenBook);

            // Print total price of reservation
            Console.WriteLine($"total price of reservation: {reservationTwo.TotalPrice:0.00}");

            // Print the tickets for reservationOne
            Console.WriteLine($"creating tickets (for {reservationOne.Customer.Name})");
            foreach (Ticket ticket in reservationOne.Tickets)
            {
                Console.WriteLine(ticket.ToString());
            }
            Console.WriteLine($"total price of reservation: {reservationOne.TotalPrice:0.00}");

            // Print the tickets for reservationTwo
            Console.WriteLine($"creating tickets (for {reservationTwo.Customer.Name})");
            foreach (Ticket ticket in reservationTwo.Tickets)
            {
                Console.WriteLine(ticket.ToString());
            }
            Console.WriteLine($"total price of reservation: {reservationTwo.TotalPrice:0.00}");

        }

        public void PrintCustomer(Customer customer)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(customer.Name);
            Console.ResetColor();

            Console.WriteLine($"date of birth: {customer.AgeOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"age: {customer.Age}");
            Console.WriteLine($"discount: {(customer.Discount ? "yes" : "no")}");
        }
    }
}
