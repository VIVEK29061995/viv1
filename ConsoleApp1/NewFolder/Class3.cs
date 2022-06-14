using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.NewFolder
{
    class subarray
    {
        static void Main(string[] args)
        {
            //Accept Size
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            //Accept data
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones;

            //Find Largest subarray length have equal zero and one 

            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }



    // C# program to check if two
    // numbers are co-prime or not


    class GFG
    {

        // Recursive function to
        // return gcd of a and b
        static int __gcd(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        // function to check and print if
        // two numbers are co-prime or not
        static void coprime(int a, int b)
        {

            if (__gcd(a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }

        // Driver code
        public static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //check
            coprime(a, b);
        }
    }
    class DemoLL
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddLast(400);
            ll.AddFirst(1000);

            LinkedListNode<int> nodeafter = ll.Find(300);
            ll.AddAfter(nodeafter, 9000);
            foreach (int data in ll)
                Console.WriteLine(data);

        }
    }
    //Delegates
    class c
    {
        public delegate void mydelegate3(int a);
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)

                fact = fact * i;
            Console.WriteLine("Factorial:" + fact);

        }



    }

    class d
    {
        static void Main(string[] args)
        {
            c.mydelegate3 f3 = c.factorial;
            f3(4);
        }

    }



    public delegate void MyDelegate(string msg);

    public class Program
    {
        public static void Main()
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            //del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            //del("Hello World");

        }
    }

    public class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    public class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }

    public delegate void mydel(int a, int b);
    class a11
    {
        public void add(int a, int b)
        {
            Console.WriteLine("sum:" + (a + b));

        }
        //public void substract(int a, int b)
        //{
        //    Console.WriteLine("sub:" + (a * b));
        //}
        public void product(int a, int b)
        {
            Console.WriteLine("product:" + (a * b));
        }
        public static void Main(string[] args)
        {
            //mydel d1 = add;
            //d1 = d1 + product;
            //d1(2, 4);

        }
    }
    class arrayprimesum
    {
        public static void Main(string[] args)
        {
            int i, j, p;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("All Prime List:");

            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    Console.Write(arr[i] + " ");
                    //int sum = 0;
                    //sum += arr[i];
                    //Console.WriteLine(sum);
                }

            }
        }
    }
    class DuplicateWord
    {
        public static void Main()
        {
            Console.WriteLine();
           string S = Convert.ToString(Console.ReadLine());
            int count;

            //Converts the string into lowercase  
           // string1 = string1.ToLower();

            //Split the string into words using built-in function  
            String[] words = S.Split(' ');

            //Console.WriteLine("Duplicate words in a given string : ");
            for (int i = 0; i < words.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].Equals(words[j]))
                    {
                        count++;
                        //Set words[j] to 0 to avoid printing visited word  
                        words[j] = "0";
                    }
                }

                //Displays the duplicate word if count is greater than 1  
                if (count > 1 && words[i] != "0")
                    Console.WriteLine(words[i]);
            }
        }

    }
    class user
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[0]<arr[i+1])
                arr[0] = arr[i+1];
            }
            Console.WriteLine(arr[0]);
        }
    }
    class Program300
    {
        public static void Main(string[] args)
        {
            int i, j, p, s = 0;
            int[] arr = new int[5];

            Console.WriteLine("Enter array elements:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    s = s + arr[i];
                }
            }
            Console.Write("Sum of prime numbers:" + s);
        }
    }
}

