using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace taskTwo 
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName;
            //string lastName;
            //string firstName= Console.ReadLine();
           // string lastName = Console.ReadLine();
           // Console.WriteLine("FirstName:" + firstName + " LastName:" + lastName);
            //int x = 10;
            //string y = "10";
            //int z =Int32.Parse(y);
            //Console.WriteLine(x+z);
            //Console.ReadKey();
            int i,max,min;
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            if (num2 > num1)
            {
                 max = num2;
                 min = num1;
            }
            else
            {
                 max = num1;
                 min = num2;
            }
                if (min % 2 == 1)
                {
                    for (i = min; i <= max; i++)
                    {
                        Console.WriteLine(i++);
                    }
                    Console.ReadKey();
                }
                else if (min % 2 == 0)
                {
                    min = min + 1;

                    for (i = min; i <= max; i++)
                    {
                        Console.WriteLine(i++);
                    }
                    Console.ReadKey();

            }

                

        }
    }
}
