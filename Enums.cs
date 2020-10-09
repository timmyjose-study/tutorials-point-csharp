using System;

namespace EnumsDemo
{
  enum Weekday {
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
  }

  class Enums
  {
    static bool IsWeekDay(Weekday day)
    {
      switch (day)
      {
        case Weekday.Sunday:
        case Weekday.Saturday:
          return false;
        default: 
          return true;
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine(IsWeekDay(Weekday.Sunday));
      Console.WriteLine(IsWeekDay(Weekday.Monday));
      Console.WriteLine(IsWeekDay(Weekday.Friday));
      Console.WriteLine(IsWeekDay(Weekday.Tuesday));
      Console.WriteLine(IsWeekDay(Weekday.Saturday));
    }
  }
}