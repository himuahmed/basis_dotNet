using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter mark : ");
            double marks = Double.Parse(Console.ReadLine());
            string result = returnGrade(marks);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string returnGrade (double num)
        {
            string grade = "Pending";

            if (num < 40)
            {
                grade = "F";
            }
            else if (num >= 40 & num < 45)
            {
                grade = "D";
            }
            else if (num >= 45 & num < 50)
            {
                grade = "C";
            }
            else if (num >= 50 & num < 55)
            {
                grade = "C+";
            }
            else if (num >= 55 & num < 60)
            {
                grade = "B-";
            }
            else if (num >= 60 & num < 65)
            {
                grade = "B";
            }
            else if (num >= 65 & num < 70)
            {
                grade = "B+";
            }
            else if (num >= 70 & num < 75)
            {
                grade = "A-";

            }
            else if (num >= 75 & num < 80)
            {
                grade = "A";
            }
            else if (num >= 80 & num < 100)
            {
                grade = "A+";
            }


            return grade;
        }
    }
}
