namespace QueueImplUsingLL
{
    internal class QueueImplUsingLL
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Dispay();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dispay();
        }
    }
}
