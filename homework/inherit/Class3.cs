using System;
using System.Collections.Generic;
using System.Text;

namespace homework.inherit
{
    public class Car
    {
       public int cno;
        string name;
        void mileage()
        {
            Console.WriteLine("best car");
        }

    }

    class Owner1
    {
        string name;

        public Owner1()
        {
            Console.WriteLine("idk");
        }
    }
    class Driver
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.cno);
        }

    }
}
