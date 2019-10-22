using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0, sqrSum = 0;
            for(i = 0; i<= 100; i++)
            {
                sum = sum+i;
                sqrSum = sqrSum + (i*i);
            }
            //Console.WriteLine(sum);
            Console.WriteLine((sum*sum)-sqrSum);
            Console.ReadKey();

        }
    }
}
