using System;
using System.Threading;

namespace MultithreadingDemo
{
  class Program
  {
    static void SayHello()
    {
      Thread.Sleep(500);
      Console.WriteLine("Hello from thread!");
    }

    static void Main(string[] args)
    {
      Thread th = Thread.CurrentThread;
      th.Name = "Ma Man thread";
      Console.WriteLine("This is {0}", th.Name);

      ThreadStart helloRef = new ThreadStart(SayHello);
      Thread childThread = new Thread(helloRef);
      childThread.Start();
      childThread.Join();

      ThreadAbortDemo();
    }

    private static void CountTo100()
    {
      for (int i = 0; i < 100; i++)
      {
        Thread.Sleep(new Random().Next(1, 11));
        Console.WriteLine(i);
      }
    }

    static void ThreadAbortDemo()
    {
      ThreadStart counterRef = new ThreadStart(CountTo100);
      Thread childThread = new Thread(counterRef);
      childThread.Start();
      Thread.Sleep(new Random().Next(1, 101));
      childThread.Abort();
    }
  }
}
