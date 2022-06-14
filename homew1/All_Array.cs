using System;
using System.Collections.Generic;
using System.Text;

namespace homew1
{
    
    

    class Merge2
    {
        static void Main(string[] args)
        {
            int[] d = { 1, 2, 3, 4};
            int[] e = { 5, 6, 7, 8, 9, 10 };
            int[] f = new int[d.Length + e.Length];
            int k = 0;
            for (int i = 0; i < f.Length; i++)
            {
                if (k < d.Length && k < e.Length)//same
                {
                    f[i] = d[k];
                    i++;
                    f[i] = e[k];
                    i++;
                }
                else if (k < d.Length)
                {
                    f[i] = d[k];
                    i++;
                }
                else
                {
                    f[i] = e[k];
                    i++;
                }
                k++;


            }
        }
    }

    class Alternate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size first array");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter size second array");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size1];
            int[] b = new int[size2];

            Console.WriteLine($"enter{a.Length} element of first array");
            for( int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"enter{b.Length} element in second array");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] c = new int[b.Length + b.Length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }
            for (int i = 0; i < c.Length; i++)
                Console.WriteLine(c[i]+" ");




        }


       
    }
}

