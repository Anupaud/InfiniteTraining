//3.Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,/) on them and displays the result of that operation.  Test Data
//	Input first number: 20
//	Input operation: -
//	Input second number: 12
//	Expected Output : 20 - 12 = 8
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    class Opertaions
    
    {
        class question_no
        {
            static void Main(string[] args)
            {
                int n1 ,n2,c;
                Console.WriteLine("Enter a value ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b value ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter your option ");           
                c = Convert.ToInt32(Console.ReadLine());              

                switch (c)
                {
                    case 1:
                        Console.WriteLine(n1 + n2);
                        break;

                    case 2:
                        Console.WriteLine(n1 - n2);
                        break;

                    case 3:
                        Console.WriteLine(n1 * n2);
                        break;

                    case 4:
                        Console.WriteLine(n1 / n2);
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}

