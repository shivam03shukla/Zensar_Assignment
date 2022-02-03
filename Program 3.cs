/* 4. Create a class library CalculateConcession () that takes age as an input
 * and calculates concession for travel as below: If age<=5 then
 * “Little Champs- Free Ticket” should be displayed If age >60 then calculate
 * 30% concession on the totalfare(Which is a constant Eg:500/-) and 
 * Display “ Senior Citizen” + Calculated Fare Else “Print Ticket Booked” + 
 * Fare. Create a Console application with a Class called Program which has 
 * TotalFare as Constant, Name, Age. Accept Name, Age from the user and call 
 * the CalculateConcession() function */


using System;

namespace Assignment4
{
    class Program2
    {
        static void Main()
        { 
            int TotalFare = 500;
            string Name;  
             int Age;
           Console.WriteLine("Enter Name of the citizen: ");
            Name = Console.ReadLine(); 
            CalculateConcession. Concession cc = new CalculateConcession.Concession();
            cc.CalculateConcession1(); 
            Console.Read(); }

    }
}
namespace CalculateConcession
{
    public class Concession
    {
        int TotalFare = 500;
        int Age; 
        public void CalculateConcession1()
        { 
            Console.WriteLine("Enter Age of Citizen : "); 
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age <= 5) { 
                Console.WriteLine("Little Champs-Free Ticket"); 
            } 
            else if (Age > 60) {
                double CalculatedFare = TotalFare * 0.03;
                double Fare = TotalFare - CalculatedFare;
                Console.WriteLine("Senior Citizen has to pay:Rs.{0}", Fare);
            } else
            { 
                Console.WriteLine("Ticked Booked with a payment of Rs.{0}", TotalFare);
            }
        }
    }
}
/* ---OUTPUT---
 Enter Name of the citizen:
shivam
Enter Age of Citizen :
4
Little Champs-Free Ticket
*/


