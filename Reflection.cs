using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true
    )]
class DebugInfo: System.Attribute
{
  public DebugInfo() {}
  public DebugInfo(int _bugNo, string _developer, string _lastReview, string _message) {}

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

  public void Display()
  {
    Console.WriteLine("Bug no. {0}, assigned to {1} has its last review on {2} with message: {3}", 
        BugNo,
        Developer,
        LastReview,
        Message);
  }
}

[DebugInfo(BugNo = 1, Developer = "Rob H.", Message = "Don't do this")]  
class Rectangle
{
  public double Length { get; set; }
  public double Width { get; set; }

  public Rectangle(double _length, double _width)
  {
    Length = _length;
    Width = _width;
  }

  [DebugInfo(BugNo = 2, Developer = "Rob H.", Message = "Stop it!")]
  public double GetArea()
  {
    return Length * Width;
  }

  [DebugInfo(BugNo = 3, Developer = "Robert H.", Message = "Changing your name won't help!")]
  public void Display()
  {
    Console.WriteLine("Length = {0}, Width = {1}, Area = {2}", Length, Width, GetArea());
  }
}

namespace ReflectionDemo
{
  class Reflection
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle(10, 20);
      r.Display();

      Type type = typeof(Rectangle);

      // class attributes
      foreach (Object attributes in type.GetCustomAttributes(false))
      {
        DebugInfo dbg = (DebugInfo)attributes;
        if (dbg != null)
          dbg.Display();
      }

      // method attributes
      foreach (MethodInfo m in type.GetMethods())
      {
        foreach (Object attributes in m.GetCustomAttributes(true))
        {
          if (attributes is DebugInfo)
          {
            DebugInfo dbg = (DebugInfo)attributes;
            if (dbg != null)
              dbg.Display();
          }

        }
      }
    }
  }
}
