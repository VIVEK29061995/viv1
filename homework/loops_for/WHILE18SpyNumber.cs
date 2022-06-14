using System;
using System.Collections.Generic;
using System.Text;

namespace homework.loops_for
{
    class SpyNumber
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter Number");
			int input = Convert.ToInt32(Console.ReadLine());
			int digit, sum = 0, product = 1;

			while (input > 0)
			{
				digit = input % 10;

				// getting the sum
				// of digits
				    sum = sum + digit;
				product = product * digit;
				  input = input / 10;
			}

			// Comparing the sum
			// and product
			if (sum == product)
				Console.WriteLine("The number is " +
									"a Spy number");
			else
				Console.WriteLine("The number is " +
								"NOT a Spy number");
		}

		
		
	}
}
    

