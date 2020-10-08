using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "hello";
            dynamic age = 42;
            object salary = 12345.0;
            Console.WriteLine("message = {0}, age = {1}, and salary = {2}", message, age, salary);

            unsafe
            {
                int x = 100;
                int* p = &x;
                Console.WriteLine("x has the value {0}", *p);
            }
        }
    }
}