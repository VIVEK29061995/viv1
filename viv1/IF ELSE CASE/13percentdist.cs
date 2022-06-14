using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER PERCENT");
            int per = Convert.ToInt32(Console.ReadLine());

            if(per>=75)
                Console.WriteLine("DISTINCTION");
            else if (per>=60)
                Console.WriteLine("FIRST CLASS");
            else if (per >= 50)
                Console.WriteLine("SECOND CLASS");
            else if (per >= 40)
                Console.WriteLine("THIRD CLASS");
            else
                Console.WriteLine("FAIL");



        }
    }
}
