using System;

namespace AnonymousMethodsDemo
{
  delegate void NumberChanger(int n);

  class AnonymousMethods
  {
    static int num = 0;

    static void AddNum(int n)
    {
      num += n;
    }
    
    static void MultNum(int n)
    {
      num *= n;
    }

    public static int GetNum()
    {
      return num;
    }

    static void Main(string[] args)
    {

      NumberChanger nc = delegate(int x) {
        Console.WriteLine("You passed in {0}", x);
      };

      nc(10);

      nc = new NumberChanger(AddNum);
      nc(10); 
      Console.WriteLine(GetNum()); // 10

      nc = new NumberChanger(MultNum);
      nc(2);
      Console.WriteLine(GetNum()); // 20
    }
  }
}
