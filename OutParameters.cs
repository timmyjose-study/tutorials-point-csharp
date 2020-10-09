using System;

// out parameters are similar to reference parameters except that they are meant for passing values
// out of a called function. This also enables "returning" multiple values from a function.
namespace OutParametersDemo
{
  class NumberManipulator
  {
    public void RandomNumber(out int x)
    {
      // this does not work since x is write-only
      //int t = x;
      //x = t * t;

      // this works since we're only writing to x
      x = 42;
    }

    public void ReadValues(out int x, out int y)
    {
      x = Convert.ToInt32(Console.ReadLine());
      y = Convert.ToInt32(Console.ReadLine());
    }
  }

  class OutParameters
  {
    static void Main(string[] args)
    {
      int a = 100;
      Console.WriteLine("Before call, a = {0}", a);
      NumberManipulator nm = new NumberManipulator();
      nm.RandomNumber(out a);
      Console.WriteLine("After call, a = {0}", a);

      int x, y;
      nm.ReadValues(out x, out y);
      Console.WriteLine("x = {0} and y = {1}", x, y);
    }
  }
}
