using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = AddTowName("jahid", "hasan");
            Console.WriteLine(result);
            Console.ReadLine();

        }

        static string AddTowName(string firstName, string secoundName)
        {
            return (firstName + secoundName);
        }
            }
}
