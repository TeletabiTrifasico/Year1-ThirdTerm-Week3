using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignment02
{
    class Customer
    {
        private string name;
        private DateTime dateOfBirth;

        public Customer(string name, DateTime dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
        public string Name
        {
            get { return name;}
            private set
            {
                if (value.Length > 0)
                {
                    Console.WriteLine("name cannot be an empty string.");
                }
                else{this.name = value; }
            }
        }
        public DateTime AgeOfBirth
        {
            get { return dateOfBirth; }
            private set
            {
                if (value >= DateTime.Today)
                {
                    Console.WriteLine("date of birth must be in the past");
                }
                else { this.dateOfBirth = value; }
            }
        }
        public int Age
        {
            get
            {
                DateTime todaysDateTime = DateTime.Today;
                int age = Convert.ToInt32(todaysDateTime.Year - AgeOfBirth.Year)-1;
                return age;
            }
        }
        public bool Discount
        {
            get
            {
                if (Age > 60)
                { return true; }
                else
                { return false; }
            }
        }
    }
}