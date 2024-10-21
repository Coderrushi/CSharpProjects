using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static Polymorphism
            Console.WriteLine("Performing Static Polymorphism..");
            TestData data = new TestData();
            Console.WriteLine(data.Add(1, 2));
            Console.WriteLine(data.Add(3, 4, 5));

            //Dynamic Polymorphism
            Console.WriteLine("\nPerforming Dynamic Polymorphism..");
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
            Square square = new Square();
            Console.WriteLine("Area of Square: " + square.Area());
            Circle circle = new Circle();
            Console.WriteLine("Area of Circle: " + circle.Area());
        }
    }
}
