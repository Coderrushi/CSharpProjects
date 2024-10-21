using System.Globalization;

namespace ClassandObject
{

    static class Author
    {
        public static string A_name = "Raj";
        public static string L_name = "C-sharp";

        public static void Details()
        {
            Console.WriteLine("The details of author is: ");
        }
    }
    internal class ClassandObject
    {

        static ClassandObject()
        {
            Console.WriteLine("static constructor");
        }

        public ClassandObject()
        {
            Console.WriteLine("non-static constructor");
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            ClassandObject obj = new ClassandObject();
            int result = obj.Add(2, 3);
            Console.WriteLine(result);
            // static class properties
            Author.Details();
            Console.WriteLine("Author name: {0}", Author.A_name);
            Console.WriteLine("Language: {0}", Author.L_name);
        }
    }
}
