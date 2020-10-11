using System;
using System.Collections;

namespace StackDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack st = new Stack();
      st.Push('o');
      st.Push('l');
      st.Push('l');
      st.Push('e');
      st.Push('H');

      foreach (char c in st)
      {
        Console.Write(c + " ");
      }
      Console.WriteLine();

      while (st.Count != 0)
      {
        Console.WriteLine(st.Pop());
      }
      Console.WriteLine();
    }
  }
}
