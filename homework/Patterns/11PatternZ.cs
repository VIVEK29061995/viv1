﻿using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Patterns
{
    class PatternZ
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if ((r == 1 || r == 5) || c ==1 && c==5 || r+c==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
