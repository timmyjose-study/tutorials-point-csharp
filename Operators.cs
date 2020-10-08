using System;
using System.IO;

namespace OperatorsDemo
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of int is {0}", sizeof(int));
            Console.WriteLine("typeof Foo is {0}", typeof(Foo));
            Console.WriteLine("typeof Baz is {0}", typeof(Foo.Bar.Baz));
            Console.WriteLine("typeof FooBar is {0}", typeof(Enigma.FooBar));

            // as casts without raising an exception and simply 
            // returning null instead
            Object obj = new StringReader("");
            StringReader reader = obj as StringReader;

            // this should be null
            Foo foo = obj as Foo;
            Console.WriteLine("foo is null? {0}", foo == null);

            // ternary operator
            int x = 10, y = 20;
            int z = x < y ? x : y;
            Console.WriteLine("z = {0}", z);
        }
    }

    class Foo
    {
        public class Bar
        {
            public class Baz
            {
            }
        }
    }
}

namespace Enigma
{
    class FooBar
    {

    }
}