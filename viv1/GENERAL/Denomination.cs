using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            //9888
            //2000,500,200,100,50,20,10,5,2,1
            //     2000*4=8000
            //1888=>500*3=1500
            //388=> 200*1=200
            //188=> 100*1=100
            //88=>    50*=50
            //38=>   20*1=20
            //18=>  10*1=10
            //8=>    5*1=5
            //3=>    2*1=2
            //1=>    1*1=1
            //n2000= 2000's no. of notes...
            int n2000 = amount / 2000;
            int x = amount % 2000;

            int n500 = x / 500;
            int y = x % 500;

            int n200 = y / 200;
            int z = y % 200;

            int n100 = z / 100;
            int a = z % 100;

            int n50 = a / 50;
            int b = a % 50;

            int n20 = b / 20;
            int c = b % 20;

            int n10 = c / 10;
            int d = c % 10;

            int n5 = d / 5;
            int e = d % 5;

            int n2 = e / 2;
            int f = e % 2;

            int n1 = f / 1;
            int g = f % 1;

            Console.WriteLine($"notes of 2000={n2000}");
            Console.WriteLine($"notes of 500={n500}");
            Console.WriteLine($"notes of 200={n200}");
            Console.WriteLine($"notes of 100={n100}");
            Console.WriteLine($"notes of 50={n50}");
            Console.WriteLine($"notes of 20={n20}");
            Console.WriteLine($"notes of 10={n10}");
            Console.WriteLine($"notes of 5={n5}");
            Console.WriteLine($"notes of 2={n2}");
            Console.WriteLine($"notes of 1={n1}");

        }
    }
}
