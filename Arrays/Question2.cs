//using System;
//using System.Collections.Generic;
//using System.Text;
////enter 10 elements in an array and print the biggest element
//namespace Arrays
//{
//    internal class Question2
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[10];
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.WriteLine($"Enter the value for element {i + 1}:");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            int max = a[0];
//            for (int i = 1; i < a.Length; i++)
//            {
//                if (a[i] > max)
//                {
//                    max = a[i];
//                }
//            }
//            Console.WriteLine($"The biggest element in the array is: {max}");
//        }
//    }
//}
