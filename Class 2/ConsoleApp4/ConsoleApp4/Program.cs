using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secoundtNumber = Convert.ToInt32(Console.ReadLine());
            int thirdNumber = Convert.ToInt32(Console.ReadLine());
            int forthNumber = Convert.ToInt32(Console.ReadLine());
            int fifthNumber = Convert.ToInt32(Console.ReadLine());

            int result = AverageNumber(firstNumber,secoundtNumber,thirdNumber,forthNumber,fifthNumber);
            Console.WriteLine(result);
        }

        static int AverageNumber(int firstNumber, int secoundNumber, int thirtNumber, int fourthNumber, int fifthNumber)
        {
            return (firstNumber + secoundNumber + thirtNumber + fourthNumber + fifthNumber);
        }
    }
}
