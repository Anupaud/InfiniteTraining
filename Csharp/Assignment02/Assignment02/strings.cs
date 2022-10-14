//3.Strings Assignment
//  1.Write a program in C# to accept a word from the user and display the length of it.
//	2.Write a program in C# to accept a word from the user and display the reverse of it. 
//	3.Write a program in C# to accept two words from user and find out if they are same. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    class strings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word:");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine(len);
        }

        public static void reversestring()
        {
            string str, str1="";
            int i, l;
            Console.Write("Enter a string : ");
            str = Console.ReadLine();

            l = str.Length - 1;
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];

            }
            Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
        }

        public static void WordsequalorNot()
        {
            Console.WriteLine("Enter first Word :");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter second value :");
            string str2 = Console.ReadLine();

            if (str1 == str2)
                Console.WriteLine("Both words are equal");

            else
                Console.WriteLine("Both words are not equal");
        }
    }
    
}
