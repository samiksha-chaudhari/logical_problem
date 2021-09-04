using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int i = 1;
            int total = 0;

            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.Write("{0} is a perfect number", num);
            else
                Console.Write("{0} is not a perfect number", num);
            Console.ReadLine();
        }
    }
}
