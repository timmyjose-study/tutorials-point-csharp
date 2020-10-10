using System;

// we can combine delegates with matching signatures using + and -
namespace MulticastDelegatesDemo
{
  delegate void Unary(int n);

  class MulticastDelegates
  {
    static int num = 0;

    static int GetNum()
    {
      return num;
    }

    static void Add(int n)
    {
      num += n;
    }

    static void Square(int n)
    {
      num *= n;
    }

    static void Main(string[] args)
    {
      Unary un1;
      Unary un2 = new Unary(Add);
      Unary un3 = new Unary(Square);
      un1 = un2;
      un1 += un3;
      un1(11);
      Console.WriteLine(GetNum()); // 121

      num = 1;

      un1 = un3;
      un1 += un2;
      un1(11);
      Console.WriteLine(GetNum()); // 22
    }
  }
}