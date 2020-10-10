using System;

namespace UnsafeDemo
{
  class Unsafe
  {
    static void Main(string[] args)
    {
      UnsafeMethodDemo();
      UnsafeBlockDemo();
    }

    static void UnsafeBlockDemo()
    {
      int x = 100;
      int y = 200;

      unsafe {
        int *px = &x;
        int *py = &y;
        int result = *px + *py;

        Console.WriteLine("result = {0}", result);
      };
    }

    static unsafe void UnsafeMethodDemo()
    {
      int x = 100;
      Console.WriteLine("x = {0}", x);

      int *p = &x;
      Console.WriteLine("p = 0x{0:X}", (int)p);
      *p += 100;

      Console.WriteLine("x = {0}", x);
    }
  }
}