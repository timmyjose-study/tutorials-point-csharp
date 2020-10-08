using System;

namespace TypeConversionDemo
{
    class TypeConversions
    {
        static void Main(string[] args)
        {
            // explicit conversion
            double d = 1.2345;
            int i = (int)d;
            Console.WriteLine("d = {0}, i = {1}", d, i);

            // using the helper class Convert
            int i1 = Convert.ToInt32(d);
            Console.WriteLine("d = {0}, i = {1}", d, i);

            // implicit conversion
            double dd = i;
            Console.WriteLine("i = {0}, dd = {1}", i, dd);

            // ToString for a generic string conversion mechanism
            bool b = true;
            float f = -1.233f;

            Console.WriteLine("{0}, {1}, {2}, {3}", d.ToString(), i.ToString(), b.ToString(), f.ToString());
        }
    }
}