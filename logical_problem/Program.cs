using System;
using System.Diagnostics; // to use Stopwatch feature
using System.Threading; // to perform multiple operations
class Demo_Stopwatch // Demo class for implementing the Stopwatch functionality
{
    static void Main()
    {
        Stopwatch stopw = new Stopwatch();
        stopw.Start();
        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(2);
        }
        stopw.Stop();
        Console.WriteLine(" Time elapsed: {0} ", stopw.Elapsed);
    }
}