﻿namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Append the list");
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            Console.WriteLine("\nDelete the first node");
            list.DeleteFirstNode();
            list.Display();
        }
    }
}
