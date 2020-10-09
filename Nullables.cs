using System;

namespace NullablesDemo
{
  class Nullables
  {
    static void Main(string[] args)
    {
      int? num1 = null;
      int? num2 = 42;

      double? d1 = new double?();
      double? d2 = 3.14159;

      Console.WriteLine("num1 = {0}, num2 = {1}, d1 = {2}, d2 = {3}", num1, num2, d1, d2);

      // the null coalescing operator 
      double d3;
      d3 = d1 ?? 1.0;
      Console.WriteLine("d3 = {0}", d3);

      d3 = d2 ?? 1.0;
      Console.WriteLine("d3 = {0}", d3);
    }
  }
}