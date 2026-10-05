using System;
using System.Collections.Generic;
using System.Text;

namespace Project5
{
    class p5
    {
        public static void Main(String[] args)
        {
            int[] a = new int[5];
            int count = 0;

            Console.WriteLine("Enter 5 elements:");

            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("Number of duplicate elements = " + count);
            Console.WriteLine("Name : AESH DOMADIYA");
            Console.WriteLine("Enrollment No. : 24SOECE11008");

        }
    }
}
