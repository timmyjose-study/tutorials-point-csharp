using System;

namespace NamespaceOne
{
  class Clazz 
  {
    public void Func()
    {
      Console.WriteLine("Insdide NamespaceOne");
    }
  }
}

namespace NamespaceTwo 
{
  class Clazz
  {
    public void Func()
    {
      Console.WriteLine("Inside NamespaceTwo");
    }
  }
}

namespace NamespacesDemo
{

  class Namesapces
  {
    static void Main(string[] args)
    {
      NamespaceOne.Clazz c1 = new NamespaceOne.Clazz();
      c1.Func();

      NamespaceTwo.Clazz c2 = new NamespaceTwo.Clazz();
      c2.Func();
    }
  }
}
