namespace StaticandNotStaticMethods
{
    public class Class1
    {
        public static void Method()
        {
            Console.WriteLine("Method() from Class1");
        }
    }
    
    internal class StaticMethod
    {
        static void Main(string[] args)
        {
            Class1.Method();
            //Class1 obj = new Class1();
            //obj.Method();  // (prior to C# 11 it was possible)
        }
    }
}
