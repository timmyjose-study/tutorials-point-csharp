using System;
using R = System.Text.RegularExpressions;

namespace RegexDemo
{
  class Regex
  {
    static void Main(string[] args)
    {
      string str = "A Thousand Splendid soothing Suns";
      Console.WriteLine("Words that start wuth 'S' or 's'...");
      ShowMatches(str, @"\b[S|s]\S*");
      Console.WriteLine();

      str = "make maze and manage to measure it";
      Console.WriteLine("Words that start with 'm' and end is 'e'..");
      ShowMatches(str, @"\bm\S*e\b");
      Console.WriteLine();

      str = "hello      world nice     to   meet     you      again";
      string pattern = "\\s+";
      string replacement = " ";
      R.Regex regex = new R.Regex(pattern);
      string result = regex.Replace(str, replacement);
      Console.WriteLine("Replacing all extra whitespaces...");
      Console.WriteLine(result);
    }

    private static void ShowMatches(string text, string regex)
    {
      Console.WriteLine("regex = {0}", regex);
      
      R.MatchCollection mc = R.Regex.Matches(text, regex);

      foreach (R.Match m in mc)
      {
        Console.WriteLine(m);
      }
    }
  }
}
