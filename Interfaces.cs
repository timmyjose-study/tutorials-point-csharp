using System;

namespace InterfacesDemo
{
  interface Shape
  {
    double GetArea();
  }

  class Circle : Shape
  {
    private double radius;

    public Circle(double _radius)
    {
      radius = _radius;
    }

    public double GetArea()
    {
      return Math.PI * radius * radius;
    }
  }

  class Rectangle : Shape
  {
    private double length;
    private double width;

    public Rectangle(double _length, double _width)
    {
      length = _length;
      width = _width;
    }

     public double GetArea()
    {
      return length * width;
    }
  }

  class Triangle: Shape
  {
    private double bottom;
    private double height;

    public Triangle(double _bottom, double _height)
    {
      bottom = _bottom;
      height = _height;
    }

     public double GetArea()
    {
      return 0.5 * bottom * height;
    }
  }

  class Inheritance
  {
    static void Main(string[] args)
    {
      Circle c = new Circle(10.0);
      Console.WriteLine(c.GetArea());

      Rectangle r = new Rectangle(10.0, 4.9);
      Console.WriteLine(r.GetArea());

      Triangle t = new Triangle(10.0, 4.0);
      Console.WriteLine(t.GetArea());

      // polymorphism
      Shape s = new Circle(20.0);
      Console.WriteLine(s.GetArea());

      s = new Rectangle(100.0, 50.0);
      Console.WriteLine(s.GetArea());

      s = new Triangle(12.3, 9.232);
      Console.WriteLine(s.GetArea());
    }
  }
}