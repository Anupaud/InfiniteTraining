
//5.Write a program in C# to display temperature in Celsius. Accept the temperature in Fahrenheit.
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01
{
    class Temperature
    {
        static void Main(string[] args)
        {
            double celsius;
            double fahrenheit;

            Console.WriteLine("Enter the temp in fahrenheit");
            fahrenheit = Double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is : " + celsius);
        }
    }
}
