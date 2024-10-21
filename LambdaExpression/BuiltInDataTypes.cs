using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class BuiltInDataTypes
    {
        public static void LambdaExpOnInt()
        {
            List<int> list = new List<int>()
            {
                10,20,40,30,110, 120, 80, 50
            };
            //lambda expression to calculate square of each element of list
            var squares = list.Select(x => x * x);
            Console.WriteLine("squares: ");
            foreach (var square in squares)
            {
                Console.Write(square+" ");
            }
            Console.WriteLine();
            //lambda expression to find all numbers in the list divisible by 3
            List<int> list2 = list.FindAll(x => (x % 3) == 0);
            Console.WriteLine("Numbers divisible by 3");
            foreach (var value in list2)
            {
                Console.Write(value + " ");
            }
        }
    }
}
