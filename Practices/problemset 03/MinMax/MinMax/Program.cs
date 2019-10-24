using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] numList = new int[size];
            Console.WriteLine("Enter  {0}.", size +" integers.");
            for (int i = 0; i < size; i++)
            {
                numList[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maximumNumber = GetMaximum(numList);
            int minimumNumber = GetMinimum(numList);
            Console.WriteLine("Maximum number : " + maximumNumber);
            Console.WriteLine("Minimum number : " + minimumNumber);
            Console.ReadKey();
        }
        static int GetMaximum(int[] myNumberArray)
        {
            int max = myNumberArray[0];
            for (int i = 0; i < myNumberArray.Length; i++)
            {
                if (myNumberArray[i] > max)
                {
                    max = myNumberArray[i];
                }
            }
            return max;
        }
        static int GetMinimum(int[] myNumberArray)
        {
            int min = myNumberArray[0];
            for (int i = 0; i < myNumberArray.Length; i++)
            {
                if (myNumberArray[i] < min)
                {
                    min = myNumberArray[i];
                }
            }
            return min;
        }
    }
}
