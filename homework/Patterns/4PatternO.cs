using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Patterns
{
    class PatternO
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || c == 5 || r == 1 || r==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
