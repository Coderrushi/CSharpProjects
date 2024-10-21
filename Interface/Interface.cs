namespace Interface
{
    interface IArea
    {
        double GetArea();
    }
    public class Circle : IArea
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea ()
        {
            double area = 3.14*radius*radius;
            return area;
        }
    }
    internal class Interface
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10.2);
            Console.WriteLine("Area of circle is " + circle.GetArea());
        }
    }
}
