using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize;
            Console.Write("Enter array size : ");
            //arraySize = Console.Read();
            arraySize = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" Give names ");

            string [] nameList = new string[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Enter Array Value (names) : ");
                string name = Console.ReadLine();
                nameList[i] = name;
            }

            foreach (string name in nameList)
            {
                Console.WriteLine("Names : {0}",name);     
            }
            Console.WriteLine(" ");
          Array.Reverse(nameList);
          Console.WriteLine("Reverse aray : ");
          foreach (string VARIABLE in nameList)
          {
              Console.Write(VARIABLE);
          }
            Console.ReadKey();





        }
    }
}
