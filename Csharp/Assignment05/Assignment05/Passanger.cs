//2.Create an console application to book train tickets. Create a Passanger class with (Name, Age) and 
//    write a function called TicketBooking(int no_of_tickets) that takes no.of tickets to be booked. 
//    If the no of tickets is > 2 per booking, raise an user defined exception, and print "cannot book more than 2 tickets".
//Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment05
{
    class Passanger
    {
        public int Age;
        public string Name;
        private int no_of_tickets;

        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 2)
            {
                Console.WriteLine("cannot book more than 2 tickets");
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
        static void Main(string[] args)
        {
            Passanger obj = new Passanger();
            
        }
    }
   
}
