////2.Write a C# Sharp program to check whether a given number is positive or negative.  
////	Test Data : 14
//// Expected Output : 14 is a positive number
//using System;
//using System.Collections.Generic;
//using System.Text;

using System;

namespace Assignment01
{
    class positiveOrNot

    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a input number:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
                Console.WriteLine("{0} is a positive number:", num);
            else
                Console.WriteLine("{0} is a negative number:", num);
        }

    }
}



