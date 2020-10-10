using System;

namespace PropertiesDemo
{
  abstract class Person
  {
    public abstract string Name
    {
      get; set;
    }

    public abstract int Age
    {
      get; set;
    }
  }

  class Student: Person
  {
    private string _name;
    private string _id;

    public Student() {}

    public string Id
    {
      get
      {
        return _id;
      }

      set
      {
        _id = value;
      }
    }

    public override string Name
    {
      get
      {
        return _name;
      }

      set
      {
        _name = value;
      }
    }

    public override int Age
    {
      get; set;
    }

    public Student(string id, string name, int age)
    {
      Id = id;
      Name = name;
      Age = age;
    }

    public override string ToString()
    {
      return "Student { id = " + Id + ", name = " + Name + ", age = " + Age + " }";
    }
  }

  class Properties
  {
    static void Main(string[] args)
    {
      Student s = new Student();
      s.Id = "cs1";
      s.Name = "Rob P.";
      s.Age = 42;

      Console.WriteLine(s);
    }
  }
}
