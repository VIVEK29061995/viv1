using System;
using System.Collections.Generic;
using System.Text;

namespace viv1
{
    class Class1
    {
        private static int area;

        static void Main(string[] args)
        {
                int square_of_side,perimeter;
            Console.WriteLine("enter side of square");
          square_of_side =  Convert.ToInt32(Console.ReadLine());
            area = square_of_side * square_of_side;
                perimeter = 4 * square_of_side;
            Console.WriteLine("Area of square is " + area);
            Console.WriteLine("perimeter of square is " + perimeter);

        }
    }
}
