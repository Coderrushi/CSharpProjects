namespace FunctionsLoopsandConditions
{
   
    internal class Program
    {

        public static int add(int x, int y)
        {
            return x+y;
        }
        static void Main(string[] args)
        {
            int result = add(10, 20);
            Console.WriteLine(result);
        }
    }
}
