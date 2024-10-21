namespace ConditionalStatements
{
    internal class ConditionalStatements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32 (Console.ReadLine());
            if( age > 18)
            {
                Console.WriteLine("You're eligible for voting..");
            }
            else if(age == 18)
            {
                Console.WriteLine("One more year to go and you'll be eligible for voting..");
            }
            else
            {
                Console.WriteLine("You're not eligible for voting..");
            }
        }
    }
}
