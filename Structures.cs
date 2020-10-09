using System;

namespace StructuresDemo
{
  struct Book
  {
    public string title;
    public string author;
    public string subject;
    public string bookId;

    public void Display()
    {
      Console.WriteLine("{0}({1}) was written by {2} and deals with {3}", title, bookId , author, subject);
    }
  }

  class Structures
  {
    static void Main(string[] args)
    {
      Book warAndPeace;
      warAndPeace.title = "War and Peace";
      warAndPeace.author = "leo Tolstoy";
      warAndPeace.subject = "Drama";
      warAndPeace.bookId = "1";

      warAndPeace.Display();
    }
  }
}