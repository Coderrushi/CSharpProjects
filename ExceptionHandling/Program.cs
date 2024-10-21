namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("Result is " + div);
        }
    }
}
