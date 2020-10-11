using System;
using System.Collections;

// SortedList is a data structure that can behave both as an array (if indexed by an index)
// as well as a Hashtable (if accessed by a key). The keys are also sorted by their natural
// sorting order.
namespace SortedListDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      SortedList sl = new SortedList();
      sl.Add("rob", 100);
      sl.Add("bob", 200);
      sl.Add("sob", 300);
      sl.Add("gob", 400);
      sl.Add("dob", 500);

      Display(ref sl);

      if (sl.ContainsKey("mob"))
      {
        Console.WriteLine("The sorted list already contains this key");
      }
      else
      {
        sl.Add("mob", 600);
      }

      Display(ref sl);
      for (int i = 0; i < sl.Count; i++)
      {
        Console.WriteLine("Element at index {0} is {1}", i, sl.GetByIndex(i));
      }
    }

    static void Display(ref SortedList sl)
    {
      foreach (string k in sl.Keys)
      {
        Console.WriteLine("{0} has the value {1}", k, sl[k]);
      }
      Console.WriteLine();
    }
  }
}
