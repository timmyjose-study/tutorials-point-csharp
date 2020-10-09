using System;

namespace ClassesDemo
{
  class Box
  {
    private int length;
    private int width;
    private int height;
    private static int createCount = 0;

    public Box()
    {
      createCount++;
    }

    public Box(int _length, int _width, int _height)
    {
      length = _length;
      width = _width;
      height= _height;
      createCount++;
    }

    // C# has destructors!
    ~Box()
    {
      Console.WriteLine("Adios!");
    }

    public static int GetCreateCount()
    {
      return createCount;
    }

    public void SetLength(int _length)
    {
      length = _length;
    }

    public void SetWidth(int _width)
    {
      width = _width;
    }

    public void SetHeight(int _height)
    {
      height = _height;
    }

    public int GetVolume()
    {
      return length * width * height;
    }
  }

  class Classes
  {
    static void Main(string[] args)
    {
      Box box1 = new Box(1, 2, 3);
      Console.WriteLine(Box.GetCreateCount());
      Console.WriteLine(box1.GetVolume());

      Box box2 = new Box();
      box2.SetLength(2);
      box2.SetWidth(3);
      box2.SetHeight(4);
      Console.WriteLine(Box.GetCreateCount());
      Console.WriteLine(box2.GetVolume());
    }
  }

}