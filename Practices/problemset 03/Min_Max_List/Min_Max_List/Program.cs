using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            Console.WriteLine("Enter list size : ");
            int size = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} ", size +" items.");
            for (int i = 0; i < size; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                numberList.Add(number);
            }
            int maximumNumber = GetMaxNum(numberList);
            Console.WriteLine("Maximum number is: " + maximumNumber);
            int minimumNumber = GetMinNum(numberList);
            Console.WriteLine("Minimum number is: " + minimumNumber);
            Console.ReadKey();

        }
        static int GetMaxNum(List<int> numberArray)
        {
            int max = numberArray[0];
            foreach (int number in numberArray)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }
        static int GetMinNum(List<int> numberArray)
        {
            int min = numberArray[0];
            foreach (int number in numberArray)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }
    }

}

