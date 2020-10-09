using System;

namespace VarargsDemo
{
  class Varargs
  {
    static void Main(string[] args)
    {
      Console.WriteLine(SumArray(1, 2, 3, 4, 5));
      Console.WriteLine(SumArray(1, 2, 3));
      Console.WriteLine(SumArray()); // 0
    }

    // equivalent to Java's int...
    static int SumArray(params int[] arr)
    {
      int sum = 0;
      foreach (int e in arr)
      {
        sum += e;
      }

      return sum;
    }
  }
}