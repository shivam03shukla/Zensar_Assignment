using System;

namespace Assignment
{
     class FahrenhitetoCelsius
    { 
            static void Main(string[] args)
            {
                double celsius;
            Console.WriteLine("enter temperature in Fahrenhite");
            double fahrenheit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fahrenheit: " + fahrenheit);
                celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Celsius: " + celsius);
                Console.ReadLine();
            }
        }
    }
