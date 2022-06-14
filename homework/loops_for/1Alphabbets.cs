using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops
{
    class alphabets
    {
        static void Main(string[] args)
        {
            int num = 26;
            char Alphabet = 'A';
            for(int i=1;i<=num;i++)
            {
                Console.Write(Alphabet + " ");
                Alphabet++;
            }
            

        }
    }
}
