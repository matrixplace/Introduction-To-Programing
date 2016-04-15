using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class ForLoop
    {
        static void Main(string[] args)
        {
            int numbers;
            
            for (int i = 2; i <= 11; i++)
            {
                if ( i % 2 == 0)
                {
                    numbers = i;
                }
                else
                {
                    numbers = i * (-1);
                }
                Console.WriteLine(numbers);
            }
        }
    }
}
