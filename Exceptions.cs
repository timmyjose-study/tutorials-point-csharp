using System;

// System.Exception <- System.ApplicationException <- Custom Exceptions
// System.Exception <- System.SystemException <- all system exceptions
namespace Exceptions
{
  class DivNumbers
  {
    private int n;
    private int d;

    public DivNumbers(int _n, int _d)
    {
      n = _n;
      d = _d;
    }

    public void Divide()
    {
      int result = 0;
      try 
      {
        result = n / d;

      } catch (DivideByZeroException e)
      {
        Console.WriteLine("Caught exception: {0}", e);
      } 
      finally
      {
        Console.WriteLine("Result of division = {0}", result);
      }
    }
  }

  class Exceptions
  {
    static void Main(string[] args)
    {
      DivNumbers d1 = new DivNumbers(10, 2);
      d1.Divide();

      DivNumbers d2 = new DivNumbers(10, 0);
      d2.Divide();
    }
  }
}
