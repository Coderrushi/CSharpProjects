namespace Loops
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            string[] colors = { "Yellow", "Green", "Grey", "Red", "Blue", "White", "Orange" };
            int i = 0;
            do
            {
                Console.WriteLine(colors[i]);
                i++;
            } while(i < colors.Length);

            //while(i < colors.Length)
            //{
            //    Console.WriteLine(colors[i]);
            //    i++;
            //}

            //for(int i = 0; i <colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}


        }
    }
}
