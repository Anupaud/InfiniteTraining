//2.Create a class called student which has data members like rollno, name, class, Semester, branch, int[] marks = new int marks [5](marks of 5 subjects )

//-Pass the details of student like rollno, name, class, SEM, branch in constructor
//- For marks write a method called GetMarks() and give marks for all 5 subjects
//-Write a method called displayresult, which should calculate the average marks
//-If marks of any one subject is less than 35 print result as failed
//-If marks of all subject is >35 but average is < 50 then also print result as failed
//-If avg > 50 then print result as passed.
//-Write a DisplayData() method to display all values.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment03
{
    class Student
    {
          
			public int RollNo;
			public string Name;
			public int stuClass;
			public int Semester;
			public string branch;
			public int sum;
			int[] marks = new int[5];
			int avgMarks;
			int count = 0;
		

		public Student(int rolNo, string stName, int sClass, int sem, string branchName)
			{
				RollNo = rolNo;
				Name = stName;
				stuClass = sClass;
				Semester = sem;
				branch = branchName;

			}

			public void GetMarks()        
			{

				for (int i = 0; i < marks.Length; i++)
				{
					marks[i] = Convert.ToInt32(Console.ReadLine());
					if (marks[i] < 35)
					{
						count++;
					}
					sum += marks[i];

				}

			}

			public void DisplayResult()     
			{
				int len = marks.Length;
				int sum = 0;
				for (int i = 0; i < marks.Length; i++)
				{
					sum += marks[i];
				}

				avgMarks = sum / len;
			}

			public void DisplayData()
			{
				Console.WriteLine("Student Details And Results are:");
				Console.WriteLine("Student Name :{0}\nStudent Roll No :{1}\nStudent class :{2}\nsemester :{3}\nbranch is :{4}", Name, RollNo, stuClass, Semester, branch);
				Console.WriteLine("total marks :{0}\nAvg Marks : {1}:", sum, avgMarks);

				if (count > 0 && avgMarks < 50)
				{
					Console.WriteLine("Student {0} got failed ", Name);
				}
				else
				{
					Console.WriteLine("Student {0} got Passed ", Name);
				}
			}
		static void Main(string[] args)
		{
			Student obj = new Student(101, "sheshadri", 10, 6, "science");
			Console.WriteLine("Enter the marks of all five subjects of the student  :");
			obj.GetMarks();
			obj.DisplayResult();
			obj.DisplayData();

			Console.ReadKey();
		}


	}
}

