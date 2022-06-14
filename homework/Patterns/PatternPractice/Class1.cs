using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Patterns.PatternPractice
{
    class STARRECTANGLE
    {
        static void Main(string[] args)
        {
            /*
              *****
              *****
              *****
              *****
              */
            int c = 4;//j
            int r = 5;//i
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
