using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter middle name : ");
            string middleName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lastName = Console.ReadLine();
            string showName = TakeName(firstName,middleName,lastName);
            Console.WriteLine("Your fullname is :{0} ", showName);
            Console.ReadKey();

        }

        static string TakeName(string firstName, string middleName, string lastName)
        {

            string fullname = firstName + " " + middleName + " " + lastName;
            return (fullname);
        }
    }
}
