using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Recursion
    {
        static void greet1()
        {
            Console.WriteLine("good morning");
        }
        static void Main(string[] args)
        {
            Recursion.greet1();
        }
    }

    class factorial
    {
        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = Factorial(n - 1);
                return n * ans;
            }
        }

        static void Main(string[] args)
        {
            int r = Factorial(3);
        }
    }
}
