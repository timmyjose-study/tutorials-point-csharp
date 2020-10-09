using System;

namespace LoopdDemo 
{
  class Loops 
  {
    static void Main(string[] args) 
    {
      int a = 10;
      while (a > 0) 
      {
        Console.WriteLine("{0}", a);
        a--;
      }
      Console.WriteLine();

      for (int i = 0; i < 10; i++) 
      {
        Console.WriteLine("{0}", i);
      }
      Console.WriteLine();

      int b = 10;
      do 
      {
        Console.WriteLine("{0}", b);
        b--;
      } while (b > 0);

      // nested loops
      for (int i = 0; i < 5; i++) 
      {
        for (int j = 0; j < 5; j++) 
        {
          Console.WriteLine("{0}", i + j);
        }
      }

    }
  }
}