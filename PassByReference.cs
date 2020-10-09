using System;

// just like C++ references
namespace PassByReferenceDemo
{
  class NumberManipulator
  {
    public void Swap(ref int x, ref int y)
    {
      int t = x;
      x = y;
      y = t;
    }
  }

  class PassByReference
  {
    static void Main(string[] args)
    {
      int x = Convert.ToInt32(Console.ReadLine());
      int y = Convert.ToInt32(Console.ReadLine());
      
      NumberManipulator nm = new NumberManipulator();
      Console.WriteLine("Before swap, x = {0} and y = {1}", x, y);
      nm.Swap(ref x, ref y);
      Console.WriteLine("After swap, x = {0} and y = {1}", x, y);
    }
  }
}
