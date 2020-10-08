using System;

namespace SizeofDemo
{
    class Sizeof
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sizeof int = {0} bytes", sizeof(int));
            Console.WriteLine("sizeof char = {0} bytes", sizeof(char));
            Console.WriteLine("sizeof double = {0} bytes", sizeof(double));
        }
    }
}