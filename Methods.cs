using System;

namespace MethodsDemo
{
  class Methods
  {
    static void Main(string[] args)
    {
      NumberManipulator nm = new NumberManipulator();
      Console.WriteLine(nm.FindMax(10, 20));

      var n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The factorial of {0} is {1}", n, nm.Factorial(n));
    }
  }

  class NumberManipulator
  {
    public int FindMax(int x, int y)
    {
      return x > y ? x : y;
    }

    public int Factorial(int n)
    {
      if (n <= 0)
      {
        return 1;
      }
      else
      {
        return n * Factorial(n - 1);
      }
    }
  }
}