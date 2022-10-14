
//5.Create a class called Scholarship which has int Totalmarks and float fees as fields and a function
//Public float Merit(int m, float f) that takes Totalmarks and fees as an input.
 
//If the given marks is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
//If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
//If the given mark is >90, then calculate scholarship amount as 50% of the fees.
//In all the cases return the Scholarship amount

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment04
{
    class Scholarship
    {
        int Totalmarks;
        float fees;
        float ScholshipAmount;

        public float merit(int m, float f)
        {
            Totalmarks = m;
            fees = f;

            if (Totalmarks >= 70 && Totalmarks <= 80)
            {
                ScholshipAmount = Convert.ToSingle((fees * 0.2f));
                return ScholshipAmount;
            }

            else if (Totalmarks > 80 && Totalmarks <= 90)
            {
                ScholshipAmount = Convert.ToSingle((fees * 0.3f));
                return ScholshipAmount;
            }

            else if (Totalmarks > 90)
            {
                ScholshipAmount = Convert.ToSingle((fees * 0.5f));
                return ScholshipAmount;
            }

            else
            {
                Console.WriteLine("Not Eligable for Scholorship");
                return 0;
            }

        }
        static void Main(string[] args)
        {
            Scholarship obj = new Scholarship();
            Console.Write("Enter Total Marks :");
            obj.Totalmarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Fees Amount : ");
            obj.fees = Convert.ToSingle(Console.ReadLine());
            obj.ScholshipAmount = obj.merit(obj.Totalmarks, obj.fees);
            Console.WriteLine("The Scholorship amount is :{0}", obj.ScholshipAmount);
            Console.ReadKey();

        }
    }
}
