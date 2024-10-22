using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplUsingLL
{
    internal class Queue
    {
        Node front;
        Node rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                this.data = d;
                next = null;
            }
        }
        internal void Enqueue(int item)
        {
            Node newNode = new Node(item);
            if (this.rear == null)
            {
                this.front = this.rear = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
            Console.WriteLine(item + "inserted into Queue");
        }
        internal void Dequeue()
        {
            if(this.front == null)
            {
                Console.WriteLine("The queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;
            if(this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine(temp.data + " is deleted");
        }
        internal void Dispay() 
        {
            if(front == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Node temp = front;
            Console.WriteLine("Queue elements are: ");
            while(temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
