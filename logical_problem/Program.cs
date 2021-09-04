using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number up to fibonacci series require:");
            int limit = Convert.ToInt32(Console.ReadLine());
           
            int a = 0;
            int b = 1;
            int c = a + b;

            Console.WriteLine("Fibonacci series upto {0}: ", limit);
            Console.Write("{0} {1} ", a, b);

            while (c <= limit)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}
