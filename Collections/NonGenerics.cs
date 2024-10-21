using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class NonGenerics
    {
        protected void ArrayList()
        {
            ArrayList al = new ArrayList();
            string str = "I Feel Good Today";
            int x = 10;
            DateTime d = DateTime.Parse("17-oct-2024");
            al.Add(str);
            al.Add(x);
            al.Add(d);
            foreach(object o in al)
            {
                Console.WriteLine(o);
            }
        }
        protected void HashTable()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine(de.Key + " -> " +  de.Value);
            }
        }
        protected void SortedList()
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(10, "Ten");
            sortedList.Add(10000, "Ten thousand");
            sortedList.Add(100, "Hundred");
            sortedList.Add(1000, "Thousand");
            
            foreach (DictionaryEntry de in sortedList)
            {
                Console.WriteLine(de.Key + " -> " + de.Value);
            }
        }
        protected void Stack()
        {
            Stack stack = new Stack();
            stack.Push("cs.net");
            stack.Push("vb.net");
            stack.Push("asp.net");
            stack.Push("ado.net");
            foreach(Object o in stack)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(stack.Peek());
            stack.Pop();
            foreach (Object o in stack)
            {
                Console.WriteLine(o);
            }
        }
        protected void Queue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            foreach(Object o in queue)
            {
                Console.WriteLine(o);
            }
            queue.Dequeue();
            foreach (Object o in queue)
            {
                Console.Write(o+" ");
            }
        }
    }
}
