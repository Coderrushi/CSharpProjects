namespace ExceptionHandling
{
    internal class ExceptionHandling
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //int div = 0;
            //try
            //{
            //    div = 100 / x;
            //    Console.WriteLine("Not executed line");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Exception Occured");
            //}
            //finally
            //{
            //    Console.WriteLine("Finally Block");
            //}
            //Console.WriteLine("Result is " + div);

            //for custom-exception
            int number1, number2, result;
            try
            {
                Console.WriteLine("Enter First Number: ");
                number1 = int.Parse(Console.ReadLine());
                number2 = 3;
                if(number1 % number2 != 0)
                {
                    throw new CustomException();
                }
                result = number1 / number2;
                Console.WriteLine("Result: " + result);
            }
            catch (CustomException ce)
            {
                Console.WriteLine("Messge: "+  ce.Message);
                Console.WriteLine("HelpLink: "+ ce.HelpLink);
                Console.WriteLine("Source: " + ce.Source);
                Console.WriteLine("StackTrace: " + ce.StackTrace);
            }
            Console.WriteLine("End of the program");
        }
    }
}
