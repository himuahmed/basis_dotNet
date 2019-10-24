using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int size = Int32.Parse(Console.ReadLine());
            int[] numberList = new int[size];
            Console.WriteLine("Enter {0}", size +" integers.");
            for (int i = 0; i < size; i++)
            {
                numberList[i] = Int32.Parse(Console.ReadLine());
            }
            int myAverageNumber = GetAverage(numberList);
            Console.WriteLine("Average :" + myAverageNumber);
            Console.ReadKey();
        }
        static int GetAverage(int[] numberArray)
        {
            int sum = 0;
            int average;
            for (int i = 0; i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }
            average = sum / numberArray.Length;
            return average;
        }
    }
}
