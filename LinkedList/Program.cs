namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            Node node1 = new Node(76);
            Node node2 = new Node(30);
            Node node3 = new Node(56);
            list.Add(node1);
            list.Add(node2);
            list.Add(node3);
            list.Display();
            Console.WriteLine("After Appending\n");
            list.Append(40);
            list.Display();
        }
    }
}
