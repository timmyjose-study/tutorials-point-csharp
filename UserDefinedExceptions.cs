using System;

namespace UserDefinedExceptions
{
  class ZeroTemperatureException: Exception
  {
    private string _message;

    private string Mesage
    {
      get
      {
        return _message;
      }

      set
      {
        _message = value; // value is magic
      }
    }

    public ZeroTemperatureException(string _message) : base(_message) {}
  }

  class UserDefinedExceptions 
  {
    static void Main(string[] args)
    {
      TemperatureCheck checker = new TemperatureCheck();
      checker.CheckTemperature(100);
      // so C# only has unchecked exceptions
      try 
      {
        checker.CheckTemperature(0);
      }
      catch (ZeroTemperatureException e)
      {
        Console.WriteLine("error: {0}", e.Message);
      }
    }
  }

  class TemperatureCheck
  {
    public void CheckTemperature(int temp)
    {
      if (temp == 0)
      {
        throw new ZeroTemperatureException("temperature is zero!");
      }
      Console.WriteLine("The temperature is " + temp);
    }
  }
}
