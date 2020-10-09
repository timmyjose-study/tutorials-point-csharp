using System;

namespace OperatorOverloadingDemo
{
  class Box
  {
    private double length;
    private double width;
    private double height;

    public Box() {}

    public Box(double _length, double _width, double _height)
    {
      length = _length;
      width = _width;
      height = _height;
    }

    ~Box() {}

    public double GetVolume()
    {
      return length * width * height;
    }

    // C# supports operator overloading - must be static
    // and public
    public static Box operator+(Box b1, Box b2)
    {
      Box b3 = new Box();
      b3.length = b1.length + b2.length;
      b3.width = b1.width + b2.width;
      b3.height = b1.height + b2.height;

      return b3;
    }

    public static bool operator==(Box b1, Box b2)
    {
      return b1.length == b2.length && b1.width == b2.width && b1.height == b2.height;
    }

    public static bool operator!=(Box b1, Box b2)
    {
      return b1 != b2;
    }
  }

  class OperatorOverloading
  {
    static void Main(string[] args)
    {
      Box b1 = new Box(10.0, 20.0, 30.0);
      Console.WriteLine(b1.GetVolume());

      Box b11 = b1;

      Box b2 = new Box(20.0, 30.0, 40.0);
      Console.WriteLine(b2.GetVolume());

      Box b3 = b1 + b2;
      Console.WriteLine(b3.GetVolume());

      Console.WriteLine("b1 == b1? {0}", b1 == b1);
      Console.WriteLine("b11 == b1? {0}", b11 == b1);
      Console.WriteLine("b1 == b2? {0}", b1 == b2);
      Console.WriteLine("b1 == b3? {0}", b1 == b3);
      Console.WriteLine("b3 == b3? {0}", b3 == b3);
    }
  }
}