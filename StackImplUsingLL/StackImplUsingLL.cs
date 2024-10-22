namespace StackImplUsingLL
{
    internal class StackImplUsingLL
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Display();
            stack.Peek();
            stack.Pop();
            stack.Peek();
            stack.Display();
        }
    }
}
