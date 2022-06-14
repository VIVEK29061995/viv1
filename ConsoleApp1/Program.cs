using System;

namespace ConsoleApp1
{
    class Sum
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element  {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}", sum);
        }
    }





    class Sumavg
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;
            int average = 0;
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write(n);
            for (i = 0; i < n; i++)
            {
                Console.Write(" element  {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }

            average = sum / n;

            Console.WriteLine("Sum of all elements stored in the array is : {0}", sum);
            Console.WriteLine("Average Of Array is : " + average);
        }
    }

    class indexx
    {
        static void Main(string[] args)
        {
            int indx = 0;

            int[] a = { 1, 2, 3, 4, 5 };

            for (int i = 1; i <= a.Length; i++)
                Console.WriteLine(i);

            for (int i = 1; i <= a.Length; i++)
            {

            }
            Console.WriteLine(indx);
        }

    }
    class Max
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 56, 78, -3, 90, 876, 76, 23 };
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("max" + max);
        }
    }
    class insertarray
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[20];
            Console.WriteLine("how many elements you want insert initially");
            int size = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("enter the position of index where you want to insert");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("insert the data you want to insert");


            int data = Convert.ToInt32(Console.ReadLine());
            if (pos == size)
            {
                arr[size] = data;
                size++;
            }
            else if (pos >= 0 && pos < size)
            {
                for (int k = size - 1; k >= pos; k--)
                {
                    arr[k + 1] = arr[k];
                }
                arr[pos] = data;
            }
            else
                Console.WriteLine("index out of range");
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    } 
        
}

