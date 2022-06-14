using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
     class ConstOverloading
     {
            int value1;
            int value2;

            ConstOverloading()
            {
                value1 = 10;
                value2 = 20;
                Console.WriteLine("Inside 1st Constructor");
            }

            ConstOverloading(int a)
            {
                value1 = a;
                Console.WriteLine("Inside 2nd Constructor");
            }

            ConstOverloading(int a, int b)
            {
                value1 = a;
                value2 = b;
                Console.WriteLine("Inside 3rd Constructor");
            }

            public void display()
            {
                Console.WriteLine("Value1 " + value1);
                Console.WriteLine("Value2 " + value2);
            }

            public static void Main(String[]args)
            {
                ConstOverloading d1 = new ConstOverloading();
                ConstOverloading d2 = new ConstOverloading(30);
                ConstOverloading d3 = new ConstOverloading(30, 40);
                d1.display();
                d2.display();
                d3.display();
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            }

        }  
}  

