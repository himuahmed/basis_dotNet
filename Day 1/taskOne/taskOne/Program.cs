using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //SecondMethod();
            Console.WriteLine("Main method");
            Program obj1 = new Program();
            obj1.SecondMethod();
            Console.ReadKey();
        }

        void SecondMethod()
        {
            //Console.WriteLine("Second method" );
            string name = Console.ReadLine();
            Console.WriteLine("Second method : "+ name);
            //Console.WriteLine(name);
            //Console.ReadKey();
        }
    }
 


}
