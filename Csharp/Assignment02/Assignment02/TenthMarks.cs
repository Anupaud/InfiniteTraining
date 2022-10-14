//2.Write a program in C# to accept ten marks and display the following
//	a.Total
//	b.Average
//	c.Minimum marks
//	d.Maximum marks
//	e.Display marks in ascending order
//	f.Display marks in descending order

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    class TenthMarks
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 45, 55, 65, 75, 85, 95, 25, 35, 15, 5 };
            int sum = 0;
            int avg;
            int i=0;
            

            for ( i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }

            avg = sum / num.Length;

            Console.WriteLine("Average of an array:" + avg);

            

            for (i = 0; i < num.Length - 1; i++)
            {
                if (num[i] > num[i + 1])
                {
                    int a = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = a;
                }
            }
            Console.WriteLine("Max value is {0}", num[i]);


            for (i = 0; i < num.Length - 1; i++)
            {
                if (num[i] < num[i + 1])
                {
                    int a = num[i];
                    num[i] = num[i + 1];
                    num[i + 1] = a;
                }
            }
            Console.WriteLine("Min value is {0}", num[i]);


            for (int n = num.Length - 1; n >= 1; n--)
            {
                for (i = 0; i < n; i++)
                {
                    if (num[i] > num[i + 1])
                    {
                        int a = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = a;
                    }
                }
            }
            Console.WriteLine("Ascending order of an array is :");

            foreach (int ii in num)
            {
                Console.WriteLine(ii);
            }

            for (int n = num.Length - 1; n >= 1; n--)
            {
                for (i = 0; i > n; i++)
                {
                    if (num[i] < num[i + 1])
                    {
                        int a = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = a;
                    }
                }
            }

            Console.WriteLine("Descending order of an array is :");

            foreach (int ii in num)
            {
                Console.WriteLine(ii);
            }
        }
    }
}
