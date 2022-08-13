namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Append the list");
            list.Append(56);
            list.Append(70);
            list.Display();
            Console.WriteLine("Adding Node after Node.");
            list.AddNodeAfterNode(30, 56);
            list.Display();
        }
    }
}
