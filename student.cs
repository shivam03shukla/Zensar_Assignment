/* create a class called student which has data members like rollno,name,class,
  SEM,branch,int[] marks=new marks[5]*/
using System;

namespace Accounts
{
     
        
        class Student
        {
            private int rollNo, sem;
            private String name, branch, classs;
            public int[] marks = new int[5];
            Student(int rollNo, String name, String classs, int sem, String branch)
            {
                this.rollNo = rollNo;
                this.name = name;
                this.classs = classs;
                this.sem = sem;
                this.branch = branch;
            }
            public void displayResult()
            {
                int sum = 0;
                int avg = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum = sum + marks[i];
                }
                avg = sum / 5;
                for (int i = 0; i < 5; i++)
                {
                    if (marks[i] < 35)
                    {
                       Console.WriteLine("Result: Fail");
                        return;
                    }
                }
                if (avg < 50)
                {
                    Console.WriteLine("Result: Fail");
                    return;
                }
                Console.WriteLine("Result: Pass");
            }
            public void displayValue()
            {
                Console.WriteLine("Roll No: " + rollNo);
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Class: " + classs);
                Console.WriteLine("Semester: " + sem);
                Console.WriteLine("Branch: " + branch);
            }
            public static void Main(string[] args)
            {
                int r, s;
                String n, b, c;
                Console.WriteLine("Enter the name: ");
                 n = Console.ReadLine();               
                Console.WriteLine("Enter the class: ");
                c = Console.ReadLine();
                Console.WriteLine("Enter the branch: ");
                b = Console.ReadLine();
                Console.WriteLine("Enter the roll No: ");
                 r = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter the semester: ");
            s =Convert.ToInt32(Console.ReadLine());
                Student st = new Student(r, n, c, s, b);
                Console.WriteLine("Enter marks: ");
                for (int i = 0; i < 5; i++)
                {
                    st.marks[i] =Convert.ToInt32( Console.ReadLine());
                }
                st.displayResult();
                st.displayValue();
            }
        }
    }

/* ----OUTPUT----
 Enter the name:
shivam
Enter the class:
btech
Enter the branch:
cse
Enter the roll No:
123456
Enter the semester:
8
Enter marks:
80
75
75
80
75
Result: Pass
Roll No: 123456
Name: shivam
Class: btech
Semester: 8
Branch: cse
 */