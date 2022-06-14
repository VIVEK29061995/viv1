using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class Trimorphic
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Number");
            int n = Convert.ToInt32(Console.ReadLine());
            int cube = n * n * n;
            int a =n;
            bool istrimorphic = true;
            while(n>0)
            {
                int r1 = n % 10;
                n = n / 10;
                int r2 = cube % 10;
                cube = cube / 10;
                if(r1!=r2)
                {
                    istrimorphic = false;
                    break;
                }

            }
            if(istrimorphic==true)
                Console.WriteLine("trimorphic");
            else
                Console.WriteLine("not");
        }
    }
}
