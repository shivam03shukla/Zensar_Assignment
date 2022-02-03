/* 2.Create a Class called Products with Productid, Product Name, Price.
Accept 5 Products, sort them based on the price, and display the sorted
Product*/
using System;
using System.Collections.Generic;

namespace Assignment4
{
    class Product {
        static void Main() {
            int Product_ID; 
            string Product_Name; 
            SortedList<double, string> product = new SortedList<double, string>(); 
            Console.WriteLine("Enter 5 Products Details:");
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("Enter product {0} Price and Product {1} Name", i + 1, i + 1);
                product.Add(Convert.ToDouble(Console.ReadLine()), Console.ReadLine());
            } 
            Console.WriteLine("After sorting the deatils of products are:");
            foreach (KeyValuePair<double, string> prod in product) 
            {
                Console.WriteLine("Product Name: {1} \t ProductName: {0}", prod.Key, prod.Value); 
            }
            Console.Read();
        }

    }
}

/*---OUTPUT----
Enter 5 Products Details:
Enter product 1 Price and Product 1 Name
50000
mobile
Enter product 2 Price and Product 2 Name
10
pen'
Enter product 3 Price and Product 3 Name
30
copy
Enter product 4 Price and Product 4 Name
5
pencil
Enter product 5 Price and Product 5 Name
90000
laptop
After sorting the deatils of products are:
Product Name: pencil ProductName: 5
Product Name: pen '       ProductName: 10
Product Name: copy ProductName: 30
Product Name: mobile ProductName: 50000
Product Name: laptop ProductName: 90000
*/