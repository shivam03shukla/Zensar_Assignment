/* 1. Create a console application to book train tickets.
 Create a Passanger class with (Name, Age) and write a function called 
TicketBooking(no_of_tickets) that takes no.of tickets to be booked. 
If the no of tickets is > 5 per booking, raise an user defined exception, 
and print "cannot book more than 2 tickets". Else Print  "Ticket Booked 
Successfully". Add a Test class to call TicketBooking method by accepting
all required details.*/
using System;

namespace Ticket_Booking
{
    class TicketException : ApplicationException
    {
        public TicketException(string msg) : base(msg)
        {

        }
    }

    class Passenger
    {
        public string name;
        public int age;
        public void book()
        {
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
        }
        public void showdetails()
        {
            Console.WriteLine("Passenger Name:" + name);
            Console.WriteLine("Passenger Age:" + age);
        }
        public void TicketBooking(int no_of_tickets)
        {
            if (no_of_tickets > 5)
            {
                throw (new TicketException("You cannot buy more than five tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }

     class class1
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n <= 3)
            {
                Passenger p = new Passenger();
                Console.WriteLine("Enter Passenger Name and Age");
                p.book();
                p.showdetails();
                Console.WriteLine("No. of tickets that booked:");
                int T = Convert.ToInt32(Console.ReadLine());

                try
                {
                    p.TicketBooking(T);
                }
                catch (TicketException te)
                {
                    Console.WriteLine(te.Message);
                }
                n++;
            }
        }
    }
}

/* ---OUTPUT----
Enter Passenger Name and Age
shivam
25
Passenger Name:shivam
Passenger Age:25
No.of tickets that booked:
5
Ticket Booked Successfully
Enter Passenger Name and Age
shubham
25
Passenger Name:shubham
Passenger Age:25
No.of tickets that booked:
6
You cannot buy more than five tickets
*/