using System;

namespace SwapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before BadSwap, a = {0}, b = {1}", a, b);
            BadSwap(a, b);
            Console.WriteLine("After BadSwap, a = {0}, b = {1}", a, b);
            Console.WriteLine("Before GoodSwap, a = {0}, b = {1}", a, b);
            unsafe
            {
                GoodSwap(&a, &b);
            }
            Console.WriteLine("After GoodSwap, a = {0}, b = {1}", a, b);
        }

        static void BadSwap(int x, int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static unsafe void GoodSwap(int* px, int* py)
        {
            int t = *px;
            *px = *py;
            *py = t;
        }
    }
}