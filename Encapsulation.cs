using System;

// default access specifier in C# is `private`
namespace EncapsulationDemo
{
  class Encapsulation
  {
    static void Main(string[] args)
    {
      Rectangle r = new Rectangle();
      r.length = 122.23;
      r.width = 92.01;
      r.Display();

      Circle c = new Circle();
      c.AcceptDetails();
      c.Display();

      Square s = new Square();
      s.side = 20.0;
      s.Display();
    }
  }

  class Rectangle
  {
    public double length;
    public double width;

    public double GetArea() 
    {
      return length * width;
    }

    public void Display() 
    {
      Console.WriteLine("Length = {0}, width = {1}, area = {2}", length, width, GetArea());
    }
  }

  class Circle 
  {
    private double radius;

    public double GetArea()
    {
      return Math.PI * radius * radius;
    }

    public void AcceptDetails()
    {
      Console.WriteLine("Enter the radius:");
      radius = Convert.ToDouble(Console.ReadLine());
    }

    public void Display() 
    {
      Console.WriteLine("Radius = {0}, area = {1}", radius, GetArea());
    }
  }

  // internal specifier is visible anywhere within the application
  class Square
  {
    internal double side;

    // private access by default
    double GetArea()
    {
      return side * side;
    }

    public void Display()
    {
      Console.WriteLine("Area of square of side {0} = {1}", side, GetArea());
    }
  }
}