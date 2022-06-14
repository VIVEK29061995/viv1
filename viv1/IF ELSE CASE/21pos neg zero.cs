using System;
using System.Collections.Generic;
using System.Text;

namespace vivG
{
    class Class21
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());

                 if (num == 0)
                    Console.WriteLine("entered number zero");
                
                else if (num>0)
                    Console.WriteLine(num + " is a positive number ");
                
                else if (num<0)
                Console.WriteLine(num +" is a negative number ");
            
            
            }
        }
    }

