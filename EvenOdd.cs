using System;
namespace Assignment
{
     class EvenOdd
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Int32.Parse(Console.ReadLine());
            if(number%2 == 0)
            {
                Console.WriteLine("{0} is even", number);      
             }
            else
            {
                Console.WriteLine("{0} is odd", number);
            }
            Console.ReadKey();
        }
    }
}
