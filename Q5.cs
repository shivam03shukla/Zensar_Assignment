/*Write a program in C# Sharp to create a nested structure to store two data for an employee in an array*/
using System;
    class strucExer3
    {
        struct employee
        {
            public string eName;
            public dtObirth Date;
        }
        struct dtObirth
        {
            public int Day;
            public int Month;
            public int Year;
        }  
        static void Main(string[] args)
        {
             
            int dd=0, mm=0, yy=0;
            int total = 2;
      Console.WriteLine("Create a nested structure and store data in an array :");
      Console.WriteLine("-------------------------------------------------------");   
            employee[] emp = new employee[total];
 
            for (int i = 0; i < total; i++)
            {
                Console.Write("Name of the employee : ");
                string nm = Console.ReadLine();
                emp[i].eName = nm;
                Console.Write("Input day of the birth : ");
                dd = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Day = dd;
                Console.Write("Input month of the birth : ");
                mm = Convert.ToInt32(Console.ReadLine());
                emp[i].Date.Month = mm;
                Console.Write("Input year for the birth : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                emp[i].Date.Year = yy;
            }
        }
    }
/*----OUTPUT---
Create a nested structure and store data in an array :-------------------------------------------------------
Name of the employee : SHIVAM
Input day of the birth : 21
Input month of the birth : 01
Input year for the birth : 2000
*/