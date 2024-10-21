namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            // Console.WriteLine("Performing Single Inheritance..");
            //DerivedClass derivedClass = new DerivedClass();
            //derivedClass.display2();

            // Hierarchical Inheritance
            //Console.WriteLine("Performing Hierarchical Inheritance..");
            //FirstChildClass first = new FirstChildClass();
            //Console.WriteLine("My name is {0}, my father name is {1}", first.FirstChildName(), first.FatherName());
            //SecondChildClass second = new SecondChildClass();
            //Console.WriteLine("My name is {0}, my father name is {1}", second.SecondChildName(), second.FatherName());

            //  Multilevel Inheritance
            //Console.WriteLine("Performing Multilevel Inheritance..");
            //Dog dog = new Dog();
            //dog.Eat();
            //dog.walk();
            //dog.Bark();

            //  Multiple Inheritance
            Console.WriteLine("Performing Multiple Inheritance..");
            Rectangle rectangle = new Rectangle(12.3, 13.4, "Red");
            Console.WriteLine("Area of the rectangle is " + rectangle.GetArea());
            Console.Write("Color of rectangle is " + rectangle.GetColor());

        }
    }
}
