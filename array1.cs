using System;

namespace Assignment
{
     class array1
    {

        public static void Main()
        {
            int[] arr = { 1, 2, 6, 2, 18 };

            int i = 0;
            int sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);

          
            
               
                int  max, min, n;
                // size of the array
                n = 5;
                max = arr[0];
                min = arr[0];
                for (i = 1; i < n; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.Write("Maximum element = {0}\n", max);
                Console.Write("Minimum element = {0}\n\n", min);
            }
        }
    }
    


