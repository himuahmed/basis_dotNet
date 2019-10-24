//Enter First Name : 
//		Saddam
//    Enter Last Name : 
//		Hosen
//    Enter Subject 	: 
//		Math
//    Enter Mark 	: 
//		80
//	Hello Saddam Hosen.Congratulation! Your have passed in Math
//   and your grade is "A+"
 	
//	Sorry! you have failed.Please try again!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name :");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter Subject :");
            string subject = Console.ReadLine();
            Console.WriteLine("Enter Mark :");
            double mark = double.Parse(Console.ReadLine());

            string fullName = getName(fName,lName);  
            string getResult = returnGrade(mark);
            int showResult = retrunResult(mark); 
            
            if(showResult == 1)
            {
                Console.WriteLine("Hello {0}.Congratulation! Your have passed in {1} and your grade is '{2}'.",fullName,subject,getResult);
            }
            else
            {
                Console.WriteLine("Sorry! you have failed.Please try again!");
            }

            Console.ReadKey();
        }

        static string getName(string firstName, string lastName)
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }


        static string returnGrade(double num)
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

        static int retrunResult(double num)
        {
            int result = 1;
            if(num < 40 )
            {
                result = 0;
            }
            else
            {
                result = 1;
            }

            return result;
        }
    }
}

