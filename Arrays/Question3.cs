//using System;
//using System.Collections.Generic;
//using System.Text;
////enter 10 elements in an array and print the smallest element
//namespace Arrays
//{
//    internal class Question3
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[10];
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.WriteLine($"Enter the value for element {i + 1}:");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            int min = a[0];
//            for (int i = 1; i < a.Length; i++)
//            {
//                if (a[i] < min)
//                {
//                    min = a[i];
//                }
//            }
//            Console.WriteLine($"The smallest element in the array is: {min}");
//        }
//    }
//}
