  using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class2
    {
        static void Main(string[] args)
        {
            double total_marks = 500;

            Console.WriteLine("enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter marathi marks");
            double marathi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter hindi marks");
            double hindi = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter english marks");
            double english = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter maths marks");
            double maths = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter science marks");
            double science = Convert.ToDouble(Console.ReadLine());

           double obtained_marks = (marathi + hindi + english + maths + science);
            double average = (marathi + hindi + english + maths + science) / 5;
            Console.WriteLine(obtained_marks);
            Console.WriteLine(average);

            double percentage = obtained_marks / total_marks * 100;
            Console.WriteLine(percentage);
        }
    }
}
