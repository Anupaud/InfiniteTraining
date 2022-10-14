//4.Create a class called Customer with Customerid, Name, Age, Phone, City. Write a constructor with no arguments and 
//      another constructor with all information.
//      Write a method called DisplayCustomer(), which is called directly without any object. Also  include destructor

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    class Customer
    {
        int CustomerId;
        string Name;
        int Age;
        string PhoneNo;
        string City;

        public Customer()
        {

        }
        public Customer(int id, string name, int age, string phNo, string town)
        {
            CustomerId = id;
            Name = name;
            Age = age;
            PhoneNo = phNo;
            City = town;
        }
        public void DisplayCustomer()
        {
            Console.WriteLine(" Customer Details are:");
            Console.WriteLine("Customewr Id :{0}\nName : {1}\nAge : {2}\nPhone No : {3}\nCity :{4}", CustomerId, Name, Age, PhoneNo, City);
        }
        static void Main(string[] args)
        {
            Customer obj1 = new Customer();         
            Customer obj2 = new Customer(100, "aaa", 22, "789000000", "Bangalore");
            obj2.DisplayCustomer();
            Console.ReadKey();
        }
    }
}
