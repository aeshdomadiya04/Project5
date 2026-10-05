using System;
using System.Collections.Generic;
using System.Text;

namespace Project5
{
    internal class p3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the element" + i );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Ascending order
            //Array.Sort(arr);
            Console.WriteLine("Reverse Order Elements");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Name : AESH DOMADIYA");
            Console.WriteLine("Enrollment No. : 24SOECE11008");
            Console.ReadLine();
        }
    }
}
