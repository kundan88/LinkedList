namespace LinkedList
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
            Console.WriteLine("\nSearch for Node 30");
            if (list.Search(30))
            {
                Console.WriteLine("Node Found");
            }
            else
            {
                Console.WriteLine("Node doesn't exists");
            }
            list.Display();
            Console.WriteLine("\nInsert a node 40.");
            list.AddNodeAfterNode(40, 30);
            list.Display();

        }
    }
}
