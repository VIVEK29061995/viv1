using System;
using System.Collections.Generic;
using System.Text;

namespace homework.Patterns.PatternPractice
{
    class HalfPyramid
    {
        static void Main(string[] args)
        {
            /*
             
              *
              **
              ***
              ****
              
              */
            Console.WriteLine("ENTER THE ROWS");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= r; i++)
            {
               
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}
