﻿using System;


namespace ConsoleApplication2
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int numberToPrint;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    numberToPrint = i;
                }
                else
                {
                    numberToPrint = i * (-1);
                }
                Console.WriteLine(numberToPrint);
            }
        }
    }
}
