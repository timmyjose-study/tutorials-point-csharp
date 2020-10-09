using System;

namespace PassByValueDemo 
{
  class NumberManipulator
  {
    // this does not work as expected, of course
    public void Swap(int x, int y)
    {
      int t = x;
      x = y;
      y = x;
    }
  }

  class PassByValue 
  {
    static void Main(string[] args)
    {
      int x = Convert.ToInt32(Console.ReadLine());
      int y = Convert.ToInt32(Console.ReadLine());

      NumberManipulator nm = new NumberManipulator();
      Console.WriteLine("Before swap, x = {0} and y = {1}", x, y);
      nm.Swap(x, y);
      Console.WriteLine("After swap, x = {0} and y = {1}", x, y);
    }
  }
}
