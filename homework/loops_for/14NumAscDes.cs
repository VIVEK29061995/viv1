using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class NumAscDes
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 200; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 200; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
