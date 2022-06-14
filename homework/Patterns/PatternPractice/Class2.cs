using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Patterns.PatternPractice
{
    class HOLORECTANGLE
    {
        static void Main(string[] args)
        {
            /*
              *****
              *   *
              *   *
              *****
              */
            int c = 4;
            int r = 5;
            for (int i = 1; i <= c; i++)
            {
                for (int j = 1; j <= r; j++)
                {
                    if(i==1 ||j==1 || i==c || j==r)
                    Console.Write("*");
                
                else
                
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
