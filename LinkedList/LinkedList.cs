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
        public void Append(int data)
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
                //if not then put head in temp variable
                Node temp = Head;

                while (temp.next != null)    //check until node next location is null so all node can added
                {
                    temp = temp.next;   //temp variable changed so next node can added
                }
                temp.next = node;
            }
            Console.WriteLine("Added at starting of linkedlist is " + data);
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
        public void AddNodeAfterNode(int nodedata, int addAfterthatValue)
        {
            //  create new node which we r going to add
            Node newNode = new Node(nodedata);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                // checking until temp variable data equal to previous value of value to be added
                while (temp.data != addAfterthatValue)
                {
                    //for traversing through list
                    temp = temp.next;
                }
                //new node stores next node position
                newNode.next = temp.next;
                //new node location will be previous node next position
                temp.next = newNode;
            }
            Console.WriteLine("\nAdded node in between: " + nodedata);
        }
        public void DeleteFirstNode()
        {
            //check if list is empty or not
            if (this.Head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            //put temp variable become head in list
            Node temp = this.Head;
            //change head to next node to delete previous node
            this.Head = this.Head.next;

            Console.WriteLine("\nRemoved from the linkedlist :" + temp.data);
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