using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            while (true)
            {
                i++;
                if (i % 2 == 0 && i <100 )
                {
                    continue;
                }
               
                else if (i == 100)
                {
                    break;
                }
               Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
