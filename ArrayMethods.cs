using System;

namespace ArrayMethodsDemo
{
  class ArrayMethods
  {
    static void DisplayArray(string name, int[] a)
    {
      Console.WriteLine("The contents of array {0} are...", name);
      foreach (var e in a)
      {
        Console.Write("{0} ", e);
      }
      Console.WriteLine();
    }

    static void Main(string[] args)
    {
      int[] a = { 1, 2, 3, 4, 5 };
      DisplayArray("a", a);

      int[] c = a;
      DisplayArray("c", c);

      Array.Reverse(a);
      DisplayArray("a", a);

      Array.Sort(a);
      DisplayArray("a", a);
    }
  }
}