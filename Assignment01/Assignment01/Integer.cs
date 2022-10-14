//1.Write a C# Sharp program to accept two integers and check whether they are equal or not.  Test Data :
//	Input 1st number: 5
//  Input 2nd number: 5
// Expected Output : 5 and 5 are equal
//using System;

using System;

namespace Assignment01
{
    class Integer
    {
        static void Main(string[] args)
        {
            int FirstNumber = 5;
            int SecondNumber = 5;
            Console.Write("Enter the first Number:");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number:");
            SecondNumber = Convert.ToInt32(Console.ReadLine());

            if (FirstNumber == SecondNumber)
                Console.WriteLine("Given two numbers are equal",FirstNumber);
            else
                Console.WriteLine("Given two numbers are not equal",SecondNumber);
        }
    }
}
