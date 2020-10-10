using System;

// delegates are basically function pointers
namespace DelegatesDemo
{
  delegate void NumberChanger(int n);

  class Delegates
  {
    static int num = 10;
    
    static void AddNum(int p)
    {
      num += p;
    }

    static void MultNum(int p)
    {
      num *= p;
    }

    static int GetNum()
    {
      return num;
    }

    static void Main(string[] args)
    {
      NumberChanger nc1 = new NumberChanger(AddNum);
      NumberChanger nc2 = new NumberChanger(MultNum);

      nc1(25);
      Console.WriteLine(GetNum());
      nc2(10);
      Console.WriteLine(GetNum());
    }
  }
}