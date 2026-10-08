//using System;
//using System.Collections.Generic;
//using System.Text;
//// checking how many occourance of a number in an array
//namespace Arrays
//{
//    internal class Question7
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[10];
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.WriteLine($"Enter the value for element {i + 1}:");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("Enter the number to check its occurrence:");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int count = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] == num)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine($"The number {num} occurs {count} times in the array.");
//        }
//    }
//}
