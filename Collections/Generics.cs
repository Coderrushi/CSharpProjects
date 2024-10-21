using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Generics
    {
        protected void List()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            foreach (int i in list)
            {
                Console.Write(i);
            }
        }
        protected void Dictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "One");
            dict.Add(2, "Two");
            dict.Add(3, "Three");
            dict.Add(4, "Four");
            foreach(KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Key+" -> "+ kvp.Value);
            }
        }
        protected void SortedList()
        {
            SortedList<char, string> sortedList = new SortedList<char, string>();
            sortedList.Add('A', "Apple");
            sortedList.Add('B', "Book");
            sortedList.Add('C', "Cat");
            sortedList.Add('D', "Dodge");
            foreach(KeyValuePair<char, string> kvp in sortedList)
            {
                Console.WriteLine(kvp.Key + " -> " + kvp.Value);
            }
        }
        protected void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(stack.Peek());
        }
        protected void Queue()
        {
            Queue <int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }
}
