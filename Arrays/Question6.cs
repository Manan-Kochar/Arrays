using System;
using System.Collections.Generic;
using System.Text;
// enter 10 elements in an array and print array after sorting it in assending order
namespace Arrays
{
    internal class Question6
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter the value for element {i + 1}:");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(a);
            Console.WriteLine("The array elements in ascending order are:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }
        }
    }
}
