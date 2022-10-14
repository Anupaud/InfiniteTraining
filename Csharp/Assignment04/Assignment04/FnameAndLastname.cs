//1.Create a Class Program which would be used to accepts two  Strings - FirstName and LastName and call the static method Display() that
//    displays the first name in one line and the LastName in the second line after converting the same to upper case.

using System;

namespace Assignment04
{
    class FnameAndLastname
    {
        public string FirstName;
        public string LastName;

        public void Display()
        {
            Console.WriteLine("Enter First Name :");          
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            LastName = Console.ReadLine();                          
            Console.WriteLine("First Name is : {0}", FirstName.ToUpper());
            Console.WriteLine("Last Name is : {0}", LastName.ToUpper());
        }

        static void Main(string[] args)
        {
            FnameAndLastname obj = new FnameAndLastname();
           
            obj.Display();
            Console.ReadKey();
        }
    }
}
