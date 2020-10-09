using System;

namespace MatrixDemo
{
  class Matrix
  {
    static void Main(string[] args)
    {
      int[][] a = new int[2][];
      for (int i = 0; i < a.Length; i++) 
      {
        a[i] = new int[5];
        for (int j = 0; j < 5; j++)
        {
          a[i][j] = j * i + j;
        }
      }

      foreach (int[] r in a)
      {
        foreach (int e in r)
        {
          Console.Write("{0} ", e);
        }
        Console.WriteLine();
      }

      // uneven arrays - jagged arrays
      int[][] b = new int[][] {
        new int[] { 1 },
            new int[] { 2, 3, 4 },
            new int[] { 5, 6, 7, 8, 9, 10 }
      };

      foreach (int[] r in b)
      {
        foreach (int e in r)
        {
          Console.Write("{0} ", e);
        }
        Console.WriteLine();
      }
      Console.WriteLine();

      // multidimensional arrays
      int[,] c = new int[2, 3];
      for (int i = 0; i < 2; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          c[i, j] = j * i * 2 + 100;
        }
      }

      foreach (var r in c)
      {
        Console.Write("{0} ", r);
      }
      Console.WriteLine();
    }
  }
}