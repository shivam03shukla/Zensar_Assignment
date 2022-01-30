/*Write a program in C# Sharp to insert the information of two books.*/

using System;

struct book 
{
  public string title;
  public string author;
}
public class test
{
public static void Main (string[] args)  
  {
  int nobook = 1000;  
  book [] books =new book [nobook];  
  int i,j,n=1,k=1;  
  Console.WriteLine("Insert the information of two books :");
  Console.WriteLine("-----------------------------------------");    
      for(j=0;j<=n;j++)
        {
          Console.WriteLine("Information of book {0} :",k);
          Console.Write("Input name of the book : ");
          books[j].title= Console.ReadLine();
          Console.Write("Input the author : ");
          books[j].author= Console.ReadLine();
                k++;
          Console.WriteLine();
          }

          for(i = 0;i <=n;i++)
          {
            Console.WriteLine("{0}: Title = {1},  Author = {2}", i+1, books[i].title, books[i].author);
            Console.WriteLine();
          }

  }
}
/*----OUTPUT----
Insert the information of two books :
-----------------------------------------
Information of book 1 :
Input name of the book : power of subconscious mind
Input the author : dr josheph murfy

Information of book 2 :
Input name of the book : harry potter
Input the author :j.k.rowling   

1: Title = power of subconscious mind,  Author = dr josheph murfy

2: Title = harry potter,  Author = j.k.rowling  

*/