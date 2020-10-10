using System;

[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true
    )]
class DebugInfo : System.Attribute
{
  public DebugInfo(int _bugNo, string _developer, string _lastReview, string _message)
  {
    
  }
  public int BugNo
  {
    get; set;
  }

  public string Developer
  {
    get; set;
  }

  public string LastReview
  {
    get; set;
  }

  public string Message
  {
    get; set;
  }
}

[DebugInfo(1, "Rob H.", "22/01/2020", "Fix this asap")]
class Rectangle
{
  private double length;
  private double width;

  public Rectangle(double _length, double _width)
  {
    length = _length;
    width = _width;
  }

  public double GetArea()
  {
    return length * width;
  }

  public void Display()
  {
    Console.WriteLine("Length = {0}, Width = {1}, Area = {2}", length, width, GetArea());
  }
}

namespace CustomAttributesDemo
{
  class CustomAttributes
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle(10, 20);
      r.Display();
    }
  }
}
