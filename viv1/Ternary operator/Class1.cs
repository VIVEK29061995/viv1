using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class27

    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER LETTER");
            char CH = Convert.ToChar(Console.ReadLine());
            if (CH >= 65 && CH <= 'Z')
            {
                CH = (char)(CH + 32);
            }

            else if (CH >= 'a' && CH <= 'z')
            {
                CH = (char)(CH - 32);
                Console.WriteLine(CH);
            }
            Console.WriteLine("Not an Alphabet");
        }
    }
}
