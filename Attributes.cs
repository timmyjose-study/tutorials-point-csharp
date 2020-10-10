#define DEBUG
using System;
using System.Diagnostics;

// Attributes are annotations in Java-speak
namespace AttributesDemo
{
  class Attributes
  {
    [Conditional("DEBUG")]
    static void Function1()
    {
      Console.WriteLine("In Function1");
      Function2();
    }

    static void Function2()
    {
      Console.WriteLine("In Function2");
    }

    [Obsolete("Deprecated - use NewMethod instead")]
    static void OldMethod()
    {
      Console.WriteLine("Inside OldMethod");
    }

    static void NewMethod()
    {
      Console.WriteLine("Inside NewMethod");
    }

    static void Main(string[] args)
    {
      Function1();
      OldMethod();
    }
  }
}