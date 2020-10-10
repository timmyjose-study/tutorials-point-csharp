using System;

namespace IndexersDemo
{
  class IndexedNames
  {
    private static int size = 10;
    private string[] names = new string[size];

    public IndexedNames()
    {
      for (int i = 0; i < size; i++)
        names[i] = "N.A";
    }

    public void Display()
    {
      for (int i = 0; i < size; i++)
        Console.WriteLine(names[i]);
    }

    // this makes the class an indexer type - 
    // basically a class whose values can be indexed over,
    // pretty much like an Iterable in Java.
    public string this[int index]
    {
      get
      {
        if (index < 0 || index >= size)
          return "";

        return names[index];
      }

      set
      {
        if (index < 0 || index >= size)
          return;

        names[index] = value;
      }
    }
  }

  class Indexers
  {
    static void Main(string[] args)
    {
      IndexedNames names = new IndexedNames();
      names[0] = "Rob";
      names[1] = "Andrew";
      names[2] = "Slava";
      names[3] = "Larry";
      names[4] = "John";

      names.Display();
    }
  }
}
