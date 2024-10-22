namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst("a");
            list.AddFirst("is");
            list.AddLast("list");
            list.AddFirst("this");
            list.PrintList();
            list.DeleteFirst();
            list.DeleteLast();
            list.PrintList();
            list.AddFirst("this");
            list.AddAtPosition(3, "list");
            list.AddAtPosition(3, "b");
            list.PrintList();
            list.DeleteAtPosition(3);
            list.PrintList();
        }
    }
}
