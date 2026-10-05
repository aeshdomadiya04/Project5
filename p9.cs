using System;
using System.Collections.Generic;
using System.Text;

namespace Project5
{
    class p9
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter position to delete: ");
            int pos = Convert.ToInt32(Console.ReadLine());

            for (int i = pos - 1; i < 4; i++)
            {
                a[i] = a[i + 1];
            }

            Console.WriteLine("Array after deletion:");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("Name : AESH DOMADIYA");
            Console.WriteLine("Enrollment No. : 24SOECE11008");
        }
    }
}
