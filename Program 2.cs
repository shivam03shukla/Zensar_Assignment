/* 1.Write a program to find the Sum and the Average points scored by the
teams in the IPL. Create a Class called Cricket that has a function called
Pointscalculation(int no_of_matches) that takes no.of matches as input and 
accepts that many scores from the user. The function should then display 
the Average and Sum of the scores */

using System;

namespace ConsoleApp1
{
    class Cricket
    {
        public void PointsCalculation(int[] no_of_matches)
        {
            for (int i = 1; i < no_of_matches.Length; i++)
            {
                no_of_matches[i] *= 2;
            }

        }
        public void DisplayPoints(int[] no_of_matches)
        {
            Console.WriteLine("The point score by teams are:");
            for (int i = 0; i < no_of_matches.Length; i++)
            {
                Console.WriteLine(no_of_matches[i]);
            }
        }
        public int DisplaySum(int[] no_of_matches)
        {
            int sum = 0;
            for (int i = 0; i < no_of_matches.Length; i++)
            {
                sum = sum + no_of_matches[i];
            }
            return sum;
        }
        public double DisplayAvg(int[] no_of_matches)
        {
            double avg;
            avg = DisplaySum(no_of_matches) / 8.0;
            return avg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[8];
            Console.WriteLine("Enter the Matches played by Teams:");
            for (int i = 1; i < m.Length; i++)
            {
                Console.WriteLine("Enter the Matches played by Team{0}:", i);
                m[i] = Convert.ToInt32(Console.ReadLine());
            }
            Cricket C = new Cricket();
            C.PointsCalculation(m);
            C.DisplayPoints(m);
            int s = C.DisplaySum(m);
            double a = C.DisplayAvg(m);
            Console.WriteLine("The Sum and Average of points scored by teams are: {0} and {1}", s, a);
        }
    }
}
/* ---OUTPUT----
Enter the Matches played by Teams:
Enter the Matches played by Team1:
4
Enter the Matches played by Team2:
5
Enter the Matches played by Team3:
4
Enter the Matches played by Team4:
5
Enter the Matches played by Team5:
6
Enter the Matches played by Team6:
4
Enter the Matches played by Team7:
4
The point score by teams are:
8
10
8
10
12
8
8
The Sum and Average of points scored by teams are: 64 and 8 */