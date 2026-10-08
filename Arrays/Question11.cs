//using System;
//using System.Collections.Generic;
//using System.Text;
////finding missing number in an array of 1 to 10
//namespace Arrays
//{
//    internal class Question11
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[9];
//            Console.WriteLine("Enter 9 elements in the array (from 1 to 10, with one missing):");
//            for (int i = 0; i < a.Length; i++)
//            {
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            int sum = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                sum += a[i];
//            }
//            int missingNumber = 55 - sum; 
//            Console.WriteLine($"The missing number in the array is: {missingNumber}");
//        }
//    }
//}
