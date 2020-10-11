using System;


namespace RandomNumbersDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      Random r = new Random();
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(r.Next(1, 100));
      }
    }
  }
}