using System;
using System.Collections.Generic;

delegate void NumberChanger<T>(T n);

namespace GenericsDemo
{
  class GenericArray<T>
  {
    private T[] array;

    public GenericArray(int size)
    {
      array = new T[size];
    }

    public T GetItem(int index)
    {
      return array[index];
    }

    public void SetItem(int index, T item)
    {
      array[index] = item;
    }
  }

  class Generics
  {
    static void Main(string[] args)
    {
      GenericArray<int> intArray = new GenericArray<int>(5); // no type inference here
      for (int i = 0; i < 5; i++)
        intArray.SetItem(i, i + 100);

      for (int i = 0; i < 5; i++)
        Console.Write(intArray.GetItem(i) + " ");
      Console.WriteLine();

      GenericArray<string> strArray = new GenericArray<string>(2); // no type inference here
      strArray.SetItem(0, "Hello");
      strArray.SetItem(1, "World");

      Console.Write(strArray.GetItem(0) + " ");
      Console.Write(strArray.GetItem(1) + " ");
      Console.WriteLine();

      GenericSwapDemo();
      GenericDelegatesDemo();
    }

    private static void Swap<T>(ref T lhs, ref T rhs)
    {
      T temp = lhs;
      lhs = rhs;
      rhs = temp;
    }


    static void GenericSwapDemo()
    {
      int x = 10;
      int y = 20;

      Console.WriteLine("Before swap, x = {0}, y = {1}", x, y);
      Swap<int>(ref x, ref y);
      Console.WriteLine("After swap, x = {0}, y = {1}", x, y);

      string s = "Hello";
      string t = "World";

      Console.WriteLine("Before swap, s = {0}, t = {1}", s, t);
      Swap<string>(ref s, ref t);
      Console.WriteLine("After swap, s = {0}, t = {1}", s, t);
    }

    static int num = 10;

    static void AddNum(int n)
    {
      num += n;
    }

    static int GetNum()
    {
      return num;
    }

    static void GenericDelegatesDemo()
    {

      NumberChanger<int> nc = new NumberChanger<int>(AddNum);
      nc(10);
      Console.WriteLine(GetNum());
    }
  }
}
