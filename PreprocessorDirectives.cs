#define DEBUG
#define VC_V10
#define FOO

using System;

namespace PreprocessorDirectivesDemo
{
  class PreprocessorDirectives
  {
    static void Main(string[] args)
    {
#if (FOO)
      Console.WriteLine("FOO is defined");
#else
      Consolw.WriteLine("FOO is not defined");
#endif
#if (BAR)
      Console.WriteLine("BAR is defined");
#else
      Console.WriteLine("BAR is not defined");
#endif
#if (DEBUG && !VC_V10)
      Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && VC_V10)
      Console.WriteLine("VC_V10 is defined");
#elif (DEBUG && VC_V10)
      Console.WriteLine("DEBUG && VC_V10 are both defined");
#endif
    }
  }
}
