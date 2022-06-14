using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog:Animal
    {
        public static void Main(string[] args)
        {
            Dog tommy = new Dog();
            tommy.Eat();
            Console.ReadLine();

        }
    }
}
