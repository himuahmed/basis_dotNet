using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sum = 0;
            for(i=1;i<1000;i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000 is  {0}. ",sum);
            Console.ReadKey();

        }
    }
}
