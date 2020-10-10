using System;
using System.IO;

namespace IODemo
{
  class IO
  {
    static void Main(string[] args)
    {
      FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

      for (int i = 0; i < 20; i++)
        f.WriteByte((byte)i);

      f.Position = 0;
      for (int i = 0; i < 20; i++)
        Console.Write(f.ReadByte() + " ");
      f.Close();

      ReadWriteTextDemo();
      ReadWriteBinaryDemo();
    }

    static void ReadWriteTextDemo()
    {
      string[] lines = {
        "Down the way where the nights are gay",
        "And the sun shines daily on the mountain top",
        "I took a trip on a sailing ship",
        "And when I reached Jamaica",
        "I made a stop"
      };

      using (StreamWriter sw = new StreamWriter("jamaica.txt"))
      {
        foreach (string s in lines)
        {
          sw.WriteLine(s);
        }
      }

      string line = "";
      using (StreamReader sr = new StreamReader("jamaica.txt"))
      {
        while ((line = sr.ReadLine()) != null)
        {
          Console.WriteLine(line);
        }
      }
    }

    static void ReadWriteBinaryDemo()
    {
      try 
      {
        using (BinaryWriter bw = new BinaryWriter(new FileStream("data.bin", FileMode.Create)))
        {
          bw.Write(1);
          bw.Write(false);
          bw.Write(2.78128);
          bw.Write("Hello, world");
        }
      }
      catch (IOException e)
      {
        Console.WriteLine("error while trying to create binary file: {0}", e);
      }

      try 
      {
        using (BinaryReader bw = new BinaryReader(new FileStream("data.bin", FileMode.Open)))
        {
          int i = bw.ReadInt32();
          bool b = bw.ReadBoolean();
          double d = bw.ReadDouble();
          string s = bw.ReadString();

          Console.WriteLine("{0}, {1}, {2}, {3}", i, b, d, s);
        }
      }
        catch (IOException e)
        {
          Console.WriteLine("error while reading binary file: {0}", e);
        }
      }
    }
  }
