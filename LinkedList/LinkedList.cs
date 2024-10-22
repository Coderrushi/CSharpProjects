using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        Node head;
        public class Node
        {
            public string data;
            public Node next;
            public Node(String data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void AddFirst(string data)
        {
            Node  newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            newNode.next = head;
            head = newNode;
        }
        public void AddLast(string data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
                return;
            }
            Node currNode = head;
            while(currNode.next != null)
            {
                currNode = currNode.next;
            }
            currNode.next = newNode;
        }
        public void AddAtPosition(int position, string data)
        {
            if(position < 0)
            {
                Console.WriteLine("Invalid Position..");
                return;
            }
            Node newNode = new Node(data);
            if(position == 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            Node currNode = head;
            int currentPos = 0;
            while(currNode != null && currentPos < position -1) 
            {
                currNode = currNode.next;
                currentPos++;
            }
            if(currNode == null)
            {
                Console.WriteLine("Position out of bounds");
                return;
            }
            newNode.next = currNode.next;
            currNode.next = newNode;
        }
        public void DeleteFirst()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty..");
                return;
            }
            head = head.next;
        }
        public void DeleteLast()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty..");
                return;
            }
            if(head.next == null)
            {
                head = null;
                return;
            }
            Node secondLast = head;
            Node lastNode = head.next;
            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
                secondLast = secondLast.next;
            }
            secondLast.next = null;
        }
        public void DeleteAtPosition(int position)
        {
            if (position < 0 || head == null)
            {
                Console.WriteLine("Invalid Position");
                return;
            }
            if(position == 0) 
            {
                head = head.next;
                return;
            }
            Node currNode = head;
            Node prevNode = null;
            int currentPos = 0;
            while(currNode != null && currentPos < position)
            {
                prevNode = currNode;
                currNode = currNode.next;
                currentPos++;
            }
            if(currNode == null)
            {
                Console.WriteLine("Position out of bounds");
                return;
            }
            prevNode.next = currNode.next;
        }
        public void PrintList()
        {
            if(head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node currNode = head;
            while(currNode != null)
            {
                Console.Write(currNode.data + " -> ");
                currNode = currNode.next;
            }
            Console.WriteLine("Null");
        }
    }
}
