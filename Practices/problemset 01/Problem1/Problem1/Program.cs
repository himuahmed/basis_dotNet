using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,num1, num2;
            int min=0, max=0;
            Console.Write("Enter first integer: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            num2 = Int32.Parse(Console.ReadLine());
            
            if (num1 > num2)
            {
                max = num1;
                min = num2;
            }
            else if(num1 < num2)
            {
                max = num2;
                min = num1;
            }
            else
            {
                Console.WriteLine("Numbers are equal");
                Console.ReadKey();
            }

            for (i = min-1; i < max; i++)
            {
                Console.WriteLine(min);
                min = min + 1;
            
            }
            Console.ReadKey();

        }
    }
}
