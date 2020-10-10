using System;
using NamespaceOne;
using NamespaceTwo;

namespace NamespaceOne
{
  class Clazz1
  {
    public void Func()
    {
      Console.WriteLine("Inside NamepaceOne");
    }
  }
}

namespace NamespaceTwo
{
  class Clazz2
  {
    public void Func()
    {
      Console.WriteLine("Inside NamespaceTwo");
    }
  }
}

namespace UsingDemo
{
  class Using
  {
    static void Main(string[] args)
    {
      Clazz1 c1 = new Clazz1();
      c1.Func();

      Clazz2 c2 = new Clazz2();
      c2.Func();
    }
  }
}
