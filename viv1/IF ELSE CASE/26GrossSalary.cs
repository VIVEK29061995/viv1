using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class26
    {
        static void Main(string[] args)

        {
            double basic, hra, da, totalsalary1, totalsalary2, totalsalary3;
            Console.WriteLine("ENTER BASIC SALARY");
            basic = Convert.ToDouble(Console.ReadLine());

            if (basic <= 10000)
            {
                da = (basic * 80) / 100;
                hra = (basic * 20) / 100;
                totalsalary1 = basic + hra + da;
                Console.WriteLine("totalsalary" + totalsalary1);

            }
            else if (basic <= 20000)
            {
                hra = (basic * 25) / 100;
                da = (basic * 90) / 100;
                totalsalary2 = basic + hra + da;
                Console.WriteLine("totalsalary" + totalsalary2);

            }

            else if (basic > 20000)
            {
                hra = (basic * 30) / 100;
                da = (basic * 95) / 100;
                totalsalary3 = basic + hra + da;
                Console.WriteLine("totalsalary" + totalsalary3);

            }

        }

    }
}       
    

