using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    internal class p2
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the element" + i + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Ascending order
            Array.Sort(arr);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }

            Console.WriteLine("Name : AESH DOMADIYA");
            Console.WriteLine("Enrollment No. : 24SOECE11008");
            Console.ReadLine();
        }
    }
}


//OR

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Project5
//{
//    internal class p3
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[5];

//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Enter the element" + i + ": ");
//                arr[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            //Ascending order
//            //Array.Sort(arr);
//            for (int i = 0; i < 5; i++)
//            {
//                for (int j = i + 1; j < 5; j++)
//                {
//                    int temp = arr[i];
//                    arr[i] = arr[j];
//                    arr[j] = temp;
//                }
//            }

//            Console.WriteLine("Sorted Array: ");
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine(arr[i] + " ");
//            }

//            Console.WriteLine("Name : AESH DOMADIYA");
//            Console.WriteLine("Enrollment No. : 24SOECE11008");
//            Console.ReadLine();
//        }
//    }
//}
