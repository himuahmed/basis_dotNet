using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                if (i % 2 ==0)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }
    }
}
