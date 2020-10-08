using System;

namespace VariablesDemo
{
    class Variables
    {
        static void Main(string[] args)
        {
            short s = 100;
            int i = 200;
            double d = 13.113;
            bool b = false;

            Console.WriteLine("s = {0}, i = {1}, d = {2}, b = {3}", s, i, d, b);

            var x = Convert.ToInt32(Console.ReadLine());
            var y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}", x, y, Add(x, y));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}