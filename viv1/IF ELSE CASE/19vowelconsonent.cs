using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class19
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter the alphabet");
            character = Char.Parse(Console.ReadLine());
            if ((character >= 'A' && character <= 'Z') || character >= 'a' && character <= 'z')
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' || character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')

                {
                    Console.WriteLine(character + " is vowel");
                }
                else
                {
                    Console.WriteLine(character + " is consonent");
                }
            }
            else
            {
                Console.WriteLine(character + " is not an alphabet");
            }
            
        }
    }
}
    

