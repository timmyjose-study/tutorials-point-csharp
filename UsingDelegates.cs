using System;
using System.IO;

namespace UsingDelegatesDemo
{
  class UsingDelegates
  {
    delegate void PrintString(string s);

    static void WriteToConsole(string s)
    {
      Console.WriteLine(s);
    }

    static void WriteToFile(string s)
    {
      try 
      {
        using (StreamWriter sw = new StreamWriter(new FileStream("out.txt", FileMode.Create)))
        {
          sw.WriteLine(s);
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("error while writing to file: {0}", e);
      }
    }

    static void SendString(PrintString ps, string message)
    {
      ps(message);
    }

    static void Main(string[] args)
    {
      PrintString console = new PrintString(WriteToConsole);
      PrintString file = new PrintString(WriteToFile);

      SendString(console, "Hello, delegates!");
      SendString(file, "Hello, delegates!");
    }
  }
}