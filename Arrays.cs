using System;

namespace ArraysDemo
{
  class Arrays
  {
    static void Main(string[] args)
    {
      var n = Convert.ToInt32(Console.ReadLine());
      int[] a = new int[n];

      for (int i = 0; i < n; i++) 
      {
        Console.Write("Enter a number: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
      }

      DisplayArray(a);

      // the foreach statement
      foreach (int e in a)
      {
        Console.Write("{0} ", e);
      }
      Console.WriteLine();
      
      // passing arrays as function arguments
      Console.WriteLine(GetAverage(new int[]{11, 299, 153, 4, 15}));
    }

    static void DisplayArray(int[] a)
    {
      for (int i = 0; i < a.Length; i++) 
      {
        Console.Write("{0} ", a[i]);
      }
      Console.WriteLine();
    }

    static double GetAverage(int[] a)
    {
      int sum = 0;
      foreach (int e in a) 
      {
        sum += e;
      }
      return (double) sum / a.Length;
    }
  }
}
