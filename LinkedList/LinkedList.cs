using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;
        public LinkedList()
        {
            this.Head = null;
        }
        public void AddNode(Node node)
        {
            //Check wether list is empty or not then create node as head
            if (Head == null) 
            {
                Head = node;
            }
            else
            {
                //if node than add new node as head
                node.next = Head;
                Head = node;
            }
        }
        public void AddStart(int data)
        {
            //Create node to add in linked list
            Node node = new Node(data);
            //Check if list is empty then new node become head node
            if (this.Head == null)
            {
                this.Head = node;
            }

            else
            {
                //New node location will store the address of previous node 
                node.next = Head;
                //node become head
                Head = node;
            }
            Console.WriteLine("Added at starting of linkedlist is " + data);
        }
        public void Display()
        {
            //temp variable will head
            Node temp = Head;
            //Check wether list is empty or not
            if (this.Head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            while (temp != null)
            {
                //Check until temp will null
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("-->");
                }
                //for traversing the node
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}