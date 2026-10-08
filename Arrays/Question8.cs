//using System;
//using System.Collections.Generic;
//using System.Text;
////searching for an element in an array and print the index of that element
//namespace Arrays
//{
//    internal class Question8
//    {
//        static void Main(string[] args)
//        {
//            int[] a = new int[10];
//            for (int i = 0; i < a.Length; i++)
//            {
//                Console.WriteLine($"Enter the value for element {i + 1}:");
//                a[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            Console.WriteLine("Enter the element to search for:");
//            int searchElement = Convert.ToInt32(Console.ReadLine());
//            int index = -1;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] == searchElement)
//                {
//                    index = i;
//                    break;
//                }
//            }
//            if (index != -1)
//            {
//                Console.WriteLine($"The element {searchElement} is found at index {index}.");
//            }
//            else
//            {
//                Console.WriteLine($"The element {searchElement} is not found in the array.");
//            }
//        }
//    }
//}
