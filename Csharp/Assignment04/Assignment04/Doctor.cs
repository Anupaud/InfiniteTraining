//6.Create a Class called Doctor with RegnNo, Name, Feescharged as Private members. 
//    Allow values to be set and also to display the same.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    class Doctor
    {
        int RegNo;
        string name;
        private int Feescharged;

        public int _RegNo

        {
            get { return RegNo; }
            set { RegNo = value; }
        }
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        public int _Feescharged
        {
            get { return Feescharged; }
            set { Feescharged = value; }
        }
        public void Display()
        {
            Console.WriteLine(" The Register number is " + RegNo);
            Console.WriteLine(" The Doctor Name is " + name);
            Console.WriteLine(" The  fees is " + Feescharged);
            Console.ReadLine();
        }
    }
    class MyClass
    {
        static void Main(string[] args)
        {
            Doctor obj = new Doctor();
            obj._RegNo = 101;
            obj._name = "aaa";
            obj._Feescharged = 4000;
            obj.Display();
            Console.Read();
        }
    }
}
