using System;
using System.Collections;

namespace ArrayListDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList al = new ArrayList();
      for (int i = 0; i < 10; i++)
        al.Add(10 - i);

      Console.WriteLine("Count = {0}, Capacity = {1}", al.Count, al.Capacity);
      foreach (int e in al)
        Console.WriteLine(e + " ");
      Console.WriteLine();

      al.Sort();
      foreach (int e in al)
        Console.WriteLine(e +  " ");
      Console.WriteLine();
    }
  }
}