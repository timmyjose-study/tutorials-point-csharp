using System;

namespace ConstantsAndLiteralsDemo
{
    class ConstantsAndLiterals
    {
        static void Main(string[] args)
        {
            long a = 0xdeadbeef;
            double d = 2.23e-10;
            string s = @"Hello,  world"; // string literal
            Console.WriteLine("{0}\n\t{1}\n{2}", a, d, s);

            // constants
            const double pi = 3.14159;
            var radius = Convert.ToDouble(Console.ReadLine());
            var area = pi * radius * radius;
            Console.WriteLine("A circle of radius {0} has an area of {1}", radius, area);
        }
    }
}