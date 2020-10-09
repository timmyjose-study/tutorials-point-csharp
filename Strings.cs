using System;

namespace StringsDemo
{
  class String
  {
    static void Main(string[] args)
    {
      string firstName, lastName, fullName;
      firstName = "Robert";
      lastName = "McGregor";
      fullName = firstName + lastName;
      Console.WriteLine("fullName = {0}", fullName);

      string[] messages = {"hello", "world", "nice", "to", "meet", "you", "again"};
      Console.WriteLine(System.String.Join(" ", messages));

      string name = new string(new char[]{'A', 'b', 'e', 'l'});
      Console.WriteLine(name);
    }
  }
}