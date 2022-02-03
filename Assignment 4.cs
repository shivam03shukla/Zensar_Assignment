/* 3. Create a simple Stationery application to add items and display added items using Generic collections */
using System;
using System.Collections.Generic;
namespace GenericApp
{
    public class TestClass<T>
    {
        T[] obj = new T[5];
        int count = 0;
        public void  Add(T item)
        {
            if (count + 1 < 6)
            {
                obj[count] = item;

            }
            count++;
        }
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass<int> intObj = new TestClass<int>();
            intObj.Add(Convert.ToInt32(Console.ReadLine()));
            intObj.Add(Convert.ToInt32(Console.ReadLine()));
            intObj.Add(Convert.ToInt32(Console.ReadLine()));     
            intObj.Add(Convert.ToInt32(Console.ReadLine()));
            intObj.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Added Item is:");
            for (int i = 0; i < 5; i++)
            {  
                Console.WriteLine(intObj[i]); 
            }
            Console.ReadKey();
        }
    }
}

/*----OUTPUT-----
8
88
888
98
9
Added Item is:
8
88
888
98
9
*/
