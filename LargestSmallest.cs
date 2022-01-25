using System;

namespace Assignment
{
     class LargestSmallest
    {
        static void Main(string[] args)
        {    int a,b,c;
		Console.WriteLine("enter any three numbers");
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		c=Convert.ToInt32(Console.ReadLine());
		if(a<b&&a<c){
				Console.WriteLine("the smallest number is " + a);
				}
		else if(b<c){
				Console.WriteLine("the smallest number is " + b);
					}
		else{
			Console.WriteLine("the smallest number is " + c);
					}
		if(a>b&&a>c){
			Console.WriteLine("the largest number is " + a);
				}
		else if(b>c){
			Console.WriteLine("the largest number is " + b);
				}
		else{
			Console.WriteLine("the largest number is " + c);
				}

            }
		}
			}