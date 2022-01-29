/*Create an Interface IStudent with StudentId and Name as Properties,
 ShowDetails() as its method. Create 2 classes Dayscholar and Resident 
 that implements the interface Properties and Methods. Test The 
 functionalities. */
using System;
namespace _28janprj
{
    class class3
    {

        interface IStudent
        {
           
            void ShowDetails();
        }
        class DayScholar : IStudent
        {

            public int StudentId;
            public String Name;
            public DayScholar(int StudentId, String Name)
            {
                this.StudentId = StudentId;
                this.Name = Name;
            }
            public void ShowDetails()
            {
                Console.WriteLine("Day Scholar Student Id: " + StudentId);
                Console.WriteLine("Day Scholar Student Name: " + Name);
            }
        }
        class Resident : IStudent
        {
            public int StudentId;
            public String Name;
            public Resident(int StudentId, String Name)
            {
                this.StudentId = StudentId;
                this.Name = Name;
            }
            public void ShowDetails()
            {
                Console.WriteLine("Resident Student Id: " + StudentId);
                Console.WriteLine("Resident Student Name: " + Name);
            }
        }
        class psp3
        {
            public static void Main(string[] args)
            {
                int StudentId;
                String Name;
                Console.WriteLine("Enter the name of day scholar student:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Id of day scholar student:");
                StudentId = Convert.ToInt32(Console.ReadLine());
                DayScholar ds = new DayScholar(StudentId, Name);
                ds.ShowDetails();
                Console.WriteLine("Enter the name of resident student:");
                Name = Console.ReadLine();
                Console.WriteLine("Enter the Id of day resident student:");
                StudentId = Convert.ToInt32(Console.ReadLine());
                Resident rs = new Resident(StudentId, Name);
                rs.ShowDetails();
            }
        }
    }
}
/*---OUTPUT----
Enter the name of day scholar student:
SHIVAM
Enter the Id of day scholar student:
9090
Day Scholar Student Id: 9090
Day Scholar Student Name: SHIVAM
Enter the name of resident student:
SHIV
Enter the Id of day resident student:
8080
Resident Student Id: 8080
Resident Student Name: SHIV
*/