//4.Create an Interface IStudent with int StudentId and string Name as Properties, void ShowDetails() as its method.
//   Create 2 classes Dayscholar and Resident that implements the interface Properties and Methods.ShowDetails() should show
//    DaysScholar details and Resident Details accordingly. 

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment05
{
    interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetatils();
    }

    public class DayScholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int _StudentId
        {
            set { StudentId = value; }
            get { return StudentId; }
        }

        public string _Name
        {
            set { Name = value; }
            get { return Name; }
        }

        public void GetDayScholar()
        {
            Console.Write("Enter DayScholar Student Id :");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter DayScholar Student Name : ");
            Name = Console.ReadLine();
        }
        public void ShowDetatils()
        {
            Console.WriteLine("  Day Scholar Student Details are: ");
            Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);
        }
    }

    public class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public int _StudentId
        {
            set { StudentId = value; }
            get { return StudentId; }
        }

        public string _Name
        {
            set { Name = value; }
            get { return Name; }
        }

        public void GetResident()
        {
            Console.Write("Enter Resident Student Id :");
            StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Resident Student Name : ");
            Name = Console.ReadLine();
        }

        public void ShowDetatils()
        {
            Console.WriteLine("  Resident Student Details are: ");
            Console.WriteLine("StudentId : {0}\nName : {1}", StudentId, Name);
        }
    }
    class Student_InterfaceEg
    {
        static void Main(string[] args)
        {
            Resident obj1 = new Resident();
            obj1.GetResident();
            obj1.ShowDetatils();
            DayScholar obj2 = new DayScholar();
            obj2.GetDayScholar();
            obj2.ShowDetatils();
            Console.Read();
        }
    }
}
