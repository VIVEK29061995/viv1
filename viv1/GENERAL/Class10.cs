using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name");
            string? name = Console.ReadLine();
            Console.WriteLine("enter age");
            int age = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("gender");
            char gender = Convert.ToChar((Console.Read()));
            Console.WriteLine("height");
            float height = Convert.ToSingle((Console.Read()));

            Console.WriteLine("name" + name);
            Console.WriteLine("Age" + age);
            Console.WriteLine("geder" + gender);
            Console.WriteLine("height" + height);







            Console.Read();
        }
    }
}
