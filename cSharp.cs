using System;

namespace cSharp.cs
{
    class Program 
    {

        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());

            Rectangle rect2 = new Rectangle(100, 40);

            rect2 = rect1;
            rect1.length = 33;

            Console.WriteLine("rect2.length: {0}", rect2.length);

            Console.ReadLine();
        }

        struct Rectangle 
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, 
                double w = 1)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}