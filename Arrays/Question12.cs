//using System;
//using System.Collections.Generic;
//using System.Text;
////finding the largest difference between two elements in an array
//namespace Arrays
//{
//    internal class Question12
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
//            int min = a[0];
//            for (int i = 1; i < a.Length; i++)
//            {
//                if (a[i] > max)
//                {
//                    max = a[i];
//                }
//                if (a[i] < min)
//                {
//                    min = a[i];
//                }
//            }
//            int largestDifference = max - min;
//            Console.WriteLine($"The largest difference between two elements in the array is: {largestDifference}");
//        }
//    }
//}
