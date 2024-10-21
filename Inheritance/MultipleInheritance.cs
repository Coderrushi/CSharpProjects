using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IShape
    {
        public double GetArea();
    }
    interface IColor
    {
        public string GetColor();
    }
    public class Rectangle : IShape, IColor
    {
        private double length;
        private double breadth;
        private string color;
        public Rectangle(double length, double breadth, string color)
        {
            this.length = length;
            this.breadth = breadth;
            this.color = color;
        }
        public double GetArea()
        {
            double result = length * breadth;
            return result;
        }
        public string GetColor()
        {
            return color;
        }
    }
}
