using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MyPrintSequence
    {
        static void Main(string[] args)
        {
            int number;

           for (int i = 1; i <=10; i++)
           {
              if ( i % 2 == 0)
              {
                  number = i;
              }
              else
              {
                  number = i * (-1);
              }
              Console.WriteLine(number);
           }
        }
    }
}
