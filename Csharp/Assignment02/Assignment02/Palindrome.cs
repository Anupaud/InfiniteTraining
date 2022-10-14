//4.Write a program in C# to accept a word and to find out whether the given word is a palindrome or not.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string str, reverse = "";
            Console.WriteLine(" Enter string");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--) 
            {
                reverse += str[i].ToString();
            }
            if (reverse == str) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome ", str, reverse);
            }
            else
            {
                Console.WriteLine("String is not Palindrome ", str, reverse);
            }
            Console.Read();
        }
    }
}
    




