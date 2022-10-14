using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment04
{
    class Count
    {
        public static void Main()
        {
            string str = "OOPS PROGRAMMING";
            char ch = 'O';

            int freq = str.Count(f => (f == ch));
            Console.WriteLine("Number of occurrences of a letter {0} in a given string {1} is : {2} ", ch, str, freq);
            Console.ReadKey();
        }
    }
}
