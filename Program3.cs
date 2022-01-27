/*create an abstract class student with name,studentid,grade as members and also
 * an abstract method boolean ispassed(grade) which takes grade as an input and checks
 * whether student passed the course or not.*/
using System;

namespace assignment2
{
    class Program3
    {

        abstract class Student
        {
            private String name;
            private int studentId;
            private double grade;
            abstract public bool Ispassed(double grade);
        }
        class UnderGrad:Student
        {
            public override bool Ispassed(double grade)
            {
                if (grade > 70.0) return true;
                else return false;
            }
        }
        class Grad : Student
        {
            public override bool Ispassed(double grade)
            {
                if (grade > 80.0) return true;
                else return false;
            }
        }
        class psp
        {
            public static void Main(string[] args)
            {
                double grade;
                bool result;
                Console.WriteLine("Enter the grade of under graduate student:");
                grade = Convert.ToDouble(Console.ReadLine());
                UnderGrad ug = new UnderGrad();
                result = ug.Ispassed(grade);
                Console.WriteLine("Result of under graduate student:" + result);
                Console.WriteLine("Enter the grade of graduate student:");
                grade = Convert.ToDouble(Console.ReadLine());
                Grad g = new Grad();
                result = g.Ispassed(grade);
                Console.WriteLine("Result of graduate student:" + result);
            }
        }
    }
}
/*---OUTPUT---
 Enter the grade of under graduate student:
69.0
Result of under graduate student:False
Enter the grade of graduate student:
81.0
Result of graduate student:True
*/
    

