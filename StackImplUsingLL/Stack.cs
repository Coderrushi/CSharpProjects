using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StackImplUsingLL
{
    internal class Stack
    {
        private Node top;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data) 
            {
                this.data = data;
                this.next = null;
            }
        }
        public void Push(int new_data)
        {
            Node newNode = new Node(new_data);
            if(top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine(new_data + " pushed to stack ");
        }
        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("\n Stack is underflow");
                return;
            }
            Console.WriteLine(top.data + " is popped");
            top = top.next;
        }
        public void Peek()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is underflow");
                return;
            }
            Console.WriteLine(top.data + " is on the top of the stack"); 
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Node temp = top;
            Console.WriteLine("Stack elements are: ");
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
