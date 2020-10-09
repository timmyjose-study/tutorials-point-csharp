using System;

namespace PolymorphismDemo
{
  // function overloading
  class PrintData
  {
   public void Print(int i)
   {
     Console.WriteLine("Printing an int: {0}", i);
   }

   public void Print(double d)
   {
     Console.WriteLine("Printing a double: {0}", d);
   }

   public void Print(bool b)
   {
     Console.WriteLine("Printing a bool: {0}", b);
   }

   public void Print(string s)
   {
     Console.WriteLine("Printing a string: {0}", s);
   }
  }

  class Polymorphism
  {
    static void Main(string[] args)
    {
      PrintData pd = new PrintData();
      pd.Print(100);
      pd.Print(false);
      pd.Print(2.71828);
      pd.Print("Privet!");
    }
  }
}