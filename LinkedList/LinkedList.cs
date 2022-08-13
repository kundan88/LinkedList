using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            //Check wether list is empty or not then create node as head
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {              
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted Data: " + node.data);
            }

        }
        public void Display()
        {
            //temp variable will head
            Node temp = head;
            //Check wether list is empty or not
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                //Check until temp will null
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    //for traversing the node
                    temp = temp.next;
                }
            }
        }
    }
}

