using System;
using System.Collections;

namespace QueueDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Queue q = new Queue();

      for (int i = 1; i < 10; i++)
        q.Enqueue(i);

      while (q.Count != 0)
      {
        Console.Write(q.Dequeue() + " ");
      }
      Console.WriteLine();
    }
  }
}
