using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment02
{
    class Ticket
    {
        private string movieName;
        public double Price { get; private set; }
        private int cinemaRoom;
        private DateTime startTime;
        private int minimumAge;

        public Ticket(string movieName, double price, int cinemaRoom, DateTime startTime, int minimumAge)
        {
            MovieName = movieName;
            Price = price;
            CinemaRoom = cinemaRoom; 
            StartTime = startTime;
            MinimumAge = minimumAge;
        }
        public string MovieName
        {
            get { return movieName; }
            private set
            {
                if (value.Length > 0)
                {
                    this.movieName = value;
                }
                else { Console.WriteLine("Error occured: Empty movie name!"); }
            }
        }
        public int CinemaRoom
        {
            get { return cinemaRoom; }
            private set
            {
                if (value > 0 && value < 6)
                {
                    this.cinemaRoom = value;
                }
                else { Console.WriteLine($"Error occured: Invalid cinema room({cinemaRoom})!"); }
            }
        }
        public DateTime StartTime
        {
            get { return startTime; }
            private set
            {
                if (value.Minute == 30 || value.Minute == 00)
                {
                    this.startTime = value;
                }
                else { Console.WriteLine($"Error occured: Invalid start time! ({startTime})"); }
            }
        }
        public int MinimumAge
        {
            get { return minimumAge; }
            private set
            {
                if (value == 0 || value == 6 || value == 9 || value == 12 || value == 16)
                {
                    this.minimumAge = value;
                }
                else
                {
                    Console.WriteLine($"Error occured: Invalid minimum age ({minimumAge})!");
                }
            }
        }
        public bool Discount
        {
            get
            {
                if (startTime.DayOfWeek.ToString() == "Monday" || startTime.DayOfWeek.ToString() == "Tuesday")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string ToString()
        {
            return $"created ticket '{movieName}', start time: {startTime.ToString("dd/MM/yyyy HH:mm")}, price: {Price:0.00}, room: {CinemaRoom} ({MinimumAge}+)";
        }
    }
}