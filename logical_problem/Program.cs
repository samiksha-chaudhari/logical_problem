using System;

namespace COUPON
{
    class Program
    {
        static void Coupon(int n)
        {
            int[] rand = new int[n];
            int[] distict = new int[n];
            for (int i = 1; i < n; i++)
            {
                Random random = new Random();
                int num = random.Next(1, 100);
                rand[i] = num;
            }
            Console.WriteLine("distinct coupon numbers are :");
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                int count = 1;
                for (int j = 0; j < i; j++)
                {
                    if (rand[i] == rand[j])
                    {
                        count++;
                    }

                }
                distict[a] = count;
                a++;
            }
            for (int i = 0; i < n; i++)
            {
              Console.WriteLine(rand[i]);
            }
        }
        static void Main(string[] args)
        {
            
            int n;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Coupon(n);
        }
    }
}