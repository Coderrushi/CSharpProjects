namespace Encapsulation
{
    public class MyClass
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value;  }
        }

        private static int y;
        public static int Y
        {
            get { return y; }
            set { y = value; }
        }

    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.X = 10;
            int result = obj.X;
            Console.WriteLine("with non-static property: {0}", result);

            MyClass.Y = 20;
            int result2 = MyClass.Y;
            Console.WriteLine("with static property: {0}", result2);
        }
    }
}
