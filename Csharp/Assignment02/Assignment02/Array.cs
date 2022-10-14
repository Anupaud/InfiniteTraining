//1.Write a Program to assign integer values to an array and then print the following
//	a. Average value of Array elements
//	b. Minimum and Maximum value in an array 
using System;

namespace Assignment02
{
    class Array
    {
        static void Main(string[] args)
        {
            Array arr = new Array();
            arr.Avg();
            arr.MaxandMinofArray();
            Console.Read();
        }
        public void Avg()
        {
            int[] arr = new int[4] { 4, 2, 5, 3 };
            int sum = 0;
            int avg;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            avg = sum / arr.Length;

            Console.WriteLine("Average of an array:" + avg);
        }

        public void MaxandMinofArray()
        {
            int[] arr = new int[5] { 44, 55, 33, 11, 99 };
            int max = arr[0];
            int min = arr[4];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int j = 1; j < arr.Length; j++)
            {
                if (arr[j] < min)
                {
                    min = arr[j];
                }
            }
            Console.WriteLine("max value of an array: " + max);
            Console.WriteLine("min value of an array: " + min);
        }

    }
}
