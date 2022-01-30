/* write a program in c# to declare a structure called books with property,a method to desplay
the value of book_id, and a private field called book_id(int)*/
using System;
struct Books
{
    private int Book_id;
    public void GetBook_id(int id)
    {
        Book_id=id;
        Console.WriteLine("Book_id: {0}",Book_id);
    }
};
public class Test
{
    public static void Main(string[] args)
    {   int id;
        Console.WriteLine("Enter the book id: ");
        id=Convert.ToInt32(Console.ReadLine());
        Books b=new Books();
        b.GetBook_id(id);
        Console.ReadKey();
    }
}
/*----OUTPUT-----
Enter the book id: 
786
Book_id: 786
*/