using System;

namespace RectangleApp
{
    class Rectangle
    {
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("width: {0}", width);
            Console.WriteLine("area: {0}", GetArea());
        }
    }

    class RectangleClient
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.AcceptDetails();
            r.Display();
        }
    }
}