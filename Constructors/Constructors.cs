namespace Constructors
{
    public class BaseClass
    {
        public BaseClass() : this(23) //initializer
        {
            Console.WriteLine("BaseClass Constructor");
        }

        public BaseClass(int age)
        {
            Console.WriteLine("My age is: {0}", age);
        }
    }
    public class DerivedClass : BaseClass 
    {
        static DerivedClass()
        {
            Console.WriteLine("Static Constructor");
        }
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor");
        }
        public DerivedClass(int num) : base(num)
        {
            Console.WriteLine("Parameterized Constructor");
        }
    }
    internal class Constructors
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass(20);
        }
    }
}
