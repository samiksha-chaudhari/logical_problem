using System;

namespace PRIME
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }

            if (count == 2)
                Console.Write("{0} is a prime number", num);
            else
                Console.Write("{0} is not a prime number", num);
            Console.ReadLine();
        }
    }
}
