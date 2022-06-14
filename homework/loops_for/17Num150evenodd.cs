using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Num150EVODD
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {

                if (i % 2 == 0)
                    Console.WriteLine(i);
                else
                    Console.WriteLine(i * i);
            }
        }
                  
    }
}
