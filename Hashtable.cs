using System;
using System.Collections;

namespace HashtableDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Hashtable ht = new Hashtable();
      ht.Add(1, "Bob");
      ht.Add(2, "Rob");
      ht.Add(3, "Gob");
      ht.Add(4, "Sob");
      ht.Add(5, "Dob");

      Console.WriteLine(ht.Count);

      if (ht.ContainsKey(3))
      {
        Console.WriteLine("Key 3 has the value {0}", ht[3]);
      }

      ICollection keys = ht.Keys;
      foreach (int k in keys)
      {
        Console.WriteLine("{0} => {1}", k, ht[k]);
      }
      Console.WriteLine();

      ht.Remove(3);
      foreach (int k in ht.Keys)
      {
        Console.WriteLine("{0} => {1}", k, ht[k]);
      }
    }
  }
}
